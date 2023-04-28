using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class BooksGivenAway : Form
    {
        public static EmployeeKab clientform;
        ListViewItem lvi;
        public BooksGivenAway()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            clientform.Visible = true;
        }

        public void SelectAllBooks()
        {
            ListViewBooks.Items.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (GivenAway givenAway in db.GivenAwaySet)
                {
                    lvi = new ListViewItem(givenAway.Id.ToString());
                    lvi.SubItems.Add(givenAway.Name);
                    lvi.SubItems.Add(givenAway.Author);
                    lvi.SubItems.Add(givenAway.Publishing);
                    lvi.SubItems.Add(givenAway.YearPublishing);
                    lvi.SubItems.Add(givenAway.Genre);
                    ListViewBooks.Items.Add(lvi);
                }
            }
        }

        private void BooksGivenAway_Load(object sender, EventArgs e)
        {
            SelectAllBooks();
        }

        private void TextBoxForSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewBooks.Items.Clear();
                using (UserContainer1 db = new UserContainer1())
                {
                    foreach (Book book in db.BookSet)
                    {
                        if (TextBoxForSearch.Text != "")
                        {
                            if (ComboBoxFilterSearch.SelectedItem == "названию")
                            {
                                if (TextBoxForSearch.Text == book.Name)
                                {

                                    lvi = new ListViewItem(book.Id.ToString());
                                    lvi.SubItems.Add(book.Name);
                                    lvi.SubItems.Add(book.Author);
                                    lvi.SubItems.Add(book.Publishing);
                                    lvi.SubItems.Add(book.YearPublish);
                                    lvi.SubItems.Add(book.Genre);
                                    ListViewBooks.Items.Add(lvi);
                                }

                            }

                            if (ComboBoxFilterSearch.SelectedItem == "автору")
                            {
                                if (TextBoxForSearch.Text == book.Author)
                                {
                                    lvi = new ListViewItem(book.Id.ToString());
                                    lvi.SubItems.Add(book.Name);
                                    lvi.SubItems.Add(book.Author);
                                    lvi.SubItems.Add(book.Publishing);
                                    lvi.SubItems.Add(book.YearPublish);
                                    lvi.SubItems.Add(book.Genre);
                                    ListViewBooks.Items.Add(lvi);
                                }

                            }

                            if (ComboBoxFilterSearch.SelectedItem == "году")
                            {
                                if (TextBoxForSearch.Text == book.YearPublish)
                                {

                                    lvi = new ListViewItem(book.Id.ToString());
                                    lvi.SubItems.Add(book.Name);
                                    lvi.SubItems.Add(book.Author);
                                    lvi.SubItems.Add(book.Publishing);
                                    lvi.SubItems.Add(book.YearPublish);
                                    lvi.SubItems.Add(book.Genre);
                                    ListViewBooks.Items.Add(lvi);
                                }

                            }

                            if (ComboBoxFilterSearch.SelectedItem == "жанру")
                            {
                                if (TextBoxForSearch.Text == book.Genre)
                                {

                                    lvi = new ListViewItem(book.Id.ToString());
                                    lvi.SubItems.Add(book.Name);
                                    lvi.SubItems.Add(book.Author);
                                    lvi.SubItems.Add(book.Publishing);
                                    lvi.SubItems.Add(book.YearPublish);
                                    lvi.SubItems.Add(book.Genre);
                                    ListViewBooks.Items.Add(lvi);
                                }

                            }
                        }
                        else
                        {
                            SelectAllBooks();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
