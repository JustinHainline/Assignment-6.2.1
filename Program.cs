namespace Assignment_6._2._1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
           Stack myStack = new Stack();
            myStack.Push(40);
            myStack.Push(30);
            myStack.Push(20);
            myStack.Push(10);

            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine($"Item popped from Stack: {10}", myStack.Pop());
            myStack.PrintStack();
        }

        internal class Stack
        {
            static readonly int MAX = 1000;

            int top;  //Pointer for element not involved

            int[] stack = new int[MAX];  // create array/stack

            bool IsEmpty()
            {
                return (top < 0);
            }
            public Stack()
            {
                top = -1;
            }

            internal bool Push(int data)
            {
                if (top >= MAX)
                {
                    Console.WriteLine("Stack Overflow.");
                    return false;
                }
                else
                {
                    stack[++top] = data;
                    return true;
                }
            }
            internal int Pop()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return 0;
                }
                else
                {
                    int value = stack[top--];
                    return value;
                }
            }
            internal void Peek()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine($"The top element of the Stack is: {10}", stack[top]);
                }
            }
            internal void PrintStack()
            {
                if (top < 0)
                {
                    Console.WriteLine("Stack Underflow");
                    return;
                }
                else
                {
                    Console.WriteLine("Items in the Stack are:");
                    for (int i = top; i >= 0; i--)
                    {
                        Console.WriteLine(stack[i]);
                    }
                }
            }
        }

    }
}
