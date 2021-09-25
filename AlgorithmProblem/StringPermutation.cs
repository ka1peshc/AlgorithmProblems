using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    class StringPermutation
    {
        internal static List<string> permutationNames;
        
        public static void Permute(String s, int startIndex, int endIndex)
        {
            if(startIndex == endIndex)
            {
                Console.WriteLine(s);
                
            }
            else
            {
                for(int i = startIndex; startIndex < endIndex; startIndex++)
                {
                    s = Swaping(s, startIndex, i);
                    Permute(s, startIndex + 1, endIndex);
                    s = Swaping(s, startIndex, i);
                }
            }
            
        }
        public static String Swaping(String s, int i, int j)
        {
            char temp;
            char[] charArr = s.ToCharArray();
            temp = charArr[i];
            charArr[i] = charArr[j];
            charArr[j] = temp;
            string resultString = new string(charArr);
            
            return resultString;
        }
    }
}
