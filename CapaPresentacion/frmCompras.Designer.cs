namespace CapaPresentacion
{
    partial class frmCompras
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cbotipodocumento = new ComboBox();
            txtfecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtidproveedor = new TextBox();
            txtrazonsocial = new TextBox();
            btnbusquedaproveedor = new FontAwesome.Sharp.IconButton();
            txtnumerodocproveedor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            txtidproducto = new TextBox();
            txtprecioventa = new TextBox();
            label9 = new Label();
            numericstock = new NumericUpDown();
            label8 = new Label();
            txtpreciocompra = new TextBox();
            label7 = new Label();
            txtnombreproducto = new TextBox();
            btnbusquedaproducto = new FontAwesome.Sharp.IconButton();
            txtcodigoproducto = new TextBox();
            label1 = new Label();
            label6 = new Label();
            btnagregar = new FontAwesome.Sharp.IconButton();
            btnregistrar = new FontAwesome.Sharp.IconButton();
            txttotalapagar = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btneliminar = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericstock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cbotipodocumento);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 65);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(456, 95);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Compra";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbotipodocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipodocumento.Font = new Font("Segoe UI", 10F);
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(196, 56);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(253, 25);
            cbotipodocumento.TabIndex = 25;
            // 
            // txtfecha
            // 
            txtfecha.BackColor = SystemColors.Control;
            txtfecha.Font = new Font("Segoe UI", 10F);
            txtfecha.Location = new Point(7, 56);
            txtfecha.Name = "txtfecha";
            txtfecha.ReadOnly = true;
            txtfecha.Size = new Size(183, 25);
            txtfecha.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 33);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 1;
            label3.Text = "Tipo documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 33);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(txtrazonsocial);
            groupBox2.Controls.Add(btnbusquedaproveedor);
            groupBox2.Controls.Add(txtnumerodocproveedor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(489, 65);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(539, 95);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Proveedor";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtidproveedor.Font = new Font("Segoe UI", 10F);
            txtidproveedor.Location = new Point(496, 24);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(31, 25);
            txtidproveedor.TabIndex = 35;
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtrazonsocial.BackColor = SystemColors.Control;
            txtrazonsocial.Font = new Font("Segoe UI", 10F);
            txtrazonsocial.Location = new Point(247, 55);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.ReadOnly = true;
            txtrazonsocial.Size = new Size(280, 25);
            txtrazonsocial.TabIndex = 27;
            // 
            // btnbusquedaproveedor
            // 
            btnbusquedaproveedor.BackColor = SystemColors.ControlLight;
            btnbusquedaproveedor.Cursor = Cursors.Hand;
            btnbusquedaproveedor.FlatAppearance.BorderColor = Color.Black;
            btnbusquedaproveedor.FlatStyle = FlatStyle.Popup;
            btnbusquedaproveedor.ForeColor = Color.White;
            btnbusquedaproveedor.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbusquedaproveedor.IconColor = Color.Black;
            btnbusquedaproveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbusquedaproveedor.IconSize = 20;
            btnbusquedaproveedor.Location = new Point(201, 56);
            btnbusquedaproveedor.Name = "btnbusquedaproveedor";
            btnbusquedaproveedor.Size = new Size(40, 25);
            btnbusquedaproveedor.TabIndex = 26;
            btnbusquedaproveedor.TextAlign = ContentAlignment.MiddleRight;
            btnbusquedaproveedor.UseVisualStyleBackColor = false;
            btnbusquedaproveedor.Click += btnbusquedaproveedor_Click;
            // 
            // txtnumerodocproveedor
            // 
            txtnumerodocproveedor.Font = new Font("Segoe UI", 10F);
            txtnumerodocproveedor.Location = new Point(7, 56);
            txtnumerodocproveedor.Name = "txtnumerodocproveedor";
            txtnumerodocproveedor.ReadOnly = true;
            txtnumerodocproveedor.Size = new Size(188, 25);
            txtnumerodocproveedor.TabIndex = 26;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(244, 33);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 1;
            label4.Text = "Razón Social";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 33);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 0;
            label5.Text = "Número Documento";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(txtidproducto);
            groupBox3.Controls.Add(txtprecioventa);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(numericstock);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtpreciocompra);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtnombreproducto);
            groupBox3.Controls.Add(btnbusquedaproducto);
            groupBox3.Controls.Add(txtcodigoproducto);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(25, 168);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(877, 95);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información Compra";
            // 
            // txtidproducto
            // 
            txtidproducto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtidproducto.Font = new Font("Segoe UI", 10F);
            txtidproducto.Location = new Point(182, 25);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(31, 25);
            txtidproducto.TabIndex = 36;
            // 
            // txtprecioventa
            // 
            txtprecioventa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtprecioventa.Font = new Font("Segoe UI", 10F);
            txtprecioventa.Location = new Point(630, 56);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(135, 25);
            txtprecioventa.TabIndex = 34;
            txtprecioventa.KeyPress += txtprecioventa_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(769, 32);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 33;
            label9.Text = "Cantidad:";
            // 
            // numericstock
            // 
            numericstock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericstock.Location = new Point(771, 56);
            numericstock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericstock.Name = "numericstock";
            numericstock.Size = new Size(99, 25);
            numericstock.TabIndex = 5;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(628, 32);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 31;
            label8.Text = "Precio Venta:";
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtpreciocompra.Font = new Font("Segoe UI", 10F);
            txtpreciocompra.Location = new Point(489, 56);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(135, 25);
            txtpreciocompra.TabIndex = 30;
            txtpreciocompra.KeyPress += txtpreciocompra_KeyPress;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(487, 34);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 29;
            label7.Text = "Precio Compra:";
            // 
            // txtnombreproducto
            // 
            txtnombreproducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtnombreproducto.BackColor = SystemColors.Control;
            txtnombreproducto.Font = new Font("Segoe UI", 10F);
            txtnombreproducto.Location = new Point(265, 56);
            txtnombreproducto.Name = "txtnombreproducto";
            txtnombreproducto.ReadOnly = true;
            txtnombreproducto.Size = new Size(218, 25);
            txtnombreproducto.TabIndex = 28;
            // 
            // btnbusquedaproducto
            // 
            btnbusquedaproducto.BackColor = SystemColors.ControlLight;
            btnbusquedaproducto.Cursor = Cursors.Hand;
            btnbusquedaproducto.FlatAppearance.BorderColor = Color.Black;
            btnbusquedaproducto.FlatStyle = FlatStyle.Popup;
            btnbusquedaproducto.ForeColor = Color.White;
            btnbusquedaproducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbusquedaproducto.IconColor = Color.Black;
            btnbusquedaproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbusquedaproducto.IconSize = 20;
            btnbusquedaproducto.Location = new Point(219, 56);
            btnbusquedaproducto.Name = "btnbusquedaproducto";
            btnbusquedaproducto.Size = new Size(40, 25);
            btnbusquedaproducto.TabIndex = 27;
            btnbusquedaproducto.TextAlign = ContentAlignment.MiddleRight;
            btnbusquedaproducto.UseVisualStyleBackColor = false;
            btnbusquedaproducto.Click += btnbusquedaproducto_Click;
            // 
            // txtcodigoproducto
            // 
            txtcodigoproducto.Font = new Font("Segoe UI", 10F);
            txtcodigoproducto.Location = new Point(7, 56);
            txtcodigoproducto.Name = "txtcodigoproducto";
            txtcodigoproducto.Size = new Size(206, 25);
            txtcodigoproducto.TabIndex = 26;
            txtcodigoproducto.KeyDown += txtcodigoproducto_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(262, 34);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Producto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(5, 34);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 0;
            label6.Text = "Código Producto:";
            // 
            // btnagregar
            // 
            btnagregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnagregar.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnagregar.IconColor = Color.Black;
            btnagregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnagregar.IconSize = 52;
            btnagregar.Location = new Point(909, 176);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(119, 87);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "Agregar";
            btnagregar.TextAlign = ContentAlignment.BottomCenter;
            btnagregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnregistrar
            // 
            btnregistrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnregistrar.ForeColor = SystemColors.ControlText;
            btnregistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnregistrar.IconColor = Color.DodgerBlue;
            btnregistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnregistrar.IconSize = 26;
            btnregistrar.Location = new Point(909, 511);
            btnregistrar.Name = "btnregistrar";
            btnregistrar.Size = new Size(119, 30);
            btnregistrar.TabIndex = 5;
            btnregistrar.Text = "Registrar";
            btnregistrar.TextAlign = ContentAlignment.MiddleRight;
            btnregistrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnregistrar.UseVisualStyleBackColor = true;
            // 
            // txttotalapagar
            // 
            txttotalapagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txttotalapagar.BackColor = SystemColors.Control;
            txttotalapagar.Font = new Font("Segoe UI", 10F);
            txttotalapagar.Location = new Point(909, 479);
            txttotalapagar.Name = "txttotalapagar";
            txttotalapagar.ReadOnly = true;
            txttotalapagar.Size = new Size(119, 25);
            txttotalapagar.TabIndex = 28;
            txttotalapagar.Text = "0";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(906, 456);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 30;
            label10.Text = "Total a Pagar:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(dgvdata);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txttotalapagar);
            panel1.Controls.Add(btnregistrar);
            panel1.Controls.Add(btnagregar);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(64, 20);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1060, 563);
            panel1.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 18F);
            label11.Location = new Point(25, 23);
            label11.Name = "label11";
            label11.Size = new Size(222, 29);
            label11.TabIndex = 32;
            label11.Text = "Registrar Compra";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, PrecioCompra, PrecioVenta, Stock, Subtotal, btneliminar });
            dgvdata.Location = new Point(25, 276);
            dgvdata.Margin = new Padding(100);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(877, 265);
            dgvdata.TabIndex = 31;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 150F;
            Nombre.HeaderText = "Producto";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio de Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio de Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Cantidad";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Sub Total";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // btneliminar
            // 
            btneliminar.FillWeight = 30F;
            btneliminar.HeaderText = "";
            btneliminar.Name = "btneliminar";
            btneliminar.ReadOnly = true;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1194, 611);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 11F);
            Margin = new Padding(4);
            Name = "frmCompras";
            Text = "frmCompras";
            Load += frmCompras_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericstock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbotipodocumento;
        private TextBox txtfecha;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtrazonsocial;
        private FontAwesome.Sharp.IconButton btnbusquedaproveedor;
        private TextBox txtnumerodocproveedor;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private TextBox txtprecioventa;
        private Label label9;
        private NumericUpDown numericstock;
        private Label label8;
        private TextBox txtpreciocompra;
        private Label label7;
        private TextBox txtnombreproducto;
        private FontAwesome.Sharp.IconButton btnbusquedaproducto;
        private TextBox txtcodigoproducto;
        private Label label1;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnagregar;
        private FontAwesome.Sharp.IconButton btnregistrar;
        private TextBox txttotalapagar;
        private Label label10;
        private Panel panel1;
        private DataGridView dgvdata;
        private Label label11;
        private TextBox txtidproveedor;
        private TextBox txtidproducto;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn btneliminar;
    }
}