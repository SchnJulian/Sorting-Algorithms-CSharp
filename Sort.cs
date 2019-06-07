using System;
using System.Collections.Generic;

namespace SortingAlgorithms {
    public static class Sort {

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

        /*********************************************************************/

        /* 
         * Mergesort
         * best-case:       O(n*log(n))
         * average-case:    O(n*log(n))
         * worst-case:      O(n*log(n))
         */
     

        public static int[] MergeSort(int[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-listså
            var l = new int[m];
            var r = new int[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static int[] Merge(int[] l, int[] r) {
            var m = new int[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }


        public static double[] MergeSort(double[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new double[m];
            var r = new double[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static double[] Merge(double[] l, double[] r) {
            var m = new double[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }

        public static float[] MergeSort(float[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new float[m];
            var r = new float[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static float[] Merge(float[] l, float[] r) {
            var m = new float[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }

        public static sbyte[] MergeSort(sbyte[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new sbyte[m];
            var r = new sbyte[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static sbyte[] Merge(sbyte[] l, sbyte[] r) {
            var m = new sbyte[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }



        public static short[] MergeSort(short[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new short[m];
            var r = new short[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static short[] Merge(short[] l, short[] r) {
            var m = new short[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }

        public static long[] MergeSort(long[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new long[m];
            var r = new long[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static long[] Merge(long[] l, long[] r) {
            var m = new long[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }

        public static byte[] MergeSort(byte[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new byte[m];
            var r = new byte[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static byte[] Merge(byte[] l, byte[] r) {
            var m = new byte[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }

        public static ushort[] MergeSort(ushort[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new ushort[m];
            var r = new ushort[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static ushort[] Merge(ushort[] l, ushort[] r) {
            var m = new ushort[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }

        public static uint[] MergeSort(uint[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new uint[m];
            var r = new uint[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static uint[] Merge(uint[] l, uint[] r) {
            var m = new uint[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }

        public static ulong[] MergeSort(ulong[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new ulong[m];
            var r = new ulong[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static ulong[] Merge(ulong[] l, ulong[] r) {
            var m = new ulong[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }


        public static decimal[] MergeSort(decimal[] A) {
            //  Exit condition for recursion
            if (A.Length <= 1) return A;



            //  Middle index of list to sort
            int m = A.Length / 2;
            //  Define left and right sub-lists
            var l = new decimal[m];
            var r = new decimal[A.Length - m];



            //  Initialize left list
            for (int i = 0; i < m; i++) l[i] = A[i];

            //  Initialize right list
            for (int i = m, x = 0; i < A.Length; i++, x++) r[x] = A[i];

            //  Recursively sort left half of the list
            l = MergeSort(l);
            //  Recursively sort right half of the list
            r = MergeSort(r);

            //  Merge sorted sub-lists
            return Merge(l, r);
        }

        public static decimal[] Merge(decimal[] l, decimal[] r) {
            var m = new decimal[l.Length + r.Length];
            int index_l = 0;
            int nl, nr;
            nl = l.Length - 1;
            nr = r.Length - 1;
            for (int i = 0; i <= nl + nr + 1; i++) {
                if (index_l > nl) {
                    m[i] = (r[i - index_l]);
                    continue;
                }

                if (index_l < i - nr) {
                    m[i] = (l[index_l]);
                    index_l++;
                    continue;
                }

                if (l[index_l].CompareTo(r[i - index_l]) < 0 || l[index_l].Equals(r[i - index_l])) {
                    m[i] = (l[index_l]);
                    index_l++;
                } else {
                    m[i] = (r[i - index_l]);
                }
            }
            return m;
        }

        /* Insertionsort
        * best-case:       O(n^2)
        * average-case:    O(n^2)
        * worst-case:      O(n^2)
        */
       
        public static int[] SelectionSort(int[] A) {
            int n = A.Length - 1;
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

        public static double[] SelectionSort(double[] A) {
            int n = A.Length - 1;
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


        public static float[] SelectionSort(float[] A) {
            int n = A.Length - 1;
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

        public static sbyte[] SelectionSort(sbyte[] A) {
            int n = A.Length - 1;
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

        public static byte[] SelectionSort(byte[] A) {
            int n = A.Length - 1;
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

        public static long[] SelectionSort(long[] A) {
            int n = A.Length - 1;
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

        public static short[] SelectionSort(short[] A) {
            int n = A.Length - 1;
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


        public static ushort[] SelectionSort(ushort[] A) {
            int n = A.Length - 1;
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
        //TODO uint16 usw?
        public static uint[] SelectionSort(uint[] A) {
            int n = A.Length - 1;
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

        public static ulong[] SelectionSort(ulong[] A) {
            int n = A.Length - 1;
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

        public static decimal[] SelectionSort(decimal[] A) {
            int n = A.Length - 1;
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



        /* 
         * Bubblesort
         * best-case:       O(n)
         * average-case:    O(n^2)
         * worst-case:      O(n^2)
         */
        

        public static int[] BubbleSort(int[] A) {
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


        public static double[] BubbleSort(double[] A) {
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

        public static sbyte[] BubbleSort(sbyte[] A) {
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

        public static short[] BubbleSort(short[] A) {
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

        public static long[] BubbleSort(long[] A) {
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


        public static byte[] BubbleSort(byte[] A) {
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

        public static ushort[] BubbleSort(ushort[] A) {
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

        public static uint[] BubbleSort(uint[] A) {
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

        public static ulong[] BubbleSort(ulong[] A) {
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

        public static decimal[] BubbleSort(decimal[] A) {
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




        /* 
         * Quicksort
         * best-case:       O(n*log(n))
         * average-case:    O(n*log(n))
         * worst-case:      O(n^2)
         */
        
        public static int[] QuickSort(int[] A, int lo, int hi) {
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

        public static int Partition(int[] A, int low, int high) {
            //  Assign the last element to the pivot element
            int pivot = A[high];
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

        public static double[] QuickSort(double[] A, int lo, int hi) {
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

        public static int Partition(double[] A, int low, int high) {
            //  Assign the last element to the pivot element
            double pivot = A[high];
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



        public static float[] QuickSort(float[] A, int lo, int hi) {
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

        public static int Partition(float[] A, int low, int high) {
            //  Assign the last element to the pivot element
            float pivot = A[high];
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


        public static short[] QuickSort(short[] A, int lo, int hi) {
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

        public static int Partition(short[] A, int low, int high) {
            //  Assign the last element to the pivot element
            short pivot = A[high];
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



        public static ushort[] QuickSort(ushort[] A, int lo, int hi) {
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

        public static int Partition(ushort[] A, int low, int high) {
            //  Assign the last element to the pivot element
            ushort pivot = A[high];
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


        public static byte[] QuickSort(byte[] A, int lo, int hi) {
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

        public static int Partition(byte[] A, int low, int high) {
            //  Assign the last element to the pivot element
            byte pivot = A[high];
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


        public static sbyte[] QuickSort(sbyte[] A, int lo, int hi) {
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

        public static int Partition(sbyte[] A, int low, int high) {
            //  Assign the last element to the pivot element
            sbyte pivot = A[high];
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


        public static uint[] QuickSort(uint[] A, int lo, int hi) {
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

        public static int Partition(uint[] A, int low, int high) {
            //  Assign the last element to the pivot element
            uint pivot = A[high];
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


        public static long[] QuickSort(long[] A, int lo, int hi) {
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

        public static int Partition(long[] A, int low, int high) {
            //  Assign the last element to the pivot element
            long pivot = A[high];
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


        public static ulong[] QuickSort(ulong[] A, int lo, int hi) {
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

        public static int Partition(ulong[] A, int low, int high) {
            //  Assign the last element to the pivot element
            ulong pivot = A[high];
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


        public static decimal[] QuickSort(decimal[] A, int lo, int hi) {
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

        public static int Partition(decimal[] A, int low, int high) {
            //  Assign the last element to the pivot element
            decimal pivot = A[high];
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





        /* 
         * Insertionsort
         * best-case:       O(n)
         * average-case:    O(n^2)
         * worst-case:      O(n^2)
         */
     
        public static int[] InsertionSort(int[] A) {
            int n = A.Length;
            //  value to be sorted 
            int value;
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


        public static double[] InsertionSort(double[] A) {
            int n = A.Length;
            //  value to be sorted 
            double value;
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

        public static float[] InsertionSort(float[] A) {
            int n = A.Length;
            //  value to be sorted 
            float value;
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

        public static sbyte[] InsertionSort(sbyte[] A) {
            int n = A.Length;
            //  value to be sorted 
            sbyte value;
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

        public static short[] InsertionSort(short[] A) {
            int n = A.Length;
            //  value to be sorted 
            short value;
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

        public static ushort[] InsertionSort(ushort[] A) {
            int n = A.Length;
            //  value to be sorted 
            ushort value;
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

        public static byte[] InsertionSort(byte[] A) {
            int n = A.Length;
            //  value to be sorted 
            byte value;
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

        public static long[] InsertionSort(long[] A) {
            int n = A.Length;
            //  value to be sorted 
            long value;
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

        public static uint[] InsertionSort(uint[] A) {
            int n = A.Length;
            //  value to be sorted 
            uint value;
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

        public static ulong[] InsertionSort(ulong[] A) {
            int n = A.Length;
            //  value to be sorted 
            ulong value;
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

        public static decimal[] InsertionSort(decimal[] A) {
            int n = A.Length;
            //  value to be sorted 
            decimal value;
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



        /* 
        * Combsort
        * best-case:       O(n*log(n))
        * average-case:    O(n*log(n))
        * worst-case:      O(n^2)
        */
       

        public static int[] CombSort(int[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        public static uint[] CombSort(uint[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        public static double[] CombSort(double[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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
        public static float[] CombSort(float[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        public static decimal[] CombSort(decimal[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        public static sbyte[] CombSort(sbyte[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        public static short[] CombSort(short[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        public static ushort[] CombSort(ushort[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        public static byte[] CombSort(byte[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        public static long[] CombSort(long[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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


        public static ulong[] CombSort(ulong[] A) {

            int stepLength = A.Length;
            bool swapped;
            do {
                swapped = false;
                for (int i = 0; i < (A.Length - stepLength); i++) {
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

        /* 
        * Introsort
        * best-case:       O(n*log(n))
        * average-case:    O(n*log(n))
        * worst-case:      O(n*log(n))
        */



        public static int[] IntroSort(int[] A) {

            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static uint[] IntroSort(uint[] A) {

            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static double[] IntroSort(double[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static float[] IntroSort(float[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static short[] IntroSort(short[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static ushort[] IntroSort(ushort[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static byte[] IntroSort(byte[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static sbyte[] IntroSort(sbyte[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static long[] IntroSort(long[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static ulong[] IntroSort(ulong[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            if (p < 16) {
                A = InsertionSort(A);
            } else {
                A = p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            }
            return A;
        }

        public static decimal[] IntroSort(decimal[] A) {


            int p = Partition(A, 0, A.Length - 1);
            //  Use Insertionsort for small lists
            A = p < 16 ? InsertionSort(A) : p > (2 * Math.Log(A.Length)) ? HeapSort(A) : QuickSort(A, 0, A.Length - 1);
            return A;
        }

        /* 
        * Mergesort
        * best-case:       O(n*log(n))
        * average-case:    O(n*log(n))
        * worst-case:      O(n*log(n))
        */
       

        public static int[] HeapSort(int[] A) {
            int n = A.Length;

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

        public static int[] Heapify(int[] A, int n, int i) {
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

        public static double[] HeapSort(double[] A) {
            int n = A.Length;

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

        public static double[] Heapify(double[] A, int n, int i) {
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

        public static float[] HeapSort(float[] A) {
            int n = A.Length;

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

        public static float[] Heapify(float[] A, int n, int i) {
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

        public static decimal[] HeapSort(decimal[] A) {
            int n = A.Length;

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

        public static decimal[] Heapify(decimal[] A, int n, int i) {
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

        public static ushort[] HeapSort(ushort[] A) {
            int n = A.Length;

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

        public static ushort[] Heapify(ushort[] A, int n, int i) {
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

        public static short[] HeapSort(short[] A) {
            int n = A.Length;

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

        public static short[] Heapify(short[] A, int n, int i) {
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

        public static sbyte[] HeapSort(sbyte[] A) {
            int n = A.Length;

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

        public static sbyte[] Heapify(sbyte[] A, int n, int i) {
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

        public static byte[] HeapSort(byte[] A) {
            int n = A.Length;

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

        public static byte[] Heapify(byte[] A, int n, int i) {
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

        public static uint[] HeapSort(uint[] A) {
            int n = A.Length;

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

        public static uint[] Heapify(uint[] A, int n, int i) {
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

        public static long[] HeapSort(long[] A) {
            int n = A.Length;

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

        public static long[] Heapify(long[] A, int n, int i) {
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

        public static ulong[] HeapSort(ulong[] A) {
            int n = A.Length;

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

        public static ulong[] Heapify(ulong[] A, int n, int i) {
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

        /*
        * Bucketsort
        * best-case:       O(n)
        * average-case:    O(n+k)
        * worst-case:      O(n*log(n))
        */

    }
}