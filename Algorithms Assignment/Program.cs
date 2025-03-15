using System;

namespace Application 
{
    
    class main 
    {
        static void Main(string[] args) 
        {
            while (true)
            {
                Console.Write("Menu:");
                Console.WriteLine("1. Sort");
                Console.WriteLine("2. Search");
                string menuInput = Console.ReadLine();

                if (menuInput == "1")
                {
                    Console.WriteLine("Sorting...");
                }
            }
        }
    }
}