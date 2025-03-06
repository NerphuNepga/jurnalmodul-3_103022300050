using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul_3_103022300050
{
    public partial class Form1 : Form
    {
        public int left_num;
        public int right_num;
        public int[] arr_num = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
        public int hasil;
        public int n = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + button0.Text;
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            left_num = int.Parse(labelOutput.Text);
            arr_num[n] = left_num;
            n++;
            labelOutput.Text = "";
        }

        private void button_equ_Click(object sender, EventArgs e)
        {
            right_num = int.Parse(labelOutput.Text);
            for (int i = 0; i < arr_num.Length; i++)
            {
                hasil = hasil + arr_num[i];
            }
            hasil = hasil + right_num;
            labelOutput.Text = hasil.ToString();
        }
    }
}
