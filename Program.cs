using System;
using System.Collections.Generic;
namespace SortingAlgorithms {
    class MainClass {
        public static void Main(string[] args) {
            Random random = new Random();
            Console.WriteLine("CountingSort:");
            for (int i = 0; i < 11; i++) {
                List<int> x = new List<int>();
                for (int j = 0; j < 22; j++) {
                    x.Add(random.Next(1, 100));
                }
                printList(Sort.QuickSort(x, 0, x.Count-1));
            }
        

        }

        public static void printList<T>(List<T> list) {
            foreach (var c in list) {
                Console.Write(c + " ");
            }
            Console.WriteLine("");
        }
    }
}

