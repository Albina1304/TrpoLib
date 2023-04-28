using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using MaterialSkin.Controls;

namespace WindowsFormsApplication11
{
    public partial class AllBooks : Form
    {
        public static EmployeeKab clientform;
        ListViewItem lvi;

        public AllBooks()
        {
            MaximizeBox = false;
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AllBooks_Load(object sender, EventArgs e)
        {
            SelectAllBooks();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            clientform.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (UserContainer1 db = new UserContainer1())
            {
                if (textBoxName.Text == "" || textBoxAuthor.Text == "" || textBoxPublish.Text == "" || textBoxYearPublish.Text == "" || textBoxGenre.Text == "")
                {
                    MessageBox.Show("Заполните поля!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Book book = new Book() { Name = textBoxName.Text, Author = textBoxAuthor.Text, Genre = textBoxGenre.Text, Publishing = textBoxPublish.Text, YearPublish = textBoxYearPublish.Text };
                    db.BookSet.Add(book);
                    db.SaveChanges();
                    SelectAllBooks();
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void SelectAllBooks()
        {
            ListViewBooks.Items.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (Book book in db.BookSet)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxName.Clear();
        }

        private void textBoxAuthor_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxAuthor.Clear();
        }

        private void textBoxPublish_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPublish.Clear();
        }

        private void textBoxYearPublish_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxYearPublish.Clear();
        }

        private void textBoxGenre_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxGenre.Clear();
        }
    }
}
