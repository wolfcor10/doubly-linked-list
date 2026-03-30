namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Previous { get; set; }
            public Node Next { get; set; }
            public Node(T data)
            {
                Data = data;
            }
        }

        private Node? _head;
        private Node? _tail;
        private int _size;
        public int Size => _size;
        public bool IsEmpty => _size == 0;
        public void InsertHead(T value)
        {
            Node newNode = new Node(value);
            if (_head == null)
            {
                _head = _tail = newNode;
            }
            else
            {
                newNode.Next = _head;
                _head.Previous = newNode;
                _head = newNode;
            }
            _size++;
        }

        public void InsertTail(T value)
        {
            Node newNode = new Node(value);
            if (_tail == null)
            {
                _head = _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                newNode.Previous = _tail;
                _tail = newNode;
            }
            _size++;
        }

        public bool RemoveByValue(T value)
        {
            var current = _head;
            while (current != null)
            {
                if(EqualityComparer<T>.Default.Equals(current.Data, value))
                {
                    Unlink(current);
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        private void Unlink(Node current)
        {
            var prev = current.Previous;
            var next = current.Next;

            if (prev == null)
            {
                _head = next;
            }
            else
            {
                prev.Next = next;
            }

            if (next == null)
            {
                _tail = prev;
            }
            else
            {
                next.Previous = prev;
            }

            current.Previous = null;
            current.Next = null;

            _size--;

        }

        public void RemoveDuplicates()
        {
            var seen = new HashSet<T>();
            var current = _head;

            while(current != null)
            {
                var next = current.Next;
                if(!seen.Add(current.Data))
                {
                    Unlink(current);
                }
                current = next;
            }
        }

        public int Search(T value)
        {
            var current = _head;
            int index = 0;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1; // Not found
        }

        public override string ToString()
        {
            var values = new List<string>();
            var current = _head;
            while (current != null)
            {
                values.Add(current.Data?.ToString() ?? "null");
                current = current.Next;
            }
            return "["+string.Join(", ",values) +"]";
        }


    }
}
