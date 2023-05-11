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
    public partial class Assigments : Form
    {
        public Assigments()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddNew form = new FrmAddNew();
            form.ShowDialog();
            Osvjezi();
        }

        private object showAssigments()
        {
            using(var context = new EF_DBEntities())
            {
                return context.Assignments.ToList();
            }
        }

        private void Osvjezi()
        {
            dgvAssigments.DataSource = showAssigments();
            dgvAssigments.Columns["AssignmentStatus"].Visible = false;

        }

        private void Assigments_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Assignment assignment = dgvAssigments.CurrentRow.DataBoundItem as Assignment;
            using (var context = new EF_DBEntities())
            {
                context.Assignments.Attach(assignment);
                context.Assignments.Remove(assignment);
                context.SaveChanges();
            }
            Osvjezi();
        }
    }
}
