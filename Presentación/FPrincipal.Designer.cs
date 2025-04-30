using System;

namespace Presentación
{
    partial class FPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPrincipal));
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEmpleado = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dsGimnasio1 = new CAD.DSGimnasio();
            this.panelDeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripEmpleado.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
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
            // menuStripEmpleado
            // 
            this.menuStripEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStripEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStripEmpleado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.facturasTSM,
            this.panelDeControlToolStripMenuItem});
            this.menuStripEmpleado.Location = new System.Drawing.Point(0, 0);
            this.menuStripEmpleado.Name = "menuStripEmpleado";
            this.menuStripEmpleado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStripEmpleado.Size = new System.Drawing.Size(606, 49);
            this.menuStripEmpleado.TabIndex = 0;
            this.menuStripEmpleado.Text = "menuStrip1";
            this.menuStripEmpleado.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripEmpleado_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(104, 45);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(103, 45);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // facturasTSM
            // 
            this.facturasTSM.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasTSM.Name = "facturasTSM";
            this.facturasTSM.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.facturasTSM.Size = new System.Drawing.Size(113, 45);
            this.facturasTSM.Text = "Facturación";
            this.facturasTSM.Click += new System.EventHandler(this.facturasTSM_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStripEmpleado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 49);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dsGimnasio1
            // 
            this.dsGimnasio1.DataSetName = "DSGimnasio";
            this.dsGimnasio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelDeControlToolStripMenuItem
            // 
            this.panelDeControlToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDeControlToolStripMenuItem.Name = "panelDeControlToolStripMenuItem";
            this.panelDeControlToolStripMenuItem.Size = new System.Drawing.Size(133, 45);
            this.panelDeControlToolStripMenuItem.Text = "Panel de control";
            this.panelDeControlToolStripMenuItem.Click += new System.EventHandler(this.panelDeControlToolStripMenuItem_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(606, 333);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripEmpleado;
            this.Name = "FPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FPrincipalEmpleado_Load);
            this.menuStripEmpleado.ResumeLayout(false);
            this.menuStripEmpleado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem facturasTSM;
        private System.Windows.Forms.ToolStripMenuItem panelDeControlToolStripMenuItem;
    }
}