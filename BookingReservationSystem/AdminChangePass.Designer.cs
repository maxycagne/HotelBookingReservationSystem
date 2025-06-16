namespace BookingReservationSystem
{
    partial class AdminChangePass
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
            loginLabel = new Label();
            panel1 = new Panel();
            btnExit = new PictureBox();
            btnChangePassword = new Button();
            inputPasswordAdmin = new TextBox();
            pictureBox4 = new PictureBox();
            inputUsernameAdmin = new TextBox();
            pictureBox1 = new PictureBox();
            loginPictureBox = new PictureBox();
            passwordPictureBox = new PictureBox();
            contactNum = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.White;
            loginLabel.Location = new Point(132, 14);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(104, 34);
            loginLabel.TabIndex = 5;
            loginLabel.Text = "Admin";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 123, 255);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(loginLabel);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 63);
            panel1.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.remove_button;
            btnExit.Location = new Point(314, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(27, 24);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 57;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.White;
            btnChangePassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.FromArgb(0, 123, 255);
            btnChangePassword.Location = new Point(70, 342);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(208, 34);
            btnChangePassword.TabIndex = 49;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // inputPasswordAdmin
            // 
            inputPasswordAdmin.BackColor = SystemColors.ButtonHighlight;
            inputPasswordAdmin.BorderStyle = BorderStyle.None;
            inputPasswordAdmin.Font = new Font("Century Gothic", 10F);
            inputPasswordAdmin.ForeColor = SystemColors.ButtonShadow;
            inputPasswordAdmin.Location = new Point(81, 195);
            inputPasswordAdmin.Name = "inputPasswordAdmin";
            inputPasswordAdmin.Size = new Size(197, 21);
            inputPasswordAdmin.TabIndex = 52;
            inputPasswordAdmin.Text = "Enter New Password";
            inputPasswordAdmin.MouseClick += inputPasswordAdmin_MouseClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_05_14_195513_removebg_preview;
            pictureBox4.Location = new Point(49, 69);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(263, 88);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 53;
            pictureBox4.TabStop = false;
            // 
            // inputUsernameAdmin
            // 
            inputUsernameAdmin.BackColor = SystemColors.ButtonHighlight;
            inputUsernameAdmin.BorderStyle = BorderStyle.None;
            inputUsernameAdmin.Font = new Font("Century Gothic", 10F);
            inputUsernameAdmin.ForeColor = SystemColors.ButtonShadow;
            inputUsernameAdmin.Location = new Point(81, 101);
            inputUsernameAdmin.Name = "inputUsernameAdmin";
            inputUsernameAdmin.Size = new Size(197, 21);
            inputUsernameAdmin.TabIndex = 51;
            inputUsernameAdmin.Text = "Enter Username";
            inputUsernameAdmin.MouseClick += inputUsernameAdmin_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_14_195513_removebg_preview;
            pictureBox1.Location = new Point(49, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // loginPictureBox
            // 
            loginPictureBox.Image = Properties.Resources.user;
            loginPictureBox.Location = new Point(12, 95);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(45, 33);
            loginPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            loginPictureBox.TabIndex = 55;
            loginPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Image = Properties.Resources.padlock;
            passwordPictureBox.Location = new Point(12, 191);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(45, 33);
            passwordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            passwordPictureBox.TabIndex = 56;
            passwordPictureBox.TabStop = false;
            // 
            // contactNum
            // 
            contactNum.BackColor = SystemColors.ButtonHighlight;
            contactNum.BorderStyle = BorderStyle.None;
            contactNum.Font = new Font("Century Gothic", 10F);
            contactNum.ForeColor = SystemColors.ButtonShadow;
            contactNum.Location = new Point(81, 287);
            contactNum.Name = "contactNum";
            contactNum.Size = new Size(197, 21);
            contactNum.TabIndex = 57;
            contactNum.Text = "Enter Phone Number";
            
            contactNum.MouseClick += contactNum_MouseClick;
            contactNum.TextChanged += contactNum_TextChanged;
            contactNum.KeyPress += contactNum_KeyPress;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_05_14_195513_removebg_preview;
            pictureBox3.Location = new Point(49, 253);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(263, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.phone_call;
            pictureBox2.Location = new Point(12, 283);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 59;
            pictureBox2.TabStop = false;
            // 
            // AdminChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 403);
            Controls.Add(pictureBox2);
            Controls.Add(contactNum);
            Controls.Add(pictureBox3);
            Controls.Add(passwordPictureBox);
            Controls.Add(loginPictureBox);
            Controls.Add(inputPasswordAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(inputUsernameAdmin);
            Controls.Add(pictureBox4);
            Controls.Add(btnChangePassword);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminChangePass";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Panel panel1;
        private Button btnChangePassword;
        private TextBox inputPasswordAdmin;
        private PictureBox pictureBox4;
        private TextBox inputUsernameAdmin;
        private PictureBox pictureBox1;
        private PictureBox loginPictureBox;
        private PictureBox passwordPictureBox;
        private PictureBox btnExit;
        private TextBox contactNum;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}