using System;
using System.Collections.Generic;
namespace AlgorithmProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //StringPermutation sp = new StringPermutation();
            string s = "mango";
            int n = s.Length;
            StringPermutation.permute(s, 0, n - 1);
            //List<string> strList = StringPermutation.permutationNames;
            //foreach(var i in strList)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
