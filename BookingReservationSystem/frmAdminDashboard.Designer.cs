namespace BookingReservationSystem
{
    partial class frmAdminDashboard
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
            panel1 = new Panel();
            btnLogout = new Button();
            btnRoomTypes = new Button();
            btnRooms = new Button();
            btnClient = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mvPanel = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel3 = new Panel();
            btnExit = new PictureBox();
            headerTitle = new Label();
            mainPanel = new Panel();
            userControlRoomType = new User_Control.UserControl4();
            userControlRoom = new User_Control.UserControl3();
            dashboardUserControl = new User_Control.UserControl2();
            clientUserControl = new User_Control.UserControl1();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 123, 255);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRoomTypes);
            panel1.Controls.Add(btnRooms);
            panel1.Controls.Add(btnClient);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 548);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.icons8_logout_35;
            btnLogout.Location = new Point(0, 508);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(10, 0, 0, 0);
            btnLogout.Size = new Size(232, 40);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "  Logout";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            btnLogout.Leave += btnLogout_Leave;
            // 
            // btnRoomTypes
            // 
            btnRoomTypes.Dock = DockStyle.Top;
            btnRoomTypes.FlatAppearance.BorderSize = 0;
            btnRoomTypes.FlatStyle = FlatStyle.Flat;
            btnRoomTypes.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoomTypes.ForeColor = Color.White;
            btnRoomTypes.Image = Properties.Resources.icons8_room_35__2_;
            btnRoomTypes.Location = new Point(0, 257);
            btnRoomTypes.Margin = new Padding(4, 3, 4, 3);
            btnRoomTypes.Name = "btnRoomTypes";
            btnRoomTypes.Padding = new Padding(18, 0, 0, 0);
            btnRoomTypes.Size = new Size(232, 40);
            btnRoomTypes.TabIndex = 4;
            btnRoomTypes.Text = "  Room Types";
            btnRoomTypes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoomTypes.UseVisualStyleBackColor = true;
            btnRoomTypes.Click += btnRoomTypes_Click;
            btnRoomTypes.Leave += btnRoomTypes_Leave;
            // 
            // btnRooms
            // 
            btnRooms.Dock = DockStyle.Top;
            btnRooms.FlatAppearance.BorderSize = 0;
            btnRooms.FlatStyle = FlatStyle.Flat;
            btnRooms.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRooms.ForeColor = Color.White;
            btnRooms.Image = Properties.Resources.icons8_home_351;
            btnRooms.Location = new Point(0, 217);
            btnRooms.Margin = new Padding(4, 3, 4, 3);
            btnRooms.Name = "btnRooms";
            btnRooms.Padding = new Padding(2, 0, 0, 0);
            btnRooms.Size = new Size(232, 40);
            btnRooms.TabIndex = 3;
            btnRooms.Text = "  Rooms";
            btnRooms.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRooms.UseVisualStyleBackColor = true;
            btnRooms.Click += btnRooms_Click;
            btnRooms.Leave += btnRooms_Leave;
            // 
            // btnClient
            // 
            btnClient.Dock = DockStyle.Top;
            btnClient.FlatAppearance.BorderSize = 0;
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClient.ForeColor = Color.White;
            btnClient.Image = Properties.Resources.icons8_member_35;
            btnClient.Location = new Point(0, 177);
            btnClient.Margin = new Padding(4, 3, 4, 3);
            btnClient.Name = "btnClient";
            btnClient.Padding = new Padding(10, 0, 0, 0);
            btnClient.Size = new Size(232, 40);
            btnClient.TabIndex = 2;
            btnClient.Text = "  Client User";
            btnClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            btnClient.Leave += btnClient_Leave;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = Properties.Resources.icons8_dashboard_35;
            btnDashboard.Location = new Point(0, 137);
            btnDashboard.Margin = new Padding(4, 3, 4, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(232, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "  Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            btnDashboard.Leave += btnDashboard_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 137);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 19);
            label1.TabIndex = 1;
            label1.Text = "Admin Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mvPanel
            // 
            mvPanel.BackColor = Color.White;
            mvPanel.ForeColor = Color.White;
            mvPanel.Location = new Point(0, 183);
            mvPanel.Margin = new Padding(4, 3, 4, 3);
            mvPanel.Name = "mvPanel";
            mvPanel.Size = new Size(5, 95);
            mvPanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(headerTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(232, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(847, 85);
            panel3.TabIndex = 30;
            // 
            // btnExit
            // 
            btnExit.Image = Properties.Resources.remove_button;
            btnExit.Location = new Point(806, 7);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(34, 34);
            btnExit.SizeMode = PictureBoxSizeMode.Zoom;
            btnExit.TabIndex = 24;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // headerTitle
            // 
            headerTitle.AutoSize = true;
            headerTitle.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            headerTitle.ForeColor = Color.FromArgb(0, 123, 255);
            headerTitle.Location = new Point(30, 23);
            headerTitle.Margin = new Padding(4, 0, 4, 0);
            headerTitle.Name = "headerTitle";
            headerTitle.Size = new Size(178, 37);
            headerTitle.TabIndex = 3;
            headerTitle.Text = "Dashboard";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(userControlRoomType);
            mainPanel.Controls.Add(userControlRoom);
            mainPanel.Controls.Add(dashboardUserControl);
            mainPanel.Controls.Add(clientUserControl);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(232, 85);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(847, 463);
            mainPanel.TabIndex = 31;
            // 
            // userControlRoomType
            // 
            userControlRoomType.Dock = DockStyle.Fill;
            userControlRoomType.Location = new Point(0, 0);
            userControlRoomType.Margin = new Padding(2, 3, 2, 3);
            userControlRoomType.Name = "userControlRoomType";
            userControlRoomType.Size = new Size(847, 463);
            userControlRoomType.TabIndex = 3;
            // 
            // userControlRoom
            // 
            userControlRoom.Dock = DockStyle.Fill;
            userControlRoom.Location = new Point(0, 0);
            userControlRoom.Margin = new Padding(2, 3, 2, 3);
            userControlRoom.Name = "userControlRoom";
            userControlRoom.Size = new Size(847, 463);
            userControlRoom.TabIndex = 2;
            // 
            // dashboardUserControl
            // 
            dashboardUserControl.Dock = DockStyle.Fill;
            dashboardUserControl.Location = new Point(0, 0);
            dashboardUserControl.Margin = new Padding(2, 3, 2, 3);
            dashboardUserControl.Name = "dashboardUserControl";
            dashboardUserControl.Size = new Size(847, 463);
            dashboardUserControl.TabIndex = 1;
            dashboardUserControl.Visible = false;
            // 
            // clientUserControl
            // 
            clientUserControl.Dock = DockStyle.Fill;
            clientUserControl.Location = new Point(0, 0);
            clientUserControl.Margin = new Padding(2, 3, 2, 3);
            clientUserControl.Name = "clientUserControl";
            clientUserControl.Size = new Size(847, 463);
            clientUserControl.TabIndex = 0;
            clientUserControl.Visible = false;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 548);
            Controls.Add(mainPanel);
            Controls.Add(panel3);
            Controls.Add(mvPanel);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdminDashboard";
            Load += frmAdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDashboard;
        private Button btnRoomTypes;
        private Button btnRooms;
        private Button btnClient;
        private Button btnLogout;
        private Panel mvPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel3;
        private Label headerTitle;
        private Panel mainPanel;
        private PictureBox btnExit;
        private User_Control.UserControl1 clientUserControl;
        private User_Control.UserControl2 dashboardUserControl;
        private User_Control.UserControl3 userControlRoom;
        private User_Control.UserControl4 userControlRoomType;
    }
}