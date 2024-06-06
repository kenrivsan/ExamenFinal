namespace ExamenFinal
{
    public class clsSmartPhone : clsDispositivo
    {
        public string SistemaOperativo { get; set; }
        public int NoCamaras { get; set; }
        public clsSmartPhone()
        {
            SistemaOperativo = string.Empty;
            NoCamaras = 0;
        }
    }
}
