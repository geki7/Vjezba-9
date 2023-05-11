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
    public partial class AddSensor : Form
    {
        public AddSensor()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSensor_Load(object sender, EventArgs e)
        {
            FillType();
            FillUnit();
        }

        private void FillUnit()
        {
            List<MeasurementUnit> unit;
            using (var context = new DB_EntityEntities())
            {
                unit = context.MeasurementUnits.ToList();
            }
            cmbUnit.DataSource = unit;
        }

        private void FillType()
        {
            List<SensorType> type;
            using(var context = new DB_EntityEntities())
            {
                type = context.SensorTypes.ToList();
            }
            cmbType.DataSource = type;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new DB_EntityEntities())
            {
                string name = txbName.Text;
                SensorType senosr = cmbType.SelectedItem as SensorType;
                context.SensorTypes.Attach(senosr);
                MeasurementUnit unit = cmbUnit.SelectedItem as MeasurementUnit;
                context.MeasurementUnits.Attach(unit);

                Sensor sensor = new Sensor
                {
                    Name = name,
                    SensorType = senosr,
                    MeasurementUnit = unit
                };

                context.Sensors.Add(sensor);
                context.SaveChanges();
            }
            Close();
        }
    }
}
