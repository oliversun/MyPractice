using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace ConApp
{
    public class TPool
    {
        public static void Test()
        {
            try
            {
                int i1, i2;
                ThreadPool.GetMaxThreads(out i1, out i2);
                Console.WriteLine(i1);
                Console.WriteLine(i2);
                return;


                //WaitHandle[] arryWD = new WaitHandle[64];
                List<AutoResetEvent> lstARE = new List<AutoResetEvent>();
                DateTime dt = DateTime.Now;

                MyObj obk = new MyObj();
                for (int i = 0; i < 66; i++)
                {
                    lstARE.Add(new AutoResetEvent(false));
                    obk = new MyObj() { IData = i, waitHanle = lstARE[i] };
                    ThreadPool.QueueUserWorkItem(new WaitCallback(Work), obk);

                }

                Console.WriteLine("Main Thread Wait");

               // bool b = WaitHandle.WaitAll(arryWD, 10000);
                WaitAll(lstARE,50000);

                Console.WriteLine("Both task are completed ");
            }
            catch (Exception ex)
            {
                
                throw;
            }


        }

        private static void Work(object status)
        {
            //
            MyObj are = (MyObj)status;
            int i = are.IData;
            AutoResetEvent are1 = (AutoResetEvent)are.waitHanle;


            Thread.Sleep(10000);
            Console.WriteLine("Performing a task for {0} milliseconds.", i);


            are1.Set();
        }

        /// <summary>
        /// 线程等待同步
        /// </summary>
        /// <param name="lstARE"></param>
        /// <param name="TimeOutMilliSeconds">功耗时间毫秒</param>
        /// <returns></returns>
        public static long WaitAll(List<AutoResetEvent> lstARE,int TimeOutMilliSeconds)
        {
            long lTotal = 0;
            Stopwatch watcher=new Stopwatch ();
            watcher.Reset();
            bool bTimeOut = false;

            while (lstARE.Count > 0)
            {
                watcher.Restart();
                if (WaitHandle.WaitAll(lstARE.Take(64).ToArray(), TimeOutMilliSeconds))//一次等待64个句柄
                {
                    watcher.Stop();
                    lTotal += watcher.ElapsedMilliseconds;
                    if (lTotal < TimeOutMilliSeconds)
                    {
                        lstARE = lstARE.Skip(64).ToList();//跳过0-63共64个
                        continue;
                    }
                    else
                    {
                        watcher.Stop();
                        lTotal += watcher.ElapsedMilliseconds;
                        bTimeOut = true;
                        break;
                    }
                }
                else
                {
                    watcher.Stop();
                    lTotal += watcher.ElapsedMilliseconds;
                    bTimeOut = true;
                    break;
                }
            }
            return lTotal;
        }

    }


    public class MyObj
    {
        public WaitHandle waitHanle { get; set; }
        public int IData { get; set; }
    }

}
