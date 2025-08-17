namespace CapaPresentacion
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            txt = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtdocumento = new TextBox();
            txtnombrecompleto = new TextBox();
            txtclave = new TextBox();
            txtcorreo = new TextBox();
            txtconfimarclave = new TextBox();
            cborol = new ComboBox();
            cboestado = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btneditar = new FontAwesome.Sharp.IconButton();
            btneliminar = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnseleccionar = new DataGridViewButtonColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            NombreComleto = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Clave = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            EstadoValor = new DataGridViewTextBoxColumn();
            label9 = new Label();
            txtid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 534);
            label1.TabIndex = 0;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.BackColor = Color.White;
            txt.Font = new Font("Segoe UI", 9F);
            txt.Location = new Point(41, 65);
            txt.Name = "txt";
            txt.Size = new Size(93, 15);
            txt.TabIndex = 1;
            txt.Text = "Nro Documento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(41, 117);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre Comleto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(41, 168);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(41, 217);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(41, 269);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 5;
            label6.Text = "Confirmar Contraseña";
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(41, 83);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(194, 23);
            txtdocumento.TabIndex = 6;
            // 
            // txtnombrecompleto
            // 
            txtnombrecompleto.Location = new Point(41, 135);
            txtnombrecompleto.Name = "txtnombrecompleto";
            txtnombrecompleto.Size = new Size(194, 23);
            txtnombrecompleto.TabIndex = 7;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(41, 235);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(194, 23);
            txtclave.TabIndex = 9;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(41, 186);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(194, 23);
            txtcorreo.TabIndex = 8;
            // 
            // txtconfimarclave
            // 
            txtconfimarclave.Location = new Point(41, 287);
            txtconfimarclave.Name = "txtconfimarclave";
            txtconfimarclave.Size = new Size(194, 23);
            txtconfimarclave.TabIndex = 10;
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.FormattingEnabled = true;
            cborol.Location = new Point(41, 339);
            cborol.Name = "cborol";
            cborol.Size = new Size(194, 23);
            cborol.TabIndex = 11;
            // 
            // cboestado
            // 
            cboestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboestado.FormattingEnabled = true;
            cboestado.Location = new Point(41, 390);
            cboestado.Name = "cboestado";
            cboestado.Size = new Size(194, 23);
            cboestado.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(41, 321);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 13;
            label7.Text = "Rol";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(41, 372);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 14;
            label8.Text = "Estado";
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.ForestGreen;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 20;
            btnguardar.Location = new Point(41, 428);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(194, 26);
            btnguardar.TabIndex = 15;
            btnguardar.Text = "Guardar";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.RoyalBlue;
            btneditar.Cursor = Cursors.Hand;
            btneditar.FlatAppearance.BorderColor = Color.Black;
            btneditar.FlatStyle = FlatStyle.Flat;
            btneditar.ForeColor = Color.White;
            btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btneditar.IconColor = Color.White;
            btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneditar.IconSize = 20;
            btneditar.Location = new Point(41, 462);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(194, 26);
            btneditar.TabIndex = 16;
            btneditar.Text = "Editar";
            btneditar.TextAlign = ContentAlignment.MiddleRight;
            btneditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneditar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Firebrick;
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.ForeColor = Color.White;
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btneliminar.IconColor = Color.White;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminar.IconSize = 20;
            btneliminar.Location = new Point(41, 496);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(194, 26);
            btneliminar.TabIndex = 17;
            btneliminar.Text = "Eliminar";
            btneliminar.TextAlign = ContentAlignment.MiddleRight;
            btneliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneliminar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(41, 20);
            label2.Name = "label2";
            label2.Size = new Size(172, 28);
            label2.TabIndex = 18;
            label2.Text = "Detalle de Usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, IdUsuario, Documento, NombreComleto, Correo, Clave, IdRol, Rol, Estado, EstadoValor });
            dataGridView1.Location = new Point(305, 113);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(722, 405);
            dataGridView1.TabIndex = 19;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 30;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "IdUsuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            // 
            // Documento
            // 
            Documento.HeaderText = "Nro Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            Documento.Width = 150;
            // 
            // NombreComleto
            // 
            NombreComleto.HeaderText = "Nombre Completo";
            NombreComleto.Name = "NombreComleto";
            NombreComleto.ReadOnly = true;
            NombreComleto.Width = 150;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 150;
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
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // EstadoValor
            // 
            EstadoValor.HeaderText = "EstadoValor";
            EstadoValor.Name = "EstadoValor";
            EstadoValor.ReadOnly = true;
            EstadoValor.Visible = false;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 17F);
            label9.Location = new Point(305, 51);
            label9.Name = "label9";
            label9.Size = new Size(722, 42);
            label9.TabIndex = 20;
            label9.Text = "Lista de Usuarios";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtid
            // 
            txtid.Location = new Point(208, 54);
            txtid.Name = "txtid";
            txtid.Size = new Size(27, 23);
            txtid.TabIndex = 21;
            txtid.Visible = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1192, 534);
            Controls.Add(txtid);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(btneliminar);
            Controls.Add(btneditar);
            Controls.Add(btnguardar);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cboestado);
            Controls.Add(cborol);
            Controls.Add(txtconfimarclave);
            Controls.Add(txtclave);
            Controls.Add(txtcorreo);
            Controls.Add(txtnombrecompleto);
            Controls.Add(txtdocumento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtdocumento;
        private TextBox txtnombrecompleto;
        private TextBox txtclave;
        private TextBox txtcorreo;
        private TextBox txtconfimarclave;
        private ComboBox cborol;
        private ComboBox cboestado;
        private Label label7;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label9;
        private DataGridViewButtonColumn btnseleccionar;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn NombreComleto;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Clave;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn EstadoValor;
        private TextBox txtid;
    }
}