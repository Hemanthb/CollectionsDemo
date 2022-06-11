using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPractice
{
    public class CollectionPractice
    {
        List<string> names = new List<string>();
        Stack<int> stack = new Stack<int>();

        public void ManipulateList()
        {
            names.Add("hem");
            names.Add("asha");
            names.Add("sree");
            names.Add("priyesh");

            foreach (var item in names)
                Console.WriteLine(item);
            //last element
            Console.WriteLine("Last name -- " + names.Last());
            //Removes an element
            names.RemoveAt(1);

            foreach (var item in names)
                Console.WriteLine(item);

            Console.WriteLine("------After Reversal------");
            names.Reverse();
            foreach (var item in names)
                Console.WriteLine(item);
        }

        public void ManipulateStack()
        {
            Console.WriteLine("\n------STACK OPERATION------\n");
            stack.Push(10);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Console.WriteLine("TOP ELEMENT --> "+stack.Peek());
            int pop = stack.Pop();
            Console.WriteLine("Popped element -> "+pop);
            foreach (var item in stack)
                Console.Write(item + " -> ");
            Console.WriteLine();
        }
    }
}
