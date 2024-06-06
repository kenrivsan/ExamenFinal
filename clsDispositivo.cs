using System.ComponentModel.DataAnnotations;

namespace ExamenFinal
{
    public class clsDispositivo
    {
        public string NoSerial {  get; set; }
        public string Marca { get; set; }

        public string Modelo { get; set; }
        public clsDispositivo()
        {
            NoSerial = string.Empty;
            Marca = string.Empty;
            Modelo = string.Empty;
        }
    }
}
