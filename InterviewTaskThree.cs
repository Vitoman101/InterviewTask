using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTask
{
    class InterviewTaskThree
    {
        public static int[] Convert2Dto1D(int[,] array)
        {
            int index = 0;
            int width = array.GetLength(0);
            int height = array.GetLength(1);
            int[] arr = new int[width * height];
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    arr[index] = array[k, i];
                    index++;
                }
            }
            return arr;
        }
    }
}
