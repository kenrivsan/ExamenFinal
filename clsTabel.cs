namespace ExamenFinal
{
    public class clsTabel :clsDispositivo
    {
        public string Tamanio { get; set; }
        public string Soporte { get;}
        public clsTabel()
        {
            Tamanio = string.Empty;
            Soporte = string.Empty;
        }
    }
}
