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
                cargarGraficoPorcentajeActivos();
                CargarGraficoIngresosMensualesUltimoAno();
                CargarGraficoResumenSemanal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar gráficos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra los clientes activos por mes en el gráfico izquierdo.
        /// </summary>
        private void CargarGraficoClientesActivos()
        {
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
                    LabelStyle = { Format = "N0" }
                }
            };

            chartClientes.ChartAreas.Add(area);
            chartClientes.Titles.Add("Clientes activos (Año actual)");

            var serie = new Series("Activos")
            {
                ChartType = SeriesChartType.Column,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White,
                Color = Color.FromArgb(0, 150, 136)
            };

            var meses = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames.Take(12).ToArray();
            DateTime hoy = DateTime.Today;

            for (int mes = 1; mes <= hoy.Month; mes++)
            {
                int cantidad = NProcedimientos.ObtenerClientesActivos(dsGimnasio1, mes, hoy.Year);
                int punto = serie.Points.AddXY(meses[mes - 1], cantidad);

                if (cantidad > 0)
                {
                    serie.Points[punto].Label = cantidad.ToString();
                    serie.Points[punto].Color = Color.FromArgb(255, 193, 7);
                }
            }

            chartClientes.Series.Add(serie);
            chartClientes.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartClientes.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
        }

        /// <summary>
        /// Muestra los ingresos mensuales del último año en el gráfico de la derecha.
        /// </summary>
        private void CargarGraficoIngresosMensualesUltimoAno()
        {
            chartIngresos.Series.Clear();
            chartIngresos.Titles.Clear();
            chartIngresos.ChartAreas.Clear();

            var area = new ChartArea("AreaIngresos")
            {
                AxisX = { Title = "Mes", Interval = 1 },
                AxisY = { Title = "Ingresos (€)" }
            };

            chartIngresos.ChartAreas.Add(area);
            chartIngresos.Titles.Add("Ingresos mensuales (Último año)");

            var serie = new Series("Ingresos")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.SteelBlue
            };

            try
            {
                DataTable ingresos = NProcedimientos.obtenerIngresosMensualesUltimoAno(dsGimnasio1);

                foreach (DataRow fila in ingresos.Rows)
                {
                    int anio = Convert.ToInt32(fila["Año"]);
                    int mes = Convert.ToInt32(fila["Mes"]);
                    decimal total = Convert.ToDecimal(fila["IngresosMensuales"]);
                    string etiqueta = $"{new DateTime(anio, mes, 1):MMM yyyy}";
                    serie.Points.AddXY(etiqueta, total);
                }

                chartIngresos.Series.Add(serie);
                chartIngresos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chartIngresos.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chartIngresos.ChartAreas[0].RecalculateAxesScale();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico de ingresos mensuales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Carga un gráfico circular correcto en chartPorcentaje basado en el
        /// número real de clientes activos e inactivos.
        /// </summary>
        private void cargarGraficoPorcentajeActivos()
        {
            chartPorcentaje.Series.Clear();
            chartPorcentaje.Titles.Clear();
            chartPorcentaje.ChartAreas.Clear();
            chartPorcentaje.Legends.Clear(); // Añadir leyenda clara

            var area = new ChartArea("AreaClientes");
            chartPorcentaje.ChartAreas.Add(area);

            var leyenda = new Legend("Leyenda")
            {
                Docking = Docking.Bottom,
                Font = new Font("Segoe UI", 9)
            };
            chartPorcentaje.Legends.Add(leyenda);

            var serie = new Series("Clientes")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                Label = "#VALX: #PERCENT{P1}", // Ej: Activos: 24.4%
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                LegendText = "#VALX"
            };

            try
            {
                DataTable resumen = NProcedimientos.obtenerResumenClientesActivos(dsGimnasio1);

                if (resumen.Rows.Count > 0)
                {
                    var fila = resumen.Rows[0];
                    int activos = Convert.ToInt32(fila["ClientesActivos"]);
                    int total = Convert.ToInt32(fila["TotalClientes"]);
                    int inactivos = total - activos;

                    serie.Points.AddXY("Activos", activos);
                    serie.Points.AddXY("Inactivos", inactivos);

                    // Colores consistentes con otros gráficos
                    serie.Points[0].Color = Color.Goldenrod; // Amarillo como el gráfico de arriba
                    serie.Points[1].Color = Color.LightGray;
                }

                chartPorcentaje.Series.Add(serie);
                chartPorcentaje.Titles.Add("Distribución de Clientes Activos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico de clientes activos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Muestra clientes activos e ingresos semanales del mes actual en un único gráfico combinado.
        /// </summary>
        private void CargarGraficoResumenSemanal()
        {
            chartResumenSemanal.Series.Clear();
            chartResumenSemanal.Titles.Clear();
            chartResumenSemanal.ChartAreas.Clear();
            chartResumenSemanal.Legends.Clear();

            var area = new ChartArea("Resumen")
            {
                AxisX = { Title = "Semana", Interval = 1 },
                AxisY = { Title = "Clientes activos" },
                AxisY2 = { Title = "Ingresos (€)", Enabled = AxisEnabled.True }
            };
            chartResumenSemanal.ChartAreas.Add(area);

            var leyenda = new Legend("Leyenda")
            {
                Docking = Docking.Top,
                Font = new Font("Segoe UI", 9)
            };
            chartResumenSemanal.Legends.Add(leyenda);

            var serieClientes = new Series("Clientes Activos")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Goldenrod,
                YAxisType = AxisType.Primary,
                IsValueShownAsLabel = true
            };

            var serieIngresos = new Series("Ingresos")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.SteelBlue,
                YAxisType = AxisType.Secondary,
                IsValueShownAsLabel = true,
                LabelFormat = "N2",
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 7
            };

            try
            {
                DataTable datos = NProcedimientos.obtenerResumenSemanalClientesIngresos(dsGimnasio1);

                foreach (DataRow fila in datos.Rows)
                {
                    string semana = "Semana " + fila["Semana"].ToString();
                    int clientes = Convert.ToInt32(fila["ClientesActivos"]);
                    decimal ingresos = Convert.ToDecimal(fila["Ingresos"]);

                    serieClientes.Points.AddXY(semana, clientes);
                    serieIngresos.Points.AddXY(semana, ingresos);
                }

                chartResumenSemanal.Series.Add(serieClientes);
                chartResumenSemanal.Series.Add(serieIngresos);
                chartResumenSemanal.Titles.Add("Clientes activos e ingresos semanales (Mes actual)");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar gráfico resumen semanal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}