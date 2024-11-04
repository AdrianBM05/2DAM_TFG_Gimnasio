using System;

namespace Presentación
{
    partial class FPrincipalEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dsGimnasio1 = new CAD.DSGimnasio();
            this.menuStripEmpleado = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            this.menuStripEmpleado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 23);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // dsGimnasio1
            // 
            this.dsGimnasio1.DataSetName = "DSGimnasio";
            this.dsGimnasio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStripEmpleado
            // 
            this.menuStripEmpleado.BackColor = System.Drawing.Color.Silver;
            this.menuStripEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            this.menuStripEmpleado.Location = new System.Drawing.Point(0, 0);
            this.menuStripEmpleado.Name = "menuStripEmpleado";
            this.menuStripEmpleado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripEmpleado.Size = new System.Drawing.Size(1265, 49);
            this.menuStripEmpleado.TabIndex = 0;
            this.menuStripEmpleado.Text = "menuStrip1";
            this.menuStripEmpleado.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripEmpleado_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(81, 45);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(94, 45);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStripEmpleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 49);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FPrincipalEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1265, 615);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStripEmpleado;
            this.Name = "FPrincipalEmpleado";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FPrincipalEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            this.menuStripEmpleado.ResumeLayout(false);
            this.menuStripEmpleado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private CAD.DSGimnasio dsGimnasio1;
        private System.Windows.Forms.MenuStrip menuStripEmpleado;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
    }
}