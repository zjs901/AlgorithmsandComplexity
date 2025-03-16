using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Data;

namespace Application 
{
    class MainClass
    {
        static void Main(string[] args) 
        {

            List<int> dataSet = new List<int>();

            // Reads the file and converts it into an array
            string filePath = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_1_256.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            int[] myNum = File.ReadAllLines(filePath).Select(int.Parse).ToArray();

            // Adds data to the data set list
            foreach (string line in lines)
            {
                dataSet.Add(int.Parse(line));
            }

            string filePath2 = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_2_256.txt";
            List<string> lines2 = File.ReadAllLines(filePath).ToList();
            int[] myNum2 = File.ReadAllLines(filePath).Select(int.Parse).ToArray();

            // Adds data to the data set list
            foreach (string line in lines2)
            {
                dataSet.Add(int.Parse(line));
            }

            string filePath3 = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_3_256.txt";
            List<string> lines3 = File.ReadAllLines(filePath).ToList();
            int[] myNum3 = File.ReadAllLines(filePath).Select(int.Parse).ToArray();

            // Adds data to the data set list
            foreach (string line in lines3)
            {
                dataSet.Add(int.Parse(line));
            }

            Console.WriteLine(dataSet.Count);
            Console.WriteLine(string.Join(", ", dataSet));
            Console.ReadLine();



            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Sort");
                Console.WriteLine("2. Search");
                string menuInput = Console.ReadLine();

                if (menuInput == "1")
                    QuickSort(dataSet.ToArray());
                else if (menuInput == "2")
                    Search(dataSet.ToArray());

            }
        }

        static void QuickSort(int[] array)
        {
            Console.WriteLine("Sorting...");
        }

        static void Search(int[] array)
        {
            Console.WriteLine($"Total numbers loaded: {array.Length}");

            // {testing} Prints the array - Console.WriteLine("Array: " + string.Join(", ", array));

            // Gets search input from user
            Console.WriteLine("Enter a number to search for:");
            string searchInput = Console.ReadLine();
            int searchNumber = Convert.ToInt32(searchInput);

            int index = Array.IndexOf(array, searchNumber);

            // Creates empty list
            List<int> validList = new List<int>();

            // Loops through the array and adds the index of the search number to the list
            for (int i = 0; i < array.Length; i++)
            {
                if (searchNumber == array[i])
                    validList.Add(i);
            }
            // Prints array
            if (validList.Count > 0)
                Console.WriteLine("Index Position: " + string.Join(", ", validList));
            else
                Console.WriteLine($"'{searchNumber}' was not found");
        }
    }
}
