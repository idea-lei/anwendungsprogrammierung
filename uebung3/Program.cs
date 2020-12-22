using System;
using System.Threading.Tasks;

namespace uebung3 {
    class Program {
        static void Main(string[] args) {

        }
    }
}
































//// 1 try - catch - finally und throw
//            try {
//                 etwas buggy here
//                int a = 2;
//int b = 0;
//Console.WriteLine(a / b);
//            }catch(Exception e) {
//                 error handling here
//                Console.WriteLine(e);
//            } finally {
//                Console.WriteLine("finally always works");
//            }

// 2 Property and field
//class Test {
//    ////property eigenschaft
//    //public string Name { get; set; }
//    ////field feld
//    //public int age;

//    private string name;
//    public string Name {
//        get {
//            Console.WriteLine(".....");
//            return name;
//        }
//        set {
//            if (value == "jack") {
//                name = value;
//            } else {
//                Console.WriteLine("name is not jack, operation rejected");
//            }

//        }
//    }
//}


//3 async Method
//static async Task Main(string[] args) {
//    HugeMethod();
//    Console.WriteLine("finish");
//}

//static async Task HugeMethod() {
//    for (int i = 0; i < 10; i++) {
//        await Task.Delay(1000);
//        Console.WriteLine(i);
//    }
//}