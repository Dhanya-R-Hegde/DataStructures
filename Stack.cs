using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Stack
    {
        Node top;

        public Stack() 
        {
            top = null;
        }

        public void pushData(int data)
        {
            Node nodeObj = new Node(data);
            nodeObj.Next = top;
            top = nodeObj;
            Console.WriteLine("{0} is inserted into the stack", data);
        }

        public void popData()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("{0} is deleted from the stack", top.data);
                top = top.Next;
            }

        }

        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                Console.Write("Peek ---> ");
                while(temp != null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.Next;
                }
                Console.WriteLine();
            }
        }
    }
}
