using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
   public class Producto
    {
        public int idProducto { set; get; }
        public string nombre { set; get; }
        public decimal precio { set; get; }
        public IList<Producto> lComplementos { get; set; } //se usa para combos unicamente
        public int idFamilia { get; set; }
        public int idReceta { get; set; }

        public Producto()
        {
            lComplementos = new List<Producto>();
        }
    }
}
