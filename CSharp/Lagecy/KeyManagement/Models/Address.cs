using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyManagement.Models;

public class Adresse
{
    public int Id { get; set; }
    public string StrasseUndHausNr { get; set; } = string.Empty;
    public string Stadt { get; set; } = string.Empty;
    public int PLZ { get; set; }
    public override string ToString()
    {
        return $"{StrasseUndHausNr}, {PLZ} {Stadt}";
    }
}
