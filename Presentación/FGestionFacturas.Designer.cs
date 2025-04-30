namespace Presentación
{
    partial class FGestionFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGestionFacturas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.lblAñadir = new System.Windows.Forms.Label();
            this.lblAbrirFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturasMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsVFacturas = new System.Windows.Forms.BindingSource(this.components);
            this.dsGimnasio1 = new CAD.DSGimnasio();
            this.bsFacturas = new System.Windows.Forms.BindingSource(this.components);
            this.bsClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bsTipoPago = new System.Windows.Forms.BindingSource(this.components);
            this.bsEstadoFactura = new System.Windows.Forms.BindingSource(this.components);
            this.bsEnvio = new System.Windows.Forms.BindingSource(this.components);
            this.bsProductos = new System.Windows.Forms.BindingSource(this.components);
            this.bsDesglose = new System.Windows.Forms.BindingSource(this.components);
            this.pagarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.facturasMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnvio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDesglose)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.contenedor, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 475);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.957814F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.03931F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.012464F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.300096F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.053691F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.779482F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.670182F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAbrir, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCrearFactura, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAñadir, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAbrirFactura, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1043, 51);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.txtBusqueda, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblBusqueda, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(242, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(130, 34);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.SystemColors.Window;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBusqueda.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(3, 20);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(124, 11);
            this.txtBusqueda.TabIndex = 8;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBusqueda.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(3, 0);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(124, 17);
            this.lblBusqueda.TabIndex = 7;
            this.lblBusqueda.Text = "Buscar cliente:";
            this.lblBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(159, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(77, 34);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrir.Image")));
            this.btnAbrir.Location = new System.Drawing.Point(107, 3);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(46, 34);
            this.btnAbrir.TabIndex = 12;
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearFactura.Image")));
            this.btnCrearFactura.Location = new System.Drawing.Point(3, 3);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(98, 34);
            this.btnCrearFactura.TabIndex = 10;
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            this.btnCrearFactura.Click += new System.EventHandler(this.btnCrearFactura_Click);
            // 
            // lblAñadir
            // 
            this.lblAñadir.AutoSize = true;
            this.lblAñadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAñadir.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñadir.Location = new System.Drawing.Point(3, 40);
            this.lblAñadir.Name = "lblAñadir";
            this.lblAñadir.Size = new System.Drawing.Size(98, 11);
            this.lblAñadir.TabIndex = 11;
            this.lblAñadir.Text = "AÑADIR";
            this.lblAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbrirFactura
            // 
            this.lblAbrirFactura.AutoSize = true;
            this.lblAbrirFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAbrirFactura.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbrirFactura.Location = new System.Drawing.Point(107, 40);
            this.lblAbrirFactura.Name = "lblAbrirFactura";
            this.lblAbrirFactura.Size = new System.Drawing.Size(46, 11);
            this.lblAbrirFactura.TabIndex = 13;
            this.lblAbrirFactura.Text = "ABRIR";
            this.lblAbrirFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 11);
            this.label1.TabIndex = 15;
            this.label1.Text = "ACTUALIZAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.contenedor.Controls.Add(this.dataGridView1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(3, 60);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1043, 412);
            this.contenedor.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.fechaVencimientoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.metodoEnvioDataGridViewTextBoxColumn,
            this.detalleEnvioDataGridViewTextBoxColumn,
            this.fechaEnvioDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.tipoPagoDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.facturasMenuStrip;
            this.dataGridView1.DataSource = this.bsVFacturas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuBar;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 412);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            this.dNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaEmisionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // fechaVencimientoDataGridViewTextBoxColumn
            // 
            this.fechaVencimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.HeaderText = "FechaVencimiento";
            this.fechaVencimientoDataGridViewTextBoxColumn.Name = "fechaVencimientoDataGridViewTextBoxColumn";
            this.fechaVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoEnvioDataGridViewTextBoxColumn
            // 
            this.metodoEnvioDataGridViewTextBoxColumn.DataPropertyName = "MetodoEnvio";
            this.metodoEnvioDataGridViewTextBoxColumn.HeaderText = "MetodoEnvio";
            this.metodoEnvioDataGridViewTextBoxColumn.Name = "metodoEnvioDataGridViewTextBoxColumn";
            this.metodoEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalleEnvioDataGridViewTextBoxColumn
            // 
            this.detalleEnvioDataGridViewTextBoxColumn.DataPropertyName = "DetalleEnvio";
            this.detalleEnvioDataGridViewTextBoxColumn.HeaderText = "DetalleEnvio";
            this.detalleEnvioDataGridViewTextBoxColumn.Name = "detalleEnvioDataGridViewTextBoxColumn";
            this.detalleEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEnvioDataGridViewTextBoxColumn
            // 
            this.fechaEnvioDataGridViewTextBoxColumn.DataPropertyName = "FechaEnvio";
            this.fechaEnvioDataGridViewTextBoxColumn.HeaderText = "FechaEnvio";
            this.fechaEnvioDataGridViewTextBoxColumn.Name = "fechaEnvioDataGridViewTextBoxColumn";
            this.fechaEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            this.fechaPagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoPagoDataGridViewTextBoxColumn
            // 
            this.tipoPagoDataGridViewTextBoxColumn.DataPropertyName = "TipoPago";
            this.tipoPagoDataGridViewTextBoxColumn.HeaderText = "TipoPago";
            this.tipoPagoDataGridViewTextBoxColumn.Name = "tipoPagoDataGridViewTextBoxColumn";
            this.tipoPagoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // facturasMenuStrip
            // 
            this.facturasMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirFacturaToolStripMenuItem,
            this.editarFacturaToolStripMenuItem,
            this.eliminarFacturaToolStripMenuItem,
            this.generarPDFToolStripMenuItem,
            this.pagarFacturaToolStripMenuItem});
            this.facturasMenuStrip.Name = "facturasMenuStrip";
            this.facturasMenuStrip.Size = new System.Drawing.Size(181, 136);
            // 
            // abrirFacturaToolStripMenuItem
            // 
            this.abrirFacturaToolStripMenuItem.Name = "abrirFacturaToolStripMenuItem";
            this.abrirFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirFacturaToolStripMenuItem.Text = "Abrir factura";
            this.abrirFacturaToolStripMenuItem.Click += new System.EventHandler(this.abrirFacturaToolStripMenuItem_Click);
            // 
            // editarFacturaToolStripMenuItem
            // 
            this.editarFacturaToolStripMenuItem.Name = "editarFacturaToolStripMenuItem";
            this.editarFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarFacturaToolStripMenuItem.Text = "Editar factura";
            this.editarFacturaToolStripMenuItem.Click += new System.EventHandler(this.editarFacturaToolStripMenuItem_Click);
            // 
            // eliminarFacturaToolStripMenuItem
            // 
            this.eliminarFacturaToolStripMenuItem.Name = "eliminarFacturaToolStripMenuItem";
            this.eliminarFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarFacturaToolStripMenuItem.Text = "Eliminar factura";
            this.eliminarFacturaToolStripMenuItem.Click += new System.EventHandler(this.eliminarFacturaToolStripMenuItem_Click);
            // 
            // generarPDFToolStripMenuItem
            // 
            this.generarPDFToolStripMenuItem.Name = "generarPDFToolStripMenuItem";
            this.generarPDFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarPDFToolStripMenuItem.Text = "Generar PDF";
            this.generarPDFToolStripMenuItem.Click += new System.EventHandler(this.generarPDFToolStripMenuItem_Click);
            // 
            // bsVFacturas
            // 
            this.bsVFacturas.DataMember = "VFacturas";
            this.bsVFacturas.DataSource = this.dsGimnasio1;
            // 
            // dsGimnasio1
            // 
            this.dsGimnasio1.DataSetName = "DSGimnasio";
            this.dsGimnasio1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsFacturas
            // 
            this.bsFacturas.DataMember = "Facturas";
            this.bsFacturas.DataSource = this.dsGimnasio1;
            // 
            // bsClientes
            // 
            this.bsClientes.DataMember = "Clientes";
            this.bsClientes.DataSource = this.dsGimnasio1;
            // 
            // bsTipoPago
            // 
            this.bsTipoPago.AllowNew = true;
            this.bsTipoPago.DataMember = "TipoPago";
            this.bsTipoPago.DataSource = this.dsGimnasio1;
            // 
            // bsEstadoFactura
            // 
            this.bsEstadoFactura.AllowNew = true;
            this.bsEstadoFactura.DataMember = "EstadoFactura";
            this.bsEstadoFactura.DataSource = this.dsGimnasio1;
            // 
            // bsEnvio
            // 
            this.bsEnvio.AllowNew = true;
            this.bsEnvio.DataMember = "Envio";
            this.bsEnvio.DataSource = this.dsGimnasio1;
            // 
            // bsProductos
            // 
            this.bsProductos.DataMember = "Productos";
            this.bsProductos.DataSource = this.dsGimnasio1;
            // 
            // bsDesglose
            // 
            this.bsDesglose.AllowNew = true;
            this.bsDesglose.DataMember = "FacturaDesglose";
            this.bsDesglose.DataSource = this.dsGimnasio1;
            // 
            // pagarFacturaToolStripMenuItem
            // 
            this.pagarFacturaToolStripMenuItem.Name = "pagarFacturaToolStripMenuItem";
            this.pagarFacturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagarFacturaToolStripMenuItem.Text = "Pagar factura";
            this.pagarFacturaToolStripMenuItem.Click += new System.EventHandler(this.pagarFacturaToolStripMenuItem_Click);
            // 
            // FGestionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FGestionFacturas";
            this.Text = "FGestionFacturas";
            this.Load += new System.EventHandler(this.FGestionFacturas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.facturasMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsVFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGimnasio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEstadoFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEnvio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDesglose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CAD.DSGimnasio dsGimnasio1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bsVFacturas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCrearFactura;
        public System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label lblAñadir;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblAbrirFactura;
        private System.Windows.Forms.BindingSource bsFacturas;
        private System.Windows.Forms.BindingSource bsClientes;
        private System.Windows.Forms.BindingSource bsTipoPago;
        private System.Windows.Forms.BindingSource bsEstadoFactura;
        private System.Windows.Forms.BindingSource bsEnvio;
        private System.Windows.Forms.BindingSource bsProductos;
        private System.Windows.Forms.BindingSource bsDesglose;
        private System.Windows.Forms.ContextMenuStrip facturasMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem abrirFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarPDFToolStripMenuItem;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.ToolStripMenuItem pagarFacturaToolStripMenuItem;
    }
}