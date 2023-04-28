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
    public partial class SignStaff : Form
    {
        public static EmployeeKab clientform;
        public SignStaff()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
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

                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {


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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (UserContainer1 db = new UserContainer1())
            {
                try
                {
                    if (textBoxLog.Text == "" || textBoxPass.Text == "" || textBoxEmail.Text == "")
                    {
                        MessageBox.Show("Ошибка!");
                    }
                    else
                    {
                        if (byteArray != null)
                        {

                            Staff staff = new Staff() { Login = textBoxLog.Text, Password = this.GetHashString(textBoxPass.Text), Email = textBoxEmail.Text, Photo = byteArray, Role = "Staff", Name = textBoxName.Text, Surname = textBoxSurname.Text, FatherName = textBoxFatherName.Text, Passport = textBoxPassport.Text, Phone = textBoxPhone.Text, Salary = textBoxSalary.Text };

                            db.StaffSet.Add(staff);
                            db.SaveChanges();

                            MessageBox.Show("Регистрация прошла успешно!");
                            this.Dispose();
                            clientform.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxLog_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxLog.Clear();
        }

        private void textBoxPass_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPass.Clear();
        }

        private void textBoxEmail_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxEmail.Clear();
        }

        private void textBoxPassport_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPassport.Clear();
        }

        private void textBoxPhone_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPhone.Clear();
        }

        private void textBoxSurname_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSurname.Clear();
        }

        private void textBoxName_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxName.Clear();
        }

        private void textBoxFatherName_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxFatherName.Clear();
        }

        private void textBoxSalary_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxSalary.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            clientform.Visible = true;
        }
    }
}
