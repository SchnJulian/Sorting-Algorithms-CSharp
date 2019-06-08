using System;
using SortingAlgorithms;

namespace SortingAlgorithms {
    class MainClass {
        public static void Main() {
			       var example = new int[] { 17, -20, 100, 33, 200, 1, 0 };
             Sort.MergeSort(example);
             Sort.IntroSort(example);
             Sort.QuickSort(example, 0 , example.Length-1);
             ...
		}
	}
}
