namespace Trip_Maker_Travel_Management_System_
{
    partial class Trains_Booking
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
            trainName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Search = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(733, 530);
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
            label6.Location = new Point(56, 530);
            label6.Name = "label6";
            label6.Size = new Size(67, 32);
            label6.TabIndex = 60;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total.Location = new Point(656, 447);
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
            label5.Location = new Point(519, 448);
            label5.Name = "label5";
            label5.Size = new Size(113, 32);
            label5.TabIndex = 58;
            label5.Text = "Total Bill";
            // 
            // noTicket
            // 
            noTicket.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            noTicket.Location = new Point(204, 447);
            noTicket.Margin = new Padding(3, 4, 3, 4);
            noTicket.Multiline = true;
            noTicket.Name = "noTicket";
            noTicket.Size = new Size(212, 43);
            noTicket.TabIndex = 57;
            noTicket.TextChanged += noTicket_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(37, 447);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 56;
            label4.Text = "No of Ticket";
            // 
            // ticketPrice
            // 
            ticketPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ticketPrice.Location = new Point(656, 357);
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
            label3.Location = new Point(464, 368);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 54;
            label3.Text = "Price Per Ticket";
            // 
            // trainName
            // 
            trainName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            trainName.Location = new Point(204, 357);
            trainName.Margin = new Padding(3, 4, 3, 4);
            trainName.Multiline = true;
            trainName.Name = "trainName";
            trainName.Size = new Size(212, 43);
            trainName.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(37, 368);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 52;
            label2.Text = "Train Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(51, 31);
            label1.Name = "label1";
            label1.Size = new Size(228, 41);
            label1.TabIndex = 51;
            label1.Text = "Trains Booking";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(56, 89);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(822, 204);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Search
            // 
            Search.Location = new Point(733, 55);
            Search.Name = "Search";
            Search.PlaceholderText = "Enter Destination";
            Search.Size = new Size(145, 27);
            Search.TabIndex = 62;
            // 
            // button1
            // 
            button1.Location = new Point(656, 53);
            button1.Name = "button1";
            button1.Size = new Size(71, 29);
            button1.TabIndex = 64;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Trains_Booking
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
            Controls.Add(trainName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Trains_Booking";
            Text = "Trains_Booking";
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
        private TextBox trainName;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox Search;
        private Button button1;
    }
}