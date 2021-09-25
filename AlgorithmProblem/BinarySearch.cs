using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    class BinarySearch<T> where T:IComparable
    {
        private string[] strArr;
        private string word;
        public BinarySearch(string[] arr,string word)
        {
            this.strArr = arr;
            this.word = word;
            Array.Sort(this.strArr);
        }
        
        internal void Search(int startIndex, int endIndex)
         {
            
            int midIndex = (startIndex + endIndex)/2;
            if (strArr[midIndex].Equals(word))
            {
                Console.WriteLine("{0} found",word);
            }
            else if (startIndex == endIndex)
            {
                Console.WriteLine("{0} not found",word);
            }
            else if(strArr[midIndex].CompareTo(word) > 0)
            {
                Search(0, midIndex);
            }
            else if(strArr[midIndex].CompareTo(word)<0)
            {
                Search(midIndex,endIndex);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
