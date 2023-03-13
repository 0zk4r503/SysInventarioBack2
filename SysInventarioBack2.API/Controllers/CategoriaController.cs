using Microsoft.AspNetCore.Mvc;
using SysInventarioBack.AccesoADatos;
using SysInventarioBack2.EntidadesDeNegocio;

namespace using_SysInventarioBack2.API.Controllers
{
    public class CategoriaController : Controller
    {
        public static List<Categoria> ListaCategoria = new List<Categoria>();
        CategoriaDAL ObjCategoriaBL = new CategoriaDAL();

        [HttpGet("MostrarCategoria")]
        public ActionResult<List<Categoria>> MostrarCategoria()
        {
            
            return ObjCategoriaBL.MostrarCategoria(ListaCategoria);
        }

        [HttpPost("AgregarCategoria")]

        public ActionResult<int> AgregarCategoria(Categoria pCategoria)
        {
            return ObjCategoriaBL.AgregarCategoria(ListaCategoria, pCategoria);
        }

        [HttpPut("ModificarCategoria")]
        public ActionResult<int> ModificarCategoria(int Id, Categoria pCategoria)
        {
            return ObjCategoriaBL.ModificarCategoria(ListaCategoria, Id, pCategoria);
        }

        [HttpDelete("EliminarCategoria")]
        public ActionResult<int> EliminarCategoria(int id, Categoria pCategoria)
        {
            return ObjCategoriaBL.EliminarCategoria(ListaCategoria, id, pCategoria);
        }
    }
}