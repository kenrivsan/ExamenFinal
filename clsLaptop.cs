namespace ExamenFinal
{
    public class clsLaptop: clsDispositivo
    {
        public string MemoriaRam {  get; set; }
        public string Almacenamiento { get; set; }
        public clsLaptop()
        {
            MemoriaRam = string.Empty;
            Almacenamiento = string.Empty;
        }
    }
}
