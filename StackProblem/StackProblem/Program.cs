using System;

namespace StackProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome In Stack Program");
            int input;
            do
            {
                Console.WriteLine("\n1:Adding the char item in Stack");
                Console.WriteLine("0:Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        StackExample.InsertChar();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Input: ----- Please Enter Correct Input");
                        break;
                }
            }
            while (input != 0);
        }
    }
}