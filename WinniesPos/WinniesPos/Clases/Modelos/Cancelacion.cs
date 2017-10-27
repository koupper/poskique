using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class Cancelacion
    {
        public int idCancelacion{get; set;}
        public int codigoEmpleado { get; set; }
        public string idVenta { get; set; }
        public int idTienda { get; set; }
        public DateTime fechaCancelacion { get; set; }
    }
}
