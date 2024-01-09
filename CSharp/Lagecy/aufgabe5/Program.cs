using System;
using System.Collections.Generic;

namespace aufgabe5 {
    class Program {
        static void Main(string[] args) {
            var list = new List<int>() { 1, 5, 3, 6, 3, 2, 7, 8, 9, 0, 5, 3, 56, 23, 67, 86, 90, 19, 28 };
            Console.WriteLine("list after sort");
            BubbleSort(list).ForEach(x => Console.Write(x + ", "));
            Console.WriteLine("\nlist before sort");
            list.ForEach(x => Console.Write(x + ", "));
        }

        static List<int> BubbleSort(List<int> originalList) {
            var result = new List<int>();
            int[] listArray = new int[originalList.Count];
            originalList.CopyTo(listArray); // this function ensures deep copy
            List<int> list = new List<int>();
            list.AddRange(listArray);

            int length = originalList.Count; // because the count of the list is dynamic, we setup a value type to avoid length problem
            int minIndex;
            for (int i = 0; i < length; i++) {
                minIndex = 0;
                for (int j = 0; j < list.Count; j++) {
                    if (list[minIndex] > list[j]) {
                        minIndex = j;
                    }
                }
                result.Add(list[minIndex]);
                list.RemoveAt(minIndex);
            }
            return result;
        }
    }
}
