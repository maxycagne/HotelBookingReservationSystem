namespace BookingReservationSystem.User_Control_Client
{
    partial class UserControl8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl8));
            roomPanel = new Panel();
            dataGridView1 = new DataGridView();
            btShow = new Button();
            revenue = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            btnPrint = new Button();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            roomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // roomPanel
            // 
            roomPanel.BackColor = Color.FromArgb(0, 123, 255);
            roomPanel.Controls.Add(dataGridView1);
            roomPanel.Controls.Add(btShow);
            roomPanel.Controls.Add(revenue);
            roomPanel.Controls.Add(label2);
            roomPanel.Controls.Add(pictureBox4);
            roomPanel.Controls.Add(btnPrint);
            roomPanel.Controls.Add(label1);
            roomPanel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomPanel.ForeColor = Color.White;
            roomPanel.Location = new Point(25, 29);
            roomPanel.Margin = new Padding(4);
            roomPanel.Name = "roomPanel";
            roomPanel.Size = new Size(797, 403);
            roomPanel.TabIndex = 3;
            roomPanel.Paint += roomPanel_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(538, 298);
            dataGridView1.TabIndex = 84;
            // 
            // btShow
            // 
            btShow.AutoSize = true;
            btShow.BackColor = Color.White;
            btShow.ForeColor = Color.FromArgb(0, 123, 255);
            btShow.Location = new Point(12, 368);
            btShow.Name = "btShow";
            btShow.Size = new Size(538, 32);
            btShow.TabIndex = 83;
            btShow.Text = "Show";
            btShow.UseVisualStyleBackColor = false;
            btShow.Click += btShow_Click;
            // 
            // revenue
            // 
            revenue.AutoSize = true;
            revenue.BackColor = Color.White;
            revenue.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            revenue.ForeColor = Color.FromArgb(0, 123, 255);
            revenue.Location = new Point(604, 111);
            revenue.Margin = new Padding(4, 0, 4, 0);
            revenue.Name = "revenue";
            revenue.Size = new Size(18, 22);
            revenue.TabIndex = 33;
            revenue.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 123, 255);
            label2.Location = new Point(592, 74);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 32;
            label2.Text = "Revenue";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_05_19_233536;
            pictureBox4.Location = new Point(565, 48);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(214, 133);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.ForeColor = Color.FromArgb(0, 123, 255);
            btnPrint.Location = new Point(615, 331);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(150, 44);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 34);
            label1.TabIndex = 2;
            label1.Text = "Revenue";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // UserControl8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roomPanel);
            Name = "UserControl8";
            Size = new Size(847, 463);
            roomPanel.ResumeLayout(false);
            roomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel roomPanel;
        private Label label1;
        private Button btnPrint;
        private Label label2;
        private PictureBox pictureBox4;
        private Label revenue;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btShow;
        private DataGridView dataGridView1;
    }
}
