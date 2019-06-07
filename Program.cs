using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SortingAlgorithms {
    class MainClass {
        public static void Main() {
           
            var bubblesort = new Tuple<string, TimeSpan>("Bubble Sort", benchmark(Sort.BubbleSort));
            var combsort = new Tuple<string, TimeSpan>("Comb Sort", benchmark(Sort.CombSort));
            var heapsort = new Tuple<string, TimeSpan>("Heap Sort", benchmark(Sort.HeapSort));
            var insertionsort = new Tuple<string, TimeSpan>("Insertion Sort", benchmark(Sort.InsertionSort));
            var introsort = new Tuple<string, TimeSpan>("Intro Sort", benchmark(Sort.IntroSort));
            var mergesort = new Tuple<string, TimeSpan>("Merge Sort", benchmark(Sort.MergeSort));
           
            var resx = new List<Tuple<string, TimeSpan>> { bubblesort, combsort, heapsort, insertionsort, introsort, mergesort };

            var resy = from element in resx orderby element.Item2 select element;

            var res = resy.ToList();

            for (int i = 0; i < res.Count; i++) {
                Console.Write(res[i].Item1);
                Console.Write("\t");
                Console.Write(res[i].Item2);
                Console.WriteLine();
            }

        }

        public static int[] randomArray(int size) {
            Random random = new Random();
            var x = new int[size];
            for (int i = 0; i < size; i++) {
                x[i] = random.Next(0, 100);
            }
            return x;
        }

        public static TimeSpan benchmark(Func<int[], int[]> func) {
            Stopwatch sw = new Stopwatch();
            var test = randomArray(40000);
            sw.Start();
            func(test);
            sw.Stop();
            return sw.Elapsed;
        }



        public static void printList<T>(T[] list) {
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
        public static Boolean IsSorted<T>(T[] array) where T : IComparable {
            for (int i = 1; i < array.Length; i++) {
                if (array[i].CompareTo(array[i - 1]) < 0) {
                    return false;
                }
            }
            return true;
        }

    }
}

