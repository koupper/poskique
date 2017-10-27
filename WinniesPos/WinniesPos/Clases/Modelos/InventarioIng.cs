using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class InventarioIng
    {
        public int idInventario { get; set; }
        public int idIngrediente { get; set; }
        public int inventarioInicial { get; set; }
        public int mermas { get; set; }
        public int prestamo { get; set; }
        public int cortecias { get; set; }
        public int entradas { get; set; }
        public int salidas { get; set; }
        public int inventarioFinal { get; set; }
        public int minimo { get; set; }
        public int maximo { get; set; }
        public int idTienda { get; set; }
        public string fecha { get; set; }
       
       

    }
}
