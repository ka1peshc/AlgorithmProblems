using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmProblem
{
    class Anagram
    {
        private string str1;
        private string str2;

        public Anagram(string s1, string s2)
        {
            this.str1 = s1;
            this.str2 = s2;
        }

        internal bool CheckAnagram()
        {
            bool result = true;

            if(str1.Length == str2.Length)
            {
                char[] strArr1 = str1.ToCharArray();
                char[] strArr2 = str2.ToCharArray();

                Array.Sort(strArr1);
                Array.Sort(strArr2);
                for(int i = 0; i < strArr1.Length; i++)
                {
                    if(strArr1[i] != strArr2[i])
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

    }
}
