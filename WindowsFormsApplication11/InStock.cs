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
    public partial class InStock : Form
    {
        public static EmployeeKab clientform;
        ListViewItem lvi;
        ListViewItem lvu;
        public InStock()
        {
            MaximizeBox = false;
            InitializeComponent();
            SelectAllBooksStatus();
            SelectAllClientStatus();
        }

        public void SelectAllBooksStatus()
        {
            ListViewBookStatus.Items.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (Book book in db.BookSet)
                {
                    
                    lvi = new ListViewItem(book.Name);
                    lvi.SubItems.Add(book.Author);
                    lvi.SubItems.Add("В наличии");
                    ListViewBookStatus.Items.Add(lvi);
                    
                }

                foreach (GivenAway givenAway in db.GivenAwaySet)
                {
                    
                    lvi = new ListViewItem(givenAway.Name);
                    lvi.SubItems.Add(givenAway.Author);
                    lvi.SubItems.Add("Не в наличии");
                    ListViewBookStatus.Items.Add(lvi);
                }
            }
        }

        public void SelectAllClientStatus()
        {
            ListViewClientStatus.Items.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (Clients clients in db.ClientsSet)
                {
                    lvu = new ListViewItem(clients.Name);
                    lvu.SubItems.Add(clients.Surname);
                    lvu.SubItems.Add("Не брал книгу");
                    ListViewClientStatus.Items.Add(lvu);
                }

                foreach (GivenAway givenAway in db.GivenAwaySet) 
                {
                    lvu = new ListViewItem(givenAway.NameClient);
                    lvu.SubItems.Add(givenAway.SurnameClient);
                    lvu.SubItems.Add("Взята книга");
                    ListViewClientStatus.Items.Add(lvu);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            clientform.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*dataGridView2.Rows.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (Clients clients in db.ClientsSet)
                {
                    if (textBox2.Text == clients.Surname)
                    {
                        dataGridView2.Rows.Add(clients.Name, clients.Surname, "Не брал книгу");
                    }
                }

                foreach (GivenAway givenAway in db.GivenAwaySet)
                {
                    if (textBox2.Text == givenAway.SurnameClient)
                    {
                        dataGridView2.Rows.Add(givenAway.NameClient, givenAway.SurnameClient, "Взята книга");
                    }
                }
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxForSearhBookStatus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewBookStatus.Items.Clear();
                using (UserContainer1 db = new UserContainer1())
                {
                    foreach (Book book in db.BookSet)
                    {
                        if (TextBoxForSearhBookStatus.Text != "")
                        {
                            
                            if (TextBoxForSearhBookStatus.Text == book.Name)
                            {
                                lvi = new ListViewItem(book.Name);
                                lvi.SubItems.Add(book.Author);
                                lvi.SubItems.Add("В наличии");
                                ListViewBookStatus.Items.Add(lvi);
                            }
                        }
                        else
                        {
                            SelectAllBooksStatus();
                        }
                    }

                    foreach (GivenAway givenAway in db.GivenAwaySet)
                    {
                        if (TextBoxForSearhBookStatus.Text != "")
                        {

                            if (TextBoxForSearhBookStatus.Text == givenAway.Name)
                            {
                                lvi = new ListViewItem(givenAway.Name);
                                lvi.SubItems.Add(givenAway.Author);
                                lvi.SubItems.Add("Не в наличии");
                                ListViewBookStatus.Items.Add(lvi);
                            }
                        }
                        else
                        {
                            SelectAllBooksStatus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxForSearhClientStatus_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewClientStatus.Items.Clear();
                using (UserContainer1 db = new UserContainer1())
                {
                    foreach (Clients clients in db.ClientsSet)
                    {
                        if (TextBoxForSearhClientStatus.Text != "")
                        {
                            if (TextBoxForSearhClientStatus.Text == clients.Surname)
                            {
                                lvu = new ListViewItem(clients.Name);
                                lvu.SubItems.Add(clients.Surname);
                                lvu.SubItems.Add("Не брал книгу");
                                ListViewClientStatus.Items.Add(lvu);
                            }
                        }
                        else
                        {
                            SelectAllClientStatus();
                        }
                    }

                    foreach (GivenAway givenAway in db.GivenAwaySet)
                    {
                        if (TextBoxForSearhClientStatus.Text != "")
                        {

                            if (TextBoxForSearhClientStatus.Text == givenAway.SurnameClient)
                            {
                                lvu = new ListViewItem(givenAway.NameClient);
                                lvu.SubItems.Add(givenAway.SurnameClient);
                                lvu.SubItems.Add("Взята книга");
                                ListViewClientStatus.Items.Add(lvu);
                            }
                        }
                        else
                        {
                            SelectAllClientStatus();
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
