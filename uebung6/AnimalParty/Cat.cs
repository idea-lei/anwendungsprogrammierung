using System;
using System.Collections.Generic;
using System.Text;

namespace uebung6.AnimalParty {
    public abstract class Cat : Animal {
        public Cat(string name, Sex sex, DateTime date) : base(name, sex, date) {
        }

        public override void Eat() {
            throw new NotImplementedException();
        }

        public override void Sleep() {
            throw new NotImplementedException();
        }

        public abstract void BeingCute();
    }
}
