namespace BookingReservationSystem.User_Control
{
    partial class UserControl4
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
            updateAndDeleteUser = new TabPage();
            label8 = new Label();
            btnDelete = new Button();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox8 = new PictureBox();
            label9 = new Label();
            description = new TextBox();
            roomType = new TextBox();
            addClient = new TabPage();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            roomTypeInput = new TextBox();
            label13 = new Label();
            btnSave = new Button();
            descriptionInput = new TextBox();
            tabAddClient = new TabControl();
            updateAndDeleteUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            addClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabAddClient.SuspendLayout();
            SuspendLayout();
            // 
            // updateAndDeleteUser
            // 
            updateAndDeleteUser.BackColor = Color.FromArgb(0, 123, 255);
            updateAndDeleteUser.Controls.Add(roomType);
            updateAndDeleteUser.Controls.Add(description);
            updateAndDeleteUser.Controls.Add(label9);
            updateAndDeleteUser.Controls.Add(pictureBox8);
            updateAndDeleteUser.Controls.Add(label4);
            updateAndDeleteUser.Controls.Add(pictureBox3);
            updateAndDeleteUser.Controls.Add(btnDelete);
            updateAndDeleteUser.Controls.Add(label8);
            updateAndDeleteUser.Location = new Point(4, 28);
            updateAndDeleteUser.Name = "updateAndDeleteUser";
            updateAndDeleteUser.Padding = new Padding(3);
            updateAndDeleteUser.Size = new Size(803, 390);
            updateAndDeleteUser.TabIndex = 2;
            updateAndDeleteUser.Text = "Delete Room Type";
            updateAndDeleteUser.Leave += updateAndDeleteUser_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(29, 27);
            label8.Name = "label8";
            label8.Size = new Size(223, 28);
            label8.TabIndex = 1;
            label8.Text = "Delete Room Type";
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
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox3.Location = new Point(54, 97);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(275, 86);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(80, 87);
            label4.Name = "label4";
            label4.Size = new Size(108, 22);
            label4.TabIndex = 14;
            label4.Text = "Room Type";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Screenshot_2024_05_19_233536;
            pictureBox8.Location = new Point(413, 97);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(334, 188);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 31;
            pictureBox8.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 123, 255);
            label9.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(438, 87);
            label9.Name = "label9";
            label9.Size = new Size(109, 22);
            label9.TabIndex = 32;
            label9.Text = "Description";
            // 
            // description
            // 
            description.BorderStyle = BorderStyle.None;
            description.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            description.Location = new Point(457, 130);
            description.Multiline = true;
            description.Name = "description";
            description.Size = new Size(249, 130);
            description.TabIndex = 34;
            // 
            // roomType
            // 
            roomType.BorderStyle = BorderStyle.None;
            roomType.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomType.Location = new Point(82, 124);
            roomType.Name = "roomType";
            roomType.Size = new Size(221, 29);
            roomType.TabIndex = 35;
            // 
            // addClient
            // 
            addClient.BackColor = Color.FromArgb(0, 123, 255);
            addClient.BackgroundImageLayout = ImageLayout.Stretch;
            addClient.Controls.Add(descriptionInput);
            addClient.Controls.Add(roomTypeInput);
            addClient.Controls.Add(btnSave);
            addClient.Controls.Add(label13);
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
            addClient.Text = "Add Room Type";
            addClient.Leave += addClient_Leave;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_05_19_233536;
            pictureBox4.Location = new Point(413, 97);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(334, 188);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Room Type";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox1.Location = new Point(54, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(75, 88);
            label2.Name = "label2";
            label2.Size = new Size(108, 22);
            label2.TabIndex = 3;
            label2.Text = "Room Type";
            // 
            // roomTypeInput
            // 
            roomTypeInput.BorderStyle = BorderStyle.None;
            roomTypeInput.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomTypeInput.Location = new Point(84, 124);
            roomTypeInput.Name = "roomTypeInput";
            roomTypeInput.Size = new Size(221, 29);
            roomTypeInput.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(0, 123, 255);
            label13.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(436, 84);
            label13.Name = "label13";
            label13.Size = new Size(109, 22);
            label13.TabIndex = 29;
            label13.Text = "Description";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = Color.FromArgb(0, 123, 255);
            btnSave.Location = new Point(597, 324);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 44);
            btnSave.TabIndex = 31;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // descriptionInput
            // 
            descriptionInput.BorderStyle = BorderStyle.None;
            descriptionInput.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionInput.Location = new Point(457, 128);
            descriptionInput.Multiline = true;
            descriptionInput.Name = "descriptionInput";
            descriptionInput.Size = new Size(249, 130);
            descriptionInput.TabIndex = 33;
            // 
            // tabAddClient
            // 
            tabAddClient.Controls.Add(addClient);
            tabAddClient.Controls.Add(updateAndDeleteUser);
            tabAddClient.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabAddClient.Location = new Point(18, 20);
            tabAddClient.Name = "tabAddClient";
            tabAddClient.SelectedIndex = 0;
            tabAddClient.Size = new Size(811, 422);
            tabAddClient.TabIndex = 2;
            // 
            // UserControl4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabAddClient);
            Name = "UserControl4";
            Size = new Size(847, 463);
            updateAndDeleteUser.ResumeLayout(false);
            updateAndDeleteUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            addClient.ResumeLayout(false);
            addClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabAddClient.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage updateAndDeleteUser;
        private TextBox roomType;
        private TextBox description;
        private Label label9;
        private PictureBox pictureBox8;
        private Label label4;
        private PictureBox pictureBox3;
        private Button btnDelete;
        private Label label8;
        private TabPage addClient;
        private TextBox descriptionInput;
        private TextBox roomTypeInput;
        private Button btnSave;
        private Label label13;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox4;
        private TabControl tabAddClient;
    }
}
