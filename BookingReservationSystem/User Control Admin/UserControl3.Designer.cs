namespace BookingReservationSystem.User_Control
{
    partial class UserControl3
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
            descriptionInput = new TextBox();
            costInput = new TextBox();
            btnSave = new Button();
            label13 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            roomTypeinput = new ComboBox();
            pictureBox2 = new PictureBox();
            roomNumInput = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            searchClientUser = new TabPage();
            roomNum = new TextBox();
            btnSearch = new PictureBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            updateAndDeleteUser = new TabPage();
            roomtypeinputs = new ComboBox();
            Costs = new TextBox();
            roomnumberInput = new TextBox();
            label14 = new Label();
            pictureBox10 = new PictureBox();
            label12 = new Label();
            descriptions = new TextBox();
            pictureBox9 = new PictureBox();
            label10 = new Label();
            pictureBox8 = new PictureBox();
            label9 = new Label();
            pictureBox7 = new PictureBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            label8 = new Label();
            tabAddClient.SuspendLayout();
            addClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            searchClientUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            updateAndDeleteUser.SuspendLayout();
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
            tabAddClient.Location = new Point(18, 20);
            tabAddClient.Name = "tabAddClient";
            tabAddClient.SelectedIndex = 0;
            tabAddClient.Size = new Size(811, 422);
            tabAddClient.TabIndex = 1;
            tabAddClient.Selected += tabAddClient_Selected;
            tabAddClient.Leave += tabAddClient_Leave;
            // 
            // addClient
            // 
            addClient.BackColor = Color.FromArgb(0, 123, 255);
            addClient.BackgroundImageLayout = ImageLayout.Stretch;
            addClient.Controls.Add(descriptionInput);
            addClient.Controls.Add(costInput);
            addClient.Controls.Add(btnSave);
            addClient.Controls.Add(label13);
            addClient.Controls.Add(label5);
            addClient.Controls.Add(pictureBox3);
            addClient.Controls.Add(label3);
            addClient.Controls.Add(roomTypeinput);
            addClient.Controls.Add(pictureBox2);
            addClient.Controls.Add(roomNumInput);
            addClient.Controls.Add(label2);
            addClient.Controls.Add(pictureBox1);
            addClient.Controls.Add(label1);
            addClient.Controls.Add(pictureBox4);
            addClient.ForeColor = SystemColors.Control;
            addClient.Location = new Point(4, 28);
            addClient.Name = "addClient";
            addClient.Padding = new Padding(3);
            addClient.Size = new Size(803, 390);
            addClient.TabIndex = 0;
            addClient.Text = "Add Room";
            addClient.Leave += addClient_Leave;
            // 
            // descriptionInput
            // 
            descriptionInput.BorderStyle = BorderStyle.None;
            descriptionInput.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionInput.Location = new Point(46, 225);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(203, 100);
            descriptionInput.TabIndex = 33;
            // 
            // costInput
            // 
            costInput.BorderStyle = BorderStyle.None;
            costInput.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costInput.Location = new Point(350, 225);
            costInput.Name = "costInput";
            costInput.Size = new Size(203, 29);
            costInput.TabIndex = 32;
            costInput.KeyPress += costInput_KeyPress;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = Color.FromArgb(0, 123, 255);
            btnSave.Location = new Point(638, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 44);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(0, 123, 255);
            label13.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(33, 184);
            label13.Name = "label13";
            label13.Size = new Size(109, 22);
            label13.TabIndex = 29;
            label13.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(339, 184);
            label5.Name = "label5";
            label5.Size = new Size(49, 22);
            label5.TabIndex = 27;
            label5.Text = "Cost";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox3.Location = new Point(319, 197);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(275, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(339, 68);
            label3.Name = "label3";
            label3.Size = new Size(108, 22);
            label3.TabIndex = 25;
            label3.Text = "Room Type";
            // 
            // roomTypeinput
            // 
            roomTypeinput.BackColor = Color.White;
            roomTypeinput.FlatStyle = FlatStyle.Flat;
            roomTypeinput.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomTypeinput.FormattingEnabled = true;
            roomTypeinput.Location = new Point(350, 105);
            roomTypeinput.Name = "roomTypeinput";
            roomTypeinput.Size = new Size(218, 31);
            roomTypeinput.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox2.Location = new Point(319, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // roomNumInput
            // 
            roomNumInput.BorderStyle = BorderStyle.None;
            roomNumInput.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomNumInput.Location = new Point(60, 105);
            roomNumInput.Name = "roomNumInput";
            roomNumInput.Size = new Size(203, 29);
            roomNumInput.TabIndex = 10;
            roomNumInput.KeyPress += roomNumInput_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(33, 68);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 3;
            label2.Text = "Room Number";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox1.Location = new Point(22, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Room";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_05_19_233536;
            pictureBox4.Location = new Point(22, 197);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(250, 151);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // searchClientUser
            // 
            searchClientUser.BackColor = Color.FromArgb(0, 123, 255);
            searchClientUser.Controls.Add(roomNum);
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
            searchClientUser.Text = "Search Room";
            // 
            // roomNum
            // 
            roomNum.BorderStyle = BorderStyle.None;
            roomNum.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomNum.Location = new Point(52, 98);
            roomNum.Name = "roomNum";
            roomNum.Size = new Size(200, 25);
            roomNum.TabIndex = 11;
            roomNum.KeyPress += roomNum_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.icons8_search_50;
            btnSearch.Location = new Point(275, 93);
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
            label7.Location = new Point(43, 65);
            label7.Name = "label7";
            label7.Size = new Size(128, 19);
            label7.TabIndex = 6;
            label7.Text = "Room Number";
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
            label6.Location = new Point(27, 25);
            label6.Name = "label6";
            label6.Size = new Size(166, 28);
            label6.TabIndex = 1;
            label6.Text = "Search Room";
            // 
            // updateAndDeleteUser
            // 
            updateAndDeleteUser.BackColor = Color.FromArgb(0, 123, 255);
            updateAndDeleteUser.Controls.Add(roomtypeinputs);
            updateAndDeleteUser.Controls.Add(Costs);
            updateAndDeleteUser.Controls.Add(roomnumberInput);
            updateAndDeleteUser.Controls.Add(label14);
            updateAndDeleteUser.Controls.Add(pictureBox10);
            updateAndDeleteUser.Controls.Add(label12);
            updateAndDeleteUser.Controls.Add(descriptions);
            updateAndDeleteUser.Controls.Add(pictureBox9);
            updateAndDeleteUser.Controls.Add(label10);
            updateAndDeleteUser.Controls.Add(pictureBox8);
            updateAndDeleteUser.Controls.Add(label9);
            updateAndDeleteUser.Controls.Add(pictureBox7);
            updateAndDeleteUser.Controls.Add(btnDelete);
            updateAndDeleteUser.Controls.Add(btnUpdate);
            updateAndDeleteUser.Controls.Add(label8);
            updateAndDeleteUser.Location = new Point(4, 28);
            updateAndDeleteUser.Name = "updateAndDeleteUser";
            updateAndDeleteUser.Padding = new Padding(3);
            updateAndDeleteUser.Size = new Size(803, 390);
            updateAndDeleteUser.TabIndex = 2;
            updateAndDeleteUser.Text = "Update and Delete Room";
            updateAndDeleteUser.Leave += updateAndDeleteUser_Leave;
            // 
            // roomtypeinputs
            // 
            roomtypeinputs.BackColor = Color.White;
            roomtypeinputs.FlatStyle = FlatStyle.Flat;
            roomtypeinputs.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomtypeinputs.FormattingEnabled = true;
            roomtypeinputs.Location = new Point(349, 104);
            roomtypeinputs.Name = "roomtypeinputs";
            roomtypeinputs.Size = new Size(218, 31);
            roomtypeinputs.TabIndex = 40;
            // 
            // Costs
            // 
            Costs.BorderStyle = BorderStyle.None;
            Costs.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Costs.Location = new Point(356, 219);
            Costs.Name = "Costs";
            Costs.Size = new Size(203, 29);
            Costs.TabIndex = 39;
            Costs.KeyPress += Costs_KeyPress;
            // 
            // roomnumberInput
            // 
            roomnumberInput.BorderStyle = BorderStyle.None;
            roomnumberInput.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomnumberInput.Location = new Point(58, 105);
            roomnumberInput.Name = "roomnumberInput";
            roomnumberInput.Size = new Size(203, 29);
            roomnumberInput.TabIndex = 38;
            roomnumberInput.KeyPress += roomnumberInput_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(329, 182);
            label14.Name = "label14";
            label14.Size = new Size(49, 22);
            label14.TabIndex = 37;
            label14.Text = "Cost";
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox10.Location = new Point(319, 192);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(275, 86);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 36;
            pictureBox10.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(0, 123, 255);
            label12.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(34, 182);
            label12.Name = "label12";
            label12.Size = new Size(109, 22);
            label12.TabIndex = 35;
            label12.Text = "Description";
            // 
            // descriptions
            // 
            descriptions.BorderStyle = BorderStyle.None;
            descriptions.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptions.Location = new Point(47, 219);
            descriptions.Multiline = true;
            descriptions.Name = "descriptions";
            descriptions.Size = new Size(203, 100);
            descriptions.TabIndex = 34;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Screenshot_2024_05_19_233536;
            pictureBox9.Location = new Point(23, 192);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(250, 151);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 31;
            pictureBox9.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(329, 68);
            label10.Name = "label10";
            label10.Size = new Size(108, 22);
            label10.TabIndex = 15;
            label10.Text = "Room Type";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox8.Location = new Point(319, 78);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(275, 86);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(33, 68);
            label9.Name = "label9";
            label9.Size = new Size(137, 22);
            label9.TabIndex = 13;
            label9.Text = "Room Number";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox7.Location = new Point(22, 78);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(275, 86);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 12;
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
            btnDelete.Location = new Point(632, 330);
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
            btnUpdate.Location = new Point(464, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 44);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(26, 24);
            label8.Name = "label8";
            label8.Size = new Size(306, 28);
            label8.TabIndex = 1;
            label8.Text = "Update and Delete Room";
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabAddClient);
            Name = "UserControl3";
            Size = new Size(847, 463);
            Load += UserControl3_Load;
            tabAddClient.ResumeLayout(false);
            addClient.ResumeLayout(false);
            addClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            searchClientUser.ResumeLayout(false);
            searchClientUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            updateAndDeleteUser.ResumeLayout(false);
            updateAndDeleteUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabAddClient;
        private TabPage addClient;
        private TextBox roomNumInput;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private TabPage searchClientUser;
        private TextBox roomNum;
        private PictureBox btnSearch;
        private DataGridView dataGridView1;
        private Label label7;
        private PictureBox pictureBox5;
        private Label label6;
        private TabPage updateAndDeleteUser;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label8;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label13;
        private PictureBox pictureBox4;
        private Button btnSave;
        private TextBox descriptionInput;
        private TextBox costInput;
        private Label label9;
        private PictureBox pictureBox7;
        private Label label10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private TextBox descriptions;
        private Label label12;
        private PictureBox pictureBox10;
        private Label label14;
        private TextBox roomnumberInput;
        private TextBox Costs;
        private ComboBox roomtypeinputs;
        private ComboBox roomTypeinput;
    }
}
