using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;
using CapaEntidad;
using CapaNegocio;
using System.Windows.Controls;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 0;

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol rol in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = rol.IdRol, Texto = rol.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;


            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbobusqueda.DisplayMember = "Texto";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;

            List<Usuario> listausuarios = new CN_Usuario().Listar();
            foreach (Usuario user in listausuarios)
            {
                dgvdata.Rows.Add(new object[] {"",
                    user.IdUsuario,
                    user.Documento,
                    user.NombreCompleto,
                    user.Correo,
                    user.Clave,
                    user.oRol.IdRol,
                    user.oRol.Descripcion,
                    user.Estado == true ? 1:0,
                    user.Estado == true ? "Activo":"No Activo",
                });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            /*dgvdata.Rows.Add(new object[] {"",
                txtid.Text,
                txtdocumento.Text,
                txtnombrecompleto.Text,
                txtcorreo.Text,
                txtclave.Text,
                ((OpcionCombo)cborol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)cboestado.SelectedItem).Texto.ToString(),
            });
            Limpiar();*/
        }

        private void Limpiar()
        {
            txtid.Text = "0";
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfimarclave.Text = "";
            cboestado.SelectedIndex = 0;
            cborol.SelectedIndex = 0;
            txtindice.Text = "0";
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check_16.Width;
                var h = Properties.Resources.check_16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                txtindice.Text = (indice + 1).ToString();
                if (indice >= 0)
                {
                    txtid.Text = dgvdata.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtconfimarclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    cborol.SelectedIndex = Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value) - 1;
                    cboestado.SelectedIndex = Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value);
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
