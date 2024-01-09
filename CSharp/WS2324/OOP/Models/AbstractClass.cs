using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models;

internal abstract class AbstractClass
{
    public virtual void VirtualMethod()
    {
        Console.WriteLine("Virtual method in AbstractClass class");
    }

    public abstract void AbstractMethod();
}
