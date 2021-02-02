using System;
using System.Collections.Generic;
using System.Text;

namespace uebung6.AnimalParty {
    public sealed class Huski : Dog {
        public Huski(string name, Sex sex, DateTime date):base(name, sex, date) {
            Console.WriteLine(ToString());
        }

        public override void Bark() {
            throw new NotImplementedException();
        }

        public void BeingNaive() {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return $"{Name} is a {Sex} Huski, it's {Age} year(s) old";
        }
    }
}
