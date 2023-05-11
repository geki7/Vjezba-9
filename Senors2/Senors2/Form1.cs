using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senors2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Sensor promjeniAssignment = dgvSenors.CurrentRow.DataBoundItem as Sensor;
            frmAssign formAssign = new frmAssign(promjeniAssignment);
            formAssign.ShowDialog();
            Osvjezi();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSensor frmAdd = new frmAddSensor();
            frmAdd.ShowDialog();
            Osvjezi();
        }

        private object showSensors()
        {
            using(var context = new DB_EntityEntities())
            {
                return context.Sensors.ToList();
            }
        }

        private void Osvjezi()
        {
            dgvSenors.DataSource = showSensors();
            dgvSenors.Columns["MeasurementUnit"].Visible = false;
            dgvSenors.Columns["SensorType"].Visible = false;
            dgvSenors.Columns["SensorReadings"].Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Sensor senzor = dgvSenors.CurrentRow.DataBoundItem as Sensor;
            using (var context = new DB_EntityEntities())
            {
                context.Sensors.Attach(senzor);
                context.Sensors.Remove(senzor);
                context.SaveChanges();
            }
            Osvjezi();
        }
    }
}
