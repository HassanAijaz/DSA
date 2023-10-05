using System.Xml.Linq;

namespace LinkedListDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedList linkedList = new();
            Node? head, tail;
            head = linkedList.GetHead();
            tail = linkedList.GetTail();
            if (head != null)
            {
                Console.WriteLine("head: " + head.value);
            }
            if (tail != null)
            {
                Console.WriteLine("tail: " + tail.value);
            }
            Console.WriteLine("len: " + linkedList.Length());
            linkedList.Prepend(012);
            linkedList.Prepend(-9);
            linkedList.Prepend(-1232);
            linkedList.Append(11);
            linkedList.Append(22);
            linkedList.Append(33);
            linkedList.Append(44);
            linkedList.Append(55);
            Console.WriteLine("Get:" + linkedList.Get(5)?.value);
            Console.WriteLine("Set:" + linkedList.Set(5, -1231231)?.value);
            Console.WriteLine("Get:" + linkedList.Get(5)?.value);
            linkedList.Insert(5, 120);
            Console.WriteLine("Remove:" + linkedList.Remove(5)?.value);


            //int? value = linkedList.RemoveFirst()?.value;
            //Console.WriteLine("Remove first node: "+value);
            Console.WriteLine("Before the reverse");
            linkedList.PrintLinkedList();

            head = linkedList.GetHead();
            tail = linkedList.GetTail();
            Console.WriteLine("len: " + linkedList.Length());
            if (head != null)
            {
                Console.WriteLine("head: " + head.value);
            }
            if (tail != null)
            {
                Console.WriteLine("tail: " + tail.value);
            }
            Console.WriteLine("After the reverse");
            linkedList.Reverse();
            linkedList.PrintLinkedList();

            head = linkedList.GetHead();
            tail = linkedList.GetTail();
            Console.WriteLine("len: " + linkedList.Length());
            if (head != null)
            {
                Console.WriteLine("head: " + head.value);
            }
            if (tail != null)
            {
                Console.WriteLine("tail: " + tail.value);
            }
        }
    }
}