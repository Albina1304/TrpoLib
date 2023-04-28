
namespace WindowsFormsApplication11
{
    partial class InStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InStock));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TextBoxForSearhBookStatus = new System.Windows.Forms.TextBox();
            this.ListViewBookStatus = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabelKnowStatusBook = new System.Windows.Forms.Label();
            this.LabelKnowStatusMan = new System.Windows.Forms.Label();
            this.ListViewClientStatus = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextBoxForSearhClientStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(462, 522);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 30);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back>";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TextBoxForSearhBookStatus
            // 
            this.TextBoxForSearhBookStatus.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxForSearhBookStatus.Location = new System.Drawing.Point(141, 521);
            this.TextBoxForSearhBookStatus.Name = "TextBoxForSearhBookStatus";
            this.TextBoxForSearhBookStatus.Size = new System.Drawing.Size(206, 30);
            this.TextBoxForSearhBookStatus.TabIndex = 10;
            this.TextBoxForSearhBookStatus.TextChanged += new System.EventHandler(this.TextBoxForSearhBookStatus_TextChanged);
            // 
            // ListViewBookStatus
            // 
            this.ListViewBookStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListViewBookStatus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListViewBookStatus.HideSelection = false;
            this.ListViewBookStatus.Location = new System.Drawing.Point(28, 39);
            this.ListViewBookStatus.Name = "ListViewBookStatus";
            this.ListViewBookStatus.Size = new System.Drawing.Size(457, 476);
            this.ListViewBookStatus.TabIndex = 17;
            this.ListViewBookStatus.UseCompatibleStateImageBehavior = false;
            this.ListViewBookStatus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Author";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 150;
            // 
            // LabelKnowStatusBook
            // 
            this.LabelKnowStatusBook.AutoSize = true;
            this.LabelKnowStatusBook.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKnowStatusBook.Location = new System.Drawing.Point(136, 6);
            this.LabelKnowStatusBook.Name = "LabelKnowStatusBook";
            this.LabelKnowStatusBook.Size = new System.Drawing.Size(238, 30);
            this.LabelKnowStatusBook.TabIndex = 18;
            this.LabelKnowStatusBook.Text = "Узнать статус книги";
            // 
            // LabelKnowStatusMan
            // 
            this.LabelKnowStatusMan.AutoSize = true;
            this.LabelKnowStatusMan.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelKnowStatusMan.Location = new System.Drawing.Point(616, 9);
            this.LabelKnowStatusMan.Name = "LabelKnowStatusMan";
            this.LabelKnowStatusMan.Size = new System.Drawing.Size(264, 30);
            this.LabelKnowStatusMan.TabIndex = 19;
            this.LabelKnowStatusMan.Text = "Узнать статус клиента";
            // 
            // ListViewClientStatus
            // 
            this.ListViewClientStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ListViewClientStatus.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListViewClientStatus.HideSelection = false;
            this.ListViewClientStatus.Location = new System.Drawing.Point(515, 39);
            this.ListViewClientStatus.Name = "ListViewClientStatus";
            this.ListViewClientStatus.Size = new System.Drawing.Size(457, 476);
            this.ListViewClientStatus.TabIndex = 20;
            this.ListViewClientStatus.UseCompatibleStateImageBehavior = false;
            this.ListViewClientStatus.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Author";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 150;
            // 
            // TextBoxForSearhClientStatus
            // 
            this.TextBoxForSearhClientStatus.Font = new System.Drawing.Font("Montserrat", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxForSearhClientStatus.Location = new System.Drawing.Point(653, 521);
            this.TextBoxForSearhClientStatus.Name = "TextBoxForSearhClientStatus";
            this.TextBoxForSearhClientStatus.Size = new System.Drawing.Size(206, 30);
            this.TextBoxForSearhClientStatus.TabIndex = 21;
            this.TextBoxForSearhClientStatus.TextChanged += new System.EventHandler(this.TextBoxForSearhClientStatus_TextChanged);
            // 
            // InStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.TextBoxForSearhClientStatus);
            this.Controls.Add(this.ListViewClientStatus);
            this.Controls.Add(this.LabelKnowStatusMan);
            this.Controls.Add(this.LabelKnowStatusBook);
            this.Controls.Add(this.ListViewBookStatus);
            this.Controls.Add(this.TextBoxForSearhBookStatus);
            this.Controls.Add(this.linkLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NKC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox TextBoxForSearhBookStatus;
        private System.Windows.Forms.ListView ListViewBookStatus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label LabelKnowStatusBook;
        private System.Windows.Forms.Label LabelKnowStatusMan;
        private System.Windows.Forms.ListView ListViewClientStatus;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox TextBoxForSearhClientStatus;
    }
}