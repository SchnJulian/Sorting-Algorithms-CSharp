using System;
using System.Collections.Generic;
namespace SortingAlgorithms {
    class MainClass {
        public static void Main(string[] args) {
            Random random = new Random();

                List<List<int>> A = new List<List<int>>();
                List<int> x = new List<int>();
               
            Tuple<int, int, int> t1 = new Tuple<int, int, int>(2, 3, 5);
            Tuple<int, int, int> t2 = new Tuple<int, int, int>(5, 3, 1);
            Tuple<int, int, int> t3 = new Tuple<int, int, int>(0, 3, 5);
            Tuple<int, int, int> t4 = new Tuple<int, int, int>(0, 0, 1);

            x.Add(1);
                x.Add(2);
                x.Add(9);

                printList(Sort.MergeSort(x));




        }

        public static void printList(List<int> list) {
            foreach (var c in list) {
                Console.Write(c + " ");
            }
            Console.WriteLine("");
        }
    }
}

