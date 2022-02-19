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
            weeklyTasks.Items.Add(textBox1.Text);

            textBox1.Clear();
        }

        private void dailyInsert_Click(object sender, EventArgs e)
        {
            dailyTasks.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)//notUrgInsert
        {
            notUrgent.Items.Add(textBox1.Text);

            textBox1.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dailyTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void weeklyTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dailyTasks.Items.Clear();
            weeklyTasks.Items.Clear();
            notUrgent.Items.Clear();
        }
    }
}
