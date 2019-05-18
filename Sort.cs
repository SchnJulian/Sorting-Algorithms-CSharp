using System;
using System.Collections.Generic;
public interface ITuple { };

namespace SortingAlgorithms {
    public static class Sort {

        public static List<int> MergeSort(List<int> A) {

            if (A.Count <= 1) return A;

            int n = A.Count - 1;
            List<int> l = new List<int>(), r = new List<int>();

            int m = A.Count / 2;
            for (int i = 0; i < m; i++) l.Add(A[i]);

            for (int i = m; i < A.Count; i++) r.Add(A[i]);

            l = MergeSort(l);
            r = MergeSort(r);

            return Merge(l, r);
        }

        public static List<int> Merge(List<int> l, List<int> r) {
            List<int> m = new List<int>();
            int index_l = 0;
            int nl = 0, nr = 0;
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

                if (l[index_l] <= r[i - index_l]) {
                    m.Add(l[index_l]);
                    index_l++;
                } else {
                    m.Add(r[i - index_l]);
                }
            }
            return m;
        }

        //public static List<Tuple<int, int, int>> RadixSort(List<Tuple<int,int,int>> A, int r) {
        //    int n = A.Count;
        //    List<Tuple<int, int, int>> bucket = new List<Tuple<int, int, int>>();
        //    for (int i = 0; i < r; i++) {
        //        for (int j = n - 1; j >= 0; j--) {
        //            switch (i) {
        //                case 1

        //                default:
        //                    break;
        //            }
        //            bucket.Insert(A[j].Item1, A[j]);
        //        }
        //        A.Clear();

        //        for (int j = 0; j < r; j++) {

        //            A.Add(A[j].bucket[j]ToValueTuple<int, int, int>()
        //        }
        //    }
        //    return A;
        //}
    
        public static List<int> 
    
    }

}
