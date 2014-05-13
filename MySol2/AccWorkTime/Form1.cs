using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AccWorkTime
{
    public partial class CtripWorkTime : Form
    {
        public CtripWorkTime()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strPath = @"09:35~22:10 
无 
 6 
10:33~17:25 
无 
 7 
09:31~23:13 
无
11:40~22:00
 ";
            strPath = txtInput.Text.Trim();

            string[] arrsstr =strPath.Replace("\n",",").Split(new char[] { ',' });
            int iTHours = 0;
            int iTMinutes = 0;
            int idays=0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arrsstr.Length; i++)
            {
                if (arrsstr[i].Contains("~"))
                {

                    int dh1 = Convert.ToInt32(arrsstr[i].Split('~')[0].Split(new char[] { ':' })[0]);
                    int dm1 = Convert.ToInt32(arrsstr[i].Split('~')[0].Split(new char[] { ':' })[1]);
                    //double i1 = dh1 + dm1;
                    //double i1 =Convert.ToDouble( (dh1 + dm1).ToString("0.00"));


                    int dh2 = Convert.ToInt32(arrsstr[i].Split('~')[1].Split(new char[] { ':' })[0]);
                    int dm2 = Convert.ToInt32(arrsstr[i].Split('~')[1].Split(new char[] { ':' })[1]);
                    //double i2 = Convert.ToDouble((dh2 + dm2).ToString("0.00"));
                    //double i2 = dh2 + dm2;

                    if (dh1 >= 0 && dh1 < 7 && dh2 >= 0 && dh2 < 7)
                        continue;

                    if (dh1 <= 7)
                        dh1 = 7;
               
                    int iHours=0;
                    int iMinutes=0;
                    iHours=int.Parse((dh2 - dh1-1).ToString());
                    iMinutes=int.Parse((dm2 - dm1).ToString());

                    if (iMinutes<0)
                    {
                        iHours--;
                        iMinutes+=60;
                    }

                    //下班小时数超过20点扣30分钟吃饭时间
                    if (dh2 >= 20)
                    {
                        iMinutes -= 30;
                        if (iMinutes < 0)
                        {
                            iHours--;
                            iMinutes += 60;
                        }
                    }

                    sb.AppendFormat("{0}day,WorkFor:{1}H {2}M ", arrsstr[i - 1].Trim().PadLeft(2,'0'), iHours, iMinutes);
                    sb.Append(Environment.NewLine);

                    //一天的小时数
                    iTHours += iHours;
                    //一天的分钟数
                    iTMinutes += iMinutes;
                    //打卡次数
                    idays++;
                }
            }

            //总分钟数换算成小时数
            int ih = iTMinutes / 60;
            int im = iTMinutes % 60;

            iTHours += ih;

            //总小时数
            double dTotal=(iTHours+im/60D);

            sb.AppendFormat("总计：\r\n {0}", 
                string.Format("天数{0},合计{1}小时{2}分钟,即{3}小时，平均每天{4}小时,额外时长:{5}小时{6}分钟",
                idays, iTHours, im, (dTotal).ToString("0.00"), (dTotal / idays).ToString("0.00"), iTHours - (idays * 8), im
                ));

            label1.Text = sb.ToString();
        }

     
    }
}
