namespace BookingReservationSystem
{
    partial class frmClientDashboard
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
            btnRevenue = new Button();
            btnCostumers = new Button();
            btnBookings = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mvPanel = new Panel();
            panel4 = new Panel();
            userControRevenue = new User_Control_Client.UserControl8();
            userControlDashboard = new User_Control_Client.UserControl7();
            userControlCustomer = new User_Control_Client.UserControl6();
            userControlBookings = new User_Control_Client.UserControl5();
            panel3 = new Panel();
            btnExit = new PictureBox();
            headerTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 123, 255);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnRevenue);
            panel1.Controls.Add(btnCostumers);
            panel1.Controls.Add(btnBookings);
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
            // btnRevenue
            // 
            btnRevenue.Dock = DockStyle.Top;
            btnRevenue.FlatAppearance.BorderSize = 0;
            btnRevenue.FlatStyle = FlatStyle.Flat;
            btnRevenue.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRevenue.ForeColor = Color.White;
            btnRevenue.Image = Properties.Resources.icons8_revenue_35;
            btnRevenue.Location = new Point(0, 257);
            btnRevenue.Margin = new Padding(4, 3, 4, 3);
            btnRevenue.Name = "btnRevenue";
            btnRevenue.Padding = new Padding(4, 0, 0, 0);
            btnRevenue.Size = new Size(232, 40);
            btnRevenue.TabIndex = 4;
            btnRevenue.Text = "  Revenue";
            btnRevenue.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRevenue.UseVisualStyleBackColor = true;
            btnRevenue.Click += btnRevenue_Click;
            btnRevenue.Leave += btnRevenue_Leave;
            // 
            // btnCostumers
            // 
            btnCostumers.Dock = DockStyle.Top;
            btnCostumers.FlatAppearance.BorderSize = 0;
            btnCostumers.FlatStyle = FlatStyle.Flat;
            btnCostumers.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCostumers.ForeColor = Color.White;
            btnCostumers.Image = Properties.Resources.icons8_member_35;
            btnCostumers.Location = new Point(0, 217);
            btnCostumers.Margin = new Padding(4, 3, 4, 3);
            btnCostumers.Name = "btnCostumers";
            btnCostumers.Padding = new Padding(7, 0, 0, 0);
            btnCostumers.Size = new Size(232, 40);
            btnCostumers.TabIndex = 3;
            btnCostumers.Text = "  Customers";
            btnCostumers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCostumers.UseVisualStyleBackColor = true;
            btnCostumers.Click += btnCostumers_Click;
            btnCostumers.Leave += btnCostumers_Leave;
            // 
            // btnBookings
            // 
            btnBookings.Dock = DockStyle.Top;
            btnBookings.FlatAppearance.BorderSize = 0;
            btnBookings.FlatStyle = FlatStyle.Flat;
            btnBookings.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookings.ForeColor = Color.White;
            btnBookings.Image = Properties.Resources.icons8_booking_35;
            btnBookings.Location = new Point(0, 177);
            btnBookings.Margin = new Padding(4, 3, 4, 3);
            btnBookings.Name = "btnBookings";
            btnBookings.Padding = new Padding(3, 0, 0, 0);
            btnBookings.Size = new Size(232, 40);
            btnBookings.TabIndex = 2;
            btnBookings.Text = "  Bookings";
            btnBookings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            btnBookings.Leave += btnBookings_Leave;
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
            label1.Location = new Point(38, 106);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 19);
            label1.TabIndex = 1;
            label1.Text = "Client Dashboard";
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
            // panel4
            // 
            panel4.Controls.Add(userControRevenue);
            panel4.Controls.Add(userControlDashboard);
            panel4.Controls.Add(userControlCustomer);
            panel4.Controls.Add(userControlBookings);
            panel4.Location = new Point(232, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(847, 463);
            panel4.TabIndex = 32;
            // 
            // userControRevenue
            // 
            userControRevenue.Dock = DockStyle.Fill;
            userControRevenue.Location = new Point(0, 0);
            userControRevenue.Name = "userControRevenue";
            userControRevenue.Size = new Size(847, 463);
            userControRevenue.TabIndex = 26;
            // 
            // userControlDashboard
            // 
            userControlDashboard.AutoScroll = true;
            userControlDashboard.Dock = DockStyle.Fill;
            userControlDashboard.Location = new Point(0, 0);
            userControlDashboard.Margin = new Padding(4, 3, 4, 3);
            userControlDashboard.Name = "userControlDashboard";
            userControlDashboard.Size = new Size(847, 463);
            userControlDashboard.TabIndex = 25;
            // 
            // userControlCustomer
            // 
            userControlCustomer.Dock = DockStyle.Fill;
            userControlCustomer.Location = new Point(0, 0);
            userControlCustomer.Name = "userControlCustomer";
            userControlCustomer.Size = new Size(847, 463);
            userControlCustomer.TabIndex = 1;
           
            // 
            // userControlBookings
            // 
            userControlBookings.Dock = DockStyle.Fill;
            userControlBookings.Location = new Point(0, 0);
            userControlBookings.Name = "userControlBookings";
            userControlBookings.Size = new Size(847, 463);
            userControlBookings.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(headerTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(232, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(847, 85);
            panel3.TabIndex = 33;
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
            btnExit.Click += btnExit_Click;
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
            // frmClientDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 548);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(mvPanel);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmClientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdminDashboard";
            Load += frmClientDashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDashboard;
        private Button btnRevenue;
        private Button btnCostumers;
        private Button btnBookings;
        private Button btnLogout;
        private Panel mvPanel;
        private Panel panel4;
        private User_Control_Client.UserControl5 userControlBookings;
        private Panel panel3;
        private PictureBox btnExit;
        private Label headerTitle;
        private User_Control_Client.UserControl6 userControlCustomer;
        private User_Control_Client.UserControl7 userControlDashboard;
        private User_Control_Client.UserControl8 userControRevenue;
    }
}