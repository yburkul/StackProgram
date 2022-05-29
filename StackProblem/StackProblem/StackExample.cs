using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblem
{
    public class StackExample
    {
        public static void InsertChar()
        {
            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');

            Console.WriteLine("Current stack: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
        public static void RemoveChar()
        {
            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            Console.WriteLine("Current stack: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\nCount the stack element: " + stack.Count);
            Console.WriteLine("\nTop Element: " + stack.Pop());
            Console.WriteLine("\nAfter Removing Top element the Current stack are: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\nCount the stack element after remove element: " + stack.Count);
        }
        public static void DisplayTopChar()
        {
            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            Console.WriteLine("Current stack: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\nTop Most Element of Stack is: " + stack.Peek());
        }
        public static void ContainsInStack()
        {
            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            Console.WriteLine("Current stack: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }            
            Console.WriteLine("\nChecking whether the 'C' element is present in the Stack or not: " + stack.Contains('C'));
            Console.WriteLine("\nChecking whether the 'Y' element is present in the Stack or not: " + stack.Contains('Y'));
        }
        public static void ClearAllStack()
        {
            Stack<char> stack = new Stack<char>();
            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            Console.WriteLine("Current stack: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\nDisplaying the count of elements contained in the Stack Before removing all the elements: " + stack.Count);
            stack.Clear();
            Console.WriteLine("\nDisplaying the count of elements contained in the Stack after removing all the elements: " + stack.Count);
        }

        public static void InsertIntager()
        {
            Stack<int> stack = new Stack<int>();  
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine("Current stack are: ");
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int input;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Welcome in Stack Opertions");
                Console.WriteLine("1: Remove Element from stack by using Pop Opertaion");
                Console.WriteLine("2: Display Top Most Element by using Peek Opertaion");
                Console.WriteLine("3: Checking whether the element is present in the Stack or not");
                Console.WriteLine("4: Removing all the elements from Stack");
                Console.WriteLine("0: Please Go Back In Main Method\n");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("\nCount the stack element: " + stack.Count);
                        Console.WriteLine("\nTop Element: " + stack.Pop());
                        Console.WriteLine("\nCount the stack element after remove element: " + stack.Count);
                        break;
                    case 2:
                        Console.WriteLine("\nTop Most Element of Stack is: " + stack.Peek());
                        break;
                    case 3:
                        Console.WriteLine("\nChecking whether the '20' element is present in the Stack or not: " + stack.Contains(20));
                        break;
                    case 4:
                        Console.WriteLine("\nDisplaying the count of elements contained in the Stack Before removing all the elements: " + stack.Count);
                        stack.Clear();
                        Console.WriteLine("\nDisplaying the count of elements contained in the Stack after removing all the elements: " + stack.Count);
                        break;
                    case 0:
                        Console.WriteLine("Yes");
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