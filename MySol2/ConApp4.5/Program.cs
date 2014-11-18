using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAsyncAwait obj = new TestAsyncAwait();
            obj.DoWork();
            Console.Read();
        }
    }
}
