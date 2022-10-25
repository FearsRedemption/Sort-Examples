namespace BubbleSortExample {
    class Program {
        private static void Main(string[] args) {
            double[] unsortedList = { 36, 2, 29, 1, 8, 14 };
            double[] sortedList = BubbleSort(unsortedList);

            foreach (double num in sortedList) { Console.WriteLine(num); }
        }

        //Bring the largest to the end
        //Goes to each index and compares to the next number if that number is greater than the next number
        //then they are swapped. So the next largest number moves all the way to the right on each pass
        private static double[] BubbleSort(double[] unsortedList) {
            double temp;

            //we loop through 1 less than the length of the array because we compare to the number after the current number
            //Thus we do not need to go to the last position as there will be no number after it
            for (int i = 0; i < unsortedList.Length - 1; i++) {

                //i is the current position we solve for
                //add i to not go to the last element as that element has already been moved to the right
                for(int j = 0; j < unsortedList.Length - (1 + i); j++) {

                    //for to last element [0] > [1] -> [4] > [5]
                    if(unsortedList[j] > unsortedList[j + 1]) {

                        //if current is greater than next swap it forward
                        temp = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = temp;
                    }
                }
            }

            return unsortedList;
        }
    }
}