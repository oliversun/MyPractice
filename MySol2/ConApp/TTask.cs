using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConApp
{
    public class TTask
    {
        public static void TMain()
        {
            Console.WriteLine("TMain Begin");

            List<int> lstResult = new List<int>();
            Task<List<int>>[] ArryTasks = new Task<List<int>>[2];
            ArryTasks[0] = Task<List<int>>.Factory.StartNew(() => {  Thread.Sleep(3000); return null; });
            ArryTasks[1] = Task<List<int>>.Factory.StartNew(() => { Thread.Sleep(6000); return new List<int>() { 4 }; });
            Task.WaitAll(ArryTasks, 10000);
            lstResult.AddRange(ArryTasks[0].Result);
            lstResult.AddRange(ArryTasks[1].Result);

            Console.WriteLine("TMain End");
            foreach (var item in lstResult)
            {
                Console.WriteLine(item);
            }



        }
        public static List<int> DoWork1()
        {
            try
            {
                Console.WriteLine("DoWork1 Begin");
                Thread.Sleep(2000);
                throw new Exception();
                Console.WriteLine("DoWork1 End");
                return new List<int>() { 1 };
            }
            catch (Exception ex)
            {
                return new List<int>();
            }

        }
        public static List<int> DoWork2()
        {
            Console.WriteLine("DoWork2 Begin");
            Thread.Sleep(3000);
            Console.WriteLine("DoWork2 End");
            return new List<int>() { 2 };

        }

       
    }

}
