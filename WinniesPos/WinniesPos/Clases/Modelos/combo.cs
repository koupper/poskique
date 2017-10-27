using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    class Combo
    {
        
        public string [] combazo= new string [30];
        public string[] bebida = new string[30];
        public string consulta;
        
        public  void combodata(int i,string com,string beb)
        {
            combazo[i] = com;
            bebida[i]= beb;
        }
        public string sacarDato(int i, string com)
        {
            consulta = bebida[i];
            return consulta;

        }


}
        
    }

