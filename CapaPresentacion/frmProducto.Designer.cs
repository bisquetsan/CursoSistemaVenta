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
            Documento = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            txtindice = new TextBox();
            txtid = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            txt = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btneliminar = new FontAwesome.Sharp.IconButton();
            txtdocumento = new TextBox();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            txtnombrecompleto = new TextBox();
            btnguardar = new FontAwesome.Sharp.IconButton();
            txtcorreo = new TextBox();
            label8 = new Label();
            txtclave = new TextBox();
            label7 = new Label();
            txtconfimarclave = new TextBox();
            cboestado = new ComboBox();
            cborol = new ComboBox();
            btnseleccionar = new DataGridViewButtonColumn();
            dgvdata = new DataGridView();
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
            panel1.Location = new Point(366, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(761, 64);
            panel1.TabIndex = 31;
            // 
            // btnbusqueda
            // 
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
            // 
            // btnlimpiarbuscador
            // 
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
            // 
            // cbobusqueda
            // 
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
            txtbusqueda.Font = new Font("Segoe UI", 10F);
            txtbusqueda.Location = new Point(507, 19);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(136, 25);
            txtbusqueda.TabIndex = 24;
            // 
            // label10
            // 
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
            label9.Size = new Size(209, 36);
            label9.TabIndex = 20;
            label9.Text = "   Lista de Usuarios";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Documento
            // 
            Documento.FillWeight = 120F;
            Documento.HeaderText = "Nro Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            NombreCompleto.FillWeight = 120F;
            NombreCompleto.HeaderText = "Nombre Completo";
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Clave
            // 
            Clave.HeaderText = "Clave";
            Clave.Name = "Clave";
            Clave.ReadOnly = true;
            Clave.Visible = false;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(179, 36);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(28, 23);
            txtindice.TabIndex = 27;
            txtindice.Text = "-1";
            txtindice.TextAlign = HorizontalAlignment.Center;
            txtindice.Visible = false;
            // 
            // txtid
            // 
            txtid.Location = new Point(212, 36);
            txtid.Name = "txtid";
            txtid.Size = new Size(31, 23);
            txtid.TabIndex = 21;
            txtid.Text = "0";
            txtid.TextAlign = HorizontalAlignment.Center;
            txtid.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt);
            panel2.Controls.Add(txtindice);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtid);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btneliminar);
            panel2.Controls.Add(txtdocumento);
            panel2.Controls.Add(btnlimpiar);
            panel2.Controls.Add(txtnombrecompleto);
            panel2.Controls.Add(btnguardar);
            panel2.Controls.Add(txtcorreo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtclave);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtconfimarclave);
            panel2.Controls.Add(cboestado);
            panel2.Controls.Add(cborol);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(277, 602);
            panel2.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Verdana", 15F);
            label2.Location = new Point(35, 8);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 18;
            label2.Text = "Detalle de Usuario";
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.BackColor = Color.White;
            txt.Font = new Font("Arial", 12F);
            txt.Location = new Point(35, 54);
            txt.Name = "txt";
            txt.Size = new Size(117, 18);
            txt.TabIndex = 1;
            txt.Text = "Nro Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(35, 109);
            label3.Name = "label3";
            label3.Size = new Size(136, 18);
            label3.TabIndex = 2;
            label3.Text = "Nombre Completo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 12F);
            label4.Location = new Point(35, 164);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(35, 219);
            label5.Name = "label5";
            label5.Size = new Size(89, 18);
            label5.TabIndex = 4;
            label5.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(35, 274);
            label6.Name = "label6";
            label6.Size = new Size(162, 18);
            label6.TabIndex = 5;
            label6.Text = "Confirmar Contraseña";
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
            btneliminar.Location = new Point(35, 544);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(212, 34);
            btneliminar.TabIndex = 17;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(35, 76);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(212, 23);
            txtdocumento.TabIndex = 6;
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
            btnlimpiar.Location = new Point(35, 499);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(212, 34);
            btnlimpiar.TabIndex = 16;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(35, 131);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(212, 23);
            txtnombrecompleto.TabIndex = 7;
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
            btnguardar.Location = new Point(35, 454);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(212, 34);
            btnguardar.TabIndex = 15;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(35, 186);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(212, 23);
            txtcorreo.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(35, 390);
            label8.Name = "label8";
            label8.Size = new Size(58, 18);
            label8.TabIndex = 14;
            label8.Text = "Estado";
            // 
            // txtclave
            // 
            txtclave.Location = new Point(35, 241);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(212, 23);
            txtclave.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(35, 329);
            label7.Name = "label7";
            label7.Size = new Size(31, 18);
            label7.TabIndex = 13;
            label7.Text = "Rol";
            // 
            // txtconfimarclave
            // 
            txtconfimarclave.Location = new Point(35, 296);
            txtconfimarclave.Name = "txtconfimarclave";
            txtconfimarclave.PasswordChar = '*';
            txtconfimarclave.Size = new Size(212, 23);
            txtconfimarclave.TabIndex = 10;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.Font = new Font("Segoe UI", 12F);
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(35, 412);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(212, 29);
            cboestado.TabIndex = 12;
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.Font = new Font("Segoe UI", 12F);
            cborol.FormattingEnabled = true;
            cborol.Location = new Point(35, 351);
            cborol.Name = "cborol";
            cborol.Size = new Size(212, 29);
            cborol.TabIndex = 11;
            // 
            // btnseleccionar
            // 
            btnseleccionar.FillWeight = 30F;
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, IdUsuario, Documento, NombreCompleto, Correo, Clave, IdRol, Rol, EstadoValor, Estado });
            dgvdata.Location = new Point(366, 110);
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
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 602);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvdata);
            Name = "frmProducto";
            Text = "frmProducto";
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
        private DataGridViewTextBoxColumn EstadoValor;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Estado;
        private TextBox txtindice;
        private TextBox txtid;
        private Panel panel2;
        private Label label2;
        private Label txt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconButton btneliminar;
        private TextBox txtdocumento;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private TextBox txtnombrecompleto;
        private FontAwesome.Sharp.IconButton btnguardar;
        private TextBox txtcorreo;
        private Label label8;
        private TextBox txtclave;
        private Label label7;
        private TextBox txtconfimarclave;
        private ComboBox cboestado;
        private ComboBox cborol;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridView dgvdata;
    }
}