using SysInventarioBack.AccesoADatos;
using SysInventarioBack2.AccesoADatos;
using SysInventarioBack2.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysInventarioBack2.LogicaDeNegocio
{
    public class ProductoBL
    {
        public ProductoDAL ObjProductoBL = new ProductoDAL();
        public int AgregarProducto(List<Producto> ListaProducto, Producto pProducto)
        {
            return ObjProductoBL.AgregarProducto(ListaProducto, pProducto);
        }

        public List<Producto> MostrarProducto(List<Producto> ListaProducto)
        {
            return ObjProductoBL.MostrarProducto(ListaProducto);

        }

        public int ModificarProducto(List<Producto> ListaProducto, int Id, Producto pProducto)
        {
            return ObjProductoBL.ModificarProducto(ListaProducto, Id, pProducto);

        }

        public int EliminarProducto(List<Producto> ListaProducto, int Id, Producto pProducto)
        {
            return ObjProductoBL.EliminarProducto(ListaProducto, Id, pProducto);

        }

    }
}