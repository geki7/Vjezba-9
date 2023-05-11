using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksTask
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            RefreshGUI();
            FillGenre();
        }

        private void RefreshGUI()
        {
            dgvBooks.DataSource = GetBooks();
            dgvBooks.Columns["Genre"].Visible = false;
        }

        private object GetBooks()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Books.ToList();
            }
        }

        private void FillGenre()
        {
            List<Genre> genre;
            using(var context = new EF_DBEntities())
            {
                genre = context.Genres.ToList();
            }
            cmbGenre.DataSource = genre;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string title = txtbTitle.Text;
                int numberPages = int.Parse(txtbPages.Text);
                string mainAuthor = txtbMainAuthor.Text;
                Genre zanr = cmbGenre.SelectedItem as Genre;
                context.Genres.Attach(zanr);

                Book newBook = new Book()
                {
                    Title = title,
                    NumOfPages = numberPages,
                    MainAuthor = mainAuthor,
                    Genre = zanr
                };
                context.Books.Add(newBook);
                context.SaveChanges();
            }
            RefreshGUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Book book = deleteBook();
            using(var context = new EF_DBEntities())
            {
                context.Books.Attach(book);
                context.Books.Remove(book);
                context.SaveChanges();
            }
            RefreshGUI();
        }

        private Book deleteBook()
        {
            return dgvBooks.CurrentRow.DataBoundItem as Book;
        }
    }
}
