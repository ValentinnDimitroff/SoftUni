namespace _04.Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake : IEnumerable<int>
    {
        private IList<int> listOfStones;

        public Lake(IEnumerable<int> collection)
        {
            this.listOfStones = new List<int>(collection);
        }

        public IEnumerator<int> GetEnumerator()
        {
            //for (int i = 1; i <= this.listOfStones.Count; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        yield return this.listOfStones[i - 1];
            //    }
            //}

            //for (int i = this.listOfStones.Count; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        yield return this.listOfStones[i - 1];
            //    }
            //}

            for (int i = 0; i < this.listOfStones.Count; i += 2)
            {
                yield return this.listOfStones[i];
            }

            int lastEvenPosition = this.listOfStones.Count % 2 == 0 
                ? this.listOfStones.Count - 1 
                : this.listOfStones.Count - 2;

            for (int i = lastEvenPosition; i > 0; i -= 2)
            {
                yield return this.listOfStones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}