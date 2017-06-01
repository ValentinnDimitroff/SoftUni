using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Copy_Binary_File
{
    public class CopyBinaryFile
    {
        public static void Main()
        {
            using (var source = new FileStream("picture.jpg", FileMode.Open))
            {
                using (var destination = new FileStream("pic.jpg", FileMode.Create))
                {
                    var buffer = new byte[1024];
                    var readBytes = 1;
                    while (readBytes > 0)
                    {
                        readBytes = source.Read(buffer, 0, buffer.Length);
                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
            
            //using (var source = new BinaryReader("picture.jpg"))
            //{
                
            //}
        }
    }
}
