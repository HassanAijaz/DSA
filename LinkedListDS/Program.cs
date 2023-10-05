using System.Xml.Linq;

namespace LinkedListDS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var linkedList = new LinkedList<string>();
            var head = linkedList.GetHead();
            var tail = linkedList.GetTail();
            if (head != null)
            {
                Console.WriteLine("head: " + head.value);
            }
            if (tail != null)
            {
                Console.WriteLine("tail: " + tail.value);
            }
            Console.WriteLine("len: " + linkedList.Length());
            linkedList.Prepend("1");
            linkedList.Prepend("2");
            linkedList.Prepend("3");
            linkedList.Append("4");
            linkedList.Append("5");
            linkedList.Append("6");
            linkedList.Append("7");
            linkedList.Append("8");
            Console.WriteLine("Get:" + linkedList.Get(5)?.value);
            Console.WriteLine("Set:" + linkedList.Set(5, "asdasdasdasdasdasd")?.value);
            Console.WriteLine("Get:" + linkedList.Get(5)?.value);
            linkedList.Insert(5, "120");
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