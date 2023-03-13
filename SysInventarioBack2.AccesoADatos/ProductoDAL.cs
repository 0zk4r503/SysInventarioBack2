using SysInventarioBack2.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysInventarioBack2.AccesoADatos
{
    public class ProductoDAL
    {
        public int AgregarProducto(List<Producto> ListaProducto, Producto pProducto)
        {
            ListaProducto.Add(pProducto);
            return 1;
        }

        public List<Producto> MostrarProducto(List<Producto> ListaProducto)
        {
            return ListaProducto;
        }

        public int ModificarProducto(List<Producto> ListaProducto, int id, Producto pProducto)

        {
            if (id != 0)
            {
                Producto ProductoBuscado = ListaProducto.Where(c => c.IdProducto == id).FirstOrDefault();

                if (ProductoBuscado != null)
                {
                    ProductoBuscado.IdProducto = pProducto.IdProducto;
                    ProductoBuscado.Codigo = pProducto.Codigo;
                    ProductoBuscado.Nombre = pProducto.Nombre;
                    ProductoBuscado.Descripcion = pProducto.Descripcion;
                    ProductoBuscado.Precio = pProducto.Precio;
                    ProductoBuscado.FechaV = pProducto.FechaV;
                    ProductoBuscado.Cantidad = pProducto.Cantidad;

                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        public int EliminarProducto(List<Producto> ListaProducto, int id, Producto pProducto)
        {
            if (id != 0)
            {
                Producto ProductoBuscado = ListaProducto.Where(c => c.IdProducto == id).FirstOrDefault();
                if (ProductoBuscado != null)
                {
                    ListaProducto.Remove(ProductoBuscado);
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            else
            {
                return 0;
            }
        }
    }
}