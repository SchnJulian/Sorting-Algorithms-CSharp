using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace SortingAlgorithms {
    public static class Benchmark {
        
        public static int[] randomArray(int size) {
            Random random = new Random();
            var x = new int[size];
            for (int i = 0; i < size; i++) {
                x[i] = random.Next(0, 100);
            }
            return x;
        }

        public static void benchmark(int array_size) {
            var bubblesort = new Tuple<string, TimeSpan>("Bubble Sort", timer(Sort.BubbleSort, array_size));
            var combsort = new Tuple<string, TimeSpan>("Comb Sort", timer(Sort.CombSort, array_size));
            var heapsort = new Tuple<string, TimeSpan>("Heap Sort", timer(Sort.HeapSort, array_size));
            var insertionsort = new Tuple<string, TimeSpan>("Insertion Sort", timer(Sort.InsertionSort, array_size));
            var introsort = new Tuple<string, TimeSpan>("Intro Sort", timer(Sort.IntroSort, array_size));
            var mergesort = new Tuple<string, TimeSpan>("Merge Sort", timer(Sort.MergeSort, array_size));
            var quicksort = new Tuple<string, TimeSpan>("Quick Sort", timer(Sort.QuickSort, array_size));

            var resx = new List<Tuple<string, TimeSpan>> { bubblesort, combsort, heapsort, insertionsort, introsort, mergesort, quicksort };

            var resy = from element in resx orderby element.Item2 select element;

            var res = resy.ToList();
            Console.WriteLine("Elapsed time to sort a {0}-element array:", array_size);
            for (int i = 0; i < res.Count; i++) {
                Console.Write(res[i].Item1);
                Console.Write("\t");
                Console.Write(res[i].Item2);
                Console.WriteLine();
            }
        }

        public static TimeSpan timer(Func<int[], int[]> func, int array_size) {
            Stopwatch sw = new Stopwatch();
            var test = randomArray(array_size);
            sw.Start();
            func(test);
            sw.Stop();
            return sw.Elapsed;
        }

         public static TimeSpan timer(Func<int[],int, int, int[]> func, int array_size) {
            Stopwatch sw = new Stopwatch();
            var test = randomArray(array_size);
            sw.Start();
            func(test, 0, test.Length-1);
            sw.Stop();
            return sw.Elapsed;
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
