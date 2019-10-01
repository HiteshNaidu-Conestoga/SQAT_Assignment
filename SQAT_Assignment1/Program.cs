using System;

namespace SQAT_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choice;
            string stringChoice;
            do
            {
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                stringChoice = Console.ReadLine();
            } while (byte.TryParse(stringChoice, out choice) && (choice == 1 || choice == 2));
            if (choice == 1)
            {
                Console.WriteLine("Please enter 3 integers");
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                string input3 = Console.ReadLine();
                int.TryParse(input1, out int integer1);
                int.TryParse(input2, out int integer2);
                int.TryParse(input3, out int integer3);
                string finalOutput = TriangleSolver.Analyze(integer1, integer2, integer3);
            }
            else if (choice == 2)
                return;
        }
    }
}