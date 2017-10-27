using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class CajaMaestra
    {
        public int idCorteCaja { get; set; }
        public bool estatus { get; set; }
        public DateTime? fechaInicio { get; set; }
        public DateTime? fechaCierre { get; set; }
        public float faltante { get; set; }
        public float sobrante { get; set; }
        public int idTienda { get; set; }

    }
}
