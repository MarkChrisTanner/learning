﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseDemo6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartmanCollegeDataSet.tblStudents' table. You can move, or remove it, as needed.
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet.tblStudents);

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            var stus = from s in cartmanCollegeDataSet.tblStudents
                       group s by (int)s.GradePointAverage;

            foreach (var groupByGpa in stus)
            {
                outputListBox.Items.Add("GPA: " + groupByGpa.Key);
                foreach (var s in groupByGpa)
                    outputListBox.Items.Add("  " + s.GradePointAverage +
                       "  " + s.LastName);
            }

        }
    }
}
