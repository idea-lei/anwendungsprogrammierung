using System;

namespace aufgabe2 {
    class Program {
        static void Main(string[] args) {
            //
        }
    }

    public enum Sex {
        Male,
        Femal,
        Other
    }

    public class Human {
        public string Name { get; set; }

        public Sex Sex { get; set; }

        public DateTime Birthday { get; set; }

        public int Age {
            get {
                return DateTime.Now.Year - Birthday.Year;
            }
        }

        public Human(string name, Sex sex, DateTime birthday) {
            Name = name;
            Sex = sex;
            Birthday = birthday;
            Console.WriteLine($"{Name} is {Age} year(s) old");
        }
    }

    public class Student : Human {
        public string StudentId { get; set; }
        public string Major { get; set; }

        public Student(string name, Sex sex, DateTime birthday, string studentId, string major) : base(name, sex, birthday) {
            StudentId = studentId;
            Major = major;
            Console.WriteLine($"{Name} is student with major {Major}");
        }
    }
}
