using System;

namespace aufgabe1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(NamelessFunc(4));
        }

        static int NamelessFunc(int a) {
            return a <= 1 ? 1 : a + NamelessFunc(a - 1);
        }
    }
}

// 1
//for (int i = 1; i <= 10; i++) {
//    for (int j = 1; j <= i; j++) {
//        Console.Write($"{j} ");
//    }
//    Console.Write("\n");
//}

// 2
//for (int i = 10; i > 0; i--) {
//    for (int j = 1; j <= i; j++) {
//        Console.Write($"{j} ");
//    }
//    Console.Write("\n");
//}

// 3
//Console.Write("2 ");
//for (int i = 3; i < 100; i++) {
//    bool result = true;
//    for (int j = 2; j < i / 2 + 1; j++) {
//        if (i % j == 0) {
//            result = false;
//            break;
//        }
//    }
//    if (result) Console.Write($"{i} ");
//}