using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask
{
    class InterviewTaskOne
    {
        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr;
            }
            int midIndex = arr.Length / 2;

            int[] leftArr = new int[midIndex];
            Array.Copy(arr, 0, leftArr, 0, leftArr.Length);

            int[] rightArr = new int[arr.Length - midIndex];
            Array.Copy(arr, midIndex, rightArr, 0, rightArr.Length);

            int[] leftArrSorted = MergeSort(leftArr);
            int[] rightArrSorted = MergeSort(rightArr);

            return MergeArrays(leftArrSorted, rightArrSorted);
        }

        private static int[] MergeArrays(int[] firstArr, int[] secondArr)
        {
            int firstArrIndex = 0;
            int secondArrIndex = 0;
            int mergedArrayIndex = 0;
            int[] mergedArr = new int[firstArr.Length + secondArr.Length];

            while (firstArrIndex < firstArr.Length && secondArrIndex < secondArr.Length)
            {
                if (firstArr[firstArrIndex] <= secondArr[secondArrIndex])
                {
                    mergedArr[mergedArrayIndex] = firstArr[firstArrIndex];
                    firstArrIndex += 1;
                }
                else
                {
                    mergedArr[mergedArrayIndex] = secondArr[secondArrIndex];
                    secondArrIndex += 1;
                }
                mergedArrayIndex += 1;
            }

            while (firstArrIndex < firstArr.Length)
            {
                mergedArr[mergedArrayIndex] = firstArr[firstArrIndex];
                mergedArrayIndex += 1;
                firstArrIndex += 1;
            }

            while (secondArrIndex < secondArr.Length)
            {
                mergedArr[mergedArrayIndex] = secondArr[secondArrIndex];
                mergedArrayIndex += 1;
                secondArrIndex += 1;
            }

            return mergedArr;
        }
    }
}
