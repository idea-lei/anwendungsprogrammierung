using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyManagement.Models;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public int Age => DateTime.Now.Year - Birthday.Year;
    public Adresse Adresse { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ist {Age} Jahre alt, Adresse ist {Adresse}";
    }
}
