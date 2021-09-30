using System;
using System.Collections.Generic;
namespace AlgorithmProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose program number");
            Console.WriteLine("1. Swing permutation\n2. Binary Search\n3. Insertion Sort\n4.Bubble Sort\n5. Merge Sort\n6. Anagram");
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
                case 3:
                    string test = "Welcome to tech hub India";
                    var testArr = test.Split(" ");
                    InsertionSort<string> insertionSort = new InsertionSort<string>();
                    insertionSort.sortingArray(testArr);
                    break;
                case 4:
                    List<int> intArr = new List<int>{ 51, 75, 98, 44, 21, 36 };
                    BubbleSort bubbleSort = new BubbleSort();
                    Console.WriteLine("Before sorting");
                    bubbleSort.PrintArry(intArr);
                    bubbleSort.Search(intArr);
                    break;
                case 5:
                    MergeSort<string> mergeSort = new MergeSort<string>();
                    string test1 = "Welcome to tech hub India";
                    var testArr1 = test1.Split(" ");
                    mergeSort.Sort(testArr1, 0, testArr1.Length-1);
                    mergeSort.DisplayArry(testArr1);
                    break;
                case 6:
                    Console.WriteLine("Enter two string");
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    Anagram ag = new Anagram(str1, str2);
                    if (ag.CheckAnagram())
                    {
                        Console.WriteLine("{0} and {1} is an anagram", str1, str2);
                    }
                    else
                    {
                        Console.WriteLine("{0} and {1} is not an anagram", str1, str2);
                    }
                    break;
            }
        }  
    }
}
