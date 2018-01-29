using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 28273354967115112;
            foreach (int i in new int[] { 0, 1, 2, 2, 3, 4, 3, 5, 2, 6 })
            Console.Write((char)((a >> (i * 8)) & 255));
            Console.Read();
        }
    }
}
