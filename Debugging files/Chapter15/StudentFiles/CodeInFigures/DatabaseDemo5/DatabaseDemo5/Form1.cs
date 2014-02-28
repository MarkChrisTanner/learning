using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseDemo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Add("GPA   LastName");
            var students =
               from s in this.cartmanCollegeDataSet.tblStudents
               orderby s.GradePointAverage
               select s;
            foreach (var s in students)
                outputListBox.Items.Add(" " + s.GradePointAverage + "   " +
                   s.LastName);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cartmanCollegeDataSet.tblStudents' table. You can move, or remove it, as needed.
            this.tblStudentsTableAdapter.Fill(this.cartmanCollegeDataSet.tblStudents);

        }
    }
}
