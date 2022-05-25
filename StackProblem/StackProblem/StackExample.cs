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
    }
}