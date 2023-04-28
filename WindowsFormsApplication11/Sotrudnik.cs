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
    public partial class Sotrudnik : Form
    {
        public static EmployeeKab clientform;
        ListViewItem lvi;
        public Sotrudnik()
        {
            InitializeComponent();
            SelectAllStaff();
        }

        public void SelectAllStaff()
        {
            ListViewStaff.Items.Clear();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (Staff staff in db.StaffSet)
                {
                    if (staff.Role == "Staff")
                    {
                        lvi = new ListViewItem(staff.Surname);
                        lvi.SubItems.Add(staff.Name);
                        lvi.SubItems.Add(staff.FatherName);
                        lvi.SubItems.Add(staff.Passport);
                        lvi.SubItems.Add(staff.Phone);
                        lvi.SubItems.Add(staff.Salary);
                        ListViewStaff.Items.Add(lvi);
                    }     
                }
            }
        }

        private void Sotrudnik_Load(object sender, EventArgs e)
        {

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
                ListViewStaff.Items.Clear();
                using (UserContainer1 db = new UserContainer1())
                {
                    foreach (Staff staff in db.StaffSet)
                    {
                        if (TextBoxForSearch.Text != "")
                        {
                            if (ComboBoxFilterSearch.SelectedItem == "фамилии")
                            {
                                if (TextBoxForSearch.Text == staff.Surname)
                                {
                                    lvi = new ListViewItem(staff.Surname);
                                    lvi.SubItems.Add(staff.Name);
                                    lvi.SubItems.Add(staff.FatherName);
                                    lvi.SubItems.Add(staff.Passport);
                                    lvi.SubItems.Add(staff.Phone);
                                    lvi.SubItems.Add(staff.Salary);
                                    ListViewStaff.Items.Add(lvi);
                                }
                            }

                            if (ComboBoxFilterSearch.SelectedItem == "имени")
                            {
                                if (TextBoxForSearch.Text == staff.Name)
                                {
                                    lvi = new ListViewItem(staff.Surname);
                                    lvi.SubItems.Add(staff.Name);
                                    lvi.SubItems.Add(staff.FatherName);
                                    lvi.SubItems.Add(staff.Passport);
                                    lvi.SubItems.Add(staff.Phone);
                                    lvi.SubItems.Add(staff.Salary);
                                    ListViewStaff.Items.Add(lvi);
                                }
                            }

                            if (ComboBoxFilterSearch.SelectedItem == "паспорту")
                            {
                                if (TextBoxForSearch.Text == staff.Passport)
                                {
                                    lvi = new ListViewItem(staff.Surname);
                                    lvi.SubItems.Add(staff.Name);
                                    lvi.SubItems.Add(staff.FatherName);
                                    lvi.SubItems.Add(staff.Passport);
                                    lvi.SubItems.Add(staff.Phone);
                                    lvi.SubItems.Add(staff.Salary);
                                    ListViewStaff.Items.Add(lvi);
                                }
                            }

                            if (ComboBoxFilterSearch.SelectedItem == "номеру телефона")
                            {
                                if (TextBoxForSearch.Text == staff.Phone)
                                {
                                    lvi = new ListViewItem(staff.Surname);
                                    lvi.SubItems.Add(staff.Name);
                                    lvi.SubItems.Add(staff.FatherName);
                                    lvi.SubItems.Add(staff.Passport);
                                    lvi.SubItems.Add(staff.Phone);
                                    lvi.SubItems.Add(staff.Salary);
                                    ListViewStaff.Items.Add(lvi);
                                }
                            }
                        }
                        else
                        {
                            SelectAllStaff();
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
