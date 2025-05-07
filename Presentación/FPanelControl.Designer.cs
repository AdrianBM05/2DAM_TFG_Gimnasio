using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentación
{
    partial class FPanelControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Chart chartClientes;
        private Chart chartIngresos;
        private Label labelTitulo;
        private TableLayoutPanel mainLayout;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chartClientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartIngresos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dsGimnasio1 = new CAD.DSGimnasio();
            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).BeginInit();
            this.mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartClientes
            // 
            this.chartClientes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartClientes.BorderlineColor = System.Drawing.Color.Gray;
            this.chartClientes.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartClientes.Location = new System.Drawing.Point(17, 15);
            this.chartClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartClientes.Name = "chartClientes";
            this.chartClientes.Size = new System.Drawing.Size(356, 328);
            this.chartClientes.TabIndex = 0;
            // 
            // chartIngresos
            // 
            this.chartIngresos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chartIngresos.BorderlineColor = System.Drawing.Color.Gray;
            this.chartIngresos.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartIngresos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartIngresos.Location = new System.Drawing.Point(377, 15);
            this.chartIngresos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartIngresos.Name = "chartIngresos";
            this.chartIngresos.Size = new System.Drawing.Size(356, 328);
            this.chartIngresos.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(750, 32);
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
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 32);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Padding = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.mainLayout.RowCount = 1;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Size = new System.Drawing.Size(750, 358);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FPanelControl";
            this.Text = "Panel de Control";
            ((System.ComponentModel.ISupportInitialize)(this.chartClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIngresos)).EndInit();
            this.mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CAD.DSGimnasio dsGimnasio1;
    }
}