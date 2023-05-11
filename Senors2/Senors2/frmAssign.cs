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
    public partial class frmAssign : Form
    {
        Sensor promjeniAsagminet;
        public frmAssign(Sensor sensor)
        {
            InitializeComponent();
            promjeniAsagminet = sensor;
        }

        private void frmAssign_Load(object sender, EventArgs e)
        {
            fillUnit();
        }

        private void fillUnit()
        {
            List<MeasurementUnit> unit;
            using(var context = new DB_EntityEntities())
            {
                unit = context.MeasurementUnits.ToList();
            }
            cmbUnit.DataSource = unit;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAssignUnit_Click(object sender, EventArgs e)
        {
            using(var context = new DB_EntityEntities())
            {
                context.Sensors.Attach(promjeniAsagminet);
                MeasurementUnit unit = cmbUnit.SelectedItem as MeasurementUnit;
                context.MeasurementUnits.Attach(unit);

                promjeniAsagminet.MeasurementUnit = unit;
                context.SaveChanges();
            }
            Close();
        }
    }
}
