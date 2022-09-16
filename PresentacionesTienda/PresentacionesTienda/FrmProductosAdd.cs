using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesTienda;
using ManejadorTienda;

namespace PresentacionesTienda
{
    public partial class FrmProductosAdd : Form
    {
        ManejadorProducto mp;
        public FrmProductosAdd()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
            if (FrmProducto.p.IdProducto > 0)
            {
                txtNombre.Text = FrmProducto.p.Nombre.ToString();
                txtDescripcion.Text = FrmProducto.p.Descripcion.ToString();
                txtPrecio.Text = FrmProducto.p.Precio.ToString();
            }

        }

        private void btnn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Guardar(new Producto(FrmProducto.p.IdProducto, txtNombre.Text,txtDescripcion.Text, txtPrecio.Text));
            Close();
        }
    }
}
