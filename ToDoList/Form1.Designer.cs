﻿
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    partial class toDoApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dailyTasks = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weeklyTasks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notUrgent = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dailyInsert = new System.Windows.Forms.Button();
            this.weeklyInsert = new System.Windows.Forms.Button();
            this.notUrgInsert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.dailyTasks);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(33, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(228, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daily Tasks";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dailyTasks
            // 
            this.dailyTasks.BackColor = System.Drawing.Color.Pink;
            this.dailyTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dailyTasks.ForeColor = System.Drawing.Color.Navy;
            this.dailyTasks.FormattingEnabled = true;
            this.dailyTasks.HorizontalScrollbar = true;
            this.dailyTasks.ItemHeight = 16;
            this.dailyTasks.Location = new System.Drawing.Point(28, 23);
            this.dailyTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dailyTasks.Name = "dailyTasks";
            this.dailyTasks.Size = new System.Drawing.Size(169, 256);
            this.dailyTasks.TabIndex = 0;
            this.dailyTasks.SelectedIndexChanged += new System.EventHandler(this.dailyTasks_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.weeklyTasks);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(287, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(228, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekly Tasks";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // weeklyTasks
            // 
            this.weeklyTasks.BackColor = System.Drawing.Color.Pink;
            this.weeklyTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.weeklyTasks.ForeColor = System.Drawing.Color.Navy;
            this.weeklyTasks.FormattingEnabled = true;
            this.weeklyTasks.HorizontalScrollbar = true;
            this.weeklyTasks.ItemHeight = 16;
            this.weeklyTasks.Location = new System.Drawing.Point(29, 25);
            this.weeklyTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weeklyTasks.Name = "weeklyTasks";
            this.weeklyTasks.Size = new System.Drawing.Size(169, 256);
            this.weeklyTasks.TabIndex = 1;
            this.weeklyTasks.SelectedIndexChanged += new System.EventHandler(this.weeklyTasks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Pink;
            this.groupBox3.Controls.Add(this.notUrgent);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(544, 81);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(228, 295);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Not urgent ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // notUrgent
            // 
            this.notUrgent.BackColor = System.Drawing.Color.Pink;
            this.notUrgent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notUrgent.ForeColor = System.Drawing.Color.Navy;
            this.notUrgent.FormattingEnabled = true;
            this.notUrgent.HorizontalScrollbar = true;
            this.notUrgent.ItemHeight = 16;
            this.notUrgent.Location = new System.Drawing.Point(31, 23);
            this.notUrgent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notUrgent.Name = "notUrgent";
            this.notUrgent.Size = new System.Drawing.Size(169, 256);
            this.notUrgent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 305);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(677, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dailyInsert
            // 
            this.dailyInsert.BackColor = System.Drawing.Color.Pink;
            this.dailyInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyInsert.Location = new System.Drawing.Point(61, 382);
            this.dailyInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dailyInsert.Name = "dailyInsert";
            this.dailyInsert.Size = new System.Drawing.Size(129, 65);
            this.dailyInsert.TabIndex = 5;
            this.dailyInsert.Text = "Daily insert";
            this.dailyInsert.UseVisualStyleBackColor = false;
            this.dailyInsert.Click += new System.EventHandler(this.dailyInsert_Click);
            // 
            // weeklyInsert
            // 
            this.weeklyInsert.BackColor = System.Drawing.Color.Pink;
            this.weeklyInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weeklyInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyInsert.Location = new System.Drawing.Point(342, 382);
            this.weeklyInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.weeklyInsert.Name = "weeklyInsert";
            this.weeklyInsert.Size = new System.Drawing.Size(129, 59);
            this.weeklyInsert.TabIndex = 6;
            this.weeklyInsert.Text = "Weekly Tasks";
            this.weeklyInsert.UseVisualStyleBackColor = false;
            this.weeklyInsert.Click += new System.EventHandler(this.button3_Click);
            // 
            // notUrgInsert
            // 
            this.notUrgInsert.BackColor = System.Drawing.Color.Pink;
            this.notUrgInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notUrgInsert.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notUrgInsert.Location = new System.Drawing.Point(603, 382);
            this.notUrgInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.notUrgInsert.Name = "notUrgInsert";
            this.notUrgInsert.Size = new System.Drawing.Size(129, 59);
            this.notUrgInsert.TabIndex = 7;
            this.notUrgInsert.Text = "Not Urgent";
            this.notUrgInsert.UseVisualStyleBackColor = false;
            this.notUrgInsert.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(511, 30);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Pink;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(575, 21);
            this.Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(95, 32);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // toDoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(804, 460);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.dailyInsert);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.notUrgInsert);
            this.Controls.Add(this.weeklyInsert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "toDoApp";
            this.Text = "to-do app";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Button dailyInsert;
        private Button weeklyInsert;
        private Button notUrgInsert;
        private TextBox textBox1;
        private ListBox dailyTasks;
        private ListBox weeklyTasks;
        private ListBox notUrgent;
        private Button Clear;
    }
}

