using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Products
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddProducts form  = new frmAddProducts();    
            form.ShowDialog();
            Osvjezi();
        }

        private Object showProdcuts()
        {
            using(var context = new EF_DBEntities())
            {
                return context.Products.ToList();
            }
        }

        private void Osvjezi()
        {
            dgvProducts.DataSource = showProdcuts();
            dgvProducts.Columns["Category"].Visible = false;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Product brisanjeProduct = dgvProducts.CurrentRow.DataBoundItem as Product;
            using(var context = new EF_DBEntities())
            {
                context.Products.Attach(brisanjeProduct);
                context.Products.Remove(brisanjeProduct);
                context.SaveChanges();
            }
            Osvjezi();
        }
    }
}
