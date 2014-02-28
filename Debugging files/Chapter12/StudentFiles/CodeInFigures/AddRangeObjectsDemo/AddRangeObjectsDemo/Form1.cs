using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddRangeObjectsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmp = new Employee("", 0);
            selectedEmp = (Employee)listBox1.SelectedItem;
            outputLabel.Text = selectedEmp.LastName + "'s salary is $" +
                selectedEmp.Salary;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee emp1 = new Employee("Anderson", 25000);
            Employee emp2 = new Employee("Brown", 36000);
            Employee emp3 = new Employee("Crenshaw", 45000);
            listBox1.Items.AddRange(new Employee[] {emp1, emp2, emp3});
        }
    }
    class Employee
    {
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Employee(string name, double sal)
        {
               LastName = name;
               Salary = sal;
        }
        public override string ToString()
        {
            return LastName;
        }
    }
}
