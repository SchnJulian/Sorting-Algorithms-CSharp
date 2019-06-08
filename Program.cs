using System;
using SortingAlgorithms;

namespace SortingAlgorithms {
    class MainClass {
        public static void Main() {
			var example = new int[] { 17, -20, 100, 33, 200, 1, 0 };

			// Print unsorted array
			foreach (var item in example) {
				Console.Write(item + " ");
			}
			Console.WriteLine();

			// Sort the array
			example = Sort.HeapSort(example);

			// Print sorted array
			foreach (var item in example) {
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}
	}
}

