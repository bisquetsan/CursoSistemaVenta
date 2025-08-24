namespace CapaPresentacion
{
    partial class frmProducto
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
            panel1 = new Panel();
            btnbusqueda = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtindice = new TextBox();
            txtid = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            txtprecioventa = new TextBox();
            txt = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btneliminar = new FontAwesome.Sharp.IconButton();
            txtcodigo = new TextBox();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            txtnombre = new TextBox();
            btnguardar = new FontAwesome.Sharp.IconButton();
            txtdescripcion = new TextBox();
            label8 = new Label();
            txtstock = new TextBox();
            label7 = new Label();
            txtpreciocompra = new TextBox();
            cboestado = new ComboBox();
            cbocategoria = new ComboBox();
            label2 = new Label();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnbusqueda);
            panel1.Controls.Add(btnlimpiarbuscador);
            panel1.Controls.Add(cbobusqueda);
            panel1.Controls.Add(txtbusqueda);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(305, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 64);
            panel1.TabIndex = 31;
            // 
            // btnbusqueda
            // 
            btnbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnbusqueda.BackColor = Color.ForestGreen;
            btnbusqueda.Cursor = Cursors.Hand;
            btnbusqueda.FlatAppearance.BorderColor = Color.Black;
            btnbusqueda.FlatStyle = FlatStyle.Flat;
            btnbusqueda.ForeColor = Color.White;
            btnbusqueda.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbusqueda.IconColor = Color.White;
            btnbusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbusqueda.IconSize = 20;
            btnbusqueda.Location = new Point(649, 19);
            btnbusqueda.Name = "btnbusqueda";
            btnbusqueda.Size = new Size(49, 25);
            btnbusqueda.TabIndex = 25;
            btnbusqueda.TextAlign = ContentAlignment.MiddleRight;
            btnbusqueda.UseVisualStyleBackColor = false;
            btnbusqueda.Click += btnbusqueda_Click;
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlimpiarbuscador.BackColor = Color.RoyalBlue;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.White;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.White;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 20;
            btnlimpiarbuscador.Location = new Point(704, 19);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(49, 25);
            btnlimpiarbuscador.TabIndex = 26;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // cbobusqueda
            // 
            cbobusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.Font = new Font("Segoe UI", 10F);
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(368, 19);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(133, 25);
            cbobusqueda.TabIndex = 22;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtbusqueda.Font = new Font("Segoe UI", 10F);
            txtbusqueda.Location = new Point(507, 19);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(136, 25);
            txtbusqueda.TabIndex = 24;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(288, 23);
            label10.Name = "label10";
            label10.Size = new Size(77, 19);
            label10.TabIndex = 23;
            label10.Text = "Buscar por:";
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 17F);
            label9.Location = new Point(0, 12);
            label9.Name = "label9";
            label9.Size = new Size(227, 36);
            label9.TabIndex = 20;
            label9.Text = "   Lista de Productos";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(179, 36);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(28, 23);
            txtindice.TabIndex = 27;
            txtindice.Text = "-1";
            txtindice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtid
            // 
            txtid.Location = new Point(212, 36);
            txtid.Name = "txtid";
            txtid.Size = new Size(31, 23);
            txtid.TabIndex = 21;
            txtid.Text = "0";
            txtid.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtprecioventa);
            panel2.Controls.Add(txt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btneliminar);
            panel2.Controls.Add(txtcodigo);
            panel2.Controls.Add(btnlimpiar);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(txtdescripcion);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtstock);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtpreciocompra);
            panel2.Controls.Add(cboestado);
            panel2.Controls.Add(cbocategoria);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtindice);
            panel2.Controls.Add(txtid);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 590);
            panel2.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(35, 304);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 45;
            label1.Text = "Precio de Venta";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(35, 324);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(212, 23);
            txtprecioventa.TabIndex = 46;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.BackColor = Color.White;
            txt.Font = new Font("Arial", 12F);
            txt.Location = new Point(35, 56);
            txt.Name = "txt";
            txt.Size = new Size(60, 18);
            txt.TabIndex = 28;
            txt.Text = "Código";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(35, 105);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 29;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(35, 155);
            label4.Name = "label4";
            label4.Size = new Size(92, 18);
            label4.TabIndex = 30;
            label4.Text = "Descripción";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(35, 205);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 31;
            label5.Text = "Cantidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(35, 255);
            label6.Name = "label6";
            label6.Size = new Size(137, 18);
            label6.TabIndex = 32;
            label6.Text = "Precio de Compra";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Firebrick;
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Segoe UI", 12F);
            btneliminar.ForeColor = Color.White;
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btneliminar.IconColor = Color.White;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminar.IconSize = 20;
            btneliminar.Location = new Point(35, 548);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(212, 34);
            btneliminar.TabIndex = 44;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(35, 76);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(212, 23);
            txtcodigo.TabIndex = 33;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.RoyalBlue;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.Font = new Font("Segoe UI", 12F);
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiar.IconColor = Color.White;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 20;
            btnlimpiar.Location = new Point(35, 508);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(212, 34);
            btnlimpiar.TabIndex = 43;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(35, 125);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(212, 23);
            txtnombre.TabIndex = 34;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.ForestGreen;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI", 12F);
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 20;
            btnguardar.Location = new Point(35, 468);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(212, 34);
            btnguardar.TabIndex = 42;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(35, 175);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(212, 23);
            txtdescripcion.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(35, 409);
            label8.Name = "label8";
            label8.Size = new Size(58, 18);
            label8.TabIndex = 41;
            label8.Text = "Estado";
            // 
            // txtstock
            // 
            txtstock.Location = new Point(35, 225);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(212, 23);
            txtstock.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(35, 354);
            label7.Name = "label7";
            label7.Size = new Size(78, 18);
            label7.TabIndex = 40;
            label7.Text = "Categoria";
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(35, 275);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(212, 23);
            txtpreciocompra.TabIndex = 37;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.Font = new Font("Segoe UI", 12F);
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(35, 431);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(212, 29);
            cboestado.TabIndex = 39;
            // 
            // cbocategoria
            // 
            cbocategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbocategoria.Font = new Font("Segoe UI", 12F);
            cbocategoria.FormattingEnabled = true;
            cbocategoria.Location = new Point(35, 376);
            cbocategoria.Name = "cbocategoria";
            cbocategoria.Size = new Size(212, 29);
            cbocategoria.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Verdana", 15F);
            label2.Location = new Point(35, 8);
            label2.Name = "label2";
            label2.Size = new Size(219, 25);
            label2.TabIndex = 18;
            label2.Text = "Detalle de Productos";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdata.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Verdana", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, Id, Codigo, Nombre, Descripcion, IdCategoria, Categoria, PrecioCompra, PrecioVenta, Stock, EstadoValor, Estado });
            dgvdata.Location = new Point(305, 110);
            dgvdata.Margin = new Padding(100);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(761, 459);
            dgvdata.TabIndex = 30;
            dgvdata.CellClick += dgvdata_CellClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.FillWeight = 40F;
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Codigo
            // 
            Codigo.FillWeight = 120F;
            Codigo.HeaderText = "Código";
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.FillWeight = 120F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.Visible = false;
            // 
            // Categoria
            // 
            Categoria.FillWeight = 120F;
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            PrecioCompra.FillWeight = 130F;
            PrecioCompra.HeaderText = "Precio de Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.FillWeight = 130F;
            PrecioVenta.HeaderText = "Precio de Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.FillWeight = 70F;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1091, 590);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvdata);
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private Label label10;
        private Label label9;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn IdUsuario;
        private TextBox txtindice;
        private TextBox txtid;
        private Panel panel2;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox txtdescripcion;
        private TextBox txtstock;
        private TextBox txtpreciocompra;
        private DataGridView dgvdata;
        private Label txt;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btneliminar;
        private TextBox txtcodigo;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private TextBox txtnombre;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label8;
        private Label label7;
        private ComboBox cboestado;
        private ComboBox cbocategoria;
        private Label label1;
        private TextBox txtprecioventa;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}