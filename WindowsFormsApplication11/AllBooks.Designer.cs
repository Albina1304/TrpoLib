
namespace WindowsFormsApplication11
{
    partial class AllBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllBooks));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxYearPublish = new System.Windows.Forms.TextBox();
            this.textBoxPublish = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.LabelAddBook = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ComboBoxFilterSearch = new System.Windows.Forms.ComboBox();
            this.TextBoxForSearch = new System.Windows.Forms.TextBox();
            this.ListViewBooks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(836, 326);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 30);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back>";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(786, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 58);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxYearPublish
            // 
            this.textBoxYearPublish.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYearPublish.Location = new System.Drawing.Point(786, 185);
            this.textBoxYearPublish.Name = "textBoxYearPublish";
            this.textBoxYearPublish.Size = new System.Drawing.Size(179, 34);
            this.textBoxYearPublish.TabIndex = 16;
            this.textBoxYearPublish.Text = "Year";
            this.textBoxYearPublish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxYearPublish_MouseClick);
            this.textBoxYearPublish.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxPublish
            // 
            this.textBoxPublish.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPublish.Location = new System.Drawing.Point(786, 145);
            this.textBoxPublish.Name = "textBoxPublish";
            this.textBoxPublish.Size = new System.Drawing.Size(179, 34);
            this.textBoxPublish.TabIndex = 15;
            this.textBoxPublish.Text = "Publish";
            this.textBoxPublish.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPublish_MouseClick);
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.Location = new System.Drawing.Point(786, 225);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(179, 34);
            this.textBoxGenre.TabIndex = 14;
            this.textBoxGenre.Text = "Genre";
            this.textBoxGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxGenre_MouseClick);
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(786, 105);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(179, 34);
            this.textBoxAuthor.TabIndex = 13;
            this.textBoxAuthor.Text = "Author";
            this.textBoxAuthor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxAuthor_MouseClick);
            // 
            // LabelAddBook
            // 
            this.LabelAddBook.AutoSize = true;
            this.LabelAddBook.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAddBook.Location = new System.Drawing.Point(812, 24);
            this.LabelAddBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelAddBook.Name = "LabelAddBook";
            this.LabelAddBook.Size = new System.Drawing.Size(130, 33);
            this.LabelAddBook.TabIndex = 11;
            this.LabelAddBook.Text = "Add book";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(786, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(179, 34);
            this.textBoxName.TabIndex = 19;
            this.textBoxName.Text = "Name";
            this.textBoxName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseClick);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSearch.Location = new System.Drawing.Point(23, 501);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(120, 30);
            this.LabelSearch.TabIndex = 22;
            this.LabelSearch.Text = "Поиск по";
            // 
            // ComboBoxFilterSearch
            // 
            this.ComboBoxFilterSearch.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxFilterSearch.FormattingEnabled = true;
            this.ComboBoxFilterSearch.Items.AddRange(new object[] {
            "названию",
            "автору",
            "году",
            "жанру"});
            this.ComboBoxFilterSearch.Location = new System.Drawing.Point(149, 501);
            this.ComboBoxFilterSearch.Name = "ComboBoxFilterSearch";
            this.ComboBoxFilterSearch.Size = new System.Drawing.Size(171, 37);
            this.ComboBoxFilterSearch.TabIndex = 23;
            this.ComboBoxFilterSearch.Text = "названию";
            // 
            // TextBoxForSearch
            // 
            this.TextBoxForSearch.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxForSearch.Location = new System.Drawing.Point(326, 503);
            this.TextBoxForSearch.Name = "TextBoxForSearch";
            this.TextBoxForSearch.Size = new System.Drawing.Size(426, 34);
            this.TextBoxForSearch.TabIndex = 24;
            this.TextBoxForSearch.TextChanged += new System.EventHandler(this.TextBoxForSearch_TextChanged);
            // 
            // ListViewBooks
            // 
            this.ListViewBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ListViewBooks.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListViewBooks.HideSelection = false;
            this.ListViewBooks.Location = new System.Drawing.Point(-2, -3);
            this.ListViewBooks.Name = "ListViewBooks";
            this.ListViewBooks.Size = new System.Drawing.Size(771, 491);
            this.ListViewBooks.TabIndex = 25;
            this.ListViewBooks.UseCompatibleStateImageBehavior = false;
            this.ListViewBooks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Publish";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Year";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Genre";
            this.columnHeader6.Width = 120;
            // 
            // AllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ListViewBooks);
            this.Controls.Add(this.TextBoxForSearch);
            this.Controls.Add(this.ComboBoxFilterSearch);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxYearPublish);
            this.Controls.Add(this.textBoxPublish);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.LabelAddBook);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AllBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NKC";
            this.Load += new System.EventHandler(this.AllBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxYearPublish;
        private System.Windows.Forms.TextBox textBoxPublish;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.Label LabelAddBook;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.ComboBox ComboBoxFilterSearch;
        private System.Windows.Forms.TextBox TextBoxForSearch;
        private System.Windows.Forms.ListView ListViewBooks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}