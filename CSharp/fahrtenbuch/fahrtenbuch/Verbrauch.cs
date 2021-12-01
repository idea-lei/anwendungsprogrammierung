using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrtenbuch
{
    public class Verbrauch
    {
        [Key]
        public int ID { get; set; }
        public int FZ_ID { get; set; }
        public double km_stand { get; set; }
        public double km { get; set; }
        public double verbrauch { get; set; }
        public double v_km { get; set; }
        public double v_mpg { get; set; }
    }
}
