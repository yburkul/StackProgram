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
            Console.WriteLine("\nTop Element: " + stack.Pop());
            Console.WriteLine("\nAfter Removing Top element the Current stack are: ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }
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
            stack.Peek();
            Console.WriteLine("\nTop Most Element of Stack is: " + stack.Peek());
        }
    }
}