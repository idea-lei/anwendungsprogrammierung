using System;

namespace uebung5 {
    class Program {
        static void Main(string[] args) {
            // zeigen die Nummer 1-10 auf Bildschirm, ob es eine gerade Nummer ist.
            for(int i = 0; i < 10; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i + " ist gerade.");
                    continue;
                }
                Console.WriteLine(i + " ist ungerade.");
            }
            //logging Datei
        }
    }
}
