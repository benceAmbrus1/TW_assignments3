using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDojo
{
    /*
    It should be generic
    The size should be given in the constructor(no default constructor allowed)
    Push() functionality(when I add an item to the stack)
    Pop() functionality(when I remove an item)
    Peek() functionality(I can receive the top item without removing it from the stack, so it's peeking)
    I want to be able to get the size of the stack
    And write me a method which gives back the number of free spaces left
    Throw an exception when the stack is full and I want to add one more item
    Throw an exception when the stack is empty and I want to pop an item
    Unit tests!!
    */

    class MyStack<T>
    {
        public T[] Objects { get; set; }
        private int currentstacksize = 0;

        public MyStack(int size)
        {
            Objects = new T[size];
        }

        public void Push(T obj)
        {
            if (currentstacksize < Size())
            {
                Objects[currentstacksize] = obj;
                currentstacksize++;
            }
            else
            {
                Console.WriteLine("Stack is Full, cannot Push: " + obj.ToString());
            }  
        }

        public void Pop()
        {
            if (currentstacksize > 0)
            {
                Objects[currentstacksize-1] = default(T);
                currentstacksize--;
            }
            else
            {
                Console.WriteLine("Stack is Empty, cannot Pop");
            }
        }

        public int Peek()
        {
            return currentstacksize;
        }

        public int Size()
        {
            return Objects.Length;
        }
        public int FreeSpace()
        {
            return Size() - Peek();
        }
    }
}
