namespace BookingReservationSystem.User_Control_Client
{
    partial class UserControl5
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
            nameSearch = new ComboBox();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            btnSearch = new PictureBox();
            nameSearchBookings = new Label();
            pictureBox5 = new PictureBox();
            addClient = new TabPage();
            label6 = new Label();
            discountModify = new TextBox();
            pictureBox1 = new PictureBox();
            changeModify = new Label();
            amountModify = new Label();
            label20 = new Label();
            pictureBox2 = new PictureBox();
            label21 = new Label();
            label22 = new Label();
            amountRecievedModify = new TextBox();
            pictureBox7 = new PictureBox();
            pictureBox19 = new PictureBox();
            roomTypeModif = new Label();
            roomTypeModify = new Label();
            label19 = new Label();
            label10 = new Label();
            pictureBox8 = new PictureBox();
            roomNumModify = new ComboBox();
            nameModify = new ComboBox();
            label11 = new Label();
            pictureBox13 = new PictureBox();
            label16 = new Label();
            pictureBox15 = new PictureBox();
            checkOutModify = new DateTimePicker();
            label17 = new Label();
            pictureBox16 = new PictureBox();
            label18 = new Label();
            checkInmodify = new DateTimePicker();
            pictureBox17 = new PictureBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            tabAddClient = new TabControl();
            ad = new TabPage();
            label = new Label();
            discount = new TextBox();
            pictureBox18 = new PictureBox();
            btnAddBookings = new Button();
            label15 = new Label();
            label5 = new Label();
            change = new Label();
            amount = new Label();
            roomType = new Label();
            label14 = new Label();
            pictureBox12 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            label12 = new Label();
            amountRecieved = new TextBox();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            roomNum = new ComboBox();
            name = new ComboBox();
            label7 = new Label();
            pictureBox6 = new PictureBox();
            Room = new Label();
            pictureBox4 = new PictureBox();
            checkOutDate = new DateTimePicker();
            pictureBox3 = new PictureBox();
            checkInDate = new DateTimePicker();
            pictureBox14 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            customerName = new Label();
            label13 = new Label();
            days = new TextBox();
            pictureBox20 = new PictureBox();
            label8 = new Label();
            searchClientUser.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            addClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            tabAddClient.SuspendLayout();
            ad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            SuspendLayout();
            // 
            // searchClientUser
            // 
            searchClientUser.BackColor = Color.FromArgb(0, 123, 255);
            searchClientUser.Controls.Add(nameSearch);
            searchClientUser.Controls.Add(panel1);
            searchClientUser.Controls.Add(btnSearch);
            searchClientUser.Controls.Add(nameSearchBookings);
            searchClientUser.Controls.Add(pictureBox5);
            searchClientUser.Location = new Point(4, 28);
            searchClientUser.Name = "searchClientUser";
            searchClientUser.Padding = new Padding(3);
            searchClientUser.Size = new Size(803, 390);
            searchClientUser.TabIndex = 1;
            searchClientUser.Text = "Search Bookings";
            searchClientUser.Leave += searchClientUser_Leave;
            // 
            // nameSearch
            // 
            nameSearch.BackColor = Color.White;
            nameSearch.FlatStyle = FlatStyle.Flat;
            nameSearch.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameSearch.FormattingEnabled = true;
            nameSearch.Items.AddRange(new object[] { "Male", "Female", "Others" });
            nameSearch.Location = new Point(49, 51);
            nameSearch.Name = "nameSearch";
            nameSearch.Size = new Size(194, 27);
            nameSearch.TabIndex = 132;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(0, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 289);
            panel1.TabIndex = 16;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = Color.FromArgb(0, 123, 255);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.GridColor = Color.Black;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(803, 289);
            dataGridView2.TabIndex = 17;
            dataGridView2.CellValueChanged += dataGridView2_CellValueChanged_1;
            dataGridView2.CurrentCellDirtyStateChanged += dataGridView2_CurrentCellDirtyStateChanged_1;
            // 
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.icons8_search_50;
            btnSearch.Location = new Point(267, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(49, 37);
            btnSearch.SizeMode = PictureBoxSizeMode.Zoom;
            btnSearch.TabIndex = 14;
            btnSearch.TabStop = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // nameSearchBookings
            // 
            nameSearchBookings.AutoSize = true;
            nameSearchBookings.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            nameSearchBookings.ForeColor = SystemColors.Control;
            nameSearchBookings.Location = new Point(32, 16);
            nameSearchBookings.Name = "nameSearchBookings";
            nameSearchBookings.Size = new Size(70, 23);
            nameSearchBookings.TabIndex = 13;
            nameSearchBookings.Text = "Name";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox5.Location = new Point(16, 30);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(257, 72);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // addClient
            // 
            addClient.AutoScroll = true;
            addClient.BackColor = Color.FromArgb(0, 123, 255);
            addClient.BackgroundImageLayout = ImageLayout.Stretch;
            addClient.Controls.Add(label6);
            addClient.Controls.Add(discountModify);
            addClient.Controls.Add(pictureBox1);
            addClient.Controls.Add(changeModify);
            addClient.Controls.Add(amountModify);
            addClient.Controls.Add(label20);
            addClient.Controls.Add(pictureBox2);
            addClient.Controls.Add(label21);
            addClient.Controls.Add(label22);
            addClient.Controls.Add(amountRecievedModify);
            addClient.Controls.Add(pictureBox7);
            addClient.Controls.Add(pictureBox19);
            addClient.Controls.Add(roomTypeModif);
            addClient.Controls.Add(roomTypeModify);
            addClient.Controls.Add(label19);
            addClient.Controls.Add(label10);
            addClient.Controls.Add(pictureBox8);
            addClient.Controls.Add(roomNumModify);
            addClient.Controls.Add(nameModify);
            addClient.Controls.Add(label11);
            addClient.Controls.Add(pictureBox13);
            addClient.Controls.Add(label16);
            addClient.Controls.Add(pictureBox15);
            addClient.Controls.Add(checkOutModify);
            addClient.Controls.Add(label17);
            addClient.Controls.Add(pictureBox16);
            addClient.Controls.Add(label18);
            addClient.Controls.Add(checkInmodify);
            addClient.Controls.Add(pictureBox17);
            addClient.Controls.Add(btnDelete);
            addClient.Controls.Add(btnUpdate);
            addClient.ForeColor = SystemColors.Control;
            addClient.Location = new Point(4, 28);
            addClient.Name = "addClient";
            addClient.Padding = new Padding(3);
            addClient.Size = new Size(803, 390);
            addClient.TabIndex = 0;
            addClient.Text = "Update and Delete Bookings";
            addClient.Leave += addClient_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(218, 254);
            label6.Name = "label6";
            label6.Size = new Size(106, 22);
            label6.TabIndex = 194;
            label6.Text = "Discount %";
            // 
            // discountModify
            // 
            discountModify.BorderStyle = BorderStyle.None;
            discountModify.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discountModify.Location = new Point(231, 291);
            discountModify.Name = "discountModify";
            discountModify.Size = new Size(131, 23);
            discountModify.TabIndex = 192;
            discountModify.KeyPress += discountModify_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox1.Location = new Point(206, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 193;
            pictureBox1.TabStop = false;
            // 
            // changeModify
            // 
            changeModify.AutoSize = true;
            changeModify.BackColor = Color.White;
            changeModify.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeModify.ForeColor = Color.Black;
            changeModify.Location = new Point(606, 291);
            changeModify.Name = "changeModify";
            changeModify.Size = new Size(18, 22);
            changeModify.TabIndex = 191;
            changeModify.Text = "-";
            // 
            // amountModify
            // 
            amountModify.AutoSize = true;
            amountModify.BackColor = Color.White;
            amountModify.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountModify.ForeColor = Color.Black;
            amountModify.Location = new Point(41, 291);
            amountModify.Name = "amountModify";
            amountModify.Size = new Size(18, 22);
            amountModify.TabIndex = 190;
            amountModify.Text = "-";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.Control;
            label20.Location = new Point(606, 254);
            label20.Name = "label20";
            label20.Size = new Size(82, 22);
            label20.TabIndex = 189;
            label20.Text = "Change";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox2.Location = new Point(585, 245);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(180, 117);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 188;
            pictureBox2.TabStop = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.Control;
            label21.Location = new Point(41, 254);
            label21.Name = "label21";
            label21.Size = new Size(79, 22);
            label21.TabIndex = 184;
            label21.Text = "Amount";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.Control;
            label22.Location = new Point(407, 254);
            label22.Name = "label22";
            label22.Size = new Size(168, 22);
            label22.TabIndex = 187;
            label22.Text = "Amount Recieved";
            // 
            // amountRecievedModify
            // 
            amountRecievedModify.BorderStyle = BorderStyle.None;
            amountRecievedModify.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountRecievedModify.Location = new Point(420, 291);
            amountRecievedModify.Name = "amountRecievedModify";
            amountRecievedModify.Size = new Size(131, 23);
            amountRecievedModify.TabIndex = 185;
            amountRecievedModify.KeyPress += amountRecievedModify_KeyPress_1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox7.Location = new Point(395, 245);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(180, 117);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 186;
            pictureBox7.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox19.Location = new Point(18, 245);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(180, 117);
            pictureBox19.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox19.TabIndex = 183;
            pictureBox19.TabStop = false;
            // 
            // roomTypeModif
            // 
            roomTypeModif.AutoSize = true;
            roomTypeModif.BackColor = Color.White;
            roomTypeModif.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomTypeModif.ForeColor = Color.Black;
            roomTypeModif.Location = new Point(569, 61);
            roomTypeModif.Name = "roomTypeModif";
            roomTypeModif.Size = new Size(18, 22);
            roomTypeModif.TabIndex = 182;
            roomTypeModif.Text = "-";
            // 
            // roomTypeModify
            // 
            roomTypeModify.AutoSize = true;
            roomTypeModify.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomTypeModify.ForeColor = SystemColors.Control;
            roomTypeModify.Location = new Point(572, 65);
            roomTypeModify.Name = "roomTypeModify";
            roomTypeModify.Size = new Size(0, 22);
            roomTypeModify.TabIndex = 177;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.Control;
            label19.Location = new Point(49, 285);
            label19.Name = "label19";
            label19.Size = new Size(0, 22);
            label19.TabIndex = 176;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(569, 25);
            label10.Name = "label10";
            label10.Size = new Size(108, 22);
            label10.TabIndex = 162;
            label10.Text = "Room Type";
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox8.Location = new Point(546, 16);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(221, 117);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 161;
            pictureBox8.TabStop = false;
            // 
            // roomNumModify
            // 
            roomNumModify.BackColor = Color.White;
            roomNumModify.FlatStyle = FlatStyle.Flat;
            roomNumModify.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomNumModify.FormattingEnabled = true;
            roomNumModify.Items.AddRange(new object[] { "Male", "Female", "Others" });
            roomNumModify.Location = new Point(307, 60);
            roomNumModify.Name = "roomNumModify";
            roomNumModify.Size = new Size(180, 27);
            roomNumModify.TabIndex = 160;
            roomNumModify.SelectedIndexChanged += roomNumModify_SelectedIndexChanged;
            // 
            // nameModify
            // 
            nameModify.BackColor = Color.White;
            nameModify.FlatStyle = FlatStyle.Flat;
            nameModify.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameModify.FormattingEnabled = true;
            nameModify.Items.AddRange(new object[] { "Male", "Female", "Others" });
            nameModify.Location = new Point(40, 60);
            nameModify.Name = "nameModify";
            nameModify.Size = new Size(180, 27);
            nameModify.TabIndex = 156;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(40, 25);
            label11.Name = "label11";
            label11.Size = new Size(154, 22);
            label11.TabIndex = 159;
            label11.Text = "Customer Name";
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox13.Location = new Point(20, 16);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(221, 117);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 157;
            pictureBox13.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(307, 25);
            label16.Name = "label16";
            label16.Size = new Size(137, 22);
            label16.TabIndex = 155;
            label16.Text = "Room Number";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox15.Location = new Point(284, 16);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(221, 117);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 154;
            pictureBox15.TabStop = false;
            // 
            // checkOutModify
            // 
            checkOutModify.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            checkOutModify.Format = DateTimePickerFormat.Custom;
            checkOutModify.Location = new Point(486, 173);
            checkOutModify.Name = "checkOutModify";
            checkOutModify.Size = new Size(250, 28);
            checkOutModify.TabIndex = 148;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.Control;
            label17.Location = new Point(486, 133);
            label17.Name = "label17";
            label17.Size = new Size(152, 22);
            label17.TabIndex = 150;
            label17.Text = "Check Out Date";
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox16.Location = new Point(459, 123);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(308, 134);
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox16.TabIndex = 153;
            pictureBox16.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.Control;
            label18.Location = new Point(53, 133);
            label18.Name = "label18";
            label18.Size = new Size(137, 22);
            label18.TabIndex = 149;
            label18.Text = "Check In Date";
            // 
            // checkInmodify
            // 
            checkInmodify.CalendarTitleBackColor = SystemColors.ControlText;
            checkInmodify.CalendarTitleForeColor = SystemColors.ActiveCaption;
            checkInmodify.CalendarTrailingForeColor = SystemColors.ControlLightLight;
            checkInmodify.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            checkInmodify.Format = DateTimePickerFormat.Custom;
            checkInmodify.Location = new Point(53, 173);
            checkInmodify.Name = "checkInmodify";
            checkInmodify.Size = new Size(250, 28);
            checkInmodify.TabIndex = 151;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox17.Location = new Point(20, 123);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(308, 134);
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox17.TabIndex = 152;
            pictureBox17.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(422, 368);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 44);
            btnDelete.TabIndex = 83;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.FromArgb(0, 123, 255);
            btnUpdate.Location = new Point(220, 368);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(150, 44);
            btnUpdate.TabIndex = 82;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tabAddClient
            // 
            tabAddClient.Controls.Add(ad);
            tabAddClient.Controls.Add(searchClientUser);
            tabAddClient.Controls.Add(addClient);
            tabAddClient.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabAddClient.Location = new Point(18, 20);
            tabAddClient.Name = "tabAddClient";
            tabAddClient.SelectedIndex = 0;
            tabAddClient.Size = new Size(811, 422);
            tabAddClient.TabIndex = 1;
            tabAddClient.Selected += tabAddClient_Selected;
            // 
            // ad
            // 
            ad.AutoScroll = true;
            ad.BackColor = Color.FromArgb(0, 123, 255);
            ad.Controls.Add(label8);
            ad.Controls.Add(days);
            ad.Controls.Add(pictureBox20);
            ad.Controls.Add(label);
            ad.Controls.Add(discount);
            ad.Controls.Add(pictureBox18);
            ad.Controls.Add(btnAddBookings);
            ad.Controls.Add(label15);
            ad.Controls.Add(label5);
            ad.Controls.Add(change);
            ad.Controls.Add(amount);
            ad.Controls.Add(roomType);
            ad.Controls.Add(label14);
            ad.Controls.Add(pictureBox12);
            ad.Controls.Add(label4);
            ad.Controls.Add(label1);
            ad.Controls.Add(label12);
            ad.Controls.Add(amountRecieved);
            ad.Controls.Add(pictureBox11);
            ad.Controls.Add(pictureBox10);
            ad.Controls.Add(pictureBox9);
            ad.Controls.Add(roomNum);
            ad.Controls.Add(name);
            ad.Controls.Add(label7);
            ad.Controls.Add(pictureBox6);
            ad.Controls.Add(Room);
            ad.Controls.Add(pictureBox4);
            ad.Controls.Add(checkOutDate);
            ad.Controls.Add(pictureBox3);
            ad.Controls.Add(checkInDate);
            ad.Controls.Add(pictureBox14);
            ad.Controls.Add(label2);
            ad.Controls.Add(label3);
            ad.Controls.Add(customerName);
            ad.Controls.Add(label13);
            ad.Location = new Point(4, 28);
            ad.Name = "ad";
            ad.Padding = new Padding(3);
            ad.Size = new Size(803, 390);
            ad.TabIndex = 2;
            ad.Text = "Add Bookings";
            ad.Leave += ad_Leave;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Control;
            label.Location = new Point(220, 248);
            label.Name = "label";
            label.Size = new Size(106, 22);
            label.TabIndex = 152;
            label.Text = "Discount %";
            // 
            // discount
            // 
            discount.BorderStyle = BorderStyle.None;
            discount.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            discount.Location = new Point(233, 285);
            discount.Name = "discount";
            discount.Size = new Size(131, 23);
            discount.TabIndex = 150;
            discount.KeyPress += discount_KeyPress;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox18.Location = new Point(208, 239);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(180, 117);
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox18.TabIndex = 151;
            pictureBox18.TabStop = false;
            // 
            // btnAddBookings
            // 
            btnAddBookings.BackColor = Color.White;
            btnAddBookings.ForeColor = Color.FromArgb(0, 123, 255);
            btnAddBookings.Location = new Point(337, 362);
            btnAddBookings.Name = "btnAddBookings";
            btnAddBookings.Size = new Size(150, 44);
            btnAddBookings.TabIndex = 48;
            btnAddBookings.Text = "Add Bookings";
            btnAddBookings.UseVisualStyleBackColor = false;
            btnAddBookings.Click += btnCreate_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(53, 118);
            label15.Name = "label15";
            label15.Size = new Size(137, 22);
            label15.TabIndex = 124;
            label15.Text = "Check In Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(486, 118);
            label5.Name = "label5";
            label5.Size = new Size(152, 22);
            label5.TabIndex = 125;
            label5.Text = "Check Out Date";
            // 
            // change
            // 
            change.AutoSize = true;
            change.BackColor = Color.White;
            change.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            change.ForeColor = Color.Black;
            change.Location = new Point(608, 285);
            change.Name = "change";
            change.Size = new Size(18, 22);
            change.TabIndex = 149;
            change.Text = "-";
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.BackColor = Color.White;
            amount.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amount.ForeColor = Color.Black;
            amount.Location = new Point(43, 285);
            amount.Name = "amount";
            amount.Size = new Size(18, 22);
            amount.TabIndex = 148;
            amount.Text = "-";
            // 
            // roomType
            // 
            roomType.AutoSize = true;
            roomType.BackColor = Color.White;
            roomType.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomType.ForeColor = Color.Black;
            roomType.Location = new Point(570, 64);
            roomType.Name = "roomType";
            roomType.Size = new Size(18, 22);
            roomType.TabIndex = 147;
            roomType.Text = "-";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(608, 248);
            label14.Name = "label14";
            label14.Size = new Size(82, 22);
            label14.TabIndex = 146;
            label14.Text = "Change";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox12.Location = new Point(587, 239);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(180, 117);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 145;
            pictureBox12.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(43, 248);
            label4.Name = "label4";
            label4.Size = new Size(79, 22);
            label4.TabIndex = 140;
            label4.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(569, 26);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 137;
            label1.Text = "Room Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(409, 248);
            label12.Name = "label12";
            label12.Size = new Size(168, 22);
            label12.TabIndex = 143;
            label12.Text = "Amount Recieved";
            // 
            // amountRecieved
            // 
            amountRecieved.BorderStyle = BorderStyle.None;
            amountRecieved.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountRecieved.Location = new Point(422, 285);
            amountRecieved.Name = "amountRecieved";
            amountRecieved.Size = new Size(131, 23);
            amountRecieved.TabIndex = 141;
            amountRecieved.KeyPress += amountRecieved_KeyPress;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox11.Location = new Point(397, 239);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(180, 117);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 142;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox10.Location = new Point(20, 239);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(180, 117);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 139;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox9.Location = new Point(546, 17);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(221, 117);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 136;
            pictureBox9.TabStop = false;
            // 
            // roomNum
            // 
            roomNum.BackColor = Color.White;
            roomNum.FlatStyle = FlatStyle.Flat;
            roomNum.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roomNum.FormattingEnabled = true;
            roomNum.Items.AddRange(new object[] { "Male", "Female", "Others" });
            roomNum.Location = new Point(307, 61);
            roomNum.Name = "roomNum";
            roomNum.Size = new Size(180, 27);
            roomNum.TabIndex = 135;
            roomNum.SelectedIndexChanged += roomNum_SelectedIndexChanged;
            // 
            // name
            // 
            name.BackColor = Color.White;
            name.FlatStyle = FlatStyle.Flat;
            name.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.FormattingEnabled = true;
            name.Items.AddRange(new object[] { "Male", "Female", "Others" });
            name.Location = new Point(40, 61);
            name.Name = "name";
            name.Size = new Size(180, 27);
            name.TabIndex = 131;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(40, 26);
            label7.Name = "label7";
            label7.Size = new Size(154, 22);
            label7.TabIndex = 134;
            label7.Text = "Customer Name";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox6.Location = new Point(20, 17);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(221, 117);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 132;
            pictureBox6.TabStop = false;
            // 
            // Room
            // 
            Room.AutoSize = true;
            Room.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Room.ForeColor = SystemColors.Control;
            Room.Location = new Point(307, 26);
            Room.Name = "Room";
            Room.Size = new Size(137, 22);
            Room.TabIndex = 130;
            Room.Text = "Room Number";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox4.Location = new Point(284, 17);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(221, 117);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 129;
            pictureBox4.TabStop = false;
            // 
            // checkOutDate
            // 
            checkOutDate.CustomFormat = "yyyy/MM/dd HH:mm";
            checkOutDate.Format = DateTimePickerFormat.Custom;
            checkOutDate.Location = new Point(486, 158);
            checkOutDate.Name = "checkOutDate";
            checkOutDate.Size = new Size(250, 28);
            checkOutDate.TabIndex = 123;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox3.Location = new Point(459, 108);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(308, 134);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 128;
            pictureBox3.TabStop = false;
            // 
            // checkInDate
            // 
            checkInDate.CalendarTitleBackColor = SystemColors.ButtonHighlight;
            checkInDate.CalendarTrailingForeColor = SystemColors.ControlLightLight;
            checkInDate.CustomFormat = "yyyy/MM/dd hh:mm";
            checkInDate.Format = DateTimePickerFormat.Custom;
            checkInDate.Location = new Point(53, 158);
            checkInDate.Name = "checkInDate";
            checkInDate.Size = new Size(250, 28);
            checkInDate.TabIndex = 126;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox14.Location = new Point(20, 108);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(308, 134);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 127;
            pictureBox14.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(568, -80);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 119;
            label2.Text = "Room Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(311, -80);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 118;
            label3.Text = "Phone Number";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerName.ForeColor = SystemColors.Control;
            customerName.Location = new Point(58, -84);
            customerName.Name = "customerName";
            customerName.Size = new Size(154, 22);
            customerName.TabIndex = 117;
            customerName.Text = "Customer Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(43, -103);
            label13.Name = "label13";
            label13.Size = new Size(0, 23);
            label13.TabIndex = 109;
            // 
            // days
            // 
            days.BorderStyle = BorderStyle.None;
            days.Font = new Font("Century Gothic", 8F, FontStyle.Bold);
            days.Location = new Point(337, 160);
            days.Name = "days";
            days.Size = new Size(116, 17);
            days.TabIndex = 153;
            // 
            // pictureBox20
            // 
            pictureBox20.Image = Properties.Resources.Screenshot_2024_05_19_123105;
            pictureBox20.Location = new Point(322, 94);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(149, 151);
            pictureBox20.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox20.TabIndex = 154;
            pictureBox20.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(334, 126);
            label8.Name = "label8";
            label8.Size = new Size(53, 22);
            label8.TabIndex = 155;
            label8.Text = "Days";
            // 
            // UserControl5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabAddClient);
            Name = "UserControl5";
            Size = new Size(847, 463);
            Load += UserControl5_Load;
            VisibleChanged += UserControl5_VisibleChanged;
            searchClientUser.ResumeLayout(false);
            searchClientUser.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            addClient.ResumeLayout(false);
            addClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            tabAddClient.ResumeLayout(false);
            ad.ResumeLayout(false);
            ad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage searchClientUser;
        private Panel panel1;
        private DataGridView dataGridView2;
        private PictureBox btnSearch;
        private Label nameSearchBookings;
        private PictureBox pictureBox5;
        private TabPage addClient;
        private TabControl tabAddClient;
        private TabPage ad;
        private Button btnAddBookings;
        private Button btnUpdate;
        private Button btnDelete;
        private DateTimePicker checkOutDate;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label15;
        private DateTimePicker checkInDate;
        private PictureBox pictureBox14;
        private Label label2;
        private Label label3;
        private Label customerName;
        private Label label13;
        private ComboBox name;
        private Label Room;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pictureBox6;
        private Label label1;
        private PictureBox pictureBox9;
        private ComboBox roomNum;
        private Label label4;
        private PictureBox pictureBox10;
        private Label label10;
        private PictureBox pictureBox8;
        private ComboBox roomNumModify;
        private ComboBox nameModify;
        private Label label11;
        private PictureBox pictureBox13;
        private Label label16;
        private PictureBox pictureBox15;
        private DateTimePicker checkOutModify;
        private Label label17;
        private PictureBox pictureBox16;
        private Label label18;
        private DateTimePicker checkInmodify;
        private PictureBox pictureBox17;
        private Label label14;
        private PictureBox pictureBox12;
        private Label label12;
        private PictureBox pictureBox11;
        private TextBox amountRecieved;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox discount;
        private Label label19;
        private Label roomTypeModify;
        private Label change;
        private Label amount;
        private Label roomType;
        private ComboBox nameSearch;
        private Label roomTypeModif;
        private Label label;
        private PictureBox pictureBox18;
        private Label label6;
        private TextBox discountModify;
        private PictureBox pictureBox1;
        private Label changeModify;
        private Label amountModify;
        private Label label20;
        private PictureBox pictureBox2;
        private Label label21;
        private Label label22;
        private TextBox amountRecievedModify;
        private PictureBox pictureBox7;
        private PictureBox pictureBox19;
        private Label label8;
        private TextBox days;
        private PictureBox pictureBox20;
    }
}
