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
    public partial class frmAddSensor : Form
    {
        public frmAddSensor()
        {
            InitializeComponent();
        }

        private void frmAddSensor_Load(object sender, EventArgs e)
        {
            fillType();
        }

        private void fillType()
        {
            List<SensorType> type;
            using (var context = new DB_EntityEntities())
            {
                type = context.SensorTypes.ToList();
            }
            cmbType.DataSource = type;
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            using(var context = new DB_EntityEntities())
            {
                string name = txtbName.Text;
                SensorType type = cmbType.SelectedItem as SensorType;
                context.SensorTypes.Attach(type);

                Sensor addSensor = new Sensor
                {
                    Name = name,
                    SensorType = type,
                };
                context.Sensors.Add(addSensor);
                context.SaveChanges();
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
