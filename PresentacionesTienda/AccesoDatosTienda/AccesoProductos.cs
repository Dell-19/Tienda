using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;

namespace AccesoDatosTienda
{
    public class AccesoProductos
    {
        Base b = new Base("localhost", "root", "", "tienda");

        public void Borrar(dynamic Entidad)
        {
            b.Comando(string.Format("call deleteproducto({0})", Entidad.IdProducto));
        }

        public void Guardar(dynamic Entidad)
        {
            b.Comando(string.Format("call insertarproducto('{0}','{1}','{2}',{3})",
                Entidad.Nombre, Entidad.Descripcion, Entidad.Precio, Entidad.IdProducto));
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener
                (string.Format("call showproducto('%{0}%')", filtro), "producto");
        }
    }
}
