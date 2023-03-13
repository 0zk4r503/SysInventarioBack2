using SysInventarioBack2.EntidadesDeNegocio;
using SysInventarioBack.AccesoADatos;

namespace SysInventarioBack.LogicaDeNegocio
{
    public class CategoriaBL
    {
        public CategoriaDAL ObjCategoriaBL = new CategoriaDAL();
        public int AgregarCategoria(List<Categoria> ListaCategoria, Categoria pCategoria)
        {
            return ObjCategoriaBL.AgregarCategoria(ListaCategoria, pCategoria);
        }

        public List<Categoria> MostrarCategoria(List<Categoria> ListaCategoria)
        {
            return ObjCategoriaBL.MostrarCategoria(ListaCategoria);

        }

        public int ModificarCategoria(List<Categoria> ListaCategoria, int Id, Categoria pCategoria)
        {
            return ObjCategoriaBL.ModificarCategoria(ListaCategoria, Id, pCategoria);

        }

        public int EliminarCategoria(List<Categoria> ListaCategoria, int Id, Categoria pCategoria)
        {
            return ObjCategoriaBL.EliminarCategoria(ListaCategoria, Id, pCategoria);

        }

    }
}

