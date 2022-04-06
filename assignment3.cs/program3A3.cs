using System;
using System.IO;


    class StackException : Exception
    {
        public StackException() : base() { }
        public StackException(string message) : base(message) { }
    }

    class Stack
    {
        int[] stack;
        int top, size;

        public Stack(int size)
        {
            this.size = size;
            this.stack = new int[size];
            this.top = -1;
        }

        public void Push(int value)
        {
            if (this.top == this.size - 1)
                throw new StackException("stack overflow");
            else
                this.stack[++this.top] = value;
        }

        public void Pop()
        {
            try{
            if (this.top == -1)
                throw new StackException();
            else
            {
                Console.WriteLine("{0} popped", this.stack[top]);
                this.top--;
            }
        }
         catch(Exception ex )
         {Console.Write("stack underflow {0}",ex.Message);}
        }

        public void DisplayStack()
        {
            Console.WriteLine("\nStack values: ");
            if (top > -1)
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.Write("{0} ", stack[i]);
                }
                Console.WriteLine("/n /n");
            }
            else
                Console.WriteLine("Stack Empty...");
        }
    }
    
     class program
     {
        static void Main()
        {
            Console.WriteLine("Enter the size of the stack");
            int size = Convert.ToInt32(Console.ReadLine());
            int z = 0;

            Stack obj = new Stack(size);

            while (z != 4)
            {
                Console.WriteLine("\n1. Push\n2. Pop\n3. Display Stack\n4. Exit\n");
                z = Convert.ToInt32(Console.ReadLine());
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Enter a value to be pushed...");
                        int value = Convert.ToInt32(Console.ReadLine());
                        obj.Push(value);
                        break;
                    case 2:
                        obj.Pop();
                        break;
                    case 3:
                        obj.DisplayStack();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice...");
                        break;
                }
            }
            
        }
    }
