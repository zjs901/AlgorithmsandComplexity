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
        public static int[] numbersArray1;
        public static int[] numbersArray2;
        public static int[] numbersArray3;
        public static int[] numbersArray4;
        public static int[] numbersArray5;
        public static int[] numbersArray6;


        static void Main(string[] args) 
        {
            ReadFiles();

            //int[] testArray = { 2, 5, 7, 1, 2 };

            //InsertionSort(numbersArray4);
            InsertionSort(numbersArray1);
            PrintArray(numbersArray1);
            Search(numbersArray1);

            //Search(numbersArray1);
            //Search(numbersArray2);
            //Search(numbersArray3);
        }

        // Reads the files
        static void ReadFiles()
        {
            string Share_1_256 = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_1_256.txt";
            try
            {
                string[] lines = File.ReadAllLines(Share_1_256);

                numbersArray1 = lines.Select(int.Parse).ToArray();

                Console.WriteLine($"{Share_1_256} loaded successfully");

                // Prints the array
                //Console.WriteLine("Numbers in the array:");
                //Console.WriteLine(string.Join(", ", numbersArray1));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            string Share_2_256 = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_2_256.txt";
            try
            {
                string[] lines = File.ReadAllLines(Share_2_256);

                numbersArray2 = lines.Select(int.Parse).ToArray();

                Console.WriteLine($"{Share_2_256} loaded successfully");

                // Prints the array
                //Console.WriteLine("Numbers in the array:");
                //Console.WriteLine(string.Join(", ", numbersArray2));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            string Share_3_256 = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_3_256.txt";
            try
            {
                string[] lines = File.ReadAllLines(Share_3_256);

                numbersArray3 = lines.Select(int.Parse).ToArray();

                Console.WriteLine($"{Share_3_256} loaded successfully");

                // Prints the array
                //Console.WriteLine("Numbers in the array:");
                //Console.WriteLine(string.Join(", ", numbersArray3));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            string Share_1_2048 = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_1_2048.txt";
            try
            {
                string[] lines = File.ReadAllLines(Share_1_2048);

                numbersArray4 = lines.Select(int.Parse).ToArray();

                Console.WriteLine($"{Share_1_2048} loaded successfully");

                // Prints the array
                //Console.WriteLine("Numbers in the array:");
                //Console.WriteLine(string.Join(", ", numbersArray4));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            string Share_2_2048 = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_2_2048.txt";
            try
            {
                string[] lines = File.ReadAllLines(Share_2_2048);

                numbersArray5 = lines.Select(int.Parse).ToArray();

                Console.WriteLine($"{Share_2_2048} loaded successfully");

                // Prints the array
                //Console.WriteLine("Numbers in the array:");
                //Console.WriteLine(string.Join(", ", numbersArray5));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            string Share_3_2048 = "C:\\Users\\UpInT\\Source\\Repos\\AlgorithmsandComplexity1\\Algorithms Assignment\\Share_3_2048.txt";
            try
            {
                string[] lines = File.ReadAllLines(Share_3_2048);

                numbersArray6 = lines.Select(int.Parse).ToArray();

                Console.WriteLine($"{Share_3_2048} loaded successfully");

                // Prints the array
                //Console.WriteLine("Numbers in the array:");
                //Console.WriteLine(string.Join(", ", numbersArray6));
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        // To sort array using insertion sort
        static void InsertionSort(int[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i]; // The element to be inserted
                int j = i - 1;

                // Move elements of arr[0..i-1] that are greater than key
                // to one position ahead of their current position
                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp; // Insert the key in the correct position
            }
        }

        // Prints array
        static void PrintArray(int[] array)
        {
            Console.WriteLine("Sorted Array:");
            foreach (int value in array)
                Console.Write(value + " ");
            Console.WriteLine();
        }

        // Search function
        static void Search(int[] numbersArray)
        {
            Console.WriteLine("Search for a number:");
            string searchedInput = Console.ReadLine();
            // Might need some error handling for non numbers
            int searchedNumber = Convert.ToInt32(searchedInput);
            // searchedNumber = int.MaxValue;

            // Creates a new list to store the index positions of the searched number
            List<int> validList = new List<int>();

            // Loops through the numbers array, incrementing i every time
            for (int i = 0; i < numbersArray.Length; i++)
            {
                // If the number is in the array then add the index position to the validList
                if (searchedNumber == numbersArray[i])
                    validList.Add(i);
            }
            if (validList.Count > 0)
                Console.WriteLine("Index Position: " + string.Join(", ", validList));
            else
                Console.WriteLine($"'{searchedNumber}' was not found");
        }
    }
}
