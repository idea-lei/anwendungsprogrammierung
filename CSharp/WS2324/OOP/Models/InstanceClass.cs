using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models;

internal class InstanceClass: AbstractClass
{
    public override void VirtualMethod()
    {
        //base.VirtualMethod();
        Console.WriteLine("Virtual method in InstanceClass class");
    }

    public override void AbstractMethod()
    {
        Console.WriteLine("Abstract method implemented in InstanceClass class");
    }
}
