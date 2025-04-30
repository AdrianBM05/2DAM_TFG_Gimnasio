namespace Presentación
{
    partial class FFichaCliente
    {
        private System.ComponentModel.IContainer components = null;

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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.gymLogo = new System.Windows.Forms.PictureBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.clientInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.dsGimnasio1 = new CAD.DSGimnasio();
            this.bsEstado = new System.Windows.Forms.BindingSource(this.components);
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.dniLabel = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tariffLabel = new System.Windows.Forms.Label();
            this.comboBoxTarifas = new System.Windows.Forms.ComboBox();
            this.bsTarifa = new System.Windows.Forms.BindingSource(this.components);
            this.statusLabel = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gymLogo)).BeginInit();
            this.clientInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarifa)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.headerPanel.Controls.Add(this.gymLogo);
            this.headerPanel.Controls.Add(this.headerLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(550, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // gymLogo
            // 
            this.gymLogo.Image = global::Presentación.Properties.Resources.natura_logo;
            this.gymLogo.Location = new System.Drawing.Point(10, 10);
            this.gymLogo.Name = "gymLogo";
            this.gymLogo.Size = new System.Drawing.Size(60, 60);
            this.gymLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gymLogo.TabIndex = 0;
            this.gymLogo.TabStop = false;
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.White;
            this.headerLabel.Location = new System.Drawing.Point(80, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(100, 50);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Datos del Cliente";
            // 
            // clientInfoGroupBox
            // 
            this.clientInfoGroupBox.Controls.Add(this.comboBoxEstado);
            this.clientInfoGroupBox.Controls.Add(this.txtCorreo);
            this.clientInfoGroupBox.Controls.Add(this.txtContraseña);
            this.clientInfoGroupBox.Controls.Add(this.txtUsuario);
            this.clientInfoGroupBox.Controls.Add(this.txtDireccion);
            this.clientInfoGroupBox.Controls.Add(this.nameLabel);
            this.clientInfoGroupBox.Controls.Add(this.txtNombre);
            this.clientInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.clientInfoGroupBox.Controls.Add(this.txtApellidos);
            this.clientInfoGroupBox.Controls.Add(this.dniLabel);
            this.clientInfoGroupBox.Controls.Add(this.txtDNI);
            this.clientInfoGroupBox.Controls.Add(this.addressLabel);
            this.clientInfoGroupBox.Controls.Add(this.usernameLabel);
            this.clientInfoGroupBox.Controls.Add(this.passwordLabel);
            this.clientInfoGroupBox.Controls.Add(this.emailLabel);
            this.clientInfoGroupBox.Controls.Add(this.startDateLabel);
            this.clientInfoGroupBox.Controls.Add(this.startDatePicker);
            this.clientInfoGroupBox.Controls.Add(this.endDateLabel);
            this.clientInfoGroupBox.Controls.Add(this.endDatePicker);
            this.clientInfoGroupBox.Controls.Add(this.tariffLabel);
            this.clientInfoGroupBox.Controls.Add(this.comboBoxTarifas);
            this.clientInfoGroupBox.Controls.Add(this.statusLabel);
            this.clientInfoGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clientInfoGroupBox.Location = new System.Drawing.Point(20, 100);
            this.clientInfoGroupBox.Name = "clientInfoGroupBox";
            this.clientInfoGroupBox.Size = new System.Drawing.Size(500, 500);
            this.clientInfoGroupBox.TabIndex = 1;
            this.clientInfoGroupBox.TabStop = false;
            this.clientInfoGroupBox.Text = "Información del Cliente";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsGimnasio1, "Clientes.Id_Estado", true));
            this.comboBoxEstado.DataSource = this.bsEstado;
            this.comboBoxEstado.DisplayMember = "Estado";
            this.comboBoxEstado.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstado.Location = new System.Drawing.Point(195, 438);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(200, 23);
            this.comboBoxEstado.TabIndex = 26;
            this.comboBoxEstado.ValueMember = "Id";
            // 
            // dsGimnasio1
            // 
            this.dsGimnasio1.DataSetName = "DSGimnasio";
            this.dsGimnasio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsEstado
            // 
            this.bsEstado.DataMember = "Estado";
            this.bsEstado.DataSource = this.dsGimnasio1;
            // 
            // txtCorreo
            // 
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGimnasio1, "Clientes.Correo", true));
            this.txtCorreo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(195, 270);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 23);
            this.txtCorreo.TabIndex = 25;
            // 
            // txtContraseña
            // 
            this.txtContraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGimnasio1, "Clientes.Contraseña", true));
            this.txtContraseña.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(195, 230);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(200, 23);
            this.txtContraseña.TabIndex = 24;
            // 
            // txtUsuario
            // 
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGimnasio1, "Clientes.Usuario", true));
            this.txtUsuario.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(195, 190);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(200, 23);
            this.txtUsuario.TabIndex = 23;
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGimnasio1, "Clientes.Dirección", true));
            this.txtDireccion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(195, 150);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 23);
            this.txtDireccion.TabIndex = 22;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(20, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGimnasio1, "Clientes.Nombre", true));
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(195, 30);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(20, 70);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(100, 23);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Apellidos", true));
            this.txtApellidos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(195, 70);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 23);
            this.txtApellidos.TabIndex = 3;
            // 
            // bsClientes
            // 
            this.bsClientes.DataMember = "Clientes";
            this.bsClientes.DataSource = this.dsGimnasio1;
            this.bsClientes.CurrentChanged += new System.EventHandler(this.bsClientes_CurrentChanged);
            // 
            // dniLabel
            // 
            this.dniLabel.Location = new System.Drawing.Point(20, 110);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(100, 23);
            this.dniLabel.TabIndex = 4;
            this.dniLabel.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGimnasio1, "Clientes.DNI", true));
            this.txtDNI.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(195, 110);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(200, 23);
            this.txtDNI.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.Location = new System.Drawing.Point(20, 150);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(100, 23);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Dirección:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(20, 190);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 23);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Usuario:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(20, 230);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(114, 23);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Contraseña:";
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(20, 270);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLabel.TabIndex = 12;
            this.emailLabel.Text = "Correo:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.Location = new System.Drawing.Point(20, 310);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(140, 23);
            this.startDateLabel.TabIndex = 14;
            this.startDateLabel.Text = "Fecha de Inicio:";
            // 
            // startDatePicker
            // 
            this.startDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsGimnasio1, "Clientes.Fecha_Inicio_Tarifa", true));
            this.startDatePicker.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDatePicker.Location = new System.Drawing.Point(195, 310);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 23);
            this.startDatePicker.TabIndex = 15;
            // 
            // endDateLabel
            // 
            this.endDateLabel.Location = new System.Drawing.Point(20, 350);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(140, 23);
            this.endDateLabel.TabIndex = 16;
            this.endDateLabel.Text = "Fecha de Fin:";
            // 
            // endDatePicker
            // 
            this.endDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsGimnasio1, "Clientes.Fecha_Caducidad_Tarifa", true));
            this.endDatePicker.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDatePicker.Location = new System.Drawing.Point(195, 350);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 23);
            this.endDatePicker.TabIndex = 17;
            // 
            // tariffLabel
            // 
            this.tariffLabel.Location = new System.Drawing.Point(20, 390);
            this.tariffLabel.Name = "tariffLabel";
            this.tariffLabel.Size = new System.Drawing.Size(140, 23);
            this.tariffLabel.TabIndex = 18;
            this.tariffLabel.Text = "Tipo de Tarifa:";
            // 
            // comboBoxTarifas
            // 
            this.comboBoxTarifas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsClientes, "IdTarifa", true));
            this.comboBoxTarifas.DataSource = this.bsTarifa;
            this.comboBoxTarifas.DisplayMember = "TipoTarifa";
            this.comboBoxTarifas.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTarifas.Location = new System.Drawing.Point(195, 392);
            this.comboBoxTarifas.Name = "comboBoxTarifas";
            this.comboBoxTarifas.Size = new System.Drawing.Size(200, 23);
            this.comboBoxTarifas.TabIndex = 19;
            this.comboBoxTarifas.ValueMember = "Id";
            // 
            // bsTarifa
            // 
            this.bsTarifa.DataMember = "Tarifas";
            this.bsTarifa.DataSource = this.dsGimnasio1;
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(20, 441);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(100, 23);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.Text = "Estado:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(215, 606);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 32);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FFichaCliente
            // 
            this.ClientSize = new System.Drawing.Size(550, 650);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.clientInfoGroupBox);
            this.Name = "FFichaCliente";
            this.Text = "Ficha del Cliente";
            this.Load += new System.EventHandler(this.FClienteFicha2_Load_1);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gymLogo)).EndInit();
            this.clientInfoGroupBox.ResumeLayout(false);
            this.clientInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarifa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox gymLogo;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.GroupBox clientInfoGroupBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label tariffLabel;
        private System.Windows.Forms.ComboBox comboBoxTarifas;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.BindingSource bsTarifa;
        private System.Windows.Forms.BindingSource bsEstado;
        private System.Windows.Forms.Button btnGuardar;
        private CAD.DSGimnasio dsGimnasio1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox comboBoxEstado;
    }
}
