using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    class BubbleSort
    {
        internal void PrintArry(List<int> arr)
        {
            foreach(var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        internal void Search(List<int> arr)
        {
            for(int i=0;i < arr.Count - 1; i++)
            {
                for(int j = 0; j < arr.Count - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting");
            PrintArry(arr);
        }
    }
}
