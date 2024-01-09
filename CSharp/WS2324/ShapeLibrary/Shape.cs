using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary;

public abstract class Shape
{
    public abstract double Area { get; }
    public abstract int Edges { get; }
    public abstract int Corner { get; }
    public virtual void Draw()
    {
        Console.WriteLine($"Drawing a {GetType().Name} with {Edges} edges. It's area is {Area}");
    }
}
