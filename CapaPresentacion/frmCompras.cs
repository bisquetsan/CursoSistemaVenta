using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
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
    public partial class frmCompras : Form
    {

        private Usuario objusuario;
        public frmCompras(Usuario objusuario)
        {
            InitializeComponent();
            this.objusuario = objusuario;
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = 0, Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;


            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtidproducto.Text = "-1";
            txtidproveedor.Text = "0";
        }

        private void btnbusquedaproveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtnumerodocproveedor.Text = modal._Proveedor.Documento.ToString();
                    txtrazonsocial.Text = modal._Proveedor.RazonSocial.ToString();
                }
                else
                {
                    txtnumerodocproveedor.Select();
                }
            }
        }

        private void btnbusquedaproducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtidproducto.Text = modal._Producto.IdProducto.ToString();
                    txtcodigoproducto.Text = modal._Producto.Codigo;
                    txtnombreproducto.Text = modal._Producto.Nombre;
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodigoproducto.Select();
                }
            }
        }

        private void txtcodigoproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtcodigoproducto.Text && p.Estado == true).FirstOrDefault();
                if (oProducto != null)
                {
                    txtcodigoproducto.BackColor = Color.Honeydew;
                    txtidproducto.Text = oProducto.IdProducto.ToString();
                    txtnombreproducto.Text = oProducto.Nombre.ToString();
                    txtpreciocompra.Select();
                }
                else
                {
                    txtcodigoproducto.BackColor = Color.MistyRose;
                    txtidproducto.Text = "-1";
                    txtnombreproducto.Text = "";
                }
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            decimal precioC = 0;
            decimal precioV = 0;
            txtpreciocompra.BackColor = Color.White;
            txtprecioventa.BackColor = Color.White;

            if (int.Parse(txtidproducto.Text) == -1)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(txtpreciocompra.Text, out precioC))
            {
                MessageBox.Show("Formato incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtpreciocompra.Select();
                txtpreciocompra.BackColor = Color.MistyRose;
                return;
            }
            if (!decimal.TryParse(txtprecioventa.Text, out precioV))
            {
                MessageBox.Show("Formato incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtprecioventa.Select();
                txtprecioventa.BackColor = Color.MistyRose;
                return;
            }
            foreach (DataGridViewRow item in dgvdata.Rows)
            {
                if (item.Cells["Id"].Value.ToString() == txtidproducto.Text)
                {
                    return;
                }
            }

            dgvdata.Rows.Add(new object[]
            {
                txtidproducto.Text,
                txtnombreproducto.Text,
                precioC.ToString("0.00"),
                precioV.ToString("0.00"),
                numericstock.Value.ToString(),
                (numericstock.Value * precioC).ToString("0.00"),
            });

            LimpiarProducto();
            CalcularTotal();
            txtcodigoproducto.Select();
        }

        private void LimpiarProducto()
        {
            txtidproducto.Text = "";
            txtcodigoproducto.Text = "";
            txtcodigoproducto.BackColor = Color.White;
            txtnombreproducto.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            numericstock.Value = 0;
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dgvdata.Rows)
                {
                    total += Convert.ToDecimal(item.Cells["Subtotal"].Value.ToString());
                }
            }
            txttotalapagar.Text = total.ToString("0.00");
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = 25;
                var h = 25;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.icons8_waste_96px_1, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
