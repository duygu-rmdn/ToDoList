using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ToDoList
{
    public partial class toDoApp : Form
    {
        public toDoApp()
        {
            InitializeComponent();
        }

        string[] todosDaily = new string[10];
        string[] todosNotUrgent = new string[10];
        string[] todosWeekly = new string[10];
        int d = 0; int u = 0; int w = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//close
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)//weeklyInsert
        {
            if (textBox1.Text.Trim() != "")
            {
                checkedListBox2.Items.Add(textBox1.Text.Trim());
            }

            textBox1.Clear();
        }

        private void dailyInsert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                checkedListBox1.Items.Add(textBox1.Text.Trim());
            }
            
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)//notUrgInsert
        {
            if (textBox1.Text.Trim() != "")
            {
                checkedListBox3.Items.Add(textBox1.Text.Trim());
            }

            textBox1.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toDoApp_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            for (int i = checkedListBox2.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    checkedListBox2.Items.Remove(checkedListBox2.Items[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    checkedListBox1.Items.Remove(checkedListBox1.Items[i]);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = checkedListBox3.Items.Count - 1; i >= 0; i--)
            {
                if (checkedListBox3.GetItemChecked(i))
                {
                    checkedListBox3.Items.Remove(checkedListBox3.Items[i]);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
