namespace CapaPresentacion
{
    partial class frmCategoria
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
            txtindice = new TextBox();
            txtid = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            txt = new Label();
            btneliminar = new FontAwesome.Sharp.IconButton();
            txtdescripcion = new TextBox();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            cboestado = new ComboBox();
            dgvdata = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            IdCategoria = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label11 = new Label();
            btnbusqueda = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt);
            panel2.Controls.Add(txtindice);
            panel2.Controls.Add(txtid);
            panel2.Controls.Add(btneliminar);
            panel2.Controls.Add(txtdescripcion);
            panel2.Controls.Add(btnlimpiar);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cboestado);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 590);
            panel2.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Verdana", 15F);
            label2.Location = new Point(35, 8);
            label2.Name = "label2";
            label2.Size = new Size(218, 25);
            label2.TabIndex = 18;
            label2.Text = "Detalle de Categoria";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.BackColor = Color.White;
            txt.Font = new Font("Arial", 12F);
            txt.Location = new Point(35, 54);
            txt.Name = "txt";
            txt.Size = new Size(92, 18);
            txt.TabIndex = 1;
            txt.Text = "Descripcion";
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
            btneliminar.Location = new Point(35, 273);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(212, 34);
            btneliminar.TabIndex = 17;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(35, 76);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(212, 23);
            txtdescripcion.TabIndex = 6;
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
            btnlimpiar.Location = new Point(35, 228);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(212, 34);
            btnlimpiar.TabIndex = 16;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
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
            btnguardar.Location = new Point(35, 183);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(212, 34);
            btnguardar.TabIndex = 15;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(35, 119);
            label8.Name = "label8";
            label8.Size = new Size(58, 18);
            label8.TabIndex = 14;
            label8.Text = "Estado";
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.Font = new Font("Segoe UI", 12F);
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(35, 141);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(212, 29);
            cboestado.TabIndex = 12;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, IdCategoria, Descripcion, EstadoValor, Estado });
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
            btnseleccionar.FillWeight = 20F;
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            // 
            // IdCategoria
            // 
            IdCategoria.HeaderText = "IdCategoria";
            IdCategoria.Name = "IdCategoria";
            IdCategoria.ReadOnly = true;
            IdCategoria.Visible = false;
            // 
            // Descripcion
            // 
            Descripcion.FillWeight = 120F;
            Descripcion.HeaderText = "Descripción";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
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
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(btnbusqueda);
            panel3.Controls.Add(btnlimpiarbuscador);
            panel3.Controls.Add(cbobusqueda);
            panel3.Controls.Add(txtbusqueda);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(305, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(761, 64);
            panel3.TabIndex = 33;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Segoe UI", 17F);
            label11.Location = new Point(2, 12);
            label11.Name = "label11";
            label11.Size = new Size(231, 36);
            label11.TabIndex = 20;
            label11.Text = "   Lista de Categorias";
            label11.TextAlign = ContentAlignment.MiddleLeft;
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(288, 23);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 23;
            label1.Text = "Buscar por:";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1091, 590);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dgvdata);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtindice;
        private TextBox txtid;
        private Panel panel2;
        private Label label2;
        private Label txt;
        private FontAwesome.Sharp.IconButton btneliminar;
        private TextBox txtdescripcion;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private Label label8;
        private ComboBox cboestado;
        private DataGridView dgvdata;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private Label label1;
        private Label label11;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn IdCategoria;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn Estado;
    }
}