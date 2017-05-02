using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SequenceWithQueue
{
    public class Program
    {
        public static void Main()
        {
            var startNumber = long.Parse(Console.ReadLine());
            var dequeCount = 50;
            var queue = new Queue<long>();
            queue.Enqueue(startNumber);

            for (int i = 0; i < dequeCount; i++)
            {
                var followingNumber = queue.Dequeue();
                Console.Write( followingNumber + " ");

                queue.Enqueue(followingNumber + 1);
                queue.Enqueue(2 * followingNumber + 1);
                queue.Enqueue(followingNumber + 2);
            }
        }
    }
}
