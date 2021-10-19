using System;
using System.Collections.Generic;
using System.Text;

namespace uebung6.AnimalParty {
    public class ExoticShorthair : Cat {
        public ExoticShorthair(string name, Sex sex, DateTime date) : base(name, sex, date) {
            Console.WriteLine(ToString());
        }

        public override void BeingCute() {
            Console.WriteLine("mowwww~~~");
        }

        public override string ToString() {
            return $"{Name} is a {Sex} Exotic Shorthair, it's {Age} year(s) old";
        }
    }
}
