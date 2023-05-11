using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanovniciHrvatske
{
    public partial class Sensors : Form
    {
        Sensor sensor = new Sensor();

        public Sensors()
        {
            InitializeComponent();
        }

        private void Stanovnici_Load(object sender, EventArgs e)
        {
            dgvSensors.DataSource = GetProjects();
            dgvSensors.Columns["SensorType"].Visible = false;
            dgvSensors.Columns["MeasurementUnit"].Visible = false;
            dgvSensors.Columns["SensorReadings"].Visible = false;
        }

        private void RefreshGUI()
        {
            dgvSensors.DataSource = GetProjects();
            dgvSensors.Columns["SensorType"].Visible = false;
            dgvSensors.Columns["MeasurementUnit"].Visible = false;
            dgvSensors.Columns["SensorReadings"].Visible = false;
        }

        private object GetProjects()
        {
            using (var context = new DB_EntityEntities())
            {
                return context.Sensors.ToList();
            }
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            AddSensor form = new AddSensor();
            form.ShowDialog();
            RefreshGUI();
        }

        private void btnDeleteSenosr_Click(object sender, EventArgs e)
        {
            Sensor senzor = senzori();
            using (var context = new DB_EntityEntities())
            {
                context.Sensors.Attach(senzor);
                context.Sensors.Remove(senzor);

                context.SaveChanges();
            }
            RefreshGUI();
        }

        private Sensor senzori()
        {
            return dgvSensors.CurrentRow.DataBoundItem as Sensor;
        }
    }
}
