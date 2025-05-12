using System;
using System.Windows.Forms;

namespace Presentación
{
    partial class FFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpVentana = new System.Windows.Forms.TableLayoutPanel();
            this.gbCabecera = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.bsFacturas = new System.Windows.Forms.BindingSource(this.components);
            this.dsGimnasio1 = new CAD.DSGimnasio();
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblEmision = new System.Windows.Forms.Label();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblFechaEnvio = new System.Windows.Forms.Label();
            this.dtpEnvio = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblEstadoFactura = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.bsTipoPago = new System.Windows.Forms.BindingSource(this.components);
            this.cbEstadoFactura = new System.Windows.Forms.ComboBox();
            this.bsEstadoFactura = new System.Windows.Forms.BindingSource(this.components);
            this.cbEnvio = new System.Windows.Forms.ComboBox();
            this.bsEnvio = new System.Windows.Forms.BindingSource(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbDesgloses = new System.Windows.Forms.GroupBox();
            this.tlpDesgloses = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDatosDesglose = new System.Windows.Forms.TableLayoutPanel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.bsProductos = new System.Windows.Forms.BindingSource(this.components);
            this.lblCódigo = new System.Windows.Forms.Label();
            this.lblBaseImponible = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtBImponible = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.btnGuardarDesglose = new System.Windows.Forms.Button();
            this.btnEliminarDesglose = new System.Windows.Forms.Button();
            this.btnEditarDesglose = new System.Windows.Forms.Button();
            this.tlpVistaDesglose = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDesglose = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseImponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVDesglose = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gpTotal = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblTotalCoste = new System.Windows.Forms.Label();
            this.lblTotalBImponible = new System.Windows.Forms.Label();
            this.bsDesglose = new System.Windows.Forms.BindingSource(this.components);
            this.tlpVentana.SuspendLayout();
            this.gbCabecera.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnvio)).BeginInit();
            this.gbDesgloses.SuspendLayout();
            this.tlpDesgloses.SuspendLayout();
            this.tlpDatosDesglose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).BeginInit();
            this.tlpVistaDesglose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesglose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVDesglose)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.gpTotal.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDesglose)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpVentana
            // 
            this.tlpVentana.ColumnCount = 1;
            this.tlpVentana.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVentana.Controls.Add(this.gbCabecera, 0, 0);
            this.tlpVentana.Controls.Add(this.gbDesgloses, 0, 1);
            this.tlpVentana.Controls.Add(this.gpTotal, 0, 2);
            this.tlpVentana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVentana.Location = new System.Drawing.Point(0, 0);
            this.tlpVentana.Name = "tlpVentana";
            this.tlpVentana.RowCount = 3;
            this.tlpVentana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.07837F));
            this.tlpVentana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.19178F));
            this.tlpVentana.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.87671F));
            this.tlpVentana.Size = new System.Drawing.Size(1063, 671);
            this.tlpVentana.TabIndex = 0;
            // 
            // gbCabecera
            // 
            this.gbCabecera.BackColor = System.Drawing.SystemColors.Menu;
            this.gbCabecera.Controls.Add(this.tableLayoutPanel1);
            this.gbCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCabecera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCabecera.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCabecera.Location = new System.Drawing.Point(3, 3);
            this.gbCabecera.Name = "gbCabecera";
            this.gbCabecera.Size = new System.Drawing.Size(1057, 162);
            this.gbCabecera.TabIndex = 0;
            this.gbCabecera.TabStop = false;
            this.gbCabecera.Text = "Datos de la factura";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tableLayoutPanel1.ColumnCount = 16;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbClientes, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtApellidos, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblApellidos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDNI, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDNI, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEmision, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpEmision, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVencimiento, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaPago, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpVencimiento, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaPago, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblCorreo, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtCorreo, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaEnvio, 7, 7);
            this.tableLayoutPanel1.Controls.Add(this.dtpEnvio, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 11, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoPago, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEnvio, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEstadoFactura, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoPago, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbEstadoFactura, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbEnvio, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVolver, 13, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 137);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombre.Location = new System.Drawing.Point(55, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbClientes
            // 
            this.cmbClientes.BackColor = System.Drawing.SystemColors.Window;
            this.cmbClientes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsFacturas, "Id_Cliente", true));
            this.cmbClientes.DataSource = this.bsClientes;
            this.cmbClientes.DisplayMember = "Nombre";
            this.cmbClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClientes.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(118, 18);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(99, 22);
            this.cmbClientes.TabIndex = 17;
            this.cmbClientes.ValueMember = "Id";
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // bsFacturas
            // 
            this.bsFacturas.DataMember = "Facturas";
            this.bsFacturas.DataSource = this.dsGimnasio1;
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
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Apellidos", true));
            this.txtApellidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtApellidos.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(118, 48);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(99, 22);
            this.txtApellidos.TabIndex = 20;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApellidos.Location = new System.Drawing.Point(55, 45);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(57, 15);
            this.lblApellidos.TabIndex = 18;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDNI.Location = new System.Drawing.Point(55, 75);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(57, 15);
            this.lblDNI.TabIndex = 21;
            this.lblDNI.Text = "DNI:";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "DNI", true));
            this.txtDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDNI.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(118, 78);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(99, 22);
            this.txtDNI.TabIndex = 22;
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmision.Location = new System.Drawing.Point(516, 15);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(88, 15);
            this.lblEmision.TabIndex = 25;
            this.lblEmision.Text = "Fecha de emisión:";
            this.lblEmision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEmision
            // 
            this.dtpEmision.CalendarFont = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmision.CustomFormat = "   dd/MM/yyyy";
            this.dtpEmision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEmision.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmision.Location = new System.Drawing.Point(610, 18);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(99, 22);
            this.dtpEmision.TabIndex = 26;
            this.dtpEmision.Value = new System.DateTime(2024, 12, 20, 0, 0, 0, 0);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVencimiento.Location = new System.Drawing.Point(516, 45);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(88, 15);
            this.lblVencimiento.TabIndex = 27;
            this.lblVencimiento.Text = "Fecha vencimiento:";
            this.lblVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaPago.Location = new System.Drawing.Point(516, 75);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(88, 15);
            this.lblFechaPago.TabIndex = 35;
            this.lblFechaPago.Text = "Fecha de pago:";
            this.lblFechaPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CalendarFont = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.CustomFormat = "   dd/MM/yyyy";
            this.dtpVencimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpVencimiento.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(610, 48);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(99, 22);
            this.dtpVencimiento.TabIndex = 36;
            this.dtpVencimiento.Value = new System.DateTime(2024, 12, 12, 9, 9, 29, 0);
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.CalendarFont = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPago.CustomFormat = "   dd/MM/yyyy";
            this.dtpFechaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFechaPago.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPago.Location = new System.Drawing.Point(610, 78);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(99, 22);
            this.dtpFechaPago.TabIndex = 37;
            this.dtpFechaPago.Value = new System.DateTime(2024, 12, 12, 9, 9, 29, 0);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCorreo.Location = new System.Drawing.Point(55, 105);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(57, 15);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsClientes, "Correo", true));
            this.txtCorreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCorreo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(118, 108);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(99, 22);
            this.txtCorreo.TabIndex = 24;
            // 
            // lblFechaEnvio
            // 
            this.lblFechaEnvio.AutoSize = true;
            this.lblFechaEnvio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFechaEnvio.Location = new System.Drawing.Point(516, 105);
            this.lblFechaEnvio.Name = "lblFechaEnvio";
            this.lblFechaEnvio.Size = new System.Drawing.Size(88, 15);
            this.lblFechaEnvio.TabIndex = 39;
            this.lblFechaEnvio.Text = "Fecha de envío:";
            this.lblFechaEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpEnvio
            // 
            this.dtpEnvio.CalendarFont = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnvio.CustomFormat = "   dd/MM/yyyy";
            this.dtpEnvio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEnvio.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnvio.Location = new System.Drawing.Point(610, 108);
            this.dtpEnvio.Name = "dtpEnvio";
            this.dtpEnvio.Size = new System.Drawing.Size(99, 22);
            this.dtpEnvio.TabIndex = 40;
            this.dtpEnvio.Value = new System.DateTime(2024, 12, 12, 9, 9, 29, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.btnGuardar, 2);
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(788, 93);
            this.btnGuardar.Name = "btnGuardar";
            this.tableLayoutPanel1.SetRowSpan(this.btnGuardar, 2);
            this.btnGuardar.Size = new System.Drawing.Size(98, 24);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTipoPago.Location = new System.Drawing.Point(275, 15);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(78, 15);
            this.lblTipoPago.TabIndex = 41;
            this.lblTipoPago.Text = "Tipo de pago:";
            this.lblTipoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnvio.Location = new System.Drawing.Point(275, 45);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(78, 15);
            this.lblEnvio.TabIndex = 42;
            this.lblEnvio.Text = "Envio:";
            this.lblEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEstadoFactura
            // 
            this.lblEstadoFactura.AutoSize = true;
            this.lblEstadoFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoFactura.Location = new System.Drawing.Point(275, 75);
            this.lblEstadoFactura.Name = "lblEstadoFactura";
            this.lblEstadoFactura.Size = new System.Drawing.Size(78, 15);
            this.lblEstadoFactura.TabIndex = 43;
            this.lblEstadoFactura.Text = "Estado:";
            this.lblEstadoFactura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsFacturas, "IdTipoPago", true));
            this.cmbTipoPago.DataSource = this.bsTipoPago;
            this.cmbTipoPago.DisplayMember = "TipoPago";
            this.cmbTipoPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoPago.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(359, 18);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(99, 22);
            this.cmbTipoPago.TabIndex = 44;
            this.cmbTipoPago.ValueMember = "Id";
            // 
            // bsTipoPago
            // 
            this.bsTipoPago.AllowNew = true;
            this.bsTipoPago.DataMember = "TipoPago";
            this.bsTipoPago.DataSource = this.dsGimnasio1;
            // 
            // cbEstadoFactura
            // 
            this.cbEstadoFactura.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsFacturas, "IdEstadoFactura", true));
            this.cbEstadoFactura.DataSource = this.bsEstadoFactura;
            this.cbEstadoFactura.DisplayMember = "Estado";
            this.cbEstadoFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEstadoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstadoFactura.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstadoFactura.FormattingEnabled = true;
            this.cbEstadoFactura.Location = new System.Drawing.Point(359, 78);
            this.cbEstadoFactura.Name = "cbEstadoFactura";
            this.cbEstadoFactura.Size = new System.Drawing.Size(99, 22);
            this.cbEstadoFactura.TabIndex = 46;
            this.cbEstadoFactura.ValueMember = "Id";
            // 
            // bsEstadoFactura
            // 
            this.bsEstadoFactura.AllowNew = true;
            this.bsEstadoFactura.DataMember = "EstadoFactura";
            this.bsEstadoFactura.DataSource = this.dsGimnasio1;
            // 
            // cbEnvio
            // 
            this.cbEnvio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsFacturas, "IdEnvio", true));
            this.cbEnvio.DataSource = this.bsEnvio;
            this.cbEnvio.DisplayMember = "MetodoEnvio";
            this.cbEnvio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEnvio.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnvio.FormattingEnabled = true;
            this.cbEnvio.Location = new System.Drawing.Point(359, 48);
            this.cbEnvio.Name = "cbEnvio";
            this.cbEnvio.Size = new System.Drawing.Size(99, 22);
            this.cbEnvio.TabIndex = 45;
            this.cbEnvio.ValueMember = "Id";
            // 
            // bsEnvio
            // 
            this.bsEnvio.AllowNew = true;
            this.bsEnvio.DataMember = "Envio";
            this.bsEnvio.DataSource = this.dsGimnasio1;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.SetColumnSpan(this.btnVolver, 2);
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(892, 93);
            this.btnVolver.Name = "btnVolver";
            this.tableLayoutPanel1.SetRowSpan(this.btnVolver, 2);
            this.btnVolver.Size = new System.Drawing.Size(98, 24);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gbDesgloses
            // 
            this.gbDesgloses.BackColor = System.Drawing.SystemColors.MenuBar;
            this.gbDesgloses.Controls.Add(this.tlpDesgloses);
            this.gbDesgloses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDesgloses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDesgloses.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDesgloses.Location = new System.Drawing.Point(3, 171);
            this.gbDesgloses.Name = "gbDesgloses";
            this.gbDesgloses.Size = new System.Drawing.Size(1057, 343);
            this.gbDesgloses.TabIndex = 1;
            this.gbDesgloses.TabStop = false;
            this.gbDesgloses.Text = "Desgloses ";
            // 
            // tlpDesgloses
            // 
            this.tlpDesgloses.BackColor = System.Drawing.SystemColors.Menu;
            this.tlpDesgloses.ColumnCount = 3;
            this.tlpDesgloses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.28391F));
            this.tlpDesgloses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.71609F));
            this.tlpDesgloses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tlpDesgloses.Controls.Add(this.tlpDatosDesglose, 0, 0);
            this.tlpDesgloses.Controls.Add(this.tlpVistaDesglose, 1, 0);
            this.tlpDesgloses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDesgloses.Location = new System.Drawing.Point(3, 22);
            this.tlpDesgloses.Name = "tlpDesgloses";
            this.tlpDesgloses.RowCount = 1;
            this.tlpDesgloses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDesgloses.Size = new System.Drawing.Size(1051, 318);
            this.tlpDesgloses.TabIndex = 0;
            this.tlpDesgloses.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpDesgloses_Paint);
            // 
            // tlpDatosDesglose
            // 
            this.tlpDatosDesglose.ColumnCount = 6;
            this.tlpDatosDesglose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.14042F));
            this.tlpDatosDesglose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.28085F));
            this.tlpDatosDesglose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.378646F));
            this.tlpDatosDesglose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.14584F));
            this.tlpDatosDesglose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.05425F));
            this.tlpDatosDesglose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDatosDesglose.Controls.Add(this.lblProducto, 1, 1);
            this.tlpDatosDesglose.Controls.Add(this.cmbProductos, 3, 1);
            this.tlpDatosDesglose.Controls.Add(this.lblCódigo, 1, 3);
            this.tlpDatosDesglose.Controls.Add(this.lblBaseImponible, 1, 5);
            this.tlpDatosDesglose.Controls.Add(this.txtCodigo, 3, 3);
            this.tlpDatosDesglose.Controls.Add(this.txtBImponible, 3, 5);
            this.tlpDatosDesglose.Controls.Add(this.lblCantidad, 1, 7);
            this.tlpDatosDesglose.Controls.Add(this.txtCantidad, 3, 7);
            this.tlpDatosDesglose.Controls.Add(this.lblConcepto, 1, 9);
            this.tlpDatosDesglose.Controls.Add(this.txtConcepto, 3, 9);
            this.tlpDatosDesglose.Controls.Add(this.btnGuardarDesglose, 3, 12);
            this.tlpDatosDesglose.Controls.Add(this.btnEliminarDesglose, 3, 15);
            this.tlpDatosDesglose.Controls.Add(this.btnEditarDesglose, 3, 18);
            this.tlpDatosDesglose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDatosDesglose.Location = new System.Drawing.Point(3, 3);
            this.tlpDatosDesglose.Name = "tlpDatosDesglose";
            this.tlpDatosDesglose.RowCount = 21;
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDatosDesglose.Size = new System.Drawing.Size(284, 312);
            this.tlpDatosDesglose.TabIndex = 1;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProducto.Location = new System.Drawing.Point(34, 10);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(57, 10);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto:";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProductos
            // 
            this.cmbProductos.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProductos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProductos, "Id", true));
            this.cmbProductos.DataSource = this.bsProductos;
            this.cmbProductos.DisplayMember = "Nombre";
            this.cmbProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductos.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(100, 13);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(150, 22);
            this.cmbProductos.TabIndex = 18;
            this.cmbProductos.ValueMember = "Id";
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // bsProductos
            // 
            this.bsProductos.DataMember = "Productos";
            this.bsProductos.DataSource = this.dsGimnasio1;
            // 
            // lblCódigo
            // 
            this.lblCódigo.AutoSize = true;
            this.lblCódigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCódigo.Location = new System.Drawing.Point(34, 30);
            this.lblCódigo.Name = "lblCódigo";
            this.lblCódigo.Size = new System.Drawing.Size(57, 10);
            this.lblCódigo.TabIndex = 19;
            this.lblCódigo.Text = "Código: ";
            this.lblCódigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBaseImponible
            // 
            this.lblBaseImponible.AutoSize = true;
            this.lblBaseImponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBaseImponible.Location = new System.Drawing.Point(34, 50);
            this.lblBaseImponible.Name = "lblBaseImponible";
            this.lblBaseImponible.Size = new System.Drawing.Size(57, 10);
            this.lblBaseImponible.TabIndex = 20;
            this.lblBaseImponible.Text = "B. Imponible:";
            this.lblBaseImponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProductos, "Id", true));
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(100, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 22);
            this.txtCodigo.TabIndex = 24;
            // 
            // txtBImponible
            // 
            this.txtBImponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBImponible.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProductos, "Base_Imponible", true));
            this.txtBImponible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBImponible.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBImponible.Location = new System.Drawing.Point(100, 53);
            this.txtBImponible.Name = "txtBImponible";
            this.txtBImponible.Size = new System.Drawing.Size(150, 22);
            this.txtBImponible.TabIndex = 25;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Location = new System.Drawing.Point(34, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 10);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCantidad.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(100, 73);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 22);
            this.txtCantidad.TabIndex = 27;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConcepto.Location = new System.Drawing.Point(34, 90);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(57, 10);
            this.lblConcepto.TabIndex = 23;
            this.lblConcepto.Text = "Concepto:";
            this.lblConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConcepto
            // 
            this.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConcepto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConcepto.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(100, 93);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(150, 22);
            this.txtConcepto.TabIndex = 28;
            // 
            // btnGuardarDesglose
            // 
            this.btnGuardarDesglose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardarDesglose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarDesglose.Location = new System.Drawing.Point(100, 123);
            this.btnGuardarDesglose.Name = "btnGuardarDesglose";
            this.tlpDatosDesglose.SetRowSpan(this.btnGuardarDesglose, 2);
            this.btnGuardarDesglose.Size = new System.Drawing.Size(150, 34);
            this.btnGuardarDesglose.TabIndex = 29;
            this.btnGuardarDesglose.Text = "AÑADIR";
            this.btnGuardarDesglose.UseVisualStyleBackColor = true;
            this.btnGuardarDesglose.Click += new System.EventHandler(this.btnGuardarDesglose_Click);
            // 
            // btnEliminarDesglose
            // 
            this.btnEliminarDesglose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarDesglose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarDesglose.Location = new System.Drawing.Point(100, 183);
            this.btnEliminarDesglose.Name = "btnEliminarDesglose";
            this.tlpDatosDesglose.SetRowSpan(this.btnEliminarDesglose, 2);
            this.btnEliminarDesglose.Size = new System.Drawing.Size(150, 34);
            this.btnEliminarDesglose.TabIndex = 30;
            this.btnEliminarDesglose.Text = "ELIMINAR";
            this.btnEliminarDesglose.UseVisualStyleBackColor = true;
            this.btnEliminarDesglose.Click += new System.EventHandler(this.btnEliminarDesglose_Click);
            // 
            // btnEditarDesglose
            // 
            this.btnEditarDesglose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarDesglose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarDesglose.Location = new System.Drawing.Point(100, 243);
            this.btnEditarDesglose.Name = "btnEditarDesglose";
            this.tlpDatosDesglose.SetRowSpan(this.btnEditarDesglose, 2);
            this.btnEditarDesglose.Size = new System.Drawing.Size(150, 34);
            this.btnEditarDesglose.TabIndex = 31;
            this.btnEditarDesglose.Text = "EDITAR";
            this.btnEditarDesglose.UseVisualStyleBackColor = true;
            this.btnEditarDesglose.Click += new System.EventHandler(this.btnEditarDesglose_Click);
            // 
            // tlpVistaDesglose
            // 
            this.tlpVistaDesglose.ColumnCount = 1;
            this.tlpVistaDesglose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpVistaDesglose.Controls.Add(this.dgvDesglose, 0, 0);
            this.tlpVistaDesglose.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlpVistaDesglose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpVistaDesglose.Location = new System.Drawing.Point(293, 3);
            this.tlpVistaDesglose.Name = "tlpVistaDesglose";
            this.tlpVistaDesglose.RowCount = 2;
            this.tlpVistaDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpVistaDesglose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpVistaDesglose.Size = new System.Drawing.Size(663, 312);
            this.tlpVistaDesglose.TabIndex = 3;
            // 
            // dgvDesglose
            // 
            this.dgvDesglose.AllowUserToAddRows = false;
            this.dgvDesglose.AllowUserToDeleteRows = false;
            this.dgvDesglose.AutoGenerateColumns = false;
            this.dgvDesglose.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesglose.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvDesglose.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesglose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDesglose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesglose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idFacturaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.preciocompraDataGridViewTextBoxColumn,
            this.baseImponibleDataGridViewTextBoxColumn,
            this.tipoIVADataGridViewTextBoxColumn,
            this.pVPDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.conceptoDataGridViewTextBoxColumn});
            this.dgvDesglose.DataSource = this.bsVDesglose;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDesglose.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDesglose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDesglose.EnableHeadersVisualStyles = false;
            this.dgvDesglose.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dgvDesglose.Location = new System.Drawing.Point(3, 3);
            this.dgvDesglose.Name = "dgvDesglose";
            this.dgvDesglose.ReadOnly = true;
            this.dgvDesglose.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesglose.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDesglose.Size = new System.Drawing.Size(657, 196);
            this.dgvDesglose.TabIndex = 2;
            this.dgvDesglose.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesglose_CellClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.FillWeight = 5F;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFacturaDataGridViewTextBoxColumn
            // 
            this.idFacturaDataGridViewTextBoxColumn.DataPropertyName = "IdFactura";
            this.idFacturaDataGridViewTextBoxColumn.FillWeight = 5F;
            this.idFacturaDataGridViewTextBoxColumn.HeaderText = "IdFactura";
            this.idFacturaDataGridViewTextBoxColumn.Name = "idFacturaDataGridViewTextBoxColumn";
            this.idFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 20F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // preciocompraDataGridViewTextBoxColumn
            // 
            this.preciocompraDataGridViewTextBoxColumn.DataPropertyName = "Precio_compra";
            this.preciocompraDataGridViewTextBoxColumn.FillWeight = 8F;
            this.preciocompraDataGridViewTextBoxColumn.HeaderText = "Precio_compra";
            this.preciocompraDataGridViewTextBoxColumn.Name = "preciocompraDataGridViewTextBoxColumn";
            this.preciocompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baseImponibleDataGridViewTextBoxColumn
            // 
            this.baseImponibleDataGridViewTextBoxColumn.DataPropertyName = "Base_Imponible";
            this.baseImponibleDataGridViewTextBoxColumn.FillWeight = 8F;
            this.baseImponibleDataGridViewTextBoxColumn.HeaderText = "Base_Imponible";
            this.baseImponibleDataGridViewTextBoxColumn.Name = "baseImponibleDataGridViewTextBoxColumn";
            this.baseImponibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoIVADataGridViewTextBoxColumn
            // 
            this.tipoIVADataGridViewTextBoxColumn.DataPropertyName = "Tipo_IVA";
            this.tipoIVADataGridViewTextBoxColumn.FillWeight = 5F;
            this.tipoIVADataGridViewTextBoxColumn.HeaderText = "Tipo_IVA";
            this.tipoIVADataGridViewTextBoxColumn.Name = "tipoIVADataGridViewTextBoxColumn";
            this.tipoIVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pVPDataGridViewTextBoxColumn
            // 
            this.pVPDataGridViewTextBoxColumn.DataPropertyName = "PVP";
            this.pVPDataGridViewTextBoxColumn.FillWeight = 10F;
            this.pVPDataGridViewTextBoxColumn.HeaderText = "PVP";
            this.pVPDataGridViewTextBoxColumn.Name = "pVPDataGridViewTextBoxColumn";
            this.pVPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.FillWeight = 6F;
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.FillWeight = 5F;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.FillWeight = 28F;
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsVDesglose
            // 
            this.bsVDesglose.DataMember = "VDesglose";
            this.bsVDesglose.DataSource = this.dsGimnasio1;
            this.bsVDesglose.CurrentChanged += new System.EventHandler(this.bsVDesglose_CurrentChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnGenerar, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 205);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(657, 104);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Location = new System.Drawing.Point(134, 31);
            this.btnGenerar.Name = "btnGenerar";
            this.tableLayoutPanel3.SetRowSpan(this.btnGenerar, 2);
            this.btnGenerar.Size = new System.Drawing.Size(125, 22);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // gpTotal
            // 
            this.gpTotal.Controls.Add(this.tableLayoutPanel2);
            this.gpTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpTotal.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTotal.Location = new System.Drawing.Point(3, 520);
            this.gpTotal.Name = "gpTotal";
            this.gpTotal.Size = new System.Drawing.Size(1057, 148);
            this.gpTotal.TabIndex = 2;
            this.gpTotal.TabStop = false;
            this.gpTotal.Text = "Total";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.lbl1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalFactura, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalProductos, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalCoste, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTotalBImponible, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1051, 123);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(9, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(131, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Total de factura:";
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.Location = new System.Drawing.Point(153, 15);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(14, 15);
            this.lblTotalFactura.TabIndex = 1;
            this.lblTotalFactura.Text = "-";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(23, 30);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(103, 15);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Cantidad de productos:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total en coste :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Base Imponible:";
            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Location = new System.Drawing.Point(153, 30);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(14, 15);
            this.lblTotalProductos.TabIndex = 5;
            this.lblTotalProductos.Text = "-";
            // 
            // lblTotalCoste
            // 
            this.lblTotalCoste.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalCoste.AutoSize = true;
            this.lblTotalCoste.Location = new System.Drawing.Point(153, 45);
            this.lblTotalCoste.Name = "lblTotalCoste";
            this.lblTotalCoste.Size = new System.Drawing.Size(14, 15);
            this.lblTotalCoste.TabIndex = 6;
            this.lblTotalCoste.Text = "-";
            // 
            // lblTotalBImponible
            // 
            this.lblTotalBImponible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalBImponible.AutoSize = true;
            this.lblTotalBImponible.Location = new System.Drawing.Point(153, 60);
            this.lblTotalBImponible.Name = "lblTotalBImponible";
            this.lblTotalBImponible.Size = new System.Drawing.Size(14, 15);
            this.lblTotalBImponible.TabIndex = 7;
            this.lblTotalBImponible.Text = "-";
            // 
            // bsDesglose
            // 
            this.bsDesglose.AllowNew = true;
            this.bsDesglose.DataMember = "FacturaDesglose";
            this.bsDesglose.DataSource = this.dsGimnasio1;
            // 
            // FFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1063, 671);
            this.Controls.Add(this.tlpVentana);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FFactura";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.FFactura_Load);
            this.tlpVentana.ResumeLayout(false);
            this.gbCabecera.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnvio)).EndInit();
            this.gbDesgloses.ResumeLayout(false);
            this.tlpDesgloses.ResumeLayout(false);
            this.tlpDatosDesglose.ResumeLayout(false);
            this.tlpDatosDesglose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).EndInit();
            this.tlpVistaDesglose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesglose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVDesglose)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gpTotal.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDesglose)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgDesgloses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbClientes.SelectedIndex != -1)
            {
                var clienteSeleccionado = cmbClientes.SelectedValue;
                Console.WriteLine("Cliente seleccionado: " + clienteSeleccionado);
            }
        }

        private void bsVDesglose_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si hay un producto seleccionado
            if (cmbProductos.SelectedIndex != -1)
            {
                // Lógica para manejar el producto seleccionado.
                // Ejemplo: obtener el valor seleccionado y hacer algo con él.

                var productoSeleccionado = cmbProductos.SelectedValue;

                

                // O si tienes más detalles, los puedes cargar de alguna manera.
                Console.WriteLine("Producto seleccionado: " + productoSeleccionado);
            }
        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpVentana;
        private System.Windows.Forms.GroupBox gbCabecera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbDesgloses;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbClientes;
        private CAD.DSGimnasio dsGimnasio1;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.BindingSource bsProductos;
        private System.Windows.Forms.BindingSource bsFacturas;
        private System.Windows.Forms.BindingSource bsDesglose;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblFechaEnvio;
        private System.Windows.Forms.DateTimePicker dtpEnvio;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblEstadoFactura;
        private System.Windows.Forms.BindingSource bsEstadoFactura;
        private System.Windows.Forms.BindingSource bsTipoPago;
        private System.Windows.Forms.BindingSource bsEnvio;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.ComboBox cbEstadoFactura;
        private System.Windows.Forms.ComboBox cbEnvio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TableLayoutPanel tlpDesgloses;
        private System.Windows.Forms.TableLayoutPanel tlpDatosDesglose;
        private System.Windows.Forms.BindingSource bsVDesglose;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblCódigo;
        private System.Windows.Forms.Label lblBaseImponible;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtBImponible;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Button btnGuardarDesglose;
        private GroupBox gpTotal;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbl1;
        private Label lblTotalFactura;
        private Label lbl2;
        private Label label1;
        private Label label2;
        private Label lblTotalProductos;
        private Label lblTotalCoste;
        private Label lblTotalBImponible;
        private Button btnEliminarDesglose;
        private Button btnEditarDesglose;
        private DataGridView dgvDesglose;
        private TableLayoutPanel tlpVistaDesglose;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idFacturaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn preciocompraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn baseImponibleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoIVADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pVPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnGenerar;
    }
}