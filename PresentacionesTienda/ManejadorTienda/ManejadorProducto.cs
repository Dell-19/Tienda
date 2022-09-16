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
    }
}
