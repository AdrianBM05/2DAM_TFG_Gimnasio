namespace Presentación
{
    partial class FFichaProducto2
    {
        private System.ComponentModel.IContainer components = null;

        // Controles añadidos
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtBaseImponible;
        private System.Windows.Forms.Label lblPVP;
        private System.Windows.Forms.ComboBox cbSeccion;
        private System.Windows.Forms.ComboBox comboBoxIVA;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecioCompra;
        private System.Windows.Forms.Label lblBaseImponible;
        private System.Windows.Forms.Label lblTipoIVA;
        private System.Windows.Forms.Label lblSeccion;
        private System.Windows.Forms.Label lblPVPTexto;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblTitulo;


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
            this.components = new System.ComponentModel.Container();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtBaseImponible = new System.Windows.Forms.TextBox();
            this.lblPVP = new System.Windows.Forms.Label();
            this.cbSeccion = new System.Windows.Forms.ComboBox();
            this.comboBoxIVA = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.lblBaseImponible = new System.Windows.Forms.Label();
            this.lblPVPTexto = new System.Windows.Forms.Label();
            this.lblSeccion = new System.Windows.Forms.Label();
            this.lblTipoIVA = new System.Windows.Forms.Label();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dsGimnasio1 = new CAD.DSGimnasio();
            this.bsSecciones = new System.Windows.Forms.BindingSource(this.components);
            this.bsProductos = new System.Windows.Forms.BindingSource(this.components);
            this.bsIVA = new System.Windows.Forms.BindingSource(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProductos, "Nombre", true));
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(176, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(300, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProductos, "Descripción", true));
            this.txtDescripcion.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(176, 142);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 60);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProductos, "Precio_compra", true));
            this.txtPrecioCompra.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(176, 212);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioCompra.TabIndex = 3;
            // 
            // txtBaseImponible
            // 
            this.txtBaseImponible.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProductos, "Base_Imponible", true));
            this.txtBaseImponible.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseImponible.Location = new System.Drawing.Point(176, 242);
            this.txtBaseImponible.Name = "txtBaseImponible";
            this.txtBaseImponible.Size = new System.Drawing.Size(100, 22);
            this.txtBaseImponible.TabIndex = 4;
            // 
            // lblPVP
            // 
            this.lblPVP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPVP.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPVP.Location = new System.Drawing.Point(176, 332);
            this.lblPVP.Name = "lblPVP";
            this.lblPVP.Size = new System.Drawing.Size(150, 23);
            this.lblPVP.TabIndex = 7;
            this.lblPVP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSeccion
            // 
            this.cbSeccion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProductos, "IdSección", true));
            this.cbSeccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSecciones, "Sección", true));
            this.cbSeccion.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeccion.Location = new System.Drawing.Point(176, 302);
            this.cbSeccion.Name = "cbSeccion";
            this.cbSeccion.Size = new System.Drawing.Size(150, 22);
            this.cbSeccion.TabIndex = 6;
            // 
            // comboBoxIVA
            // 
            this.comboBoxIVA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsIVA, "Tipo_IVA", true));
            this.comboBoxIVA.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProductos, "IdTipoIVA", true));
            this.comboBoxIVA.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIVA.Location = new System.Drawing.Point(176, 272);
            this.comboBoxIVA.Name = "comboBoxIVA";
            this.comboBoxIVA.Size = new System.Drawing.Size(150, 22);
            this.comboBoxIVA.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(37, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 23);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Producto:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(37, 142);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(107, 23);
            this.lblDescripcion.TabIndex = 9;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCompra.Location = new System.Drawing.Point(37, 212);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(132, 23);
            this.lblPrecioCompra.TabIndex = 10;
            this.lblPrecioCompra.Text = "Precio compra:";
            // 
            // lblBaseImponible
            // 
            this.lblBaseImponible.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseImponible.Location = new System.Drawing.Point(37, 242);
            this.lblBaseImponible.Name = "lblBaseImponible";
            this.lblBaseImponible.Size = new System.Drawing.Size(146, 23);
            this.lblBaseImponible.TabIndex = 11;
            this.lblBaseImponible.Text = "Base imponible:";
            // 
            // lblPVPTexto
            // 
            this.lblPVPTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPVPTexto.Location = new System.Drawing.Point(37, 332);
            this.lblPVPTexto.Name = "lblPVPTexto";
            this.lblPVPTexto.Size = new System.Drawing.Size(107, 23);
            this.lblPVPTexto.TabIndex = 14;
            this.lblPVPTexto.Text = "PVP calculado:";
            // 
            // lblSeccion
            // 
            this.lblSeccion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccion.Location = new System.Drawing.Point(37, 302);
            this.lblSeccion.Name = "lblSeccion";
            this.lblSeccion.Size = new System.Drawing.Size(107, 23);
            this.lblSeccion.TabIndex = 13;
            this.lblSeccion.Text = "Sección:";
            // 
            // lblTipoIVA
            // 
            this.lblTipoIVA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoIVA.Location = new System.Drawing.Point(37, 272);
            this.lblTipoIVA.Name = "lblTipoIVA";
            this.lblTipoIVA.Size = new System.Drawing.Size(107, 23);
            this.lblTipoIVA.TabIndex = 12;
            this.lblTipoIVA.Text = "Tipo de IVA:";
            // 
            // panelCabecera
            // 
            this.panelCabecera.BackColor = System.Drawing.Color.SteelBlue;
            this.panelCabecera.Controls.Add(this.pictureBoxLogo);
            this.panelCabecera.Controls.Add(this.lblTitulo);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(524, 78);
            this.panelCabecera.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Presentación.Properties.Resources.logo_musculoso_azul_naranja;
            this.pictureBoxLogo.Location = new System.Drawing.Point(24, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(80, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Ficha del producto";
            // 
            // dsGimnasio1
            // 
            this.dsGimnasio1.DataSetName = "DSGimnasio";
            this.dsGimnasio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsSecciones
            // 
            this.bsSecciones.DataMember = "Secciones";
            this.bsSecciones.DataSource = this.dsGimnasio1;
            // 
            // bsProductos
            // 
            this.bsProductos.DataMember = "Productos";
            this.bsProductos.DataSource = this.dsGimnasio1;
            // 
            // bsIVA
            // 
            this.bsIVA.DataMember = "Tipo_IVA";
            this.bsIVA.DataSource = this.dsGimnasio1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(153, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 32);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(295, 403);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(99, 32);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FFichaProducto2
            // 
            this.ClientSize = new System.Drawing.Size(524, 458);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panelCabecera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtBaseImponible);
            this.Controls.Add(this.comboBoxIVA);
            this.Controls.Add(this.cbSeccion);
            this.Controls.Add(this.lblPVP);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecioCompra);
            this.Controls.Add(this.lblBaseImponible);
            this.Controls.Add(this.lblTipoIVA);
            this.Controls.Add(this.lblSeccion);
            this.Controls.Add(this.lblPVPTexto);
            this.Name = "FFichaProducto2";
            this.Text = "Ficha de Producto";
            this.Load += new System.EventHandler(this.FFichaProducto2_Load);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSecciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CAD.DSGimnasio dsGimnasio1;
        private System.Windows.Forms.BindingSource bsSecciones;
        private System.Windows.Forms.BindingSource bsProductos;
        private System.Windows.Forms.BindingSource bsIVA;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
    }
}
