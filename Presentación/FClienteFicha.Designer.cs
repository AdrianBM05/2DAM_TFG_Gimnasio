namespace Presentación
{
    partial class FClienteFicha
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FClienteFicha));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDatos = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.RichTextBox();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.dsGimnasio1 = new CAD.DSGimnasio();
            this.txtContraseña = new System.Windows.Forms.RichTextBox();
            this.txtUsuario = new System.Windows.Forms.RichTextBox();
            this.txtDirec = new System.Windows.Forms.RichTextBox();
            this.txtDNI = new System.Windows.Forms.RichTextBox();
            this.txtApellido = new System.Windows.Forms.RichTextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.RichTextBox();
            this.txtFechaInicio = new System.Windows.Forms.RichTextBox();
            this.txtFechaCaducidad = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.bsEstado = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTarifas = new System.Windows.Forms.ComboBox();
            this.bsTarifa = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarifa)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 483);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.lblDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(257, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 163);
            this.panel1.TabIndex = 1;
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatos.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(0, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(630, 163);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "DATOS CLIENTE";
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDatos.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.lblCaducidad, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblInicio, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtCorreo, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtContraseña, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtUsuario, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDirec, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDNI, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtApellido, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCorreo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblContraseña, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblUsuario, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDireccion, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDNI, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblApellidos, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblNombre, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNombre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtFechaInicio, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtFechaCaducidad, 3, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(257, 172);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 187);
            this.tableLayoutPanel2.TabIndex = 3;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaducidad.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaducidad.Location = new System.Drawing.Point(317, 148);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(151, 39);
            this.lblCaducidad.TabIndex = 13;
            this.lblCaducidad.Text = "Caducidad:";
            this.lblCaducidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInicio
            // 
            this.lblInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInicio.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(3, 148);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(151, 39);
            this.lblInicio.TabIndex = 29;
            this.lblInicio.Text = "Inicio:";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Correo", true));
            this.txtCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(160, 114);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShowSelectionMargin = true;
            this.txtCorreo.Size = new System.Drawing.Size(151, 31);
            this.txtCorreo.TabIndex = 26;
            this.txtCorreo.Text = "";
            // 
            // bsClientes
            // 
            this.bsClientes.DataMember = "Clientes";
            this.bsClientes.DataSource = this.dsGimnasio1;
            // 
            // dsGimnasio1
            // 
            this.dsGimnasio1.DataSetName = "DSGimnasio";
            this.dsGimnasio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Contraseña", true));
            this.txtContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContraseña.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(474, 77);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.ShowSelectionMargin = true;
            this.txtContraseña.Size = new System.Drawing.Size(153, 31);
            this.txtContraseña.TabIndex = 25;
            this.txtContraseña.Text = "";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Usuario", true));
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(160, 77);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShowSelectionMargin = true;
            this.txtUsuario.Size = new System.Drawing.Size(151, 31);
            this.txtUsuario.TabIndex = 24;
            this.txtUsuario.Text = "";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtDirec
            // 
            this.txtDirec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirec.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Dirección", true));
            this.txtDirec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDirec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirec.Location = new System.Drawing.Point(474, 40);
            this.txtDirec.Multiline = false;
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.ShowSelectionMargin = true;
            this.txtDirec.Size = new System.Drawing.Size(153, 31);
            this.txtDirec.TabIndex = 23;
            this.txtDirec.Text = "";
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "DNI", true));
            this.txtDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDNI.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(160, 40);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ShowSelectionMargin = true;
            this.txtDNI.Size = new System.Drawing.Size(151, 31);
            this.txtDNI.TabIndex = 22;
            this.txtDNI.Text = "";
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Apellidos", true));
            this.txtApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApellido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(474, 3);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShowSelectionMargin = true;
            this.txtApellido.Size = new System.Drawing.Size(153, 31);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.Text = "";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorreo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(3, 111);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(151, 37);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContraseña.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(317, 74);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(151, 37);
            this.lblContraseña.TabIndex = 10;
            this.lblContraseña.Text = "Contraseña:";
            this.lblContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsuario.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(3, 74);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(151, 37);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDireccion.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(317, 37);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(151, 37);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Text = "Dirección:";
            this.txtDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            this.lblDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDNI.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(3, 37);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(151, 37);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApellidos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(317, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(151, 37);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(151, 37);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Nombre", true));
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(160, 3);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShowSelectionMargin = true;
            this.txtNombre.Size = new System.Drawing.Size(151, 31);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.Text = "";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Fecha_Inicio_Tarifa", true));
            this.txtFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicio.Location = new System.Drawing.Point(160, 151);
            this.txtFechaInicio.Multiline = false;
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.ShowSelectionMargin = true;
            this.txtFechaInicio.Size = new System.Drawing.Size(151, 33);
            this.txtFechaInicio.TabIndex = 27;
            this.txtFechaInicio.Text = "";
            // 
            // txtFechaCaducidad
            // 
            this.txtFechaCaducidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaCaducidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Fecha_Caducidad_Tarifa", true));
            this.txtFechaCaducidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFechaCaducidad.Enabled = false;
            this.txtFechaCaducidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCaducidad.Location = new System.Drawing.Point(474, 151);
            this.txtFechaCaducidad.Multiline = false;
            this.txtFechaCaducidad.Name = "txtFechaCaducidad";
            this.txtFechaCaducidad.ShowSelectionMargin = true;
            this.txtFechaCaducidad.Size = new System.Drawing.Size(153, 33);
            this.txtFechaCaducidad.TabIndex = 28;
            this.txtFechaCaducidad.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.comboBoxEstado, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxTarifas, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 172);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(248, 187);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsClientes, "Id_Estado", true));
            this.comboBoxEstado.DataSource = this.bsEstado;
            this.comboBoxEstado.DisplayMember = "Estado";
            this.comboBoxEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(3, 65);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(242, 21);
            this.comboBoxEstado.TabIndex = 1;
            this.comboBoxEstado.ValueMember = "Id";
            // 
            // bsEstado
            // 
            this.bsEstado.DataMember = "Estado";
            this.bsEstado.DataSource = this.dsGimnasio1;
            // 
            // comboBoxTarifas
            // 
            this.comboBoxTarifas.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsClientes, "IdTarifa", true));
            this.comboBoxTarifas.DataSource = this.bsTarifa;
            this.comboBoxTarifas.DisplayMember = "TipoTarifa";
            this.comboBoxTarifas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxTarifas.FormattingEnabled = true;
            this.comboBoxTarifas.Location = new System.Drawing.Point(3, 3);
            this.comboBoxTarifas.Name = "comboBoxTarifas";
            this.comboBoxTarifas.Size = new System.Drawing.Size(242, 21);
            this.comboBoxTarifas.TabIndex = 0;
            this.comboBoxTarifas.ValueMember = "Id";
            // 
            // bsTarifa
            // 
            this.bsTarifa.DataMember = "Tarifas";
            this.bsTarifa.DataSource = this.dsGimnasio1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnGuardar, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(257, 365);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(630, 115);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(255, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 63);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FClienteFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FClienteFicha";
            this.Text = "Ficha personal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FClienteFicha_FormClosed);
            this.Load += new System.EventHandler(this.FClienteFicha_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTarifa)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.RichTextBox txtNombre;
        private System.Windows.Forms.RichTextBox txtCorreo;
        private System.Windows.Forms.RichTextBox txtContraseña;
        private System.Windows.Forms.RichTextBox txtUsuario;
        private System.Windows.Forms.RichTextBox txtDirec;
        private System.Windows.Forms.RichTextBox txtDNI;
        private System.Windows.Forms.RichTextBox txtApellido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox comboBoxTarifas;
        private CAD.DSGimnasio dsGimnasio1;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.RichTextBox txtFechaInicio;
        private System.Windows.Forms.RichTextBox txtFechaCaducidad;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.BindingSource bsTarifa;
        private System.Windows.Forms.BindingSource bsEstado;
    }
}