namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args) 
        {

            //Linked List

            //UC1
            //LinkedList<int> list1 = new LinkedList<int>();
            //list1.AddFirst(30);
            //list1.AddFirst(56);
            //list1.AddLast(70);

            //foreach (int data in list1)
            //{
            //    Console.Write(data + " ");
            //}

            //UC2
            //LinkedList list2 = new LinkedList();
            //list2.AddNodeFirst(70);
            //list2.AddNodeFirst(36);
            //list2.AddNodeFirst(56);
            //list2.Display();

            //UC3
            //LinkedList list3 = new LinkedList();
            //list3.AddNodeFirst(56);
            //list3.AddNodeLast(30);
            //list3.AddNodeLast(70);
            //list3.Display();

            //UC4
            //LinkedList list4 = new LinkedList();
            //list4.AddNodeFirst(56);
            //list4.AddNodeLast(70);
            //list4.InsertBetween(30, 2);
            //list4.Display();

            //UC5
            //LinkedList list5 = new LinkedList();
            //list5.AddNodeFirst(56);
            //list5.AddNodeLast(70);
            //list5.InsertBetween(30, 2);
            //list5.DeleteFirst();
            //list5.Display();

            //UC6
            //LinkedList list6 = new LinkedList();
            //list6.AddNodeFirst(56);
            //list6.AddNodeLast(70);
            //list6.InsertBetween(30, 2);
            //list6.DeleteLast();
            //list6.Display();

            //UC7
            //LinkedList list7 = new LinkedList();
            //list7.AddNodeFirst(56);
            //list7.AddNodeLast(70);
            //list7.InsertBetween(30, 2);
            //list7.Display();
            //if(list7.SearchElement(30) > -1)
            //{
            //    Console.WriteLine("The element is found at index = " + list7.SearchElement(30));
            //}
            //else
            //{
            //    Console.WriteLine("The element is not found in the LinkedList");
            //}

            //UC8
            //LinkedList list8 = new LinkedList();
            //list8.AddNodeLast(56);
            //list8.AddNodeLast(30);
            //list8.AddNodeLast(70);
            //list8.InsertAfter(40, 30);
            //list8.Display();

            //UC9
            //LinkedList list9 = new LinkedList();
            //list9.AddNodeLast(56);
            //list9.AddNodeLast(30);
            //list9.AddNodeLast(70);
            //list9.InsertAfter(40, 30);
            //list9.Display();
            //list9.DeleteNode(40);
            //list9.Display();


            //Queue

            //UC1
            //Queue queue = new Queue();
            //queue.enqueueData(5);
            //queue.enqueueData(6);
            //queue.enqueueData(7);
            //queue.enqueueData(8);
            //queue.Display();

            //UC2

            //queue.dequeueData();
            //queue.Display();

   
            
            
            //Stack

            //UC1
            Stack stack = new Stack();
            stack.pushData(1);
            stack.pushData(2);
            stack.pushData(3);
            stack.pushData(4);
            stack.Display();

            //UC2
            stack.popData();
            stack.Display();


        }
    }
}
