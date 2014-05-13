using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DymaticCompiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var i = 32;
            textBox1.Text = @" 
            using System;
            using System.Collections.Generic;
            using System.Text;
            using System.Linq;

             public class MyClass
            {
                public string GetResult()
                {





                    return 0;
                }
            }";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodeCompiler.Compile(new string[] { }, textBox1.Text, "");
            listBox1.Items.Clear();
            foreach (string s in CodeCompiler.ErrorMessage)
            {
                listBox1.Items.Add(s);
            }
            listBox1.Items.Add(CodeCompiler.Message);
        }

    }
}

