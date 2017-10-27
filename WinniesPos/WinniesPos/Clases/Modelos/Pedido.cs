using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public int idIngrediente { get; set; }
        public int cantidad { get; set; }
        public int  idTienda { get; set; }
        public string fecha { get; set; }
        public bool atendido { get; set; }
    }
}
