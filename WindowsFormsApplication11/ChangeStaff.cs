using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class ChangeStaff : Form
    {
        public static EmployeeKab clientform;
        static MailAddress to;
        public ChangeStaff()
        {
            InitializeComponent();
            AllUser();
        }

        public void AllUser()
        {
            using (UserContainer1 db = new UserContainer1())
            {
                listBox1.Items.Clear();
                foreach (var item in db.StaffSet)
                {
                    listBox1.Items.Add(item.Login);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            clientform.Visible = true;
        }

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        public void MessageAboutChange(string mail, string log)
        {
            MailAddress from = new MailAddress("laba_oaip@mail.ru", "NKC");
            to = new MailAddress(mail);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Изменение данных на NKC!";
            m.Body = $"<h3>Здравствуйте, {log}.</h3>\n\n<h4>Похоже, кто-то изменил данные учётной записи NKC. Если это не вы, обратитесь по ардесу: laba_oaip@mail.ru.</h4>";
            m.Body += $"\n\n{DateTime.Now.ToString("HH:mm:ss")}\n{DateTime.Now.ToString("dd MMMM yyyy")}";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("laba_oaip@mail.ru", "labor3333");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("Заполните поля, прошу вас!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Staff staff = new Staff();
                    using (UserContainer1 db = new UserContainer1())
                    {
                        foreach (var item in db.StaffSet)
                        {
                            if (item.Login == (string)listBox1.SelectedItem)
                            {
                                staff = db.StaffSet.Find(item.Id);
                            }
                        }
                        MessageAboutChange(staff.Email, staff.Login);
                        staff.Login = textBox1.Text;
                        staff.Password = this.GetHashString(textBox2.Text);
                        staff.Email = textBox3.Text;
                        db.SaveChanges();
                        MessageBox.Show("Данные успешно изменены!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                using (UserContainer1 db = new UserContainer1())
                {
                    listBox1.Items.Clear();
                    foreach (var item in db.StaffSet)
                    {
                        listBox1.Items.Add(item.Login);
                    }
                }
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            using (UserContainer1 db = new UserContainer1())
            {
                foreach (var item in db.StaffSet)
                {
                    if (item.Login == (string)listBox1.SelectedItem)
                    {
                        staff = db.StaffSet.Find(item.Id);
                    }
                }
                textBox1.Text = staff.Login;
                textBox2.Text = staff.Password;
                textBox3.Text = staff.Email;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Staff staff = new Staff();
                using (UserContainer1 db = new UserContainer1())
                {
                    foreach (var item in db.StaffSet)
                    {
                        if (item.Login == (string)listBox1.SelectedItem)
                        {
                            staff = db.StaffSet.Find(item.Id);
                        }
                    }
                    db.StaffSet.Remove(staff);
                    db.SaveChanges();
                    MessageBox.Show("Удалили", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AllUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
