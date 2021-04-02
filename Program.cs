using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task 1 - Merge sorting
            Console.WriteLine("----------Task 1----------");
            int[] unsorted = { 3, 2, 6, 56, 23, 17, 18, 1, 5 };
            int[] sorted = InterviewTaskOne.MergeSort(unsorted);
            foreach (var i in sorted)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine("\r\nPress enter to continue on the next task...");
            Console.ReadLine();

            //End of Task 1

            //Task 2 - Integer prime number checker
            Console.WriteLine("----------Task 2----------");
            int number = 4;
            bool test = InterviewTaskTwo.isPrime(number);

            Console.WriteLine(test ? number + " is prime " : number + " is not prime!");
            Console.WriteLine("Press enter to continue on the next task...");
            Console.ReadLine();

            //Task 3 - Convertor form 2D array to 1D
            Console.WriteLine("----------Task 3----------");
            int[,] arr2D = {
                    {1, 2},
                    {3, 4},
                    {5, 6}
                };

            int[] arr1D = InterviewTaskThree.Convert2Dto1D(arr2D);

            foreach(var i in arr1D)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

        }
    }
}
