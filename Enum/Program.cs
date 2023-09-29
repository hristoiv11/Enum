using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyFile file1 = new MyFile("picture.txt", @"C:\users\hivanov\",
                Rights.READABLE | Rights.WRITABLE,null);


            //Is file1 Readable

            Console.WriteLine((int)file1.FileRights);
        }
    }
}
