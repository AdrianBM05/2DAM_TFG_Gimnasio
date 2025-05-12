namespace Presentación
{
    partial class FPanelControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIngresos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.ToolStrip toolStripFiltros;
        private System.Windows.Forms.ToolStripDropDownButton dropDownFiltros;
        private System.Windows.Forms.ToolStripLabel labelFiltroRápido;
        private System.Windows.Forms.ToolStripComboBox comboBoxFiltros;
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripFiltros = new System.Windows.Forms.ToolStrip();
            this.dropDownFiltros = new System.Windows.Forms.ToolStripDropDownButton();
            this.labelFiltroRápido = new System.Windows.Forms.ToolStripLabel();
            this.comboBoxFiltros = new System.Windows.Forms.ToolStripComboBox();
            this.dsGimnasio1 = new CAD.DSGimnasio();

            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            this.mainLayout.SuspendLayout();
            this.toolStripFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            this.SuspendLayout();

            // 
            // chartClientes
            // 
            this.chartClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartClientes.BorderlineColor = System.Drawing.Color.Silver;
            this.chartClientes.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartClientes.Location = new System.Drawing.Point(17, 15);
            this.chartClientes.Margin = new System.Windows.Forms.Padding(2);
            this.chartClientes.Name = "chartClientes";
            this.chartClientes.Size = new System.Drawing.Size(356, 328);
            this.chartClientes.TabIndex = 0;

            // 
            // chartIngresos
            // 
            this.chartIngresos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartIngresos.BorderlineColor = System.Drawing.Color.Silver;
            this.chartIngresos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartIngresos.Location = new System.Drawing.Point(377, 15);
            this.chartIngresos.Margin = new System.Windows.Forms.Padding(2);
            this.chartIngresos.Name = "chartIngresos";
            this.chartIngresos.Size = new System.Drawing.Size(356, 328);
            this.chartIngresos.TabIndex = 1;

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
            // toolStripFiltros
            // 
            this.toolStripFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripFiltros.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripFiltros.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.dropDownFiltros,
                this.labelFiltroRápido,
                this.comboBoxFiltros});
            this.toolStripFiltros.Location = new System.Drawing.Point(0, 35);
            this.toolStripFiltros.Name = "toolStripFiltros";
            this.toolStripFiltros.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripFiltros.Size = new System.Drawing.Size(750, 27);
            this.toolStripFiltros.TabIndex = 3;
            this.toolStripFiltros.Text = "toolStripFiltros";

            // 
            // dropDownFiltros
            // 
            this.dropDownFiltros.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dropDownFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dropDownFiltros.Name = "dropDownFiltros";
            this.dropDownFiltros.Size = new System.Drawing.Size(72, 24);
            this.dropDownFiltros.Text = "Opciones";

            // 
            // labelFiltroRápido
            // 
            this.labelFiltroRápido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFiltroRápido.Name = "labelFiltroRápido";
            this.labelFiltroRápido.Size = new System.Drawing.Size(85, 24);
            this.labelFiltroRápido.Text = "Filtro rápido:";

            // 
            // comboBoxFiltros
            // 
            this.comboBoxFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltros.Name = "comboBoxFiltros";
            this.comboBoxFiltros.Size = new System.Drawing.Size(200, 27);

            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayout.Controls.Add(this.chartClientes, 0, 0);
            this.mainLayout.Controls.Add(this.chartIngresos, 1, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 62);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(750, 328);
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
            this.Controls.Add(this.toolStripFiltros);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FPanelControl";
            this.Text = "Panel de Control";

            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            this.mainLayout.ResumeLayout(false);
            this.toolStripFiltros.ResumeLayout(false);
            this.toolStripFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
