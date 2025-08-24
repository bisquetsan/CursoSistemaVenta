using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cboestado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo" });
            cboestado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cboestado.DisplayMember = "Texto";
            cboestado.ValueMember = "Valor";
            cboestado.SelectedIndex = 1;

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

            List<Categoria> lista = new CN_Categoria().Listar();
            foreach (Categoria item in lista)
            {
                dgvdata.Rows.Add(new object[] {"",
                    item.IdCategoria,
                    item.Descripcion,
                    item.Estado == true ? 1:0,
                    item.Estado == true ? "Activo":"No Activo",
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Categoria objcategoria = new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtid.Text),
                Descripcion = txtdescripcion.Text,
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false,
            };

            if (objcategoria.IdCategoria == 0)
            {
                int idgenerado = new CN_Categoria().Registrar(objcategoria, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"",
                        idgenerado,
                        txtdescripcion.Text,
                        ((OpcionCombo)cboestado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cboestado.SelectedItem).Texto.ToString(),
                    });
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK);
                }
                Limpiar();
                return;
            }
            else
            {
                bool resultado = new CN_Categoria().Editar(objcategoria, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text) - 1];
                    row.Cells["IdCategoria"].Value = txtid.Text;
                    row.Cells["Descripcion"].Value = txtdescripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cboestado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cboestado.SelectedItem).Texto.ToString();
                }
                else
                {
                    mensaje = "Error al editar";
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK);
                }
            }
        }

        private void Limpiar()
        {
            txtid.Text = "0";
            txtdescripcion.Text = "";
            cboestado.SelectedIndex = 1;
            txtindice.Text = "-1";
        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
            if (e.ColumnIndex < 0) return;
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                txtindice.Text = (indice + 1).ToString();
                if (indice >= 0)
                {
                    txtid.Text = dgvdata.Rows[indice].Cells["IdCategoria"].Value.ToString();
                    txtdescripcion.Text = dgvdata.Rows[indice].Cells["Descripcion"].Value.ToString();
                    cboestado.SelectedIndex = Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value);
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (Convert.ToInt32(txtindice.Text) == -1)
            {
                mensaje = "Seleccione un usuario";
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK);
                return;
            }
            if (Convert.ToInt32(txtid.Text) == 0)
            {
                mensaje = "Seleccione un usuario";
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("¿Desea Eliminar la Categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                ==
                DialogResult.Yes)
            {
                Categoria objcategoria = new Categoria()
                {
                    IdCategoria = Convert.ToInt32(txtid.Text),
                };
                bool resultado = new CN_Categoria().Eliminar(objcategoria, out mensaje);

                if (resultado)
                {
                    dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text) - 1);
                    Limpiar();
                }
                else
                {
                    mensaje = "Error al Eliminar";
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void btnbusqueda_Click(object sender, EventArgs e)
        {
            string columnafiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnafiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                        row.Visible = false;
                }
            }

        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
