using System;
using System.Threading.Tasks;
using uebung6._2048;
using uebung6.AnimalParty;

namespace uebung6 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("type the game that you want to start: 1 or 2");
            switch (Console.ReadKey().Key) {
                case ConsoleKey.D1:
                    new Game(5);
                    break;
                case ConsoleKey.D2:
                    var myCat = new ExoticShorthair("Rich", Sex.female, new DateTime(2020, 1, 1));
                    myCat.BeingCute();
                    break;
            }
        }
    }
}
