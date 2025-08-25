using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        public Image ByteToImgage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] milogo = new CN_Negocio().ObtenerLogo(out obtenido);
            if (obtenido)
                piclogo.Image = ByteToImgage(milogo);
            Negocio datos = new CN_Negocio().ObtenerDatos();

            txtnombre.Text = datos.Nombre;
            txtruc.Text = datos.RUC;
            txtdireccion.Text = datos.Direccion;
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog op = new OpenFileDialog();
            op.FileName = "Files|;*.png;*.jpg;";

            if (op.ShowDialog() == DialogResult.OK)
            {
                byte[] milogo = File.ReadAllBytes(op.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(milogo, out mensaje);
                if (respuesta)
                {
                    piclogo.Image = ByteToImgage(milogo);
                }
                else
                    MessageBox.Show(mensaje, "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
