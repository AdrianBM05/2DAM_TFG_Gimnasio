﻿using CAD.Instancias;
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
            this.CargarGraficoGastosMensuales();
            this.CargarGraficoAsistenciaSemanal();
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
        /// Muestra los ingresos semanales del mes actual en el gráfico derecho.
        /// </summary>
        private void CargarGraficoIngresosSemanales()
        {
            chartIngresos.Series.Clear();
            chartIngresos.Titles.Clear();
            chartIngresos.ChartAreas.Clear();

            var area = new ChartArea("AreaIngresos")
            {
                AxisX = { Title = "Semana" },
                AxisY = { Title = "Ingresos (€)" }
            };

            chartIngresos.ChartAreas.Add(area);
            chartIngresos.Titles.Add("Ingresos semanales (Mes actual)");

            var serie = new Series("Ingresos")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.SteelBlue
            };

            DateTime hoy = DateTime.Today;
            DateTime inicioMes = new DateTime(hoy.Year, hoy.Month, 1);
            DateTime finMes = inicioMes.AddMonths(1).AddDays(-1);

            DataTable ingresos = NProcedimientos.obtenerIngresosSemanales(dsGimnasio1, inicioMes, finMes);

            foreach (DataRow fila in ingresos.Rows)
            {
                int semana = Convert.ToInt32(fila["Semana"]);
                decimal total = Convert.ToDecimal(fila["IngresosSemanales"]);
                serie.Points.AddXY($"Semana {semana}", total);
            }

            chartIngresos.Series.Add(serie);
            chartIngresos.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartIngresos.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
        }
    

        private void CargarGraficoGastosMensuales()
        {
            chartGastos.Series.Clear();
            chartGastos.Titles.Clear();
            chartGastos.ChartAreas.Clear();

            var area = new ChartArea("AreaGastos")
            {
                AxisX = {
                    Title = "Mes",
                    Interval = 1,
                    LabelStyle = { Format = "MMM" }
                },
                AxisY = {
                    Title = "Gastos (€)",
                    Minimum = 0,
                    LabelStyle = { Format = "C" }
                }
            };

            chartGastos.ChartAreas.Add(area);
            chartGastos.Titles.Add("Gastos Mensuales");

            var serie = new Series("Gastos")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 2,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                IsValueShownAsLabel = true,
                Color = Color.IndianRed
            };

            var meses = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames.Take(12).ToArray();
            DateTime hoy = DateTime.Today;

            for (int mes = 1; mes <= hoy.Month; mes++)
            {
                // Simulación de gastos, reemplaza por una función real si tienes acceso
                int cantidad = new Random().Next(1000, 3000);
                serie.Points.AddXY(meses[mes - 1], cantidad);
            }

            chartGastos.Series.Add(serie);
        }

        private void CargarGraficoAsistenciaSemanal()
        {
            chartAsistencia.Series.Clear();
            chartAsistencia.Titles.Clear();
            chartAsistencia.ChartAreas.Clear();

            var area = new ChartArea("AreaAsistencia")
            {
                AxisX = {
                    Title = "Día",
                    Interval = 1
                },
                AxisY = {
                    Title = "Asistencias",
                    Minimum = 0,
                    LabelStyle = { Format = "N0" }
                }
            };

            chartAsistencia.ChartAreas.Add(area);
            chartAsistencia.Titles.Add("Asistencia Semanal");

            var dias = new[] { "L", "M", "X", "J", "V", "S", "D" };
            var serie = new Series("Asistencia")
            {
                ChartType = SeriesChartType.Bar,
                IsValueShownAsLabel = true,
                Color = Color.MediumSeaGreen
            };

            for (int i = 0; i < 7; i++)
            {
                // Simulación, sustituir por datos reales
                serie.Points.AddXY(dias[i], new Random().Next(20, 80));
            }

            chartAsistencia.Series.Add(serie);
        }

    }
}