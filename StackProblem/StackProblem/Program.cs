using System;
using System.Collections;

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
                Console.WriteLine("2:Remove the char from Stack");
                Console.WriteLine("3:Show Top Most Element of Stack");
                Console.WriteLine("4:Checking whether the element is present in the Stack or not");
                Console.WriteLine("0:Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        StackExample.InsertChar();
                        break;
                    case 2:
                        StackExample.RemoveChar();
                        break;
                    case 3:
                        StackExample.DisplayTopChar();
                        break;
                    case 4:
                        StackExample.ContainsInStack();
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