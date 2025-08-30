namespace CapaPresentacion.Modales
{
    partial class mdProveedor
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
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            RazonSocial = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnbusqueda = new FontAwesome.Sharp.IconButton();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            cbobusqueda = new ComboBox();
            txtbusqueda = new TextBox();
            label10 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Documento, RazonSocial });
            dgvdata.Location = new Point(12, 109);
            dgvdata.Margin = new Padding(100);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvdata.RowTemplate.Height = 28;
            dgvdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdata.Size = new Size(527, 236);
            dgvdata.TabIndex = 35;
            dgvdata.CellDoubleClick += dgvdata_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Documento
            // 
            Documento.FillWeight = 120F;
            Documento.HeaderText = "Nro Documento";
            Documento.Name = "Documento";
            Documento.ReadOnly = true;
            // 
            // RazonSocial
            // 
            RazonSocial.FillWeight = 120F;
            RazonSocial.HeaderText = "Razón Social";
            RazonSocial.Name = "RazonSocial";
            RazonSocial.ReadOnly = true;
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 87);
            panel1.TabIndex = 36;
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
            btnbusqueda.Location = new Point(400, 50);
            btnbusqueda.Name = "btnbusqueda";
            btnbusqueda.Size = new Size(49, 25);
            btnbusqueda.TabIndex = 25;
            btnbusqueda.TextAlign = ContentAlignment.MiddleRight;
            btnbusqueda.UseVisualStyleBackColor = false;
            btnbusqueda.Click += btnbusqueda_Click;
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
            btnlimpiarbuscador.Location = new Point(455, 50);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(49, 25);
            btnlimpiarbuscador.TabIndex = 26;
            btnlimpiarbuscador.TextAlign = ContentAlignment.MiddleRight;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // cbobusqueda
            // 
            cbobusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbobusqueda.Font = new Font("Segoe UI", 10F);
            cbobusqueda.FormattingEnabled = true;
            cbobusqueda.Location = new Point(119, 50);
            cbobusqueda.Name = "cbobusqueda";
            cbobusqueda.Size = new Size(133, 25);
            cbobusqueda.TabIndex = 22;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Font = new Font("Segoe UI", 10F);
            txtbusqueda.Location = new Point(258, 50);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(136, 25);
            txtbusqueda.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(39, 54);
            label10.Name = "label10";
            label10.Size = new Size(77, 19);
            label10.TabIndex = 23;
            label10.Text = "Buscar por:";
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI", 17F);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(244, 36);
            label9.TabIndex = 20;
            label9.Text = "Lista de Proveedores";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mdProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 356);
            Controls.Add(dgvdata);
            Controls.Add(panel1);
            Name = "mdProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mdProveedor";
            Load += mdProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvdata;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnbusqueda;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private ComboBox cbobusqueda;
        private TextBox txtbusqueda;
        private Label label10;
        private Label label9;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Documento;
        private DataGridViewTextBoxColumn RazonSocial;
    }
}