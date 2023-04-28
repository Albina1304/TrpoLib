using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace WindowsFormsApplication11
{
    public partial class Recovery : Form
    {
        static string code = "";
        static MailAddress to;
        public Form1 form1;

        public Recovery()
        {
            MaximizeBox = false;
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = true;
                MailAddress from = new MailAddress("laba_oaip@mail.ru", "NKC");
                to = new MailAddress(textBoxEmail.Text);
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Восстановление пароля!";
                using (UserContainer1 db = new UserContainer1())
                {
                    foreach (Staff staff in db.StaffSet)
                    {
                        if (textBoxEmail.Text == staff.Email)
                        {
                            makeCode();
                            m.Body = $"<h1>Код: <em>{code}</em> </h1>";
                        }
                    }
                }
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
                smtp.Credentials = new NetworkCredential("laba_oaip@mail.ru", "labor3333");
                smtp.EnableSsl = true;
                smtp.Send(m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void makeCode()
        {
            Random rand = new Random();
            for (int i = 0; i < 4; i++) code += Convert.ToString(rand.Next(0, 9));
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Show();
        }

        private void Recovery_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (UserContainer1 db = new UserContainer1())
                {
                    foreach (Staff staff in db.StaffSet)
                    {
                        if (staff.Email == to.Address && textBoxCode.Text.Length == 4 && code == textBoxCode.Text)
                        {
                            staff.Password = CryptoService.GetHashString(textBoxNewPass.Text);
                            MessageBox.Show($"Уважаемый, {staff.Login}. Пароль успешно изменен!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        else
                        {
                            MessageBox.Show($"Уважаемый, {staff.Login}. Произошла ошибка!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxCode_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxCode.Text.Length == 4 && code == textBoxCode.Text)
            {
                button2.Enabled = true;
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signin signin = new Signin();
            signin.Show();
            this.Hide();
        }

        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxEmail.Clear();
        }

        private void textBoxCode_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxCode.Clear();
        }

        private void textBoxNewPass_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNewPass.Clear();
        }
    }
}