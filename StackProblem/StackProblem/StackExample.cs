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
            Console.WriteLine("Count the stack element: " + stack.Count);
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
            Console.WriteLine("\nChecking whether the element is present in the Stack or not: " + stack.Contains('C'));
            Console.WriteLine("\nChecking whether the element is present in the Stack or not: " + stack.Contains('Y'));
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
    }
}