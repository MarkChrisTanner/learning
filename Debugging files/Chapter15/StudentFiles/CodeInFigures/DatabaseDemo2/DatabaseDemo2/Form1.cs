using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseDemo2
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
            const double CUTOFF = 3.0;
            this.tblStudentsTableAdapter.Fill
              (this.cartmanCollegeDataSet.tblStudents);
            var goodStudents =
                from s in this.cartmanCollegeDataSet.tblStudents
                where s.GradePointAverage > CUTOFF
                select s;
            foreach (var s in goodStudents)
                outputListBox.Items.Add(s.LastName);
        }
    }
}
