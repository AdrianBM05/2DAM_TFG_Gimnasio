
namespace Presentación
{
    partial class FPanelControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPorcentaje;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResumenSemanal;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private CAD.DSGimnasio dsGimnasio1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.chartClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPorcentaje = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartResumenSemanal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dsGimnasio1 = new CAD.DSGimnasio();
            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResumenSemanal)).BeginInit();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartClientes
            // 
            this.chartClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartClientes.BorderlineColor = System.Drawing.Color.Silver;
            this.chartClientes.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartClientes.Location = new System.Drawing.Point(2, 2);
            this.chartClientes.Margin = new System.Windows.Forms.Padding(2);
            this.chartClientes.Name = "chartClientes";
            this.chartClientes.Size = new System.Drawing.Size(371, 173);
            this.chartClientes.TabIndex = 0;
            // 
            // chartIngresos
            // 
            this.chartIngresos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartIngresos.BorderlineColor = System.Drawing.Color.Silver;
            this.chartIngresos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartIngresos.Location = new System.Drawing.Point(377, 2);
            this.chartIngresos.Margin = new System.Windows.Forms.Padding(2);
            this.chartIngresos.Name = "chartIngresos";
            this.chartIngresos.Size = new System.Drawing.Size(371, 173);
            this.chartIngresos.TabIndex = 1;
            // 
            // chartPorcentaje
            // 
            this.chartPorcentaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartPorcentaje.BorderlineColor = System.Drawing.Color.Silver;
            this.chartPorcentaje.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartPorcentaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPorcentaje.Location = new System.Drawing.Point(2, 179);
            this.chartPorcentaje.Margin = new System.Windows.Forms.Padding(2);
            this.chartPorcentaje.Name = "chartPorcentaje";
            this.chartPorcentaje.Size = new System.Drawing.Size(371, 174);
            this.chartPorcentaje.TabIndex = 2;
            // 
            // chartResumenSemanal
            // 
            this.chartResumenSemanal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartResumenSemanal.BorderlineColor = System.Drawing.Color.Silver;
            this.chartResumenSemanal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartResumenSemanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartResumenSemanal.Location = new System.Drawing.Point(377, 179);
            this.chartResumenSemanal.Margin = new System.Windows.Forms.Padding(2);
            this.chartResumenSemanal.Name = "chartResumenSemanal";
            this.chartResumenSemanal.Size = new System.Drawing.Size(371, 174);
            this.chartResumenSemanal.TabIndex = 3;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(750, 35);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Panel de Control - Estadísticas";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.chartClientes, 0, 0);
            this.mainLayout.Controls.Add(this.chartIngresos, 1, 0);
            this.mainLayout.Controls.Add(this.chartPorcentaje, 0, 1);
            this.mainLayout.Controls.Add(this.chartResumenSemanal, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 35);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Size = new System.Drawing.Size(750, 355);
            this.mainLayout.TabIndex = 0;
            // 
            // dsGimnasio1
            // 
            this.dsGimnasio1.DataSetName = "DSGimnasio";
            this.dsGimnasio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 390);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FPanelControl";
            this.Text = "Panel de Control";
            this.Load += new System.EventHandler(this.FPanelControl_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartResumenSemanal)).EndInit();
            this.mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
