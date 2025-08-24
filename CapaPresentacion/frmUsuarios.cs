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
using System.Windows.Controls;
using System.Windows.Forms;

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
            cboestado.SelectedIndex = 1;

            List<Rol> listaRol = new CN_Rol().Listar();
            foreach (Rol item in listaRol)
            {
                cborol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            cborol.DisplayMember = "Texto";
            cborol.ValueMember = "Valor";
            cborol.SelectedIndex = 1;


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

            List<Usuario> lista = new CN_Usuario().Listar();
            foreach (Usuario item in lista)
            {
                dgvdata.Rows.Add(new object[] {"",
                    item.IdUsuario,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Clave,
                    item.oRol.IdRol,
                    item.oRol.Descripcion,
                    item.Estado == true ? 1:0,
                    item.Estado == true ? "Activo":"No Activo",
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (txtclave.Text != txtconfimarclave.Text)
            {
                mensaje = "Las Contraseñas no Coinciden";
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK);
                return;
            }

            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                Documento = txtdocumento.Text,
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Clave = txtclave.Text,
                oRol = new Rol()
                {
                    IdRol = Convert.ToInt32(((OpcionCombo)cborol.SelectedItem).Valor),
                },
                Estado = Convert.ToInt32(((OpcionCombo)cboestado.SelectedItem).Valor) == 1 ? true : false,
            };

            if (objusuario.IdUsuario == 0)
            {
                int idgenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"",
                        idgenerado,
                        txtdocumento.Text,
                        txtnombrecompleto.Text,
                        txtcorreo.Text,
                        txtclave.Text,
                        ((OpcionCombo)cborol.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cborol.SelectedItem).Texto.ToString(),
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
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text) - 1];
                    row.Cells["IdUsuario"].Value = txtid.Text;
                    row.Cells["Documento"].Value = txtdocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtnombrecompleto.Text;
                    row.Cells["Correo"].Value = txtcorreo.Text;
                    row.Cells["Clave"].Value = txtclave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cborol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cborol.SelectedItem).Texto.ToString();
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
            txtdocumento.Text = "";
            txtnombrecompleto.Text = "";
            txtcorreo.Text = "";
            txtclave.Text = "";
            txtconfimarclave.Text = "";
            cboestado.SelectedIndex = 1;
            cborol.SelectedIndex = 1;
            txtindice.Text = "-1";
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
                    txtid.Text = dgvdata.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtdocumento.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtnombrecompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtcorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtconfimarclave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    foreach (OpcionCombo item in cborol.Items)
                    {
                        if (Convert.ToInt32(item.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cborol.Items.IndexOf(item);
                            cborol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionCombo item in cboestado.Items)
                    {
                        if (Convert.ToInt32(item.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = cboestado.Items.IndexOf(item);
                            cboestado.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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

            if (MessageBox.Show("¿Desea Eliminar el Usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                ==
                DialogResult.Yes)
            {
                Usuario objusuario = new Usuario()
                {
                    IdUsuario = Convert.ToInt32(txtid.Text),
                };
                bool resultado = new CN_Usuario().Eliminar(objusuario, out mensaje);

                if (resultado)
                {
                    dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text) - 1);
                    Limpiar();
                }
                else
                {
                    mensaje += "\nError al Eliminar";
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
