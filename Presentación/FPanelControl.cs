using CAD.Instancias;
using Negocio;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentación
{
    public partial class FPanelControl : Form
    {
        public Empleado empleado;

        public FPanelControl(Empleado _empleado)
        {
            InitializeComponent();
            empleado = _empleado;
            this.Load += FPanelControl_Load;
        }

        private void FPanelControl_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGraficoClientesActivos();
                CargarGraficoIngresosSemanales();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar gráficos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga un gráfico de columnas con el número de clientes activos por mes en el año actual.
        /// </summary>
        private void CargarGraficoClientesActivos()
        {
            try
            {
                ConfigurarGrafico(chartClientes, "Clientes activos (Año actual)", "Mes", "Clientes activos");
                var serie = CrearSerie("Activos", Color.FromArgb(0, 150, 136));

                var meses = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames.Take(12).ToArray();
                DateTime hoy = DateTime.Today;

                for (int mes = 1; mes <= hoy.Month; mes++)
                {
                    int cantidad = NProcedimientos.ObtenerClientesActivos(dsGimnasio1, mes, hoy.Year);
                    int index = serie.Points.AddXY(meses[mes - 1], cantidad);

                    if (cantidad > 0)
                    {
                        serie.Points[index].Label = cantidad.ToString();
                        serie.Points[index].Color = Color.FromArgb(255, 193, 7); // Amarillo
                    }
                }

                chartClientes.Series.Add(serie);
                AjustarEstiloEjes(chartClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generando el gráfico: {ex.Message}\n\nDetalles técnicos:\n{ex.StackTrace}",
                                 "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carga un gráfico con los ingresos semanales del mes actual.
        /// </summary>
        private void CargarGraficoIngresosSemanales()
        {
            ConfigurarGrafico(chartIngresos, "Ingresos semanales (Mes actual)", "Semana", "Ingresos (€)");
            var serie = CrearSerie("Ingresos", Color.SteelBlue);

            DateTime hoy = DateTime.Today;
            int semanas = (int)Math.Ceiling(hoy.Day / 7.0);

            for (int i = 1; i <= semanas; i++)
            {
                DateTime inicio = new DateTime(hoy.Year, hoy.Month, (i - 1) * 7 + 1);
                DateTime fin = inicio.AddDays(6);
                decimal total = NProcedimientos.obtenerIngresosSemanales(dsGimnasio1, inicio, fin);
                serie.Points.AddXY($"Semana {i}", total);
            }

            chartIngresos.Series.Add(serie);
            AjustarEstiloEjes(chartIngresos);
        }

        // --- Métodos auxiliares para refactorizar la configuración ---

        private void ConfigurarGrafico(Chart chart, string titulo, string ejeX, string ejeY)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.ChartAreas.Clear();

            var area = new ChartArea()
            {
                AxisX = { Title = ejeX, Interval = 1, LabelStyle = { Format = "MMM" } },
                AxisY = { Title = ejeY, Minimum = 0, LabelStyle = { Format = "N0" } }
            };

            chart.ChartAreas.Add(area);
            chart.Titles.Add(titulo);
        }

        private Series CrearSerie(string nombre, Color color)
        {
            return new Series(nombre)
            {
                ChartType = SeriesChartType.Column,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Color = color
            };
        }

        private void AjustarEstiloEjes(Chart chart)
        {
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
        }
    }
}