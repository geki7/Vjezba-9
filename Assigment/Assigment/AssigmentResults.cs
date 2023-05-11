using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment
{
    public partial class AssigmentResults : Form
    {
        public AssigmentResults()
        {
            InitializeComponent();
        }

        private void AssigmentResults_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private Object GetStatus()
        {
            using (var context = new EF_DBEntities())
            {
                return context.AssignmentStatuses.ToList();
            }
        }

        private void Osvjezi()
        {
            dgvStatus.DataSource = GetStatus();
            dgvStatus.Columns["Assignments"].Visible = false;
            showAssigments(dgvStatus.CurrentRow.DataBoundItem as AssignmentStatus);
        }

        private void showAssigments(AssignmentStatus status)
        {
            List<Assignment> rezultati;
            using(var context = new EF_DBEntities())
            {
                context.AssignmentStatuses.Attach(status);
                rezultati = status.Assignments.ToList();
            }
            dgvAssigments.DataSource = rezultati;
        }

        private void dgvStatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AssignmentStatus odabraniStatus = dgvStatus.CurrentRow.DataBoundItem as AssignmentStatus;
            if (odabraniStatus != null)
            {
                showAssigments(odabraniStatus);
            }
        }

        private AssignmentStatus status;

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(var context = new EF_DBEntities())
            {
                string student = txtbStudent.Text;
                string description = txtDescription.Text;
                int points = int.Parse(txtPoints.Text);
                status = dgvStatus.CurrentRow.DataBoundItem as AssignmentStatus;
                context.AssignmentStatuses.Attach(status);

                Assignment assignment = new Assignment
                {
                    Student = student,
                    Description = description,
                    Points = points,
                    AssignmentStatus = status
                };
                context.Assignments.Add(assignment);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Assignment assignment = dgvAssigments.CurrentRow.DataBoundItem as Assignment;
            using(var context = new EF_DBEntities())
            {
                context.Assignments.Attach(assignment);
                context.Assignments.Remove(assignment);
                context.SaveChanges();
            }
            Osvjezi();
        }
    }
}
