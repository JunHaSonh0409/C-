using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void Minuse_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            string str=textBox1.Text.ToString();
            int len = str.Length;
            if (textBox1.Text[--len] != '.')//길이를 1 뺴서 그게 점이 아닐때 점을 입력하는 예외처리 
                textBox1.Text += ".";
        }

        private void All_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Result_Click(object sender, EventArgs e)
        {   

            /*
             DataTable의 Compute메서드는 지정된 식을 계산한다.
             두번째 인자는 필터조건이며 본 예제에서는 필요없다.
             원래 DataTable에서 Compute는 필터 조건에 맞는 행을 추출한다.
             특정컬럼을 집계한다.SUM,AVG,MAX,MIN,COUNT등
             */
            try 
            { 
               DataTable dt= new DataTable();
                var a = dt.Compute(textBox1.Text, "");
                textBox1.Text=a.ToString();
            }
            catch(Exception e1) 
            {
              MessageBox.Show(e1.Message);
            }
        }
    }
}
