namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 16;
        private T[] collection;

        public Stack(int capacity = InitialCapacity)
        {
            this.collection = new T[capacity];
        }

        public int Capacity { get => this.collection.Length; }

        public int Count { get; set; }

        public void Push(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Resize();
            }
            this.collection[this.Count] = element;
            this.Count++;
        }

        private void Resize()
        {
            var newCollection = new T[2 * this.Capacity];
            Array.Copy(this.collection, newCollection, this.Count);
            this.collection = newCollection;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            var temp = this.collection[this.Count];
            this.Count--;
            return temp;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
