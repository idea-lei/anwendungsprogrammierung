using System;
using System.Threading.Tasks;

namespace uebung3 {
    class Program {
        private delegate void ExampaleDelegate(double nr);
        static void Main(string[] args) {
            //// 1. try catch finally
            //int a = 0;
            //int b = 0;
            //try
            //{
            //    // buggy code here
            //    int result = a / b;
            //}
            //catch (Exception ex) { 
            //    // aufgerufen nur Fehler passiert
            //    Console.WriteLine(ex.ToString());
            //    Console.WriteLine("ich wird nur unter Fehler aufgerufen");
            //}
            ////finally
            ////{
            ////    // aufgerufen egal ob es Fehler gibt
            ////    Console.WriteLine("ich wird immer aufgerufen");
            ////}

            // 2. datentyp wechseln
            if(double.TryParse(Console.ReadLine(), out double result)){
                Console.WriteLine(result);
            }

            // 3. log datei
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