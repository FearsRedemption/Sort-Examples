using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort {
    internal class Program {
        public static void Main() {
            int[] arr = { 55, 25, 89, 34, 12, 19, 78, 95, 1, 100, 200, 140, 130 };
            int n = arr.Length, i;
            Console.WriteLine("Heap Sort");
            Console.Write("Initial array is: ");
            for(i = 0; i < n; i++) {
                Console.Write(arr[i] + " ");
            }
            HeapSort(arr, arr.Length);
            Console.Write("\nSorted Array is: ");
            for(i = 0; i < n; i++) {
                Console.Write(arr[i] + " ");
            }

            Console.Read();
        }

        static void HeapSort(int[] arr, int length) {
            for(int i = length / 2 - 1; i >= 0; i--) { 
                Heapify(arr, length, i); 
            }

            for(int i = length - 1; i >= 0; i--) {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                Heapify(arr, i, 0);
            }
        }

        static void Heapify(int[] arr, int n, int i) {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if(left < n && arr[left] > arr[largest]) {
                largest = left;
            }                
            if(right < n && arr[right] > arr[largest]) {
                largest = right;
            }
            if(largest != i) {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                Heapify(arr, n, largest);
            }
        }
    }
}
