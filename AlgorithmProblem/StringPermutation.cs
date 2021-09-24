using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    class StringPermutation
    {
        internal static List<string> permutationNames;
        
        public static void permute(String s, int startIndex, int endIndex)
        {
            if(startIndex == endIndex)
            {
                Console.WriteLine(s);
                
            }
            else
            {
                for(int i = startIndex; startIndex < endIndex; startIndex++)
                {
                    s = swaping(s, startIndex, i);
                    permute(s, startIndex + 1, endIndex);
                    s = swaping(s, startIndex, i);
                }
            }
            
        }
        public static String swaping(String s, int i, int j)
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
