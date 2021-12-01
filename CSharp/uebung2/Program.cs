using System;

// OOP object oriented programming
namespace uebung2 {
    class Program {
        static void Main(string[] args) {
            //var Jack = new Animal("Jack", new DateTime(2010, 01, 01));
            //var animal = new Animal();
            var jack = new Dog("Jack", new DateTime(2010, 01, 01));
        }
    }

    public abstract class Animal {
        DateTime Birthday { get; set; }
        string Name { get; set; }
        public Animal(string name, DateTime birthday) {
            Birthday = birthday;
            Name = name;
            Console.WriteLine($"{Name}, birthday is {Birthday.Date}");
            Console.WriteLine("this is a animal class");
        }
    }

    public class Dog : Animal {
        string color { get; set; }
        public Dog(string name, DateTime birthday) : base(name, birthday) {
            Console.WriteLine("this is a dog class");
        }

        public void Bark() {
            ///
        }
    }

    public sealed class Husky : Dog {

        public Husky(string name, DateTime birthday) : base(name, birthday) {
            Console.WriteLine("this is a husky class");
        }

        public void BeingNaive() {
            ///
        }
    }
}
