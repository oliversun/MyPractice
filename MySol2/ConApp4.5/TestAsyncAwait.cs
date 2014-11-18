using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp4._5
{
    public class TestAsyncAwait
    {
        public async void DoWork()
        {
            Console.WriteLine("DoWork Begin");
           int x=await fsdfAsync();
            Console.WriteLine("DoWork End");
        }

        async Task<int> fsdfAsync()
        {
            Console.WriteLine("fsdfAsync Begin1");
            var y1 = Task.Delay(10000);
            Console.WriteLine("fsdfAsync End1");

            Console.WriteLine("fsdfAsync Begin2");

            var y2 = Task.Delay(1000);
            Console.WriteLine("fsdfAsync End2");

            Console.WriteLine("fsdfAsync Begin3");
            var y3 = Task.Delay(50000);
            Console.WriteLine("fsdfAsync End3");

            await y1;
            await y2;
            await y3;
            return 1;


        }
    }
}
