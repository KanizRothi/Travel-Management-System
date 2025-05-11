namespace Trip_Maker_Travel_Management_System_
{
    partial class Launch_Booking
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
            launchName = new TextBox();
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
            button2.Location = new Point(733, 531);
            button2.Name = "button2";
            button2.Size = new Size(110, 39);
            button2.TabIndex = 85;
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
            label6.Location = new Point(56, 531);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 84;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // total
            // 
            total.BackColor = Color.MistyRose;
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total.Location = new Point(656, 453);
            total.Margin = new Padding(3, 4, 3, 4);
            total.Multiline = true;
            total.Name = "total";
            total.Size = new Size(212, 43);
            total.TabIndex = 83;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(518, 464);
            label5.Name = "label5";
            label5.Size = new Size(113, 32);
            label5.TabIndex = 82;
            label5.Text = "Total Bill";
            // 
            // noTicket
            // 
            noTicket.BackColor = Color.MistyRose;
            noTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            noTicket.Location = new Point(203, 447);
            noTicket.Margin = new Padding(3, 4, 3, 4);
            noTicket.Multiline = true;
            noTicket.Name = "noTicket";
            noTicket.Size = new Size(212, 43);
            noTicket.TabIndex = 81;
            noTicket.TextChanged += noTicket_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(37, 447);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 80;
            label4.Text = "No of Ticket";
            // 
            // ticketPrice
            // 
            ticketPrice.BackColor = Color.MistyRose;
            ticketPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ticketPrice.Location = new Point(656, 357);
            ticketPrice.Margin = new Padding(3, 4, 3, 4);
            ticketPrice.Multiline = true;
            ticketPrice.Name = "ticketPrice";
            ticketPrice.Size = new Size(212, 43);
            ticketPrice.TabIndex = 79;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(464, 368);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 78;
            label3.Text = "Price Per Ticket";
            // 
            // launchName
            // 
            launchName.BackColor = Color.MistyRose;
            launchName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            launchName.Location = new Point(203, 357);
            launchName.Margin = new Padding(3, 4, 3, 4);
            launchName.Multiline = true;
            launchName.Name = "launchName";
            launchName.Size = new Size(212, 43);
            launchName.TabIndex = 77;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(37, 368);
            label2.Name = "label2";
            label2.Size = new Size(169, 32);
            label2.TabIndex = 76;
            label2.Text = "Launch Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(51, 31);
            label1.Name = "label1";
            label1.Size = new Size(243, 41);
            label1.TabIndex = 75;
            label1.Text = "Launch Booking";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 89);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(822, 204);
            dataGridView1.TabIndex = 74;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Search
            // 
            Search.Location = new Point(743, 55);
            Search.Name = "Search";
            Search.PlaceholderText = "Enter Destination";
            Search.Size = new Size(135, 27);
            Search.TabIndex = 86;
            // 
            // button1
            // 
            button1.Location = new Point(666, 53);
            button1.Name = "button1";
            button1.Size = new Size(71, 29);
            button1.TabIndex = 87;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(928, 611);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 88;
            pictureBox1.TabStop = false;
            // 
            // Launch_Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 51, 82);
            ClientSize = new Size(914, 600);
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
            Controls.Add(launchName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Launch_Booking";
            Text = "Launch_Booking";
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
        private TextBox launchName;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox Search;
        private Button button1;
        private PictureBox pictureBox1;
    }
}