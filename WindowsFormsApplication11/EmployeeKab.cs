using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace WindowsFormsApplication11
{
    public partial class EmployeeKab : Form
    {
        
        public EmployeeKab()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        Bitmap image;
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
            pictureBox1.Invalidate();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            AllBooks.clientform = this;
            InStock.clientform = this;
            BooksGivenAway.clientform = this;
            BlackList.clientform = this;
            Sotrudnik.clientform = this;
            Getting.clientform = this;
            SignStaff.clientform = this;
            ChangeStaff.clientform = this;
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Client_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D1)
            {
                toolStripMenuItem1_Click(this, e);
            }
            if (e.KeyChar == (char)Keys.D2)
            {
                toolStripMenuItem2_Click(this, e);
            }
            if (e.KeyChar == (char)Keys.D3)
            {
                toolStripMenuItem3_Click(this, e);
            }
            if (e.KeyChar == (char)Keys.D4)
            {
                выдачаКнигиToolStripMenuItem_Click(this, e);
            }
            if (e.KeyChar == (char)Keys.D5)
            {
                if (LabelForRole.Text == "Admin")
                {
                    toolStripMenuItem4_Click(this, e);
                }
            }
            if (e.KeyChar == (char)Keys.D6)
            {
                if (LabelForRole.Text == "Admin")
                {
                    добавитьСотрудникаToolStripMenuItem_Click(this, e);
                }
            }
            if (e.KeyChar == (char)Keys.D7)
            {
                if (LabelForRole.Text == "Admin")
                {
                    изменитьДанныеToolStripMenuItem_Click(this, e);
                }
            }
            if (e.KeyChar == (char)Keys.D8)
            {
                отданныеКнигиToolStripMenuItem_Click(this, e);
            }
            if (e.KeyChar == (char)Keys.D9)
            {
                toolStripButton1_Click_1(this, e);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AllBooks allBooks = new AllBooks();
            allBooks.Show();
            this.Visible = false;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InStock inStock = new InStock();
            inStock.Show();
            this.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BooksGivenAway booksGivenAway = new BooksGivenAway();
            booksGivenAway.Show();
            this.Visible = false;
        }

        private void отданныеКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackList blackList = new BlackList();
            blackList.Show();
            this.Visible = false;
        }

        void Client_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Sotrudnik sotrudnik = new Sotrudnik();
            sotrudnik.Show();
            this.Visible = false;
        }

        private void выдачаКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Getting getting = new Getting();
            getting.Show();
            this.Visible = false;
        }

        private void добавитьСотрудникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignStaff signStaff = new SignStaff();
            signStaff.Show();
            this.Visible = false;
        }

        private void изменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStaff changeStaff = new ChangeStaff();
            changeStaff.Show();
            this.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Signin signin = new Signin();
            signin.Show();
        }
    }
}
