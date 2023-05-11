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
    public partial class frmAddProducts : Form
    {
        public frmAddProducts()
        {
            InitializeComponent();
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            fillCategory();
        }

        private void fillCategory()
        {
            List<Category> kategorija;
            using(var context = new EF_DBEntities())
            {
                kategorija = context.Categories.ToList();
            }
            cmbCategory.DataSource = kategorija;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            using(var context = new EF_DBEntities())
            {
                string name = txtbName.Text;
                int quntity = int.Parse(txtbQuantity.Text);
                int unitPrice = int.Parse(txtbPrice.Text);
                Category kategorija = cmbCategory.SelectedItem as Category;
                context.Categories.Attach(kategorija);

                Product dodajNovi = new Product
                {
                    Name = name,
                    Quantity = quntity,
                    UnitPrice = unitPrice,
                    Category = kategorija
                };

                context.Products.Add(dodajNovi);
                context.SaveChanges();
            }
            Close();
        }
    }
}
