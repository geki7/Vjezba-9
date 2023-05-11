using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
            fillPriority();
        }

        private object showEmployee()
        {
            using(var context = new EF_DBEntities())
            {
                return context.Employees.ToList();
            }
        }

        private void Osvjezi()
        {
            dgvEmployee.DataSource = showEmployee();
            dgvEmployee.Columns["Tasks"].Visible = false;
        }

        private object showTasks(Employee odabraniEmployee)
        {
            using(var context = new EF_DBEntities())
            {
                return context.Tasks.ToList();
            }
        }

        private void dgvTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee odabraniEmployee = dgvEmployee.CurrentRow.DataBoundItem as Employee;
            if (odabraniEmployee != null)
            {
                showTasks(odabraniEmployee);
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            using(var context = new EF_DBEntities())
            {
                string fname = txtbFName.Text;
                string lname = txtbLName.Text;

                Employee dodajNovi = new Employee
                {
                    FirstName = fname,
                    LastName = lname
                };

                context.Employees.Add(dodajNovi);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Employee oborisiEmployee = dgvEmployee.CurrentRow.DataBoundItem as Employee;
            using(var context = new EF_DBEntities())
            {
                context.Employees.Attach(oborisiEmployee);
                context.Employees.Remove(oborisiEmployee);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void fillPriority()
        {
            List<Task> task; 
            using(var context = new EF_DBEntities())
            {
                task = context.Tasks.ToList();
            }
            cmbPriorty.DataSource = task;
        }
    }
}
