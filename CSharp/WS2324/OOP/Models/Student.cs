using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models;

public class Student : Person
{
    public void Study()
    {
        Console.WriteLine($"{Name} is studying");
    }

    /// <summary>
    /// public: can be accessed from everywhere
    /// internal: can be accessed from the same assembly
    /// private: can be accessed from the same class
    /// protected: can be accessed from the same class and derived classes
    /// </summary>
    public string WriteSomething(string text)
    {
        Console.WriteLine(text);
        return text;
    }

    public void SomeMethod()
    {
        // PrivateMethod(); // not accessible
        ProtectedMethod();
        InternalMethod();
        PublicMethod();
    }
}
