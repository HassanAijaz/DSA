namespace LinkedListDS
{
    public class LinkedList<T>
    {
        Node<T>? head;
        Node<T>? tail;
        private int length;
        public LinkedList()
        {
            head = null;
            tail = null;
            length = 0;
        }
        public Node<T>? GetHead()
        {
            return head;
        }
        public Node<T>? GetTail()
        {
            return tail;
        }
        public int Length()
        {
            return length;
        }
        public void PrintLinkedList()
        {
            Node<T>? temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.value);
                temp = temp.next;
            }
        }
        public void Append(T value)
        {
            //Check if we got any item in our linked list. if not we create a new node and point head and tail to new node.
            Node<T> node = new(value);
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
        public void Prepend(T value)
        {
            Node<T> node = new(value);
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
        public Node<T>? RemoveLast()
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
                Node<T> temp = head;
                Node<T> pre = head;
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
        public Node<T>? RemoveFirst()
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
                Node<T> temp = head;
                head = head.next;
                return temp;
            }
            return null;
        }
        public Node<T>? Get(int index)
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
        public Node<T>? Set(int index, T value)
        {
            if (index < 0 || index >= length) { return null; }
            var node = Get(index);
            if (node == null) return null;
            node.value = value;
            return node;
        }
        public bool Insert(int index, T value)
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
            Node<T> node = new (value);
            var temp = Get(index - 1);
            if (temp == null) return false;
            node.next = temp.next;
            temp.next = node;
            length++;
            return true;
        }
        public Node<T>? Remove(int index)
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
            var nodeToRemove = prevNode?.next;
            if (prevNode == null || nodeToRemove == null) return null;
            //0 1 2 3 4 5
            prevNode.next = nodeToRemove.next;
            nodeToRemove.next = null;
            length--;
            return nodeToRemove;
        }
        public void Reverse()
        {
            Node<T>? temp = head;
            head = tail;
            tail = temp;
            _ = temp?.next;
            Node<T>? before = null;
            for (int i = 0; i < length; i++)
            {
                Node<T>? after = temp.next;
                temp.next = before;
                before = temp;
                temp = after;
            }


        }
    }
    public class Node<TValue>
    {
        public TValue value;
        public Node<TValue>? next;
        public Node(TValue value)
        {
            this.value = value;
        }
    }
}