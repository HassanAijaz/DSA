namespace LinkedListDS
{
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

            if (head is not null && tail is not null)
            {
                Node temp = head;
                head = head.next;
                return temp;
            }
            return null;
        }
        public Node? Get(int index)
        {
            if (index < 0 || index >= length)
            {
                return null;
            }
            var temp = head;
            for (int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            return temp;
        }
        public Node? Set(int index, int value)
        {
            if (index < 0 || index >= length) { return null; }
            var node = Get(index);
            if (node == null) return null;
            node.value = value;
            return node;
        }
        public bool Insert(int index, int value)
        {
            if (index < 0 || index > length)
            {
                return false;
            }
            if (index == 0)
            {
                Prepend(value);
                return true;
            }
            if (index == length)
            {
                Append(value);
                return true;
            }
            Node node = new Node(value);
            var temp = Get(index - 1);
            if (temp == null) return false;
            node.next = temp.next;
            temp.next = node;
            length++;
            return true;
        }
        public Node? Remove(int index)
        {
            if (index < 0 || index >= length) { return null; }
            if (index == 0)
            {
                return RemoveFirst();
            }
            if (index == length - 1)
            {
                return RemoveLast();
            }
            var prevNode = Get(index - 1);
            var nodeToRemove = prevNode != null ? prevNode.next : null;
            if (prevNode == null || nodeToRemove == null) return null;
            //0 1 2 3 4 5
            prevNode.next = nodeToRemove.next;
            nodeToRemove.next = null;
            length--;
            return nodeToRemove;
        }
        public void Reverse()
        {
            Node? temp = head;
            head = tail;
            tail = temp;
            Node? after = temp?.next;
            Node? before = null;
            for (int i = 0; i < length; i++)
            {
                after = temp.next;
                temp.next = before;
                before = temp;
                temp = after;
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
}