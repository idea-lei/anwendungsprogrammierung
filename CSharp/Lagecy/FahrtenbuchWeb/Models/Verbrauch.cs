using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchWeb.Models
{
    public class VerbrauchModel
    {
        public int ID { get; set; }
        public int FZ_ID { get; set; }
        public double Km_Stand { get; set; }
        public double Km { get; set; }
        public double Verbrauch { get; set; }
        public double V_Km { get; set; }
        public double V_Mpg { get; set; }
    }
}
