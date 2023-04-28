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
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication11
{
    public partial class Signin : Form
    {

        string mail = "";
        string log = "";

        public Signin()
        {
            InitializeComponent();
            MaximizeBox = false;
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer1_Tick;
            timer.Enabled = true;
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Recovery recovery = new Recovery();
            recovery.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Clear();
        }

        private void richTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox2.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recovery recovery = new Recovery();
            recovery.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                foreach (User user in db.User)
                {
                    try
                    {
                        var employee = db.Employee.FirstOrDefault(q => q.id_employee == user.Login);
                        if (richTextBox1.Text == user.Login.ToString() && this.GetHashString(richTextBox2.Text) == user.Pass && user.Role == "Админ")
                        {
                            MessageBox.Show($"© 2021, NKC \nВы вошли в аккаунт: {employee.Name}. Желаю успехов!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EmployeeKab employeeKab = new EmployeeKab();
                            employeeKab.Show();
                            employeeKab.LabelForLogin.Text = user.Login.ToString();
                            employeeKab.LabelForRole.Text = user.Role;
                            employeeKab.toolStripDropDownButton3.Visible = true;
                            //client.pictureBox1.Image = (Image)((new ImageConverter()).ConvertFrom(Convert.FromBase64String(user.Photo)));
                            this.Hide();
                            return;
                        }

                        if (richTextBox1.Text == user.Login.ToString() && this.GetHashString(richTextBox2.Text) == user.Pass && user.Role == "Сотрудник")
                        {
                            MessageBox.Show($"© 2021, NKC \nВы вошли в аккаунт: {employee.Name}. Желаю успехов <3", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EmployeeKab client = new EmployeeKab();
                            client.Show();
                            client.LabelForLogin.Text = user.Login.ToString();
                            client.LabelForEmail.Text = staff.Email;
                            client.LabelForRole.Text = staff.Role;
                            client.toolStripDropDownButton3.Visible = false;
                            client.pictureBox1.Image = (Image)((new ImageConverter()).ConvertFrom(Convert.FromBase64String(staff.Photo)));
                            this.Hide();
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка!");
                    }
                }
                MessageBox.Show("Логин или пароль указан неверно!");
            }
        }   

        private void Signin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button2.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }
    }
}
