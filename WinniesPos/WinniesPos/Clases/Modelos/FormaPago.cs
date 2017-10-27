using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class FormaPago
    {
        public string metodoPago { set; get; } // efectivo, tarjeta
        public string detalle { set; get; } // 1 efectivo, 2 tarjeta
        public decimal monto { set; get; }
        public string numeroTarjeta { set; get; } 

    }
}
