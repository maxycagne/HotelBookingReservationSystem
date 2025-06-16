namespace BookingReservationSystem
{
    partial class frmAdminLogin
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
            icon1 = new PictureBox();
            pictureBox2 = new PictureBox();
            loginPictureBox = new PictureBox();
            passwordPictureBox = new PictureBox();
            inputUsernameAdmin = new TextBox();
            inputPasswordAdmin = new TextBox();
            pictureBox4 = new PictureBox();
            btnLogin = new PictureBox();
            label1 = new Label();
            btnClient = new Label();
            welcomePictureBox = new PictureBox();
            label2 = new Label();
            btnExit = new PictureBox();
            btnHidePasswordAdmin = new PictureBox();
            btnShowPasswordAdmin = new PictureBox();
            btnChangePass = new Label();
            ((System.ComponentModel.ISupportInitialize)icon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)welcomePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHidePasswordAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnShowPasswordAdmin).BeginInit();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(616, 147);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(184, 34);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Admin Login";
            // 
            // icon1
            // 
            icon1.Image = Properties.Resources.user_interface;
            icon1.Location = new Point(643, 51);
            icon1.Name = "icon1";
            icon1.Size = new Size(130, 93);
            icon1.SizeMode = PictureBoxSizeMode.Zoom;
            icon1.TabIndex = 5;
            icon1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2024_05_14_195513_removebg_preview;
            pictureBox2.Location = new Point(585, 193);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(305, 139);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // loginPictureBox
            // 
            loginPictureBox.Image = Properties.Resources.user;
            loginPictureBox.Location = new Point(561, 246);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(45, 33);
            loginPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            loginPictureBox.TabIndex = 8;
            loginPictureBox.TabStop = false;
            // 
            // passwordPictureBox
            // 
            passwordPictureBox.Image = Properties.Resources.padlock;
            passwordPictureBox.Location = new Point(561, 338);
            passwordPictureBox.Name = "passwordPictureBox";
            passwordPictureBox.Size = new Size(45, 33);
            passwordPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            passwordPictureBox.TabIndex = 9;
            passwordPictureBox.TabStop = false;
            // 
            // inputUsernameAdmin
            // 
            inputUsernameAdmin.BackColor = SystemColors.ButtonHighlight;
            inputUsernameAdmin.BorderStyle = BorderStyle.None;
            inputUsernameAdmin.Font = new Font("Century Gothic", 10F);
            inputUsernameAdmin.ForeColor = SystemColors.ButtonShadow;
            inputUsernameAdmin.Location = new Point(614, 253);
            inputUsernameAdmin.Name = "inputUsernameAdmin";
            inputUsernameAdmin.Size = new Size(243, 21);
            inputUsernameAdmin.TabIndex = 10;
            inputUsernameAdmin.Text = "Enter Username";
            inputUsernameAdmin.MouseClick += inputUsernameAdmin_MouseClick;
            inputUsernameAdmin.TextChanged += inputUsernameAdmin_TextChanged;
            // 
            // inputPasswordAdmin
            // 
            inputPasswordAdmin.BackColor = SystemColors.ButtonHighlight;
            inputPasswordAdmin.BorderStyle = BorderStyle.None;
            inputPasswordAdmin.Font = new Font("Century Gothic", 10F);
            inputPasswordAdmin.ForeColor = SystemColors.ButtonShadow;
            inputPasswordAdmin.Location = new Point(614, 342);
            inputPasswordAdmin.Name = "inputPasswordAdmin";
            inputPasswordAdmin.Size = new Size(243, 21);
            inputPasswordAdmin.TabIndex = 11;
            inputPasswordAdmin.Text = "Enter Password";
            inputPasswordAdmin.MouseClick += inputPasswordAdmin_MouseClick;
            inputPasswordAdmin.TextChanged += inputPasswordAdmin_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_05_14_195513_removebg_preview;
            pictureBox4.Location = new Point(585, 285);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(305, 139);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Image = Properties.Resources.Screenshot_2024_05_14_212811_removebg_preview;
            btnLogin.Location = new Point(585, 396);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(261, 82);
            btnLogin.SizeMode = PictureBoxSizeMode.Zoom;
            btnLogin.TabIndex = 14;
            btnLogin.TabStop = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(614, 483);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 15;
            label1.Text = "Click Here";
            // 
            // btnClient
            // 
            btnClient.AutoSize = true;
            btnClient.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClient.ForeColor = Color.FromArgb(0, 123, 255);
            btnClient.Location = new Point(703, 484);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(55, 19);
            btnClient.TabIndex = 16;
            btnClient.Text = "Client";
            btnClient.Click += btnClient_Click;
            btnClient.MouseLeave += btnClient_MouseLeave;
            btnClient.MouseHover += btnClient_MouseHover;
            // 
            // welcomePictureBox
            // 
            welcomePictureBox.Image = Properties.Resources.Welcome_to__4_;
            welcomePictureBox.Location = new Point(-4, -193);
            welcomePictureBox.Name = "welcomePictureBox";
            welcomePictureBox.Size = new Size(664, 931);
            welcomePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            welcomePictureBox.TabIndex = 3;
            welcomePictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(755, 484);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 17;
            label2.Text = "User";
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.remove_button;
            btnExit.Location = new Point(840, 6);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 34);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 18;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnHidePasswordAdmin
            // 
            btnHidePasswordAdmin.Image = Properties.Resources.show;
            btnHidePasswordAdmin.Location = new Point(822, 340);
            btnHidePasswordAdmin.Name = "btnHidePasswordAdmin";
            btnHidePasswordAdmin.Size = new Size(35, 29);
            btnHidePasswordAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            btnHidePasswordAdmin.TabIndex = 20;
            btnHidePasswordAdmin.TabStop = false;
            btnHidePasswordAdmin.Click += btnHidePasswordAdmin_Click;
            // 
            // btnShowPasswordAdmin
            // 
            btnShowPasswordAdmin.Image = Properties.Resources.hide;
            btnShowPasswordAdmin.Location = new Point(822, 340);
            btnShowPasswordAdmin.Name = "btnShowPasswordAdmin";
            btnShowPasswordAdmin.Size = new Size(35, 29);
            btnShowPasswordAdmin.SizeMode = PictureBoxSizeMode.Zoom;
            btnShowPasswordAdmin.TabIndex = 21;
            btnShowPasswordAdmin.TabStop = false;
            btnShowPasswordAdmin.Click += btnShowPasswordAdmin_Click;
            // 
            // btnChangePass
            // 
            btnChangePass.AutoSize = true;
            btnChangePass.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            btnChangePass.ForeColor = Color.FromArgb(0, 123, 255);
            btnChangePass.Location = new Point(703, 387);
            btnChangePass.Name = "btnChangePass";
            btnChangePass.Size = new Size(155, 18);
            btnChangePass.TabIndex = 22;
            btnChangePass.Text = "Change a password";
            btnChangePass.Click += btnChangePass_Click;
            btnChangePass.MouseLeave += btnChangePass_MouseLeave;
            btnChangePass.MouseHover += btnChangePass_MouseHover;
            // 
            // frmAdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(881, 550);
            Controls.Add(btnChangePass);
            Controls.Add(btnShowPasswordAdmin);
            Controls.Add(btnHidePasswordAdmin);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(btnClient);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(passwordPictureBox);
            Controls.Add(inputPasswordAdmin);
            Controls.Add(pictureBox4);
            Controls.Add(inputUsernameAdmin);
            Controls.Add(loginPictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(icon1);
            Controls.Add(loginLabel);
            Controls.Add(welcomePictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)icon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)welcomePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHidePasswordAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnShowPasswordAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label loginLabel;
        private PictureBox icon1;
        private PictureBox pictureBox2;
        private PictureBox loginPictureBox;
        private PictureBox passwordPictureBox;
        private TextBox inputUsernameAdmin;
        private TextBox inputPasswordAdmin;
        private PictureBox pictureBox4;
        private PictureBox btnLogin;
        private Label label1;
        private Label btnClient;
        private PictureBox welcomePictureBox;
        private Label label2;
        private PictureBox btnExit;
        private PictureBox btnHidePasswordAdmin;
        private PictureBox btnShowPasswordAdmin;
        private Label btnChangePass;
    }
}