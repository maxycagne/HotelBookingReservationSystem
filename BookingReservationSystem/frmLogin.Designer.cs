namespace BookingReservationSystem
{
    partial class frmLogin
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
            inputUsernameClient = new TextBox();
            pictureBox4 = new PictureBox();
            btnLogin = new PictureBox();
            label1 = new Label();
            btnAdmin = new Label();
            welcomePictureBox = new PictureBox();
            label2 = new Label();
            btnExit = new PictureBox();
            btnHidePasswordClient = new PictureBox();
            btnShowPasswordClient = new PictureBox();
            inputPasswordClient = new TextBox();
            ((System.ComponentModel.ISupportInitialize)icon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)welcomePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHidePasswordClient).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnShowPasswordClient).BeginInit();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.Location = new Point(621, 149);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(174, 34);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Client Login";
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
            // inputUsernameClient
            // 
            inputUsernameClient.BackColor = SystemColors.ButtonHighlight;
            inputUsernameClient.BorderStyle = BorderStyle.None;
            inputUsernameClient.Font = new Font("Century Gothic", 10F);
            inputUsernameClient.ForeColor = SystemColors.ButtonShadow;
            inputUsernameClient.Location = new Point(614, 253);
            inputUsernameClient.Name = "inputUsernameClient";
            inputUsernameClient.Size = new Size(243, 21);
            inputUsernameClient.TabIndex = 10;
            inputUsernameClient.Text = "Enter Username";
            inputUsernameClient.MouseClick += inputUsernameClient_MouseClick;
            inputUsernameClient.TextChanged += inputUsernameClient_TextChanged;
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
            // btnAdmin
            // 
            btnAdmin.AutoSize = true;
            btnAdmin.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.FromArgb(0, 123, 255);
            btnAdmin.Location = new Point(703, 484);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(63, 19);
            btnAdmin.TabIndex = 16;
            btnAdmin.Text = "Admin";
            btnAdmin.Click += btnAdmin_Click;
            btnAdmin.MouseLeave += btnAdmin_MouseLeave;
            btnAdmin.MouseHover += btnAdmin_MouseHover;
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
            label2.Location = new Point(765, 483);
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
            btnExit.Click += Exit_Click_1;
            // 
            // btnHidePasswordClient
            // 
            btnHidePasswordClient.Image = Properties.Resources.show;
            btnHidePasswordClient.Location = new Point(822, 341);
            btnHidePasswordClient.Name = "btnHidePasswordClient";
            btnHidePasswordClient.Size = new Size(35, 29);
            btnHidePasswordClient.SizeMode = PictureBoxSizeMode.Zoom;
            btnHidePasswordClient.TabIndex = 20;
            btnHidePasswordClient.TabStop = false;
            btnHidePasswordClient.Click += btnHidePasswordClient_Click;
            // 
            // btnShowPasswordClient
            // 
            btnShowPasswordClient.Image = Properties.Resources.hide;
            btnShowPasswordClient.Location = new Point(822, 340);
            btnShowPasswordClient.Name = "btnShowPasswordClient";
            btnShowPasswordClient.Size = new Size(35, 29);
            btnShowPasswordClient.SizeMode = PictureBoxSizeMode.Zoom;
            btnShowPasswordClient.TabIndex = 20;
            btnShowPasswordClient.TabStop = false;
            btnShowPasswordClient.Click += btnShowPasswordClient_Click;
            // 
            // inputPasswordClient
            // 
            inputPasswordClient.BackColor = SystemColors.ButtonHighlight;
            inputPasswordClient.BorderStyle = BorderStyle.None;
            inputPasswordClient.Font = new Font("Century Gothic", 10F);
            inputPasswordClient.ForeColor = SystemColors.ButtonShadow;
            inputPasswordClient.Location = new Point(614, 342);
            inputPasswordClient.Name = "inputPasswordClient";
            inputPasswordClient.Size = new Size(243, 21);
            inputPasswordClient.TabIndex = 11;
            inputPasswordClient.Text = "Enter Password";
            inputPasswordClient.MouseClick += inputPasswordClient_MouseClick;
            inputPasswordClient.TextChanged += inputPasswordClient_TextChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(881, 550);
            Controls.Add(btnShowPasswordClient);
            Controls.Add(btnHidePasswordClient);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(btnAdmin);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(passwordPictureBox);
            Controls.Add(inputPasswordClient);
            Controls.Add(inputUsernameClient);
            Controls.Add(loginPictureBox);
            Controls.Add(pictureBox2);
            Controls.Add(icon1);
            Controls.Add(loginLabel);
            Controls.Add(pictureBox4);
            Controls.Add(welcomePictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
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
            ((System.ComponentModel.ISupportInitialize)btnHidePasswordClient).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnShowPasswordClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label loginLabel;
        private PictureBox icon1;
        private PictureBox pictureBox2;
        private PictureBox loginPictureBox;
        private PictureBox passwordPictureBox;
        private TextBox inputUsernameClient;
        private PictureBox pictureBox4;
        private PictureBox btnLogin;
        private Label label1;
        private Label btnAdmin;
        private PictureBox welcomePictureBox;
        private Label label2;
        private PictureBox btnExit;
        private PictureBox btnHidePasswordClient;
        private PictureBox btnShowPasswordClient;
        private TextBox inputPasswordClient;
    }
}