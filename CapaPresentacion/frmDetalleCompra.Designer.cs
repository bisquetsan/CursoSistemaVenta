namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            groupBox2 = new GroupBox();
            txtnumerodoc = new TextBox();
            txtidproveedor = new TextBox();
            txtrazonsocial = new TextBox();
            txtnumerodocproveedor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtusuario = new TextBox();
            label1 = new Label();
            txttipodocumeto = new TextBox();
            txtfecha = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            cbobuscarcompras = new ComboBox();
            btnpdf = new FontAwesome.Sharp.IconButton();
            label10 = new Label();
            txtmontototal = new TextBox();
            dgvdata = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnbuscar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            label11 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtnumerodoc);
            groupBox2.Controls.Add(txtidproveedor);
            groupBox2.Controls.Add(txtrazonsocial);
            groupBox2.Controls.Add(txtnumerodocproveedor);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(24, 189);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(842, 95);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información Proveedor";
            // 
            // txtnumerodoc
            // 
            txtnumerodoc.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtnumerodoc.Font = new Font("Segoe UI", 10F);
            txtnumerodoc.Location = new Point(739, 56);
            txtnumerodoc.Name = "txtnumerodoc";
            txtnumerodoc.Size = new Size(84, 25);
            txtnumerodoc.TabIndex = 37;
            txtnumerodoc.Visible = false;
            // 
            // txtidproveedor
            // 
            txtidproveedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtidproveedor.Font = new Font("Segoe UI", 10F);
            txtidproveedor.Location = new Point(1137, 25);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(31, 25);
            txtidproveedor.TabIndex = 35;
            txtidproveedor.Visible = false;
            // 
            // txtrazonsocial
            // 
            txtrazonsocial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtrazonsocial.BackColor = SystemColors.Control;
            txtrazonsocial.Font = new Font("Segoe UI", 10F);
            txtrazonsocial.Location = new Point(248, 56);
            txtrazonsocial.Name = "txtrazonsocial";
            txtrazonsocial.ReadOnly = true;
            txtrazonsocial.Size = new Size(295, 25);
            txtrazonsocial.TabIndex = 27;
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
            label4.Location = new Point(245, 34);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 1;
            label4.Text = "Razón Social";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 34);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 0;
            label5.Text = "Número Documento";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtusuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txttipodocumeto);
            groupBox1.Controls.Add(txtfecha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 86);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(842, 95);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información Compra";
            // 
            // txtusuario
            // 
            txtusuario.BackColor = SystemColors.Control;
            txtusuario.Font = new Font("Segoe UI", 10F);
            txtusuario.Location = new Point(612, 57);
            txtusuario.Name = "txtusuario";
            txtusuario.ReadOnly = true;
            txtusuario.Size = new Size(223, 25);
            txtusuario.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(609, 35);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 28;
            label1.Text = "Usuario:";
            // 
            // txttipodocumeto
            // 
            txttipodocumeto.BackColor = SystemColors.Control;
            txttipodocumeto.Font = new Font("Segoe UI", 10F);
            txttipodocumeto.Location = new Point(248, 56);
            txttipodocumeto.Name = "txttipodocumeto";
            txttipodocumeto.ReadOnly = true;
            txttipodocumeto.Size = new Size(295, 25);
            txttipodocumeto.TabIndex = 27;
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
            label3.Location = new Point(244, 34);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 1;
            label3.Text = "Tipo documento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 34);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 0;
            label2.Text = "Fecha:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnpdf);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtmontototal);
            panel1.Controls.Add(dgvdata);
            panel1.Controls.Add(btnbuscar);
            panel1.Controls.Add(btnlimpiar);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(cbobuscarcompras);
            panel1.Location = new Point(140, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 619);
            panel1.TabIndex = 5;
            // 
            // cbobuscarcompras
            // 
            cbobuscarcompras.Font = new Font("Segoe UI", 11F);
            cbobuscarcompras.FormattingEnabled = true;
            cbobuscarcompras.Location = new Point(433, 45);
            cbobuscarcompras.Name = "cbobuscarcompras";
            cbobuscarcompras.Size = new Size(183, 28);
            cbobuscarcompras.TabIndex = 42;
            // 
            // btnpdf
            // 
            btnpdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnpdf.BackColor = SystemColors.ControlLight;
            btnpdf.FlatAppearance.BorderColor = Color.Black;
            btnpdf.FlatStyle = FlatStyle.Popup;
            btnpdf.Font = new Font("Segoe UI", 10F);
            btnpdf.ForeColor = SystemColors.ControlText;
            btnpdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            btnpdf.IconColor = Color.Black;
            btnpdf.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnpdf.IconSize = 24;
            btnpdf.Location = new Point(678, 559);
            btnpdf.Name = "btnpdf";
            btnpdf.Size = new Size(188, 30);
            btnpdf.TabIndex = 41;
            btnpdf.Text = "Descargar en PDF";
            btnpdf.TextAlign = ContentAlignment.MiddleRight;
            btnpdf.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnpdf.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 11.25F);
            label10.Location = new Point(24, 564);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 40;
            label10.Text = "Monto Total:";
            // 
            // txtmontototal
            // 
            txtmontototal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtmontototal.BackColor = SystemColors.Control;
            txtmontototal.Font = new Font("Segoe UI", 10F);
            txtmontototal.Location = new Point(105, 562);
            txtmontototal.Name = "txtmontototal";
            txtmontototal.ReadOnly = true;
            txtmontototal.Size = new Size(119, 25);
            txtmontototal.TabIndex = 39;
            txtmontototal.Text = "0";
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Nombre, PrecioCompra, Stock, Subtotal });
            dgvdata.Location = new Point(24, 291);
            dgvdata.Margin = new Padding(100);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.Size = new Size(842, 259);
            dgvdata.TabIndex = 38;
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
            // Stock
            // 
            Stock.HeaderText = "Cantidad";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.FillWeight = 80F;
            Subtotal.HeaderText = "Sub Total";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            // 
            // btnbuscar
            // 
            btnbuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnbuscar.BackColor = SystemColors.ControlLight;
            btnbuscar.FlatAppearance.BorderColor = Color.Black;
            btnbuscar.FlatStyle = FlatStyle.Popup;
            btnbuscar.Font = new Font("Segoe UI", 11F);
            btnbuscar.ForeColor = SystemColors.ControlText;
            btnbuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnbuscar.IconColor = Color.Black;
            btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnbuscar.IconSize = 24;
            btnbuscar.Location = new Point(622, 46);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(119, 27);
            btnbuscar.TabIndex = 37;
            btnbuscar.Text = "Buscar";
            btnbuscar.TextAlign = ContentAlignment.MiddleRight;
            btnbuscar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnbuscar.UseVisualStyleBackColor = false;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlimpiar.BackColor = SystemColors.ControlLight;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Popup;
            btnlimpiar.Font = new Font("Segoe UI", 11F);
            btnlimpiar.ForeColor = SystemColors.ControlText;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.IconSize = 24;
            btnlimpiar.Location = new Point(747, 46);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(119, 27);
            btnlimpiar.TabIndex = 36;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 11.25F);
            label6.Location = new Point(311, 49);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 34;
            label6.Text = "Número de Factura:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 18F);
            label11.Location = new Point(24, 10);
            label11.Name = "label11";
            label11.Size = new Size(234, 29);
            label11.TabIndex = 33;
            label11.Text = "Detalle de Compra";
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 668);
            Controls.Add(panel1);
            Name = "frmDetalleCompra";
            Text = "frmDetalleCompra";
            Load += frmDetalleCompra_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox txtidproveedor;
        private TextBox txtrazonsocial;
        private TextBox txtnumerodocproveedor;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtusuario;
        private Label label1;
        private TextBox txttipodocumeto;
        private TextBox txtfecha;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label11;
        private Label label6;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnpdf;
        private Label label10;
        private TextBox txtmontototal;
        private TextBox txtnumerodoc;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Subtotal;
        private ComboBox cbobuscarcompras;
    }
}