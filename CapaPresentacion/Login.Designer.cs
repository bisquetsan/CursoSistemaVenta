
namespace CapaPresentacion
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtdocumento = new TextBox();
            txtclave = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btn_ingresar = new FontAwesome.Sharp.IconButton();
            btn_cancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SteelBlue;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 237);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 165);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 1;
            label2.Text = "SISTEMA DE VENTA";
            label2.Click += label2_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.SteelBlue;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 119;
            iconPictureBox1.Location = new Point(61, 34);
            iconPictureBox1.Margin = new Padding(0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(119, 121);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(269, 48);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(233, 23);
            txtdocumento.TabIndex = 3;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(269, 108);
            txtclave.Name = "txtclave";
            txtclave.PasswordChar = '*';
            txtclave.Size = new Size(233, 23);
            txtclave.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 30);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 5;
            label3.Text = "Nro Documento";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 90);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            label4.Click += label4_Click;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.RoyalBlue;
            btn_ingresar.Cursor = Cursors.Hand;
            btn_ingresar.FlatAppearance.BorderColor = Color.Black;
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.ForeColor = Color.White;
            btn_ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btn_ingresar.IconColor = Color.White;
            btn_ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_ingresar.IconSize = 21;
            btn_ingresar.Location = new Point(269, 160);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(93, 29);
            btn_ingresar.TabIndex = 7;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.TextAlign = ContentAlignment.MiddleRight;
            btn_ingresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.Firebrick;
            btn_cancelar.Cursor = Cursors.Hand;
            btn_cancelar.FlatAppearance.BorderColor = Color.Black;
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.ForeColor = Color.White;
            btn_cancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            btn_cancelar.IconColor = Color.White;
            btn_cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_cancelar.IconSize = 21;
            btn_cancelar.Location = new Point(409, 160);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(93, 29);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.TextAlign = ContentAlignment.MiddleRight;
            btn_cancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 237);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_ingresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtclave);
            Controls.Add(txtdocumento);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtdocumento;
        private TextBox txtclave;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btn_ingresar;
        private FontAwesome.Sharp.IconButton btn_cancelar;
    }
}