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
    public partial class frmDetalleCompra : Form
    {
        public Usuario _Usuario { get; set; }
        public frmDetalleCompra(Usuario objusuario)
        {
            InitializeComponent();
            this._Usuario = objusuario;
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Compra compra = new CN_Compra().ObtenerCompra(cbobuscarcompras.Text);

            if (compra.IdCompra != 0)
            {
                txtnumerodoc.Text = compra.NumeroDocumento;

                txtfecha.Text = compra.FechaRegistro;
                txttipodocumeto.Text = compra.TipoDocumento;
                txtusuario.Text = compra.oUsuario.NombreCompleto;
                txtrazonsocial.Text = compra.oProveedor.RazonSocial;
                txtnumerodocproveedor.Text = compra.oProveedor.Documento;

                dgvdata.Rows.Clear();
                foreach (Detalle_Compra dc in compra.oDetalleCompra)
                {
                    dgvdata.Rows.Add(new object[]
                    {
                        dc.oProducto.Nombre,
                        dc.PrecioCompra,
                        dc.Cantidad,
                        dc.MontoTotal,
                    });
                }
                txtmontototal.Text = compra.MontoTotal.ToString("0.00");
            }

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnumerodoc.Text = "";
            cbobuscarcompras.Text = "";
            txtfecha.Text = "";
            txttipodocumeto.Text = "";
            txtusuario.Text = "";
            txtrazonsocial.Text = "";
            txtnumerodocproveedor.Text = "";
            txtmontototal.Text = "";
            dgvdata.Rows.Clear();
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            List<Compra> listaCompra = new CN_Compra().Listar();
            foreach (Compra item in listaCompra)
            {
                cbobuscarcompras.Items.Add(new OpcionCombo() { Valor = item.IdCompra, Texto = item.NumeroDocumento });
            }
            cbobuscarcompras.DisplayMember = "Texto";
            cbobuscarcompras.ValueMember = "Valor";
            cbobuscarcompras.SelectedIndex = 0;
            cbobuscarcompras.Text = "";
        }
    }
}
