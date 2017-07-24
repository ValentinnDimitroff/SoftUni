namespace _06.Strategy_Pattern.Comparators
{
    using System.Collections.Generic;

    public class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length.CompareTo(y.Name.Length);
            if (result == 0)
            {
                char xLetter = char.ToLower(x.Name[0]);
                char yLetter = char.ToLower(y.Name[0]);
                result = xLetter.CompareTo(yLetter);
            }

            return result;
        }
    }
}
