namespace WindowsFormsApplication1.Clases
{
    public class ProductoComplementario
    {
        public int idProductoComplementario { get; set; } //llave
        public decimal costoEspecial { get; set; }
        public string textoComplementario { get; set; }
        public int idComplemento {get; set;} // llave
    }
}