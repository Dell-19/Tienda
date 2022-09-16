using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorTienda;
using EntidadesTienda;

namespace PresentacionesTienda
{
    public partial class FrmProducto : Form
    {
        ManejadorProducto mp;
        public static Producto p = new Producto(0, "", "", "");
        int fila = 0, col = 0;
        public FrmProducto()
        {
            InitializeComponent();
            mp = new ManejadorProducto();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p.IdProducto = -1;
            FrmProductosAdd pd = new FrmProductosAdd();
            pd.ShowDialog();
        }
    }
}
