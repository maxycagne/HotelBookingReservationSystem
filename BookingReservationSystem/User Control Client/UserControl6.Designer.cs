namespace BookingReservationSystem.User_Control_Client
{
    partial class UserControl6
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
            searchClientUser = new TabPage();
            nameCustumerSearch = new TextBox();
            btnSearch = new PictureBox();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            dataGridView2 = new DataGridView();
            tabAddClient = new TabControl();
            tabPage1 = new TabPage();
            contactNum = new TextBox();
            gender = new ComboBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            btnAdd = new Button();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            customerName = new TextBox();
            pictureBox5 = new PictureBox();
            btnAddCustomer = new Button();
            addClient = new TabPage();
            contactNumUpdate = new TextBox();
            genderUpdate = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox6 = new PictureBox();
            label4 = new Label();
            nameCustomerUpdate = new TextBox();
            pictureBox7 = new PictureBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            searchClientUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabAddClient.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            addClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // searchClientUser
            // 
            searchClientUser.BackColor = Color.FromArgb(0, 123, 255);
            searchClientUser.Controls.Add(nameCustumerSearch);
            searchClientUser.Controls.Add(btnSearch);
            searchClientUser.Controls.Add(label2);
            searchClientUser.Controls.Add(pictureBox4);
            searchClientUser.Controls.Add(dataGridView2);
            searchClientUser.Location = new Point(4, 28);
            searchClientUser.Name = "searchClientUser";
            searchClientUser.Padding = new Padding(3);
            searchClientUser.Size = new Size(803, 390);
            searchClientUser.TabIndex = 1;
            searchClientUser.Text = "Search Customers";
            searchClientUser.Leave += searchClientUser_Leave;
            // 
            // nameCustumerSearch
            // 
            nameCustumerSearch.BorderStyle = BorderStyle.None;
            nameCustumerSearch.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameCustumerSearch.Location = new Point(36, 35);
            nameCustumerSearch.Name = "nameCustumerSearch";
            nameCustumerSearch.Size = new Size(174, 23);
            nameCustumerSearch.TabIndex = 24;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.icons8_search_50;
            btnSearch.Location = new Point(233, 31);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(41, 31);
            btnSearch.SizeMode = PictureBoxSizeMode.Zoom;
            btnSearch.TabIndex = 23;
            btnSearch.TabStop = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(31, 2);
            label2.Name = "label2";
            label2.Size = new Size(64, 22);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox4.Location = new Point(14, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(218, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.FromArgb(0, 123, 255);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.GridColor = Color.Black;
            dataGridView2.Location = new Point(0, 92);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(800, 297);
            dataGridView2.TabIndex = 20;
            // 
            // tabAddClient
            // 
            tabAddClient.Controls.Add(tabPage1);
            tabAddClient.Controls.Add(searchClientUser);
            tabAddClient.Controls.Add(addClient);
            tabAddClient.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabAddClient.Location = new Point(18, 20);
            tabAddClient.Name = "tabAddClient";
            tabAddClient.SelectedIndex = 0;
            tabAddClient.Size = new Size(811, 422);
            tabAddClient.TabIndex = 2;
            tabAddClient.Selected += tabAddClient_Selected;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(0, 123, 255);
            tabPage1.Controls.Add(contactNum);
            tabPage1.Controls.Add(gender);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(customerName);
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Controls.Add(btnAddCustomer);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(803, 390);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Add Customer";
            tabPage1.Leave += tabPage1_Leave;
            // 
            // contactNum
            // 
            contactNum.BorderStyle = BorderStyle.None;
            contactNum.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactNum.Location = new Point(506, 84);
            contactNum.Name = "contactNum";
            contactNum.Size = new Size(198, 25);
            contactNum.TabIndex = 118;
            contactNum.TextChanged += contactNum_TextChanged;
            contactNum.KeyPress += contactNum_KeyPress;
            // 
            // gender
            // 
            gender.BackColor = Color.White;
            gender.FlatStyle = FlatStyle.Flat;
            gender.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female", "Others" });
            gender.Location = new Point(286, 220);
            gender.Name = "gender";
            gender.Size = new Size(214, 27);
            gender.TabIndex = 117;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(286, 179);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 116;
            label5.Text = "Gender";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox2.Location = new Point(263, 170);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(259, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 115;
            pictureBox2.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.FromArgb(0, 123, 255);
            btnAdd.Location = new Point(331, 316);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 44);
            btnAdd.TabIndex = 114;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(501, 48);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 113;
            label6.Text = "Phone Number";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox3.Location = new Point(478, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(256, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 112;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(86, 43);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 111;
            label7.Text = "Name";
            // 
            // customerName
            // 
            customerName.BorderStyle = BorderStyle.None;
            customerName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerName.Location = new Point(91, 84);
            customerName.Name = "customerName";
            customerName.Size = new Size(198, 25);
            customerName.TabIndex = 110;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox5.Location = new Point(63, 34);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(256, 130);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 109;
            pictureBox5.TabStop = false;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.BackColor = Color.White;
            btnAddCustomer.ForeColor = Color.FromArgb(0, 123, 255);
            btnAddCustomer.Location = new Point(313, 451);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(150, 44);
            btnAddCustomer.TabIndex = 49;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // addClient
            // 
            addClient.BackColor = Color.FromArgb(0, 123, 255);
            addClient.BackgroundImageLayout = ImageLayout.Stretch;
            addClient.Controls.Add(contactNumUpdate);
            addClient.Controls.Add(genderUpdate);
            addClient.Controls.Add(label1);
            addClient.Controls.Add(pictureBox1);
            addClient.Controls.Add(label3);
            addClient.Controls.Add(pictureBox6);
            addClient.Controls.Add(label4);
            addClient.Controls.Add(nameCustomerUpdate);
            addClient.Controls.Add(pictureBox7);
            addClient.Controls.Add(btnDelete);
            addClient.Controls.Add(btnUpdate);
            addClient.ForeColor = SystemColors.Control;
            addClient.Location = new Point(4, 28);
            addClient.Name = "addClient";
            addClient.Padding = new Padding(3);
            addClient.Size = new Size(803, 390);
            addClient.TabIndex = 0;
            addClient.Text = "Update and Delete Customer";
            addClient.Leave += addClient_Leave;
            // 
            // contactNumUpdate
            // 
            contactNumUpdate.BorderStyle = BorderStyle.None;
            contactNumUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contactNumUpdate.Location = new Point(514, 88);
            contactNumUpdate.Name = "contactNumUpdate";
            contactNumUpdate.Size = new Size(198, 25);
            contactNumUpdate.TabIndex = 127;
            contactNumUpdate.TextChanged += contactNumUpdate_TextChanged;
            contactNumUpdate.KeyPress += contactNumUpdate_KeyPress;
            // 
            // genderUpdate
            // 
            genderUpdate.BackColor = Color.White;
            genderUpdate.FlatStyle = FlatStyle.Flat;
            genderUpdate.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderUpdate.FormattingEnabled = true;
            genderUpdate.Items.AddRange(new object[] { "Male", "Female", "Others" });
            genderUpdate.Location = new Point(294, 224);
            genderUpdate.Name = "genderUpdate";
            genderUpdate.Size = new Size(214, 27);
            genderUpdate.TabIndex = 126;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(294, 183);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 125;
            label1.Text = "Gender";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox1.Location = new Point(271, 174);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 124;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(509, 52);
            label3.Name = "label3";
            label3.Size = new Size(155, 23);
            label3.TabIndex = 123;
            label3.Text = "Phone Number";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox6.Location = new Point(486, 38);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(256, 130);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 122;
            pictureBox6.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(94, 47);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 121;
            label4.Text = "Name";
            // 
            // nameCustomerUpdate
            // 
            nameCustomerUpdate.BorderStyle = BorderStyle.None;
            nameCustomerUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameCustomerUpdate.Location = new Point(99, 88);
            nameCustomerUpdate.Name = "nameCustomerUpdate";
            nameCustomerUpdate.Size = new Size(198, 25);
            nameCustomerUpdate.TabIndex = 120;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox7.Location = new Point(71, 38);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(256, 130);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 119;
            pictureBox7.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(421, 324);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 44);
            btnDelete.TabIndex = 109;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.FromArgb(0, 123, 255);
            btnUpdate.Location = new Point(243, 324);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 44);
            btnUpdate.TabIndex = 104;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UserControl6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabAddClient);
            Name = "UserControl6";
            Size = new Size(847, 463);
            searchClientUser.ResumeLayout(false);
            searchClientUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabAddClient.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            addClient.ResumeLayout(false);
            addClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage searchClientUser;
        private TextBox nameCustumerSearch;
        private PictureBox btnSearch;
        private Label label2;
        private PictureBox pictureBox4;
        private DataGridView dataGridView2;
        private TabControl tabAddClient;
        private TabPage tabPage1;
        private TabPage addClient;
        private Button btnAddCustomer;
        private Button btnUpdate;
        private TextBox contactNum;
        private ComboBox gender;
        private Label label5;
        private PictureBox pictureBox2;
        private Button btnAdd;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
        private TextBox customerName;
        private PictureBox pictureBox5;
        private Button btnDelete;
        private TextBox contactNumUpdate;
        private ComboBox genderUpdate;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox6;
        private Label label4;
        private TextBox nameCustomerUpdate;
        private PictureBox pictureBox7;
    }
}
