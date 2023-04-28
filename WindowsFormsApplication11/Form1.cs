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
    public partial class Form1 : Form
    {
        public Form1()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                        User user = new User() { Login = textBoxLog.Text, Password = this.GetHashString(textBoxPass.Text), Email = textBoxEmail.Text, /*Photo = this.imageBytes*/ };
                        db.UserSet.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Регистрация прошла успешно!");
                        Signin signin = new Signin();
                        signin.Show();
                        this.Hide();
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка!");
                }
            }
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
            Signin signin = new Signin();
            signin.Show();
        }


        

        byte[] imageBytes;
        Bitmap image;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();

            open_dialog.Filter = "ImageFiles(*.BMP; *.JPG; *.GIF; *.PNG)| *.BMP; *.JPG; *.GIF; *.PNG | Allfiles(*.*) | *.* ";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.imageBytes = File.ReadAllBytes(open_dialog.FileName);
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(null, null); 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
