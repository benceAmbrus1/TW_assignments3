using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>(5);
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            Console.WriteLine("Lenght: " + stack.Size());
            for (int i = 0; i < stack.Size(); i++)
            {
                Console.WriteLine(stack.Objects[i]);
            }
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < stack.Size(); i++)
            {
                Console.WriteLine("---------------------------------");
                stack.Pop();
                for (int j = 0; j < stack.Size(); j++)
                {
                    Console.WriteLine(stack.Objects[j]);
                }
                Console.WriteLine("Free space: " +  stack.FreeSpace());
            }
            stack.Pop();
        }
    }
}
