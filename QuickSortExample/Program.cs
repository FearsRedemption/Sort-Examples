using System;

namespace Quicksort {
    class Program {
        static void Main(string[] args) {
            int[] array = new int[] { 3, -2, 7, 3, 1, 0, 5, 14 };

            QuickSort(array, 0, array.Length - 1);
            for(int i = 0; i < array.Length; i++) {
                Console.WriteLine($"{array[i]} ");
            }
            Console.Read();
        }

        public static void Swap(int[] array, int i, int j) {
            int t = array[i];
            array[i] = array[j];
            array[j] = t;
        }

        private static int Partition(int[] array, int leftBound, int rightBound) {
            int index = leftBound;
            int pivot = array[leftBound];
            for(int i = leftBound + 1; i <= rightBound; i++) {
                if(array[i] < pivot) {
                    index++;
                    Swap(array, index, i);
                }
            }
            Swap(array, index, leftBound);
            return index;
        }

        private static void QuickSort(int[] array, int leftBound, int rightBound) {
            if(leftBound < rightBound) {
                var pivotPos = Partition(array, leftBound, rightBound);
                QuickSort(array, leftBound, pivotPos - 1);
                QuickSort(array, pivotPos + 1, rightBound);
            }
        }
    }
}