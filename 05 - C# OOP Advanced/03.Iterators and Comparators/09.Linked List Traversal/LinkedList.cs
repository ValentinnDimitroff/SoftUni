namespace _09.Linked_List_Traversal
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void Add(T element)
        {
            Node newNode = new Node(element);
            if (this.IsEmpty())
            {
                this.Head = newNode;
                this.Count++;
                return;
            }

            if (this.Tail == null)
            {
                this.Tail = newNode;
                this.Head.Next = this.Tail;
                this.Count++;
                return;
            }

            this.Tail.Next = newNode;
            this.Tail = newNode;
            this.Count++;
        }

        public void Remove(T element)
        {
            if (this.IsEmpty())
            {
                return;
            }

            if (this.Head.Value.CompareTo(element) == 0)
            {
                this.Head = this.Head.Next;
                this.Count--;
                return;
            }

            Node currentNode = this.Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Next.Value.CompareTo(element) == 0)
                {
                    if (this.Tail == currentNode.Next)
                    {
                        this.Tail = currentNode;
                        this.Tail.Next = null;
                    }
                    else
                    {
                        currentNode.Next = currentNode.Next.Next;
                    }
                    this.Count--;
                    break;
                }
                currentNode = currentNode.Next;
            }

        }

        private bool IsEmpty()
        {
            return this.Head == null;
        }

        public class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }
            public T Value { get; set; }
            public Node Next { get; set; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node currentNode = this.Head;
            for (int i = 0; i < this.Count; i++)
            {
                yield return currentNode.Value;
                currentNode = currentNode.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}