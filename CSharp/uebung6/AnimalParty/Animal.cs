using System;
using System.Collections.Generic;
using System.Text;

namespace uebung6.AnimalParty {
    public enum Sex {
        female,
        male,
    }

    public abstract class Animal {
        public string Name;
        public Sex Sex;
        public DateTime Birthday;
        public int Age {
            get => DateTime.Now.Year - Birthday.Year;
        }

        public Animal(string name, Sex sex, DateTime date) {
            Name = name;
            Sex = sex;
            Birthday = date;
        }

        public abstract void Eat();
        public abstract void Sleep();
    }
}
