using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categories_and_Products
{
    public partial class CategoryandProducts : Form
    {
        public CategoryandProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCatergory.DataSource = GetCategory();
            dgvCatergory.Columns["Products"].Visible = false;
        }

        private object GetCategory()
        {
            using(var context = new EF_DBEntities())
            {
                return context.Categories.ToList();
            }
        }

        private void showProducts(Category kategorija)
        {
            List<Product> proizvodi;
            using(var context = new EF_DBEntities())
            {
                context.Categories.Attach(kategorija);
                proizvodi = kategorija.Products.ToList();
            }
            dgvProducts.DataSource = proizvodi;
        }

        private void dgvCatergory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Category odabranaKat = dgvCatergory.CurrentRow.DataBoundItem as Category;
            if (odabranaKat != null)
            {
                showProducts(odabranaKat);
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private Category kat;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string name = txtbProductName.Text;
                int quantity = int.Parse(txtbQuantity.Text);
                int unitPrice = int.Parse(txtbUnitPrice.Text);
                kat = dgvCatergory.CurrentRow.DataBoundItem as Category;
                context.Categories.Attach(kat);

                Product newProdcut = new Product
                {
                    Name = name,
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                    Category = kat,
                };

                context.Products.Add(newProdcut);
                context.SaveChanges();
            }
        }
    }
}
