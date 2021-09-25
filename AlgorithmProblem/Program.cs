using System;
using System.Collections.Generic;
namespace AlgorithmProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. Swing permutation\n2. Binary Search");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    string s = "mango";
                    int n = s.Length;
                    StringPermutation.Permute(s, 0, n - 1);
                    break;
                case 2:
                    string arg = "Welcome to tech hub India";
                    var arr = arg.Split(" ");
                    Console.WriteLine("Enter word to search");
                    string word = Console.ReadLine();
                    BinarySearch<string> bs = new BinarySearch<string>(arr,word);
                    bs.Search(0, arr.Length - 1);
                    break;
            }
        }  
    }
}
