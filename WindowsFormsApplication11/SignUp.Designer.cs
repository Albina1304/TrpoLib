
namespace WindowsFormsApplication11
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.LabelCreateAc = new System.Windows.Forms.Label();
            this.LabelAlreadyHave = new System.Windows.Forms.Label();
            this.LinkLabelSignIn = new System.Windows.Forms.LinkLabel();
            this.RichTextBoxLogin = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxPassword = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxEmail = new System.Windows.Forms.RichTextBox();
            this.PictureBoxForProfile = new System.Windows.Forms.PictureBox();
            this.ButtonForSelectPhotoProfile = new System.Windows.Forms.Button();
            this.ButtonForRegistration = new System.Windows.Forms.Button();
            this.RichTextBoxRole = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxForProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCreateAc
            // 
            this.LabelCreateAc.AutoSize = true;
            this.LabelCreateAc.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCreateAc.Location = new System.Drawing.Point(290, 35);
            this.LabelCreateAc.Name = "LabelCreateAc";
            this.LabelCreateAc.Size = new System.Drawing.Size(411, 66);
            this.LabelCreateAc.TabIndex = 26;
            this.LabelCreateAc.Text = "Create account";
            // 
            // LabelAlreadyHave
            // 
            this.LabelAlreadyHave.AutoSize = true;
            this.LabelAlreadyHave.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAlreadyHave.Location = new System.Drawing.Point(233, 101);
            this.LabelAlreadyHave.Name = "LabelAlreadyHave";
            this.LabelAlreadyHave.Size = new System.Drawing.Size(389, 37);
            this.LabelAlreadyHave.TabIndex = 27;
            this.LabelAlreadyHave.Text = "Already have an account?";
            // 
            // LinkLabelSignIn
            // 
            this.LinkLabelSignIn.AutoSize = true;
            this.LinkLabelSignIn.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinkLabelSignIn.Location = new System.Drawing.Point(628, 101);
            this.LinkLabelSignIn.Name = "LinkLabelSignIn";
            this.LinkLabelSignIn.Size = new System.Drawing.Size(116, 37);
            this.LinkLabelSignIn.TabIndex = 28;
            this.LinkLabelSignIn.TabStop = true;
            this.LinkLabelSignIn.Text = "Sign In";
            this.LinkLabelSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSignIn_LinkClicked);
            // 
            // RichTextBoxLogin
            // 
            this.RichTextBoxLogin.BackColor = System.Drawing.Color.Black;
            this.RichTextBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxLogin.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxLogin.ForeColor = System.Drawing.Color.White;
            this.RichTextBoxLogin.Location = new System.Drawing.Point(281, 159);
            this.RichTextBoxLogin.Name = "RichTextBoxLogin";
            this.RichTextBoxLogin.Size = new System.Drawing.Size(280, 45);
            this.RichTextBoxLogin.TabIndex = 29;
            this.RichTextBoxLogin.Text = "Login";
            this.RichTextBoxLogin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBoxLogin_MouseClick);
            // 
            // RichTextBoxPassword
            // 
            this.RichTextBoxPassword.BackColor = System.Drawing.Color.Black;
            this.RichTextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxPassword.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxPassword.ForeColor = System.Drawing.Color.White;
            this.RichTextBoxPassword.Location = new System.Drawing.Point(281, 228);
            this.RichTextBoxPassword.Name = "RichTextBoxPassword";
            this.RichTextBoxPassword.Size = new System.Drawing.Size(280, 45);
            this.RichTextBoxPassword.TabIndex = 30;
            this.RichTextBoxPassword.Text = "Password";
            this.RichTextBoxPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBoxPassword_MouseClick);
            // 
            // RichTextBoxEmail
            // 
            this.RichTextBoxEmail.BackColor = System.Drawing.Color.Black;
            this.RichTextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxEmail.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxEmail.ForeColor = System.Drawing.Color.White;
            this.RichTextBoxEmail.Location = new System.Drawing.Point(281, 298);
            this.RichTextBoxEmail.Name = "RichTextBoxEmail";
            this.RichTextBoxEmail.Size = new System.Drawing.Size(280, 45);
            this.RichTextBoxEmail.TabIndex = 31;
            this.RichTextBoxEmail.Text = "Email";
            this.RichTextBoxEmail.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBoxEmail_MouseClick);
            // 
            // PictureBoxForProfile
            // 
            this.PictureBoxForProfile.BackColor = System.Drawing.Color.Black;
            this.PictureBoxForProfile.Location = new System.Drawing.Point(599, 177);
            this.PictureBoxForProfile.Name = "PictureBoxForProfile";
            this.PictureBoxForProfile.Size = new System.Drawing.Size(165, 199);
            this.PictureBoxForProfile.TabIndex = 32;
            this.PictureBoxForProfile.TabStop = false;
            // 
            // ButtonForSelectPhotoProfile
            // 
            this.ButtonForSelectPhotoProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.ButtonForSelectPhotoProfile.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonForSelectPhotoProfile.ForeColor = System.Drawing.Color.White;
            this.ButtonForSelectPhotoProfile.Location = new System.Drawing.Point(589, 338);
            this.ButtonForSelectPhotoProfile.Name = "ButtonForSelectPhotoProfile";
            this.ButtonForSelectPhotoProfile.Size = new System.Drawing.Size(186, 57);
            this.ButtonForSelectPhotoProfile.TabIndex = 33;
            this.ButtonForSelectPhotoProfile.Text = "Select";
            this.ButtonForSelectPhotoProfile.UseVisualStyleBackColor = false;
            this.ButtonForSelectPhotoProfile.Click += new System.EventHandler(this.ButtonForSelectPhotoProfile_Click);
            // 
            // ButtonForRegistration
            // 
            this.ButtonForRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.ButtonForRegistration.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonForRegistration.ForeColor = System.Drawing.Color.White;
            this.ButtonForRegistration.Location = new System.Drawing.Point(368, 451);
            this.ButtonForRegistration.Name = "ButtonForRegistration";
            this.ButtonForRegistration.Size = new System.Drawing.Size(274, 56);
            this.ButtonForRegistration.TabIndex = 34;
            this.ButtonForRegistration.Text = "Registration";
            this.ButtonForRegistration.UseVisualStyleBackColor = false;
            this.ButtonForRegistration.Click += new System.EventHandler(this.ButtonForRegistration_Click);
            // 
            // RichTextBoxRole
            // 
            this.RichTextBoxRole.BackColor = System.Drawing.Color.Black;
            this.RichTextBoxRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxRole.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxRole.ForeColor = System.Drawing.Color.White;
            this.RichTextBoxRole.Location = new System.Drawing.Point(281, 369);
            this.RichTextBoxRole.Name = "RichTextBoxRole";
            this.RichTextBoxRole.Size = new System.Drawing.Size(280, 45);
            this.RichTextBoxRole.TabIndex = 35;
            this.RichTextBoxRole.Text = "Role";
            this.RichTextBoxRole.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBoxRole_MouseClick);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.RichTextBoxRole);
            this.Controls.Add(this.ButtonForRegistration);
            this.Controls.Add(this.ButtonForSelectPhotoProfile);
            this.Controls.Add(this.RichTextBoxEmail);
            this.Controls.Add(this.RichTextBoxPassword);
            this.Controls.Add(this.RichTextBoxLogin);
            this.Controls.Add(this.LinkLabelSignIn);
            this.Controls.Add(this.LabelAlreadyHave);
            this.Controls.Add(this.LabelCreateAc);
            this.Controls.Add(this.PictureBoxForProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NKC";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxForProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelCreateAc;
        private System.Windows.Forms.Label LabelAlreadyHave;
        private System.Windows.Forms.LinkLabel LinkLabelSignIn;
        private System.Windows.Forms.RichTextBox RichTextBoxLogin;
        private System.Windows.Forms.RichTextBox RichTextBoxPassword;
        private System.Windows.Forms.RichTextBox RichTextBoxEmail;
        private System.Windows.Forms.PictureBox PictureBoxForProfile;
        private System.Windows.Forms.Button ButtonForSelectPhotoProfile;
        private System.Windows.Forms.Button ButtonForRegistration;
        private System.Windows.Forms.RichTextBox RichTextBoxRole;
    }
}