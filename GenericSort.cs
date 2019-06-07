﻿using System;

using System.Collections.Generic;

namespace GenericSort {
    public static class GenericSort {


        public static List<T> MergeSort<T>(List<T> A) where T : IComparable {
            //  Exit condition for recursion
            if (A.Count <= 1) return A;

            int n = A.Count - 1;

            //  Define left and right sub-lists
            var l = new List<T>();
            var r = new List<T>();

            //  Middle index of list to sort
            int m = A.Count / 2;

            //  Initialize left list
            for (int i = 0; i < m; i++) l.Add(A[i]);

            //  Initialize right list
            for (int i = m; i < A.Count; i++) r.Add(A[i]);

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static List<T> Merge<T>(List<T> l, List<T> r) where T : IComparable {
            List<T> m = new List<T>();
            int index_l = 0;
            int nl, nr;
            nl = l.Count - 1;
            nr = r.Count - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m.Add(r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m.Add(l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m.Add(l[index_l]);
                    index_l++;
                } else {
                    m.Add(r[i - index_l]);
                }
            }
            return m;
        }


        public static List<T> SelectionSort<T>(List<T> A) where T : IComparable {
            int n = A.Count - 1;
            //  Current position for insertion
            int index = 0;
            //  Position of the current smallest element
            int minPos;
            do {
                minPos = index;
                for (int i = (index + 1); i <= n; i++) {
                    if (A[i].CompareTo(A[minPos]) < 0) {
                        minPos = i;
                    }
                }
                Swap(A, minPos, index);
                index++;
            } while (index < n);
            //  Return sorted list
            return A;
        }


        public static List<T> BubbleSort<T>(List<T> A) where T : IComparable {
            int n = A.Count;
            int newn;
            do {
                //  New length of list to sort
                newn = 1;
                for (int i = 0; i < n - 1; i++) {
                    if (A[i].CompareTo(A[i + 1]) > 0) {
                        Swap(A, i, i + 1);
                        newn = i + 1;
                    }
                }
                n = newn;
            } while (n > 1);
            //  Return sorted list
            return A;
        }

        public static T[] BubbleSort<T>(T[] A) where T : IComparable {
            int n = A.Length;
            int newn;
            do {
                //  New length of list to sort
                newn = 1;
                for (int i = 0; i < n - 1; i++) {
                    if (A[i].CompareTo(A[i + 1]) > 0) {
                        Swap(A, i, i + 1);
                        newn = i + 1;
                    }
                }
                n = newn;
            } while (n > 1);
            //  Return sorted list
            return A;
        }



        public static List<T> QuickSort<T>(List<T> A, int lo, int hi) where T : IComparable {
            if (lo < hi) {
                int pi = Partition(A, lo, hi);
                //  Recursively sort smaller half of the list
                QuickSort(A, lo, pi - 1);
                //  Recursively sort higher half of the list
                QuickSort(A, pi + 1, hi);
            }
            //  Return sorted list
            return A;
        }

        public static int Partition<T>(List<T> A, int low, int high) where T : IComparable {
            //  Assign the last element to the pivot element
            T pivot = A[high];
            //  Index of smaller element
            int lowIndex = (low - 1);
            //  Iterate from lowest to highest element
            for (int j = low; j <= high - 1; j++) {

                //Swap elements if j-th element is smaller than the pivot element
                if (A[j].CompareTo(pivot) < 0 || A[j].Equals(pivot)) {
                    lowIndex++;
                    Swap(A, lowIndex, j);
                }
            }
            Swap(A, lowIndex + 1, high);
            return (lowIndex + 1);
        }


        public static List<T> InsertionSort<T>(List<T> A) where T : IComparable {
            int n = A.Count;
            //  value to be sorted 
            T value = default(T);
            //  Insertion index of 'value'
            int j;
            //  Iterate from 2nd to last element
            for (int i = 1; i < n; i++) {
                value = A[i];
                j = i;
                /* If left value of A[j] is higher than current value,
                 * move A[j-1] one the left
                 */
                while (j > 0 && (A[j - 1].CompareTo(value) > 0)) {
                    A[j] = A[j - 1];
                    j -= 1;
                }
                A[j] = value;
            }
            //  Return sorted list
            return A;
        }


        public static List<T> CombSort<T>(List<T> A) where T : IComparable {

            int stepLength = A.Count;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Count - stepLength); i++) {
                    if (A[i].CompareTo(A[i + stepLength]) > 0) {
                        Swap(A, i, i + stepLength);
                        swapped = true;
                    }
                }
                if (stepLength > 1) {
                    stepLength = (int)Math.Floor(stepLength / 1.3);
                }

            } while (swapped == true || stepLength > 1);
            return A;
        }


        public static List<T> IntroSort<T>(List<T> A) where T : IComparable {

            int n = A.Count;
            int p = Partition(A, 0, A.Count - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Count)) ? HeapSort(A) : QuickSort(A, 0, A.Count - 1);
            }
            return A;
        }

        public static List<T> HeapSort<T>(List<T> A) where T : IComparable {
            int n = A.Count;

            // Build heap (rearrange array) 
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(A, n, i);

            for (int i = n - 1; i >= 0; i--) {
                Swap(A, 0, i);

                // call max heapify on the reduced heap 
                A = Heapify(A, i, 0);
            }
            return A;
        }

        public static List<T> Heapify<T>(List<T> A, int n, int i) where T : IComparable {
            int largest = i; // Initialize largest as root 
            int left = 2 * i + 1; // left = 2*i + 1 
            int right = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (left < n && A[left].CompareTo(A[largest]) > 0)
                largest = left;

            // If right child is larger than largest so far 
            if (right < n && A[right].CompareTo(A[largest]) > 0)
                largest = right;

            // If largest is not root 
            if (largest != i) {
                Swap(A, i, largest);

                // Recursively heapify the affected sub-tree 
                A = Heapify(A, n, largest);
            }
            return A;
        }

        public static List<T> BucketSort<T>(List<T> A) where T : IComparable {
            int n = A.Count;

            //  Initialize buckets
            var bucket = new List<List<T>>();

            //  Distribute values on the buckets 
            for (int i = 0; i < n; i++) {
                int bi = (dynamic)n * A[i];
                bucket[bi].Add(A[i]);
            }

            //  Sorting every bucket using mergeSort
            for (int i = 0; i < n; i++) {
                bucket[i] = MergeSort(bucket[i]);
            }

            A.Clear();
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < bucket[i].Count; j++) {
                    A.Add(bucket[i][j]);
                }
            }
            return A;
        }

        //  auxiliary functions
        public static void Swap<T>(List<T> A, int i, int j) {
            T h = A[i];
            A[i] = A[j];
            A[j] = h;
        }

        public static void Swap<T>(T[] A, int i, int j) {
            T h = A[i];
            A[i] = A[j];
            A[j] = h;
        }

        public static Boolean IsSorted<T>(T[] A) where T : IComparable {
            for (int i = 1; i < A.Length; i++) {
                if (A[i].CompareTo(A[i - 1]) < 0) {
                    return false;
                }
            }
            return true;
        }

    }
}