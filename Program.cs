﻿namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //UC1
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddFirst(30);
            list1.AddFirst(56);
            list1.AddLast(70);

            foreach (int data in list1)
            {
                Console.Write(data + " ");
            }

            //UC2
            LinkedList list2 = new LinkedList();
            list2.AddNodeFirst(70);
            list2.AddNodeFirst(36);
            list2.AddNodeFirst(56);
            list2.Display();

            //UC3
            LinkedList list3 = new LinkedList();
            list3.AddNodeFirst(56);
            list3.AddNodeLast(30);
            list3.AddNodeLast(70);
            list3.Display();

            //UC4
            LinkedList list4 = new LinkedList();
            list4.AddNodeFirst(56);
            list4.AddNodeLast(70);
            list4.InsertBetween(30, 2);
            list4.Display();

            //UC5
            LinkedList list5 = new LinkedList();
            list5.AddNodeFirst(56);
            list5.AddNodeLast(70);
            list5.InsertBetween(30, 2);
            list5.DeleteFirst();
            list5.Display();

            //UC6
            LinkedList list6 = new LinkedList();
            list6.AddNodeFirst(56);
            list6.AddNodeLast(70);
            list6.InsertBetween(30, 2);
            list6.DeleteLast();
            list6.Display();

            //UC7
            LinkedList list7 = new LinkedList();
            list7.AddNodeFirst(56);
            list7.AddNodeLast(70);
            list7.InsertBetween(30, 2);
            list7.Display();
            if(list7.SearchElement(30) > -1)
            {
                Console.WriteLine("The element is found at index = " + list7.SearchElement(30));
            }
            else
            {
                Console.WriteLine("The element is not found in the LinkedList");
            }

            //UC8
            LinkedList list8 = new LinkedList();
            list8.AddNodeLast(56);
            list8.AddNodeLast(30);
            list8.AddNodeLast(70);
            list8.InsertAfter(40, 30);
            list8.Display();

        }
    }
}
