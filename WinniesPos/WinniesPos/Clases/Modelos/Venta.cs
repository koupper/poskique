using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class Venta
    {
        public string idVenta { get; set; }
        public int codigoEmpleado { get; set; }
        public int idTienda { get; set; }
        public DateTime fechaVenta { set; get; }
        public decimal total { get; set; }
        

        public Venta(int codigoEmpleado, int sucursal)
        {
            this.idVenta = codigoEmpleado.ToString() + DateTime.Now.Day.ToString()+
                DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() +
                DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString()+
                DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString()+ sucursal.ToString();  
        }

        public Venta()
        {
            
        }

    }
}
