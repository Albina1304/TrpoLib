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
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApplication11
{
    public partial class SignUp : Form
    {
        static MailAddress to;
        public SignUp()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        public void MessageAboutSignIn(string mail, string log)
        {
            MailAddress from = new MailAddress("laba_oaip@mail.ru", "NKC");
            to = new MailAddress(mail);
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Регистрация на NKC!";
            m.Body = $"<h3>Здравствуйте, {log}.</h3>\n\n<h4>Вы зарегистрировались учётную запись на NKC. Желаем успехов работы в этом приложении.\n\nС уважением администрация приложения!</h4>";
            m.Body += $"\n\n{DateTime.Now.ToString("HH:mm:ss")} \n\n {DateTime.Now.ToString("dd MMMM yyyy")}";
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential("laba_oaip@mail.ru", "labor3333");
            smtp.EnableSsl = true;
            smtp.Send(m);
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

        byte[] imageBytes;
        Bitmap image;
        public static string byteArray;

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void LinkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signin signin = new Signin();
            signin.Show();
        }

        private void ButtonForSelectPhotoProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();

            open_dialog.Filter = "ImageFiles(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | Allfiles(*.*) | *.* ";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.imageBytes = File.ReadAllBytes(open_dialog.FileName);
                    byteArray = Convert.ToBase64String(imageBytes);
                    image = new Bitmap(open_dialog.FileName);

                    this.PictureBoxForProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                    PictureBoxForProfile.Image = image;
                    PictureBoxForProfile.Invalidate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonForRegistration_Click(object sender, EventArgs e)
        {
            using (UserContainer1 db = new UserContainer1())
            {
                try
                {
                    if (RichTextBoxLogin.Text == "" || RichTextBoxPassword.Text == "" || RichTextBoxEmail.Text == "" || RichTextBoxRole.Text == "")
                    {
                        MessageBox.Show("Заполните все поля, пожалуйста!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (byteArray != null)
                        {
                            if (RichTextBoxRole.Text == "Admin")
                            {
                                Staff staff = new Staff() { Login = RichTextBoxLogin.Text, Password = this.GetHashString(RichTextBoxPassword.Text), Email = RichTextBoxEmail.Text, Photo = byteArray, Role = "Admin", Name = "qwe", Surname = "qwe", FatherName = "qwe", Passport = "qwe", Phone = "qwe", Salary = "qwe" };
                                db.StaffSet.Add(staff);
                                db.SaveChanges();
                                MessageBox.Show($"© 2021, NKC \nВы зарегистрировались, как {staff.Login}. Желаю успехов <3", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageAboutSignIn(staff.Email, staff.Login);
                                Signin signin = new Signin();
                                signin.Show();
                                this.Hide();
                            }
                            if (RichTextBoxRole.Text == "Staff")
                            {
                                MessageBox.Show("Зарегистрировать сотрудника может только администратор!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void RichTextBoxLogin_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBoxLogin.Clear();
        }

        private void RichTextBoxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBoxPassword.Clear();
        }

        private void RichTextBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBoxEmail.Clear();
        }

        private void RichTextBoxRole_MouseClick(object sender, MouseEventArgs e)
        {
            RichTextBoxRole.Clear();
        }
    }
}
