using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using AccesoDatosTienda;
using System.Windows.Forms;
using System.Drawing;

namespace ManejadorTienda
{
    public class ManejadorProducto
    {
        AccesoProductos ap = new AccesoProductos();
        Grafico g = new Grafico();
        public void Guardar(dynamic Entidad)
        {
            ap.Guardar(Entidad);
            g.Mensaje("Datos Guardados", "!ATENCIONS", MessageBoxIcon.Information);
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource =
                ap.Mostrar(filtro).Tables["producto"];
            tabla.Columns.Insert(4, g.Boton(
                "Editar", Color.Pink));
            tabla.Columns.Insert(5, g.Boton(
                "Borrar", Color.Purple));
            tabla.Columns[0].Visible = false;
        }
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show(string.Format("Estas Seguro?: {0}", Entidad.Nombre), "Atencion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                ap.Borrar(Entidad);
        }
    }
}
