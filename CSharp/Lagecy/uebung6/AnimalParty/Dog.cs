using System;
using System.Collections.Generic;
using System.Text;

namespace uebung6.AnimalParty {
    public abstract class Dog : Animal {
        public Dog(string name, Sex sex, DateTime date) : base(name, sex, date) {

        }

        public virtual void Bark() { }
        public override void Eat() {
            throw new NotImplementedException();
        }

        public override void Sleep() {
            throw new NotImplementedException();
        }
    }
}
