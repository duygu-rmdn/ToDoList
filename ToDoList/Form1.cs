using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkButton_Click(object sender, EventArgs e)//checkButton e imeto na butona "check"
        {
            if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked && checkBox6.Checked)
            {
                label1.Text = ("Done!");
            }
            else
            {
                label1.Text = ("Not done!");
            }

            if (checkBox7.Checked && checkBox8.Checked && checkBox9.Checked && checkBox10.Checked && checkBox11.Checked && checkBox12.Checked)
            {
                label2.Text = ("Done!");
            }
            else
            {
                label2.Text = ("Not done!");
            }

            if (checkBox13.Checked && checkBox14.Checked && checkBox15.Checked && checkBox16.Checked && checkBox17.Checked && checkBox18.Checked)
            {
                label3.Text = ("Done!");
            }
            else
            {
                label3.Text = ("Not done!");
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
