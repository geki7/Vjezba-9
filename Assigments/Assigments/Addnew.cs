using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigments
{
    public partial class FrmAddNew : Form
    {
        public FrmAddNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using(var context = new EF_DBEntities())
            {
                string studetn = txtStudent.Text;
                string description = txtDescription.Text;
                int points = int.Parse(txtPoints.Text);
                AssignmentStatus status = cmbStatus.SelectedItem as AssignmentStatus;
                context.AssignmentStatuses.Attach(status);

                Assignment dodajNovi = new Assignment
                {
                    Student = studetn,
                    Description = description,
                    Points = points,
                    AssignmentStatus = status
                };
                context.Assignments.Add(dodajNovi);
                context.SaveChanges();
            }
            Close();
        }

        private void FrmAddNew_Load(object sender, EventArgs e)
        {
            FillStatus();
        }

        private void FillStatus()
        {
            List<AssignmentStatus> status;
            using (var context = new EF_DBEntities())
            {
                status = context.AssignmentStatuses.ToList();
            }
            cmbStatus.DataSource = status;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
