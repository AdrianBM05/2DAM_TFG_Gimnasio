using CAD.Instancias;
using Negocio;
using System;
using System.Data;
using System.Drawing;
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

        private void CargarGraficoClientesActivos()
        {
            try
            {
                // 1. Configuración inicial del gráfico
                chartClientes.Series.Clear();
                chartClientes.Titles.Clear();
                chartClientes.ChartAreas.Clear();

                var area = new ChartArea("AreaClientes")
                {
                    AxisX = {
                        Title = "Mes",
                        Interval = 1,
                        LabelStyle = { Format = "MMM" }
                    },
                    AxisY = {
                        Title = "Clientes activos",
                        Minimum = 0,
                        Interval = 1,
                        LabelStyle = { Format = "N0" } // Formato numérico
                    }
                };

                chartClientes.ChartAreas.Add(area);
                chartClientes.Titles.Add("Clientes activos (Año actual)");

                // 2. Configuración de la serie
                var serie = new Series("Activos")
                {
                    ChartType = SeriesChartType.Column,
                    BorderWidth = 2,
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 8,
                    IsValueShownAsLabel = true,
                    LabelForeColor = Color.White,
                    Color = Color.FromArgb(0, 150, 136) // Verde profesional
                };

                // 3. Datos para los meses
                var meses = new[] { "Ene", "Feb", "Mar", "Abr", "May", "Jun",
                          "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

                DateTime hoy = DateTime.Today;

                // 4. Recopilación de datos
                for (int mes = 1; mes <= hoy.Month; mes++)
                {
                    int cantidad = NProcedimientos.ObtenerClientesActivos(dsGimnasio1,mes, hoy.Year);

                    // Añadir punto con formato condicional
                    var punto = serie.Points.AddXY(meses[mes - 1], cantidad);

                    // Resaltar meses con registros
                    if (cantidad > 0)
                    {
                        // Mostrar número en la propia columna (arriba)
                        serie.Points[punto - 1].Label = cantidad.ToString();
                        serie.Points[punto - 1].Color = Color.FromArgb(255, 193, 7); // Amarillo destacado
                    }
                }

                // 5. Renderizado final
                chartClientes.Series.Add(serie);

                // 6. Mejoras visuales adicionales
                chartClientes.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartClientes.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generando el gráfico: {ex.Message}\n\nDetalles técnicos:\n{ex.StackTrace}",
                              "Error Crítico",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// Grafica los ingresos semanales del mes actual.
        /// </summary>
        private void CargarGraficoIngresosSemanales()
        {
            chartIngresos.Series.Clear();
            chartIngresos.Titles.Clear();
            chartIngresos.ChartAreas.Clear();

            var area = new ChartArea("AreaIngresos");
            area.AxisX.Title = "Semana";
            area.AxisY.Title = "Ingresos (€)";
            chartIngresos.ChartAreas.Add(area);

            chartIngresos.Titles.Add("Ingresos semanales (Mes actual)");

            var serie = new Series("Ingresos")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            // Calculamos mediante fechas de las facturas e importe total de estas los ingresos semanales del mes actual
            DateTime hoy = DateTime.Today;
            int semanaActual = (int)Math.Ceiling((double)hoy.Day / 7);
            decimal[] ingresosSemanales = new decimal[semanaActual];
            for (int i = 1; i <= semanaActual; i++)
            {
                DateTime inicioSemana = new DateTime(hoy.Year, hoy.Month, (i - 1) * 7 + 1);
                DateTime finSemana = inicioSemana.AddDays(6);
                // Obtenemos el total de ingresos de la semana
                decimal totalIngresos = NProcedimientos.obtenerIngresosSemanales(dsGimnasio1, inicioSemana, finSemana);
                ingresosSemanales[i - 1] = totalIngresos;
                serie.Points.AddXY($"Semana {i}", totalIngresos);
            }
            chartIngresos.Series.Add(serie);


        }
    }
}
