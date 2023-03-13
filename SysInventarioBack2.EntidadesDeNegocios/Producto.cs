using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysInventarioBack2.EntidadesDeNegocio
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int Codigo { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaV { get; set; }
        public int Cantidad { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
