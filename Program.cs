using System;
using System.Collections.Generic;
namespace SortingAlgorithms {
    class MainClass {
        public static void Main(string[] args) {
            Random random = new Random();
            Console.WriteLine("q:");
            for (int i = 0; i < 11; i++) {

                var x = new double[22];
                for (int j = 0; j < 22; j++) {
                    x[j] = random.NextDouble() * 10;
                }
                printList(Sort.HeapSort(x));
                Console.WriteLine(Sort.IsSorted(Sort.HeapSort(x)));
            }
        }

        public static void printList<T>(List<T> list) {
            foreach (var c in list) {
                Console.Write(c + " ");
            }
            Console.WriteLine("");
        }

        public static void printList(int[] list) {
            foreach (var c in list) {
                Console.Write(c + " ");
            }
            Console.WriteLine("");
        }

        public static void printList(double[] list) {
            foreach (var c in list) {
                Console.Write(c + " ");
            }
            Console.WriteLine("");
        }

        public static void printList(float[] list) {
            foreach (var c in list) {
                Console.Write(c + " ");
            }
            Console.WriteLine("");
        }

    }
}

