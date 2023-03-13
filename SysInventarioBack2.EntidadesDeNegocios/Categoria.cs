using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysInventarioBack2.EntidadesDeNegocio
{
    public class Categoria
    {
        public int IdProducto;

        public int IdCategoria { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? IMGURL { get; set; }
        public List<Producto>? Productos { get; set; }
    }
}
