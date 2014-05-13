using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace ConApp
{
    public class ListTest
    {

        public static void Test()
        {
            List<User> lstU = new List<User>();
            lstU.Add(new User() { Age = 21, ID = 1 });
            lstU.Add(new User() { Age = 21, ID = 3 });
            lstU.Add(new User() { Age = 22, ID = 2 });

            List<User> lt = lstU.FindAll(x => x.Age == 21);

            List<User> lt1 = lstU.Where(x => x.Age == 21).ToList();

            //lstU=lstU.OrderBy(x => x.ID).ToList();

            //User sdf = lstU.OrderByDescending(x => x.ID).First();

            //lstU.RemoveAll(x => x.ID == 1);
            //lstU.RemoveAll(x => { return x.ID == 2; });

            List<User> lstU1 = new List<User>();
            lstU.Add(new User() { Age = 21, ID = 4 });
            lstU.Add(new User() { Age = 23, ID = 5 });
            lstU.Add(new User() { Age = 22, ID = 6 });

            lstU.Concat(lstU1);

        }


        /// <summary>
        /// 求交集
        /// </summary>
        public static void Performance()
        {
            Console.WriteLine("1");

            List<int> lstR = new List<int>();
            List<int> lstR1 = new List<int>();
            Random R = null;

            while (lstR.Count() < 100000)
            {
                R = new Random(DateTime.Now.Millisecond);
                lstR.Add(R.Next(0, 100));
            }


            while (lstR1.Count() < 100000)
            {
                R = new Random(DateTime.Now.Millisecond);
                lstR1.Add(R.Next(50, 150));
            }

            Console.WriteLine("lstR：" + lstR.Count().ToString());
            Console.WriteLine("lstR1：" + lstR1.Count().ToString());

            
            List<int> lTemp = new List<int>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            lTemp = lstR.AsParallel().Where(x => lstR1.Contains(x)).Distinct().ToList();
            
            sw.Stop();
            Console.WriteLine("lTemp：" + lTemp.Count);
            Console.WriteLine("Where 方式：" + sw.ElapsedMilliseconds.ToString());

            sw.Restart();
            lTemp = lstR.FindAll(x => lstR1.Contains(x)).Distinct().ToList();
            sw.Stop();
            Console.WriteLine("lTemp：" + lTemp.Count);
            Console.WriteLine("FindAll 方式：" + sw.ElapsedMilliseconds.ToString());

            sw.Restart();
            lTemp = lstR.Intersect(lstR1).ToList();
           
            sw.Stop();
            Console.WriteLine("lTemp：" + lTemp.Count);
            Console.WriteLine("Intersect 方式：" + sw.ElapsedMilliseconds.ToString());

        }

        ////查找1
        //public static void Performance1()
        //{
        //    List<int> lstR = new List<int>();
        //    Random R = null;
        //    while (lstR.Count() < 100000)
        //    {
        //        R = new Random(DateTime.Now.Millisecond);
        //        lstR.Add(R.Next(0, 100));
        //    }

        //    Hashtable Ht = new Hashtable();
        //    while (Ht.Count < 100000)
        //    {
        //        R = new Random(DateTime.Now.Millisecond);
        //        Ht.Add(Ht.Count, R);
        //    }

        //    Console.WriteLine("lstR:" + lstR.Count.ToString());
        //    Console.WriteLine("Ht:" + Ht.Count.ToString());

        //    lstR.AsParallel().Where(x => x == 1).ToString();
        //    Ht[]



        //}


           







    }

    public class User
    {
        public int ID { get; set; }
        public int Age { get; set; }
    }
}
