using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class Caja
    {
        public string idCaja {set; get;}
	    public int idTienda {set; get;}
	    public Dinero dinero {set; get;}
        public int codigoEmpleado { set; get; }
        public float efectivoInicial { set; get; }
	    public float efectivoAlCierre {set; get;}
	    public DateTime fechaInicio{set; get;}
        public DateTime? fechaCierre { set; get; }
        public bool estatus { get; set; }

        public Caja(int codigoEmpleado, int sucursal, int efectivoInicial, Dinero dinero)
        {
            this.idCaja = codigoEmpleado.ToString("#.##", CultureInfo.InvariantCulture) + DateTime.Now.Day.ToString("#.##", CultureInfo.InvariantCulture) +
                DateTime.Now.Month.ToString("#.##", CultureInfo.InvariantCulture) + DateTime.Now.Year.ToString("#.##", CultureInfo.InvariantCulture) +
                DateTime.Now.Year.ToString("#.##", CultureInfo.InvariantCulture) + DateTime.Now.Hour.ToString("#.##", CultureInfo.InvariantCulture) +
                DateTime.Now.Minute.ToString("#.##", CultureInfo.InvariantCulture) + DateTime.Now.Second.ToString("#.##", CultureInfo.InvariantCulture) + sucursal.ToString("#.##", CultureInfo.InvariantCulture) + efectivoInicial.ToString("#.##", CultureInfo.InvariantCulture);

            this.codigoEmpleado = codigoEmpleado;
            this.idTienda = sucursal;
            this.efectivoInicial = efectivoInicial;
            this.dinero = dinero;
        }

        public Caja()
        {
            // TODO: Complete member initialization
        }


    }
}
