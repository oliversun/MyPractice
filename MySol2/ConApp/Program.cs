using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("ID", typeof(System.Int32));
            //dt.Columns.Add("Name", typeof(System.String));

            //DataRow dr;
            //for (int i = 0; i < 2; i++)
            //{
            //    dr = dt.NewRow();
            //    dr[0] = i;
            //    dr[1] = "name"+i;
            //    dt.Rows.Add(dr);
			 
            //}
            //List<User> myList = DataTableExtensions.ToList<User>(dt);
            //Console.WriteLine();
            //TPool.Test();
          // ListTest.Test();
            //TTask.TMain();

            //testc();

          //  TDESEN.En("D00016493");

            //PDF2Img.Test();
            //string cDate = "";
            //string strReturn = string.Empty;
            //if (!string.IsNullOrEmpty(cDate))
            //{
            //    DateTime dt;
            //    if (DateTime.TryParse(cDate, out dt))
            //        strReturn = dt.ToString("yyyy-MM-dd");
            //    else
            //        strReturn = cDate;
            //}
           

            //Console.WriteLine(strReturn);

            //ListTest.Performance();


            Console.Read();

        }

        private static void testc()
        {
            Dictionary<string, int> dt = new Dictionary<string, int>();
            dt.Add("a", 2);
            int b = dt.Keys.Contains("a") ? dt["a"] : 0;
            int c = dt.Keys.Contains("b") ? dt["b"] : 0;

        }

        public class User
        {
            public int ID { set; get; }
            public string Name { get; set; }
        }
    }
}
