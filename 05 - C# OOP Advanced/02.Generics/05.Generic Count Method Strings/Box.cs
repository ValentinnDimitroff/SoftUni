namespace _05.Generic_Count_Method_Strings
{
    using System;
    public class Box<T> : IComparable<Box<T>> where T : IComparable
    {
        public Box(T value)
        {
            this.Value = value;
        }
        public T Value { get; set; }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }

        public int CompareTo(Box<T> otherBox)
        {
            return this.Value.CompareTo(otherBox.Value);
        }
    }
}
