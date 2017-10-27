using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class Dinero
    {
       public string idDinero { set; get; }
       public decimal billetes20 { set; get; }
       public decimal billetes50 { set; get; }
       public decimal billetes100 { set; get; }
       public decimal billetes200 { set; get; }
       public decimal billetes500 { set; get; }
       public decimal monedas50centavos { set; get; }
       public decimal monedas1 { set; get; }
       public decimal monedas2 { set; get; }
       public decimal monedas5 { set; get; }
       public decimal monedas10 {set; get;}
       public decimal cantidad { get { return billetes100*100 + billetes20*20 + billetes200*200 + billetes50*50 + billetes500*500 + monedas1*1 + monedas10*10 + monedas2*2 + monedas5*5 + monedas50centavos*(decimal)0.5; } }

       public Dinero(int sucursal)
       {
           this.idDinero = Convert.ToString(sucursal.ToString() + DateTime.Now.Day.ToString() +
                DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() +
                DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() +
                DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() +
                DateTime.Now.Millisecond.ToString(), CultureInfo.InvariantCulture);
       }

       public Dinero()
       {
       }

       public Dinero(decimal billetes100, decimal billetes20, decimal billetes200, decimal billetes50, decimal billetes500, decimal monedas1, decimal monedas10, decimal monedas2, decimal monedas5, decimal monedas50centavos)
       {
           this.billetes100 = billetes100;
           this.billetes20 = billetes20;
           this.billetes200 = billetes200;
           this.billetes50 = billetes50;
           this.billetes500 = billetes500;
           this.monedas1 = monedas1;
           this.monedas10 = monedas10;
           this.monedas2 = monedas2;
           this.monedas5 = monedas5;
           this.monedas50centavos = monedas50centavos;

       }

       internal void reiniciarCuenta()
       {
           this.billetes100 = 0;
           this.billetes20 = 0;
           this.billetes200 = 0;
           this.billetes50 = 0;
           this.billetes500 = 0;
           this.monedas1 = 0;
           this.monedas10 = 0;
           this.monedas2 = 0;
           this.monedas5 = 0;
           this.monedas50centavos = 0;
       }


       // Declare which operator to overload (+), the types 
       // that can be added (two Complex objects), and the 
       // return type (Complex):
       public static Dinero operator +(Dinero c1, Dinero c2)
       {
           
           return new Dinero(c1.billetes100 + c2.billetes100, c1.billetes20 + c2.billetes20, c1.billetes200 + c2.billetes200, c1.billetes50 + c2.billetes50, c1.billetes500 + c2.billetes500,
                              c1.monedas1 + c2.monedas1, c1.monedas10 + c2.monedas10, c1.monedas2 + c2.monedas2, c1.monedas5 + c2.monedas5, c1.monedas50centavos + c2.monedas50centavos);
       }

       public bool seIngresoDinero()
       {
           bool bandera = false;

           if (this.billetes500 > 0)
               bandera = true;
           if (this.billetes200 > 0)
               bandera = true;
           if (this.billetes100 > 0)
               bandera = true;
           if (this.billetes50 > 0)
               bandera = true;
           if (this.billetes20 > 0)
               bandera = true;
           if (this.monedas10 > 0)
               bandera = true;
           if (this.monedas5 > 0)
               bandera = true;
           if (this.monedas2 > 0)
               bandera = true;
           if (this.monedas1 > 0)
               bandera = true;
           if (this.monedas50centavos > 0)
               bandera = true;

           return bandera;
       }
       
    }


}
