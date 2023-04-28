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
    public partial class Getting : Form
    {
        public static EmployeeKab clientform;
        ListViewItem lvi;

        int id;
        string name;
        string author;
        string genre;
        string publishing;
        string yaerpublish;

        public Getting()
        {
            InitializeComponent();
        }

        public void SelectAllGivenAway()
        {
            ListViewBooks.Items.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (GivenAway givenAway in db.GivenAwaySet)
                {
                    lvi = new ListViewItem(givenAway.Id.ToString());
                    lvi.SubItems.Add(givenAway.Name);
                    lvi.SubItems.Add(givenAway.Author);
                    lvi.SubItems.Add(givenAway.NameClient);
                    lvi.SubItems.Add(givenAway.SurnameClient);
                    lvi.SubItems.Add(givenAway.Phone);
                    lvi.SubItems.Add(givenAway.Address);
                    ListViewBooks.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContainer1 db = new UserContainer1())
            {
                try
                {
                    foreach (Book book in db.BookSet)
                    {
                        if (textBox1.Text == Convert.ToString(book.Id))
                        {
                            name = book.Name;
                            author = book.Author;
                            genre = book.Genre;
                            publishing = book.Publishing;
                            yaerpublish = book.YearPublish;
                        }
                    }

                    GivenAway givenAway = new GivenAway() { Name = name, Author = author, Genre = genre, Publishing = publishing, YearPublishing = yaerpublish, NameClient = textBox3.Text, SurnameClient = textBox2.Text, Phone = textBox4.Text, Address = textBox5.Text };
                    db.GivenAwaySet.Add(givenAway);
                    db.SaveChanges();
                
                    foreach (Book book in db.BookSet)
                    {
                        if (textBox1.Text == Convert.ToString(book.Id))
                        {
                            db.BookSet.Remove(book);
                        }
                    }
                    db.SaveChanges();

                    foreach (Clients clients in db.ClientsSet)
                    {
                        if (textBox2.Text == Convert.ToString(clients.Surname))
                        {
                            db.ClientsSet.Remove(clients);
                        }
                    }
                    db.SaveChanges();

                    SelectAllGivenAway();
                    MessageBox.Show($"Выдалась книга {name} читателю {textBox2.Text}!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        private void Getting_Load(object sender, EventArgs e)
        {
            SelectAllGivenAway();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*dataGridView1.Rows.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (GivenAway givenAway in db.GivenAwaySet)
                {
                    if (textBox6.Text == givenAway.SurnameClient)
                    {
                        dataGridView1.Rows.Add(givenAway.SurnameClient, givenAway.NameClient, givenAway.Phone, givenAway.Address);
                    }
                }
            }*/
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            clientform.Visible = true;
        }

        private void TextBoxForSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewBooks.Items.Clear();
                using (UserContainer1 db = new UserContainer1())
                {
                    foreach (GivenAway givenAway in db.GivenAwaySet)
                    {
                        if (TextBoxForSearch.Text != "")
                        {
                            if (ComboBoxFilterSearch.SelectedItem == "названии книги")
                            {
                                if (TextBoxForSearch.Text == givenAway.Name) 
                                {
                                    lvi = new ListViewItem(givenAway.Id.ToString());
                                    lvi.SubItems.Add(givenAway.Name);
                                    lvi.SubItems.Add(givenAway.Author);
                                    lvi.SubItems.Add(givenAway.NameClient);
                                    lvi.SubItems.Add(givenAway.SurnameClient);
                                    lvi.SubItems.Add(givenAway.Phone);
                                    lvi.SubItems.Add(givenAway.Address);
                                    ListViewBooks.Items.Add(lvi);
                                }

                            }

                            if (ComboBoxFilterSearch.SelectedItem == "автору книги")
                            {
                                if (TextBoxForSearch.Text == givenAway.Author)
                                {
                                    lvi = new ListViewItem(givenAway.Id.ToString());
                                    lvi.SubItems.Add(givenAway.Name);
                                    lvi.SubItems.Add(givenAway.Author);
                                    lvi.SubItems.Add(givenAway.NameClient);
                                    lvi.SubItems.Add(givenAway.SurnameClient);
                                    lvi.SubItems.Add(givenAway.Phone);
                                    lvi.SubItems.Add(givenAway.Address);
                                    ListViewBooks.Items.Add(lvi);
                                }

                            }

                            if (ComboBoxFilterSearch.SelectedItem == "имени клиента")
                            {
                                if (TextBoxForSearch.Text == givenAway.NameClient)
                                {
                                    lvi = new ListViewItem(givenAway.Id.ToString());
                                    lvi.SubItems.Add(givenAway.Name);
                                    lvi.SubItems.Add(givenAway.Author);
                                    lvi.SubItems.Add(givenAway.NameClient);
                                    lvi.SubItems.Add(givenAway.SurnameClient);
                                    lvi.SubItems.Add(givenAway.Phone);
                                    lvi.SubItems.Add(givenAway.Address);
                                    ListViewBooks.Items.Add(lvi);
                                }

                            }

                            if (ComboBoxFilterSearch.SelectedItem == "фамилии клиента")
                            {
                                if (TextBoxForSearch.Text == givenAway.SurnameClient)
                                {
                                    lvi = new ListViewItem(givenAway.Id.ToString());
                                    lvi.SubItems.Add(givenAway.Name);
                                    lvi.SubItems.Add(givenAway.Author);
                                    lvi.SubItems.Add(givenAway.NameClient);
                                    lvi.SubItems.Add(givenAway.SurnameClient);
                                    lvi.SubItems.Add(givenAway.Phone);
                                    lvi.SubItems.Add(givenAway.Address);
                                    ListViewBooks.Items.Add(lvi);
                                }

                            }
                        }
                        else
                        {
                            SelectAllGivenAway();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Clear();
        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            textBox5.Clear();
        }
    }
}
