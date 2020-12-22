using System;
using System.Threading.Tasks;

namespace aufgabe3 {
    class Program {
        static void Main(string[] args) {
        }
    }

    
}


// 1
//for(; ; ) {
//                try {
//                    Console.WriteLine("give the first number, like 1 or 1.3");
//                    double a = double.Parse(Console.ReadLine().Trim());
//Console.WriteLine("give the operator, it should be within: + - * / %");
//                    string op = Console.ReadLine().Trim();
//Console.WriteLine("give the second number, like 1 or 1.3");
//                    double b = double.Parse(Console.ReadLine().Trim());
//double res;
//                    switch (op) {
//                        case "+":
//                            res = a + b;
//                            break;
//                        case "-":
//                            res = a - b;
//                            break;
//                        case "*":
//                            res = a* b;
//                            break;
//                        case "/":
//                            res = a / b;
//                            break;
//                        default:
//                            throw new Exception("operator not in range!");
//                    }
//                    Console.WriteLine($"{a} {op} {b} = {res} \n");
//                } catch (Exception e) {
//                    Console.WriteLine(e.Message + '\n');
//                }
//            }


// 2
//public class Human {
//    public string Name { get; set; }
//    private DateTime birthday;
//    public DateTime Birthday {
//        set {
//            if (value.Year > 1900) birthday = value;
//            else Console.WriteLine("too old!");
//        }
//    }
//    public int Age {
//        get {
//            return DateTime.Now.Year - birthday.Year;
//        }
//    }

//    public string Description {
//        get {
//            return $"{Name} is {Age} year(s) old";
//        }
//    }
//}

// 3
//static async Task Main(string[] args) {
//    int interval = 3 * 1000;
//    for (; ; ) {
//        await Task.Delay(interval);
//        Console.WriteLine("drink water!");
//        Console.Beep();
//    }
//}