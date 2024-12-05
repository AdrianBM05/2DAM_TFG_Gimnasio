using System;

namespace Presentación
{
    partial class F_Factura
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se están usando.
        /// </summary>
        /// <param name="disposing">True si los recursos administrados deben eliminarse; de lo contrario, False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNombreClienteValor = new System.Windows.Forms.Label();
            this.lblDireccionCliente = new System.Windows.Forms.Label();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.dgvDetallesFactura = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dsGimnasio1 = new CAD.DSGimnasio();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bsTarifa = new System.Windows.Forms.BindingSource(this.components);
            this.bsEstado = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarifa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(30, 40);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(82, 13);
            this.lblNombreCliente.TabIndex = 0;
            this.lblNombreCliente.Text = "Nombre Cliente:";
            // 
            // lblNombreClienteValor
            // 
            this.lblNombreClienteValor.AutoSize = true;
            this.lblNombreClienteValor.Location = new System.Drawing.Point(120, 40);
            this.lblNombreClienteValor.Name = "lblNombreClienteValor";
            this.lblNombreClienteValor.Size = new System.Drawing.Size(0, 13);
            this.lblNombreClienteValor.TabIndex = 1;
            // 
            // lblDireccionCliente
            // 
            this.lblDireccionCliente.AutoSize = true;
            this.lblDireccionCliente.Location = new System.Drawing.Point(30, 80);
            this.lblDireccionCliente.Name = "lblDireccionCliente";
            this.lblDireccionCliente.Size = new System.Drawing.Size(90, 13);
            this.lblDireccionCliente.TabIndex = 2;
            this.lblDireccionCliente.Text = "Dirección Cliente:";
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(30, 120);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(76, 13);
            this.lblEmailCliente.TabIndex = 3;
            this.lblEmailCliente.Text = "Correo Cliente:";
            this.lblEmailCliente.Click += new System.EventHandler(this.lblEmailCliente_Click);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(300, 10);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(100, 30);
            this.lblFactura.TabIndex = 4;
            this.lblFactura.Text = "Factura";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.Location = new System.Drawing.Point(350, 380);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(100, 40);
            this.btnGenerarFactura.TabIndex = 5;
            this.btnGenerarFactura.Text = "Generar";
            this.btnGenerarFactura.UseVisualStyleBackColor = true;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // dgvDetallesFactura
            // 
            this.dgvDetallesFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesFactura.Location = new System.Drawing.Point(30, 160);
            this.dgvDetallesFactura.Name = "dgvDetallesFactura";
            this.dgvDetallesFactura.RowTemplate.Height = 24;
            this.dgvDetallesFactura.Size = new System.Drawing.Size(600, 150);
            this.dgvDetallesFactura.TabIndex = 6;
            this.dgvDetallesFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetallesFactura_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(30, 330);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(80, 327);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // dsGimnasio1
            // 
            this.dsGimnasio1.DataSetName = "DSGimnasio";
            this.dsGimnasio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsClientes
            // 
            this.bsClientes.DataMember = "Clientes";
            this.bsClientes.DataSource = this.dsGimnasio1;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Nombre", true));
            this.txtNombre.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(145, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(31, 15);
            this.txtNombre.TabIndex = 9;
            this.txtNombre.Text = "label1";
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Dirección", true));
            this.txtDireccion.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(145, 79);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(31, 15);
            this.txtDireccion.TabIndex = 10;
            this.txtDireccion.Text = "label1";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Correo", true));
            this.txtCorreo.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(145, 118);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(31, 15);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.Text = "label1";
            // 
            // F_Factura
            // 
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreClienteValor);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDetallesFactura);
            this.Controls.Add(this.btnGenerarFactura);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblDireccionCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Name = "F_Factura";
            this.Text = "Factura Cliente";
            this.Load += new System.EventHandler(this.F_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarifa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblEmailCliente_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Función para actualizar el texto del label con el nombre del cliente
        public void ActualizarNombreCliente(string nombreCliente)
        {
            lblNombreClienteValor.Text = nombreCliente;
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            // To do
        }

        #endregion

        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNombreClienteValor;  // El nuevo Label para mostrar el nombre del cliente
        private System.Windows.Forms.Label lblDireccionCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.DataGridView dgvDetallesFactura;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private CAD.DSGimnasio dsGimnasio1;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.BindingSource bsTarifa;
        private System.Windows.Forms.BindingSource bsEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.Label txtCorreo;
    }
}
