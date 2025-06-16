namespace BookingReservationSystem.User_Control
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabAddClient = new TabControl();
            addClient = new TabPage();
            addressInput = new TextBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            btnShowPassword = new PictureBox();
            btnHidePassword = new PictureBox();
            phoneNumberInput = new TextBox();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            btnCreate = new Button();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            searchClientUser = new TabPage();
            phoneNumber = new TextBox();
            btnSearch = new PictureBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            updateAndDeleteUser = new TabPage();
            btnShow = new PictureBox();
            btnHide = new PictureBox();
            address = new TextBox();
            Password = new TextBox();
            phoneNum = new TextBox();
            Username = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            tabAddClient.SuspendLayout();
            addClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHidePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            searchClientUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            updateAndDeleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // tabAddClient
            // 
            tabAddClient.Controls.Add(addClient);
            tabAddClient.Controls.Add(searchClientUser);
            tabAddClient.Controls.Add(updateAndDeleteUser);
            tabAddClient.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabAddClient.Location = new Point(18, 21);
            tabAddClient.Name = "tabAddClient";
            tabAddClient.SelectedIndex = 0;
            tabAddClient.Size = new Size(811, 422);
            tabAddClient.TabIndex = 0;
            tabAddClient.Selected += tabAddClient_Selected;
            tabAddClient.Leave += tabAddClient_Leave;
            // 
            // addClient
            // 
            addClient.BackColor = Color.FromArgb(0, 123, 255);
            addClient.BackgroundImageLayout = ImageLayout.Stretch;
            addClient.Controls.Add(addressInput);
            addClient.Controls.Add(label5);
            addClient.Controls.Add(pictureBox4);
            addClient.Controls.Add(btnShowPassword);
            addClient.Controls.Add(btnHidePassword);
            addClient.Controls.Add(phoneNumberInput);
            addClient.Controls.Add(passwordInput);
            addClient.Controls.Add(usernameInput);
            addClient.Controls.Add(btnCreate);
            addClient.Controls.Add(label4);
            addClient.Controls.Add(pictureBox3);
            addClient.Controls.Add(label3);
            addClient.Controls.Add(pictureBox2);
            addClient.Controls.Add(label2);
            addClient.Controls.Add(pictureBox1);
            addClient.Controls.Add(label1);
            addClient.ForeColor = SystemColors.Control;
            addClient.Location = new Point(4, 28);
            addClient.Name = "addClient";
            addClient.Padding = new Padding(3);
            addClient.Size = new Size(803, 390);
            addClient.TabIndex = 0;
            addClient.Text = "Add Client User";
            addClient.Leave += addClient_Leave;
            // 
            // addressInput
            // 
            addressInput.BorderStyle = BorderStyle.None;
            addressInput.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            addressInput.Location = new Point(474, 259);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(251, 29);
            addressInput.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(474, 216);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 18;
            label5.Text = "Address";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox4.Location = new Point(443, 226);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(311, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.White;
            btnShowPassword.Image = Properties.Resources.hide;
            btnShowPassword.Location = new Point(681, 133);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(49, 40);
            btnShowPassword.SizeMode = PictureBoxSizeMode.Zoom;
            btnShowPassword.TabIndex = 16;
            btnShowPassword.TabStop = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // btnHidePassword
            // 
            btnHidePassword.BackColor = Color.White;
            btnHidePassword.Image = Properties.Resources.show;
            btnHidePassword.Location = new Point(681, 133);
            btnHidePassword.Name = "btnHidePassword";
            btnHidePassword.Size = new Size(49, 40);
            btnHidePassword.SizeMode = PictureBoxSizeMode.Zoom;
            btnHidePassword.TabIndex = 15;
            btnHidePassword.TabStop = false;
            btnHidePassword.Click += btnHidePassword_Click_1;
            // 
            // phoneNumberInput
            // 
            phoneNumberInput.BorderStyle = BorderStyle.None;
            phoneNumberInput.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            phoneNumberInput.Location = new Point(77, 259);
            phoneNumberInput.Name = "phoneNumberInput";
            phoneNumberInput.Size = new Size(251, 29);
            phoneNumberInput.TabIndex = 12;
            phoneNumberInput.TextChanged += phoneNumberInput_TextChanged;
            phoneNumberInput.KeyPress += phoneNumberInput_KeyPress;
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            passwordInput.Location = new Point(474, 138);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '●';
            passwordInput.Size = new Size(251, 29);
            passwordInput.TabIndex = 11;
            // 
            // usernameInput
            // 
            usernameInput.BorderStyle = BorderStyle.None;
            usernameInput.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            usernameInput.Location = new Point(77, 138);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(251, 29);
            usernameInput.TabIndex = 10;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.White;
            btnCreate.ForeColor = Color.FromArgb(0, 123, 255);
            btnCreate.Location = new Point(319, 337);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 44);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(77, 216);
            label4.Name = "label4";
            label4.Size = new Size(146, 23);
            label4.TabIndex = 8;
            label4.Text = "Phone Number";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox3.Location = new Point(46, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(311, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(474, 89);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox2.Location = new Point(443, 103);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(311, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(77, 89);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox1.Location = new Point(46, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(271, 28);
            label1.TabIndex = 0;
            label1.Text = "Create Client Account";
            // 
            // searchClientUser
            // 
            searchClientUser.BackColor = Color.FromArgb(0, 123, 255);
            searchClientUser.Controls.Add(phoneNumber);
            searchClientUser.Controls.Add(btnSearch);
            searchClientUser.Controls.Add(dataGridView1);
            searchClientUser.Controls.Add(label7);
            searchClientUser.Controls.Add(pictureBox5);
            searchClientUser.Controls.Add(label6);
            searchClientUser.Location = new Point(4, 28);
            searchClientUser.Name = "searchClientUser";
            searchClientUser.Padding = new Padding(3);
            searchClientUser.Size = new Size(803, 390);
            searchClientUser.TabIndex = 1;
            searchClientUser.Text = "Search Client User";
            searchClientUser.Leave += searchClientUser_Leave;
            // 
            // phoneNumber
            // 
            phoneNumber.BorderStyle = BorderStyle.None;
            phoneNumber.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneNumber.Location = new Point(52, 98);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(200, 25);
            phoneNumber.TabIndex = 11;
            phoneNumber.TextChanged += phoneNumber_TextChanged;
            phoneNumber.KeyPress += phoneNumber_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.icons8_search_50;
            btnSearch.Location = new Point(275, 92);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(49, 37);
            btnSearch.SizeMode = PictureBoxSizeMode.Zoom;
            btnSearch.TabIndex = 8;
            btnSearch.TabStop = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(24, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(753, 205);
            dataGridView1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(40, 62);
            label7.Name = "label7";
            label7.Size = new Size(132, 19);
            label7.TabIndex = 6;
            label7.Text = "Phone Number";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox5.Location = new Point(24, 76);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(257, 72);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(24, 22);
            label6.Name = "label6";
            label6.Size = new Size(222, 28);
            label6.TabIndex = 1;
            label6.Text = "Search Client User";
            // 
            // updateAndDeleteUser
            // 
            updateAndDeleteUser.BackColor = Color.FromArgb(0, 123, 255);
            updateAndDeleteUser.Controls.Add(btnShow);
            updateAndDeleteUser.Controls.Add(btnHide);
            updateAndDeleteUser.Controls.Add(address);
            updateAndDeleteUser.Controls.Add(Password);
            updateAndDeleteUser.Controls.Add(phoneNum);
            updateAndDeleteUser.Controls.Add(Username);
            updateAndDeleteUser.Controls.Add(label12);
            updateAndDeleteUser.Controls.Add(label11);
            updateAndDeleteUser.Controls.Add(label10);
            updateAndDeleteUser.Controls.Add(label9);
            updateAndDeleteUser.Controls.Add(btnDelete);
            updateAndDeleteUser.Controls.Add(btnUpdate);
            updateAndDeleteUser.Controls.Add(pictureBox10);
            updateAndDeleteUser.Controls.Add(pictureBox9);
            updateAndDeleteUser.Controls.Add(pictureBox8);
            updateAndDeleteUser.Controls.Add(pictureBox7);
            updateAndDeleteUser.Controls.Add(label8);
            updateAndDeleteUser.Location = new Point(4, 28);
            updateAndDeleteUser.Name = "updateAndDeleteUser";
            updateAndDeleteUser.Padding = new Padding(3);
            updateAndDeleteUser.Size = new Size(803, 390);
            updateAndDeleteUser.TabIndex = 2;
            updateAndDeleteUser.Text = "Update and Delete Client User";
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.White;
            btnShow.Image = Properties.Resources.hide;
            btnShow.Location = new Point(682, 113);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(49, 40);
            btnShow.SizeMode = PictureBoxSizeMode.Zoom;
            btnShow.TabIndex = 21;
            btnShow.TabStop = false;
            btnShow.Click += btnShow_Click_1;
            // 
            // btnHide
            // 
            btnHide.BackColor = Color.White;
            btnHide.Image = Properties.Resources.show;
            btnHide.Location = new Point(682, 113);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(49, 40);
            btnHide.SizeMode = PictureBoxSizeMode.Zoom;
            btnHide.TabIndex = 20;
            btnHide.TabStop = false;
            btnHide.Click += btnHide_Click_1;
            // 
            // address
            // 
            address.BorderStyle = BorderStyle.None;
            address.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            address.Location = new Point(470, 246);
            address.Name = "address";
            address.Size = new Size(251, 29);
            address.TabIndex = 19;
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            Password.Location = new Point(470, 120);
            Password.Name = "Password";
            Password.PasswordChar = '●';
            Password.Size = new Size(251, 29);
            Password.TabIndex = 18;
            // 
            // phoneNum
            // 
            phoneNum.BorderStyle = BorderStyle.None;
            phoneNum.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            phoneNum.Location = new Point(72, 246);
            phoneNum.Name = "phoneNum";
            phoneNum.Size = new Size(251, 29);
            phoneNum.TabIndex = 17;
            phoneNum.TextChanged += phoneNum_TextChanged;
            phoneNum.KeyPress += phoneNum_KeyPress;
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            Username.Location = new Point(72, 120);
            Username.Name = "Username";
            Username.Size = new Size(251, 29);
            Username.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(470, 198);
            label12.Name = "label12";
            label12.Size = new Size(84, 23);
            label12.TabIndex = 15;
            label12.Text = "Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(72, 198);
            label11.Name = "label11";
            label11.Size = new Size(146, 23);
            label11.TabIndex = 14;
            label11.Text = "Phone Number";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(470, 73);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 13;
            label10.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(72, 73);
            label9.Name = "label9";
            label9.Size = new Size(103, 23);
            label9.TabIndex = 12;
            label9.Text = "Username";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(405, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 44);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.FromArgb(0, 123, 255);
            btnUpdate.Location = new Point(222, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 44);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox10.Location = new Point(443, 211);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(311, 100);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox9.Location = new Point(46, 211);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(311, 100);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 7;
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox8.Location = new Point(443, 85);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(311, 100);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 6;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox7.Location = new Point(46, 85);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(311, 100);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 5;
            pictureBox7.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(23, 21);
            label8.Name = "label8";
            label8.Size = new Size(362, 28);
            label8.TabIndex = 1;
            label8.Text = "Update and Delete Client User";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabAddClient);
            Name = "UserControl1";
            Size = new Size(847, 463);
            tabAddClient.ResumeLayout(false);
            addClient.ResumeLayout(false);
            addClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHidePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            searchClientUser.ResumeLayout(false);
            searchClientUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            updateAndDeleteUser.ResumeLayout(false);
            updateAndDeleteUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAddClient;
        private TabPage addClient;
        private TabPage searchClientUser;
        private TabPage updateAndDeleteUser;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox3;
        private Label label3;
        private TextBox usernameInput;
        private Button btnCreate;
        private TextBox phoneNumberInput;
        private TextBox passwordInput;
        private PictureBox btnHidePassword;
        private PictureBox btnShowPassword;
        private Label label5;
        private PictureBox pictureBox4;
        private Label label6;
        private TextBox addressInput;
        private DataGridView dataGridView1;
        private Label label7;
        private PictureBox pictureBox5;
        private PictureBox btnSearch;
        private Label label8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox phoneNumber;
        private TextBox address;
        private TextBox Password;
        private TextBox phoneNum;
        private TextBox Username;
        private PictureBox btnHide;
        private PictureBox btnShow;
    }
}
