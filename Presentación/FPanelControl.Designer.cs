
namespace Presentación
{
    partial class FPanelControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGastos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAsistencia;
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
            this.chartGastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAsistencia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dsGimnasio1 = new CAD.DSGimnasio();

            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            this.mainLayout.SuspendLayout();
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
            this.chartClientes.Size = new System.Drawing.Size(370, 160);
            this.chartClientes.TabIndex = 0;

            // 
            // chartIngresos
            // 
            this.chartIngresos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartIngresos.BorderlineColor = System.Drawing.Color.Silver;
            this.chartIngresos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartIngresos.Location = new System.Drawing.Point(376, 2);
            this.chartIngresos.Margin = new System.Windows.Forms.Padding(2);
            this.chartIngresos.Name = "chartIngresos";
            this.chartIngresos.Size = new System.Drawing.Size(370, 160);
            this.chartIngresos.TabIndex = 1;

            // 
            // chartGastos
            // 
            this.chartGastos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartGastos.BorderlineColor = System.Drawing.Color.Silver;
            this.chartGastos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartGastos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGastos.Location = new System.Drawing.Point(2, 166);
            this.chartGastos.Margin = new System.Windows.Forms.Padding(2);
            this.chartGastos.Name = "chartGastos";
            this.chartGastos.Size = new System.Drawing.Size(370, 160);
            this.chartGastos.TabIndex = 2;

            // 
            // chartAsistencia
            // 
            this.chartAsistencia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartAsistencia.BorderlineColor = System.Drawing.Color.Silver;
            this.chartAsistencia.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartAsistencia.Location = new System.Drawing.Point(376, 166);
            this.chartAsistencia.Margin = new System.Windows.Forms.Padding(2);
            this.chartAsistencia.Name = "chartAsistencia";
            this.chartAsistencia.Size = new System.Drawing.Size(370, 160);
            this.chartAsistencia.TabIndex = 3;

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
            this.mainLayout.RowCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.chartClientes, 0, 0);
            this.mainLayout.Controls.Add(this.chartIngresos, 1, 0);
            this.mainLayout.Controls.Add(this.chartGastos, 0, 1);
            this.mainLayout.Controls.Add(this.chartAsistencia, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 35);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new System.Drawing.Size(750, 325);
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

            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
