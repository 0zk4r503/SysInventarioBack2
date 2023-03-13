using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysInventarioBack2.EntidadesDeNegocio;

namespace SysInventarioBack.AccesoADatos
{
    public class CategoriaDAL
    {
        public int AgregarCategoria(List<Categoria> ListaCategoria, Categoria pCategoria)
        {
            ListaCategoria.Add(pCategoria);
            return 1;
        }

        public List<Categoria> MostrarCategoria(List<Categoria> ListaCategoria)
        {
            return ListaCategoria;
        }

        public int ModificarCategoria(List<Categoria> ListaCategoria, int id, Categoria pCategoria)

        {
            if (id != 0)
            {
                Categoria categoriaBuscada = ListaCategoria.Where(c => c.IdCategoria == id).FirstOrDefault();

                if (categoriaBuscada != null)
                {
                    categoriaBuscada.IdCategoria = pCategoria.IdCategoria;
                    categoriaBuscada.Nombre = pCategoria.Nombre;
                    categoriaBuscada.Descripcion = pCategoria.Descripcion;
                    categoriaBuscada.IMGURL = pCategoria.IMGURL;
                    categoriaBuscada.Productos = pCategoria.Productos;
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

        public int EliminarCategoria(List<Categoria> ListaCategoria, int id, Categoria pCategoria)
        {
            if (id != 0)
            {
                Categoria categoriaBuscada = ListaCategoria.Where(c => c.IdCategoria == id).FirstOrDefault();
                if (categoriaBuscada != null)
                {
                    ListaCategoria.Remove(categoriaBuscada);
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
