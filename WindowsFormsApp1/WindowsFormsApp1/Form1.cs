using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String A;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            A =richTextBox1.Text;

            if (checkBox1.Checked == true)
            {
                A = "國文"+A;
                MessageBox.Show(A);
            }
            else if (checkBox2.Checked == true)
            {
                A = "數學"+A;
                MessageBox.Show(A);

            }
            else if (checkBox3.Checked == true)
            {
                A = "英文"+A;
                MessageBox.Show(A);
            }

            StreamWriter sw = new StreamWriter(@"study_plan.txt");
            sw.WriteLine(A);             
            sw.Close();

            //  this.Visible = false; 
           // f.Visible = true; 
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"study_plan.txt");
            while (!sr.EndOfStream)
            {                                  // 每次讀取一行，直到檔尾
                A = sr.ReadLine();            // 讀取文字到 line 變數
            }
            MessageBox.Show(A);
            sr.Close(); 

        }
    }
}
