namespace Trip_Maker_Travel_Management_System_
{
    partial class Bus_Booking
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
            button2 = new Button();
            label6 = new Label();
            total = new TextBox();
            label5 = new Label();
            noTicket = new TextBox();
            label4 = new Label();
            ticketPrice = new TextBox();
            label3 = new Label();
            busName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Search = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(641, 398);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 73;
            button2.Text = "Purchase";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(49, 398);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 72;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total.Location = new Point(574, 340);
            total.Multiline = true;
            total.Name = "total";
            total.Size = new Size(186, 33);
            total.TabIndex = 71;
            total.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(16, 16, 16);
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(453, 348);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 70;
            label5.Text = "Total Bill";
            label5.Click += label5_Click;
            // 
            // noTicket
            // 
            noTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            noTicket.Location = new Point(178, 335);
            noTicket.Multiline = true;
            noTicket.Name = "noTicket";
            noTicket.Size = new Size(186, 33);
            noTicket.TabIndex = 69;
            noTicket.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(16, 16, 16);
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(32, 335);
            label4.Name = "label4";
            label4.Size = new Size(121, 25);
            label4.TabIndex = 68;
            label4.Text = "No of Ticket";
            label4.Click += label4_Click;
            // 
            // ticketPrice
            // 
            ticketPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ticketPrice.Location = new Point(574, 268);
            ticketPrice.Multiline = true;
            ticketPrice.Name = "ticketPrice";
            ticketPrice.Size = new Size(186, 33);
            ticketPrice.TabIndex = 67;
            ticketPrice.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(16, 16, 16);
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(406, 276);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 66;
            label3.Text = "Price Per Ticket";
            label3.Click += label3_Click;
            // 
            // busName
            // 
            busName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            busName.Location = new Point(178, 268);
            busName.Multiline = true;
            busName.Name = "busName";
            busName.Size = new Size(186, 33);
            busName.TabIndex = 65;
            busName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(16, 16, 16);
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(32, 276);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 64;
            label2.Text = "Bus Name";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(16, 16, 16);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(45, 23);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 63;
            label1.Text = "Bus Booking";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(719, 153);
            dataGridView1.TabIndex = 62;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Search
            // 
            Search.Location = new Point(641, 41);
            Search.Margin = new Padding(3, 2, 3, 2);
            Search.Name = "Search";
            Search.PlaceholderText = "Enter Destination";
            Search.Size = new Size(127, 23);
            Search.TabIndex = 74;
            // 
            // button1
            // 
            button1.Location = new Point(574, 40);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(62, 22);
            button1.TabIndex = 75;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dark_gray_wall_with_wooden_plank_product_background;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 457);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 76;
            pictureBox1.TabStop = false;
            // 
            // Bus_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 51, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Search);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(total);
            Controls.Add(label5);
            Controls.Add(noTicket);
            Controls.Add(label4);
            Controls.Add(ticketPrice);
            Controls.Add(label3);
            Controls.Add(busName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bus_Booking";
            Text = "Bus_Booking";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label6;
        private TextBox total;
        private Label label5;
        private TextBox noTicket;
        private Label label4;
        private TextBox ticketPrice;
        private Label label3;
        private TextBox busName;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox Search;
        private Button button1;
        private PictureBox pictureBox1;
    }
}