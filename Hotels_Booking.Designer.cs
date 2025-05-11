namespace Trip_Maker_Travel_Management_System_
{
    partial class Hotels_Booking
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            hotelNme = new TextBox();
            label3 = new Label();
            price = new TextBox();
            label4 = new Label();
            noNight = new TextBox();
            label5 = new Label();
            total = new TextBox();
            label6 = new Label();
            button2 = new Button();
            Search = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(719, 153);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 105, 158);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 25);
            label1.Name = "label1";
            label1.Size = new Size(189, 32);
            label1.TabIndex = 1;
            label1.Text = "Hotels Booking";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(7, 22, 45);
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(24, 278);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 2;
            label2.Text = "Hotel Name";
            // 
            // hotelNme
            // 
            hotelNme.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            hotelNme.Location = new Point(170, 269);
            hotelNme.Multiline = true;
            hotelNme.Name = "hotelNme";
            hotelNme.Size = new Size(186, 33);
            hotelNme.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(7, 22, 45);
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(397, 278);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 4;
            label3.Text = "Price Per Night";
            // 
            // price
            // 
            price.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            price.Location = new Point(565, 269);
            price.Multiline = true;
            price.Name = "price";
            price.Size = new Size(186, 33);
            price.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(7, 22, 45);
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(24, 337);
            label4.Name = "label4";
            label4.Size = new Size(126, 25);
            label4.TabIndex = 6;
            label4.Text = "No of Nights";
            // 
            // noNight
            // 
            noNight.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            noNight.Location = new Point(170, 337);
            noNight.Multiline = true;
            noNight.Name = "noNight";
            noNight.Size = new Size(186, 33);
            noNight.TabIndex = 7;
            noNight.TextChanged += noNight_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(7, 22, 45);
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(448, 339);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 8;
            label5.Text = "Total Bill";
            // 
            // total
            // 
            total.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            total.Location = new Point(565, 341);
            total.Multiline = true;
            total.Name = "total";
            total.Size = new Size(186, 33);
            total.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(40, 399);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 48;
            label6.Text = "Back";
            label6.Click += label6_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(633, 399);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 49;
            button2.Text = "Purchase";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Search
            // 
            Search.Location = new Point(633, 43);
            Search.Margin = new Padding(3, 2, 3, 2);
            Search.Name = "Search";
            Search.PlaceholderText = "Enter Destination";
            Search.Size = new Size(127, 23);
            Search.TabIndex = 50;
            Search.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(565, 42);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(62, 22);
            button1.TabIndex = 65;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._900512_OAK41A0;
            pictureBox1.Location = new Point(-8, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(816, 468);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // Hotels_Booking
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
            Controls.Add(noNight);
            Controls.Add(label4);
            Controls.Add(price);
            Controls.Add(label3);
            Controls.Add(hotelNme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Hotels_Booking";
            Text = "Hotels_Booking";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox hotelNme;
        private Label label3;
        private TextBox price;
        private Label label4;
        private TextBox noNight;
        private Label label5;
        private TextBox total;
        private Label label6;
        private Button button2;
        private TextBox Search;
        private Button button1;
        private PictureBox pictureBox1;
    }
}