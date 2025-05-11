namespace Trip_Maker_Travel_Management_System_
{
    partial class Flights_Booking
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
            flightName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(772, 527);
            button2.Name = "button2";
            button2.Size = new Size(110, 39);
            button2.TabIndex = 61;
            button2.Text = "Purchase";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(72, 534);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 60;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total.Location = new Point(676, 438);
            total.Margin = new Padding(3, 4, 3, 4);
            total.Multiline = true;
            total.Name = "total";
            total.Size = new Size(212, 43);
            total.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(538, 438);
            label5.Name = "label5";
            label5.Size = new Size(113, 32);
            label5.TabIndex = 58;
            label5.Text = "Total Bill";
            // 
            // noTicket
            // 
            noTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            noTicket.Location = new Point(201, 438);
            noTicket.Margin = new Padding(3, 4, 3, 4);
            noTicket.Multiline = true;
            noTicket.Name = "noTicket";
            noTicket.Size = new Size(212, 43);
            noTicket.TabIndex = 57;
            noTicket.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(23, 432);
            label4.Name = "label4";
            label4.Size = new Size(165, 64);
            label4.TabIndex = 56;
            label4.Text = "No of Tickets\r\n\r\n";
            label4.Click += label4_Click;
            // 
            // ticketPrice
            // 
            ticketPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ticketPrice.Location = new Point(676, 359);
            ticketPrice.Margin = new Padding(3, 4, 3, 4);
            ticketPrice.Multiline = true;
            ticketPrice.Name = "ticketPrice";
            ticketPrice.Size = new Size(212, 43);
            ticketPrice.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(484, 353);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 54;
            label3.Text = "Price Per Ticket";
            // 
            // flightName
            // 
            flightName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            flightName.Location = new Point(201, 359);
            flightName.Margin = new Padding(3, 4, 3, 4);
            flightName.Multiline = true;
            flightName.Name = "flightName";
            flightName.Size = new Size(212, 43);
            flightName.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 359);
            label2.Name = "label2";
            label2.Size = new Size(152, 32);
            label2.TabIndex = 52;
            label2.Text = "Flight Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(41, 31);
            label1.Name = "label1";
            label1.Size = new Size(248, 41);
            label1.TabIndex = 51;
            label1.Text = "Flights  Booking";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(60, 90);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(822, 204);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            // 
            // button1
            // 
            button1.Location = new Point(660, 55);
            button1.Name = "button1";
            button1.Size = new Size(71, 29);
            button1.TabIndex = 67;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Search
            // 
            Search.Location = new Point(737, 56);
            Search.Name = "Search";
            Search.PlaceholderText = "Enter Destination";
            Search.Size = new Size(145, 27);
            Search.TabIndex = 66;
            // 
            // Flights_Booking
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
            Controls.Add(flightName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            ImeMode = ImeMode.Off;
            Name = "Flights_Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flights_Booking";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox flightName;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox Search;
    }
}