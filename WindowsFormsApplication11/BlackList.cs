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
    public partial class BlackList : Form
    {
        public static EmployeeKab clientform;
        ListViewItem lvi;
        public BlackList() 
        {
            MaximizeBox = false;
            InitializeComponent();
            SelectAllOwe();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            clientform.Visible = true;
        }

        public void SelectAllOwe()
        {
            ListViewAllOwe.Items.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (Owe owe in db.OweSet)
                {
                    lvi = new ListViewItem(owe.Surname);
                    lvi.SubItems.Add(owe.Name);
                    lvi.SubItems.Add(owe.Phone);
                    lvi.SubItems.Add(owe.Address);
                    ListViewAllOwe.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    using (UserContainer1 db = new UserContainer1())
                    {
                        foreach (GivenAway givenAway in db.GivenAwaySet)
                        {
                            if (textBox1.Text == givenAway.SurnameClient && textBox2.Text == givenAway.NameClient)
                            {
                                Owe owe = new Owe() { Surname = textBox1.Text, Name = textBox2.Text, Phone = textBox3.Text, Address = textBox4.Text };
                                db.OweSet.Add(owe);
                                db.SaveChanges();
                                SelectAllOwe();
                            }
                            else
                            {
                                MessageBox.Show($"Клиент {textBox1.Text} {textBox2.Text} не брал книгу!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля, пожалуйста!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BlackList_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void TextBoxForSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewAllOwe.Items.Clear();
                using (UserContainer1 db = new UserContainer1()) //фамилии имени номеру телефона адресу
                {
                    foreach (Owe owe in db.OweSet)
                    {
                        if (TextBoxForSearch.Text != "")
                        {
                            if (ComboBoxFilterSearch.SelectedItem == "фамилии")
                            {
                                if (TextBoxForSearch.Text == owe.Surname)
                                {
                                    lvi = new ListViewItem(owe.Surname);
                                    lvi.SubItems.Add(owe.Name);
                                    lvi.SubItems.Add(owe.Phone);
                                    lvi.SubItems.Add(owe.Address);
                                    ListViewAllOwe.Items.Add(lvi);
                                }
                            }

                            if (ComboBoxFilterSearch.SelectedItem == "имени")
                            {
                                if (TextBoxForSearch.Text == owe.Name)
                                {
                                    lvi = new ListViewItem(owe.Surname);
                                    lvi.SubItems.Add(owe.Name);
                                    lvi.SubItems.Add(owe.Phone);
                                    lvi.SubItems.Add(owe.Address);
                                    ListViewAllOwe.Items.Add(lvi);
                                }
                            }

                            if (ComboBoxFilterSearch.SelectedItem == "номеру телефона")
                            {
                                if (TextBoxForSearch.Text == owe.Phone)
                                {
                                    lvi = new ListViewItem(owe.Surname);
                                    lvi.SubItems.Add(owe.Name);
                                    lvi.SubItems.Add(owe.Phone);
                                    lvi.SubItems.Add(owe.Address);
                                    ListViewAllOwe.Items.Add(lvi);
                                }
                            }

                            if (ComboBoxFilterSearch.SelectedItem == "адресу")
                            {
                                if (TextBoxForSearch.Text == owe.Address)
                                {
                                    lvi = new ListViewItem(owe.Surname);
                                    lvi.SubItems.Add(owe.Name);
                                    lvi.SubItems.Add(owe.Phone);
                                    lvi.SubItems.Add(owe.Address);
                                    ListViewAllOwe.Items.Add(lvi);
                                }
                            }
                        }
                        else
                        {
                            SelectAllOwe();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
