namespace CapaPresentacion
{
    partial class frmNegocio
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
            label2 = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtdireccion = new TextBox();
            txtruc = new TextBox();
            txtnombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btnsubir = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            piclogo = new PictureBox();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Verdana", 15F);
            label2.Location = new Point(42, 28);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 18;
            label2.Text = "Detalle Negocio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(571, 590);
            panel2.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(txtruc);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnguardar);
            groupBox1.Controls.Add(btnsubir);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(piclogo);
            groupBox1.Location = new Point(27, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 370);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(251, 243);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(261, 23);
            txtdireccion.TabIndex = 8;
            // 
            // txtruc
            // 
            txtruc.Location = new Point(251, 157);
            txtruc.Name = "txtruc";
            txtruc.Size = new Size(261, 23);
            txtruc.TabIndex = 7;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(251, 71);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(261, 23);
            txtnombre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(251, 219);
            label5.Name = "label5";
            label5.Size = new Size(82, 18);
            label5.TabIndex = 5;
            label5.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(251, 133);
            label4.Name = "label4";
            label4.Size = new Size(62, 18);
            label4.TabIndex = 4;
            label4.Text = "R.U.C.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(251, 47);
            label3.Name = "label3";
            label3.Size = new Size(166, 18);
            label3.TabIndex = 3;
            label3.Text = "Nombre del Negocio:";
            // 
            // btnguardar
            // 
            btnguardar.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnguardar.IconColor = Color.Black;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.IconSize = 20;
            btnguardar.Location = new Point(251, 295);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(261, 29);
            btnguardar.TabIndex = 2;
            btnguardar.Text = "Guardar Cambios";
            btnguardar.TextAlign = ContentAlignment.MiddleRight;
            btnguardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnsubir
            // 
            btnsubir.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnsubir.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnsubir.IconColor = Color.Black;
            btnsubir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsubir.IconSize = 20;
            btnsubir.Location = new Point(15, 295);
            btnsubir.Name = "btnsubir";
            btnsubir.Size = new Size(206, 29);
            btnsubir.TabIndex = 2;
            btnsubir.Text = "Subir";
            btnsubir.TextAlign = ContentAlignment.MiddleRight;
            btnsubir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsubir.UseVisualStyleBackColor = true;
            btnsubir.Click += btnsubir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 1;
            label1.Text = "Logo:";
            // 
            // piclogo
            // 
            piclogo.BorderStyle = BorderStyle.FixedSingle;
            piclogo.Location = new Point(15, 46);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(206, 225);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1091, 590);
            Controls.Add(panel2);
            Name = "frmNegocio";
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Panel panel2;
        private GroupBox groupBox1;
        private PictureBox piclogo;
        private TextBox txtdireccion;
        private TextBox txtruc;
        private TextBox txtnombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnsubir;
    }
}