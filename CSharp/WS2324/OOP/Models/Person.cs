using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models;

public class Person
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public void HelloMessage()
    {
        Console.WriteLine($"Hello, my name is {Name}");
    }


    private void PrivateMethod()
    {
        Console.WriteLine("Private method in Person class");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method in Person class");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal method in Person class");
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public method in Person class");
    }

    public virtual void VirtualMethod()
    {
        Console.WriteLine("Virtual method in Person class");
    }
}
