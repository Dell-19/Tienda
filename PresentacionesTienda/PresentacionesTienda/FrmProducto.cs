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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
        void Actualizar()
        {
            mp.Mostrar(dtgProductos, textBox1.Text);
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (col)
            {
                case 4: {
                FrmProductosAdd pd = new FrmProductosAdd();
                pd.ShowDialog();
                textBox1.Text = "";
                Actualizar();
            }
            break;
                case 5: {
                mp.Borrar(p);
                textBox1.Text = "";
                Actualizar();
            }
            break;
        }
    }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            col = e.ColumnIndex;
            p.IdProducto = int.Parse(dtgProductos.Rows[fila].Cells[0].Value.ToString());
            p.Nombre = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            p.Descripcion = dtgProductos.Rows[fila].Cells[2].Value.ToString();
            p.Precio = dtgProductos.Rows[fila].Cells[3].Value.ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            p.IdProducto = -1;
            FrmProductosAdd pd = new FrmProductosAdd();
            pd.ShowDialog();
        }
    }
}
