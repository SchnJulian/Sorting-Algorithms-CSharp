using System;

namespace SortingAlgorithms {
    class MainClass {
        public static void Main() {
            Console.WriteLine("How many elements do you want to sort for the benchmark?");
            int t = Convert.ToInt32(Console.ReadLine());
            Benchmark.benchmark(t);
        }
    }
}

