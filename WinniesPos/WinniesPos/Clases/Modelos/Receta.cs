using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Clases.Modelos
{
    public class Receta
    {
        public int idReceta { get; set; }
        public int idIngrediente { get; set; }
        public int cantidadRequerida { get; set; }
        public string nombreReceta { get; set; }
    }
}
