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
            linkedList.Append(1);
            linkedList.Append(2);
            linkedList.Append(3);
            linkedList.Append(4);
            linkedList.Append(5);
            linkedList.Prepend(0);
            linkedList.Prepend(-1);
            linkedList.Prepend(-2);

            int? value = linkedList.RemoveFirst()?.value;
            Console.WriteLine("Remove first node: "+value);
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
    public class Node
    {
        public int value;
        public Node? next;
        public Node(int value)
        {
            this.value = value;
        }
    }
    public class LinkedList
    {
        Node? head;
        Node? tail;
        private int length;


        public LinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public Node? GetHead()
        {
            return head;
        }

        public Node? GetTail()
        {
            return tail;
        }

        public int Length()
        {
            return length;
        }

        public void PrintLinkedList()
        {
            Node? temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }

        public void Append(int value)
        {
            //Check if we got any item in our linked list. if not we create a new node and point head and tail to new node.
            Node node = new(value);
            if (length == 0) // linked list is empty
            {
                head = node;
                tail = node;
                length++;
                return;
            }

            //If link list is not empty then append a item at the end and change the pointer of the tail to new node.
            if (tail != null)
            {
                tail.next = node;
                tail = node;
                length++;
                return;
            }
        }

        public void Prepend(int value)
        {
            Node node = new(value);
            //Check if we got any item in our linked list. if not we create a new node and point head and head to new node.
            if (length == 0) // linked list is empty
            {
                head = node;
                tail = node;
                length++;
                return;
            }
            node.next = head;
            head = node;
            length++;
        }

        public Node? RemoveLast()
        {
            if (length == 0) // linked list is empty
            {
                return null;
            }

            if (head == tail)
            {
                head = null;
                tail = null;
                length--;
                return null;
            }
            if (head is not null && tail is not null)
            {
                Node temp = head;
                Node pre = head;
                while (temp.next != null)
                {
                    pre = temp;
                    temp = temp.next;
                }
                tail = pre;
                tail.next = null;
                length--;
                return temp;
            }
            return null;
        }

        public Node? RemoveFirst()
        {
            if (length == 0)
            {
                return null;

            }

            if (head == tail)
            {
                length--;
                return null;
            }

            if(head is not null && tail is not null)
            {
                Node temp = head;
                head = head.next;
                return temp;
            }
            return null;
        }
    }
}