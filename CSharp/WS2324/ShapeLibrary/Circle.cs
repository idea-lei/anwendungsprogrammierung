using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary;

public sealed class Circle : Shape
{
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Radius { get; }
    public override double Area => Math.PI * Radius * Radius;

    public override int Edges => 1;

    public override int Corner => 0;
}
