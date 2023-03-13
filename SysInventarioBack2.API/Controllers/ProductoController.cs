using Microsoft.AspNetCore.Mvc;
using SysInventarioBack.AccesoADatos;
using SysInventarioBack2.AccesoADatos;
using SysInventarioBack2.EntidadesDeNegocio;
using SysInventarioBack2.LogicaDeNegocio;

namespace SysInventarioBack2.API.Controllers
{
    public class ProductoController : Controller
    {
        public static List<Producto> ListaProducto = new List<Producto>();
        ProductoDAL ObjProductoBL = new ProductoDAL();

        [HttpGet("MostrarProducto")]
        public ActionResult<List<Producto>> MostrarProducto()
        {

            return ObjProductoBL.MostrarProducto(ListaProducto);
        }

        [HttpPost("AgregarProducto")]

        public ActionResult<int> AgregarProducto(Producto pProducto)
        {
            return ObjProductoBL.AgregarProducto(ListaProducto, pProducto);
        }

        [HttpPut("ModificarProducto")]
        public ActionResult<int> ModificarProducto(int Id, Producto pProducto)
        {
            return ObjProductoBL.ModificarProducto(ListaProducto, Id, pProducto);
        }

        [HttpDelete("EliminarProducto")]
        public ActionResult<int> EliminarProducto(int id, Producto pProducto)
        {
            return ObjProductoBL.EliminarProducto(ListaProducto, id, pProducto);
        }
    }
}
