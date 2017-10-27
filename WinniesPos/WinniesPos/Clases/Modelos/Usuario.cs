using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class Usuario
    {
        public int codigoEmpleado { set; get; }
        public IList<Privilegio> lPermisos{set; get;}
        public int codigoTienda { get; set; }

        public Usuario()
        {
            this.lPermisos = new List<Privilegio>();
        }
    }
}
