using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
      class Program
      {
        static void Main(string[] args)
        {
            Console.WriteLine("****Welcome to Algorithm Programs!!!****");
            Console.WriteLine("1.Permutation Using Recursion");
            Console.WriteLine("2.Binary Search the word from wordlist");
            Console.WriteLine("3.Insertion Sort");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                ///For UseCase1
                case 1:
                    Console.WriteLine("Enter String to find Permutation ");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    Permutations.Permutate(str, 0, n - 1);
                    break;

                    ///For UseCase2
                case 2:
                    string txtpath = File.ReadAllText(@"F:\BridgeLabz\AlgorithmProblems\AlgorithmProblems\Algorithm.txt");
                    List<string> words = new List<string>(txtpath.Split());
                    words.Sort();
                    BinarySearch.BinarySearchWord(words);
                    break;

                    ///For UseCase3
                case 3:
                    InsertionSort insertionSort = new InsertionSort();
                    int[] arr = { 10, 2, 14, 3, 1, 5, 9 };
                    insertionSort.Sort(arr);
                    insertionSort.PrintArray(arr);
                    break;

                default:
                    Console.WriteLine("Enter the valid option!");
                    break;
            }
            Console.WriteLine("\nDo you want to continue");
            Console.ReadLine();
        }
      }
    
}
