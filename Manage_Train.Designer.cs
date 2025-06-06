﻿namespace Trip_Maker_Travel_Management_System_
{
    partial class Manage_Train
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Train));
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            trainName = new TextBox();
            from = new TextBox();
            ticketPrice = new TextBox();
            dataGridView1 = new DataGridView();
            to = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Search = new TextBox();
            label7 = new Label();
            phone = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(724, 28);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 62;
            label6.Text = "Done";
            label6.Click += label6_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.MidnightBlue;
            button4.Location = new Point(646, 396);
            button4.Name = "button4";
            button4.Size = new Size(113, 40);
            button4.TabIndex = 61;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(452, 396);
            button3.Name = "button3";
            button3.Size = new Size(113, 40);
            button3.TabIndex = 60;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateBlue;
            button2.Location = new Point(248, 396);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 59;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(440, 124);
            label5.Name = "label5";
            label5.Size = new Size(33, 25);
            label5.TabIndex = 58;
            label5.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(18, 124);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 57;
            label4.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(440, 70);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 56;
            label3.Text = "Price ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 70);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 55;
            label2.Text = "Train Name";
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(53, 396);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 54;
            button1.Text = "Add New";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // trainName
            // 
            trainName.BackColor = Color.MistyRose;
            trainName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            trainName.Location = new Point(159, 68);
            trainName.Multiline = true;
            trainName.Name = "trainName";
            trainName.Size = new Size(250, 34);
            trainName.TabIndex = 53;
            // 
            // from
            // 
            from.BackColor = Color.MistyRose;
            from.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            from.Location = new Point(159, 116);
            from.Multiline = true;
            from.Name = "from";
            from.Size = new Size(250, 34);
            from.TabIndex = 52;
            // 
            // ticketPrice
            // 
            ticketPrice.BackColor = Color.MistyRose;
            ticketPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ticketPrice.Location = new Point(522, 68);
            ticketPrice.Multiline = true;
            ticketPrice.Name = "ticketPrice";
            ticketPrice.Size = new Size(249, 34);
            ticketPrice.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 145);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // to
            // 
            to.BackColor = Color.MistyRose;
            to.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            to.Location = new Point(522, 116);
            to.Multiline = true;
            to.Name = "to";
            to.Size = new Size(248, 34);
            to.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 20);
            label1.Name = "label1";
            label1.Size = new Size(192, 37);
            label1.TabIndex = 48;
            label1.Text = "Manage Train";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(728, 194);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Search
            // 
            Search.BackColor = Color.MistyRose;
            Search.Location = new Point(623, 201);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.PlaceholderText = "Search By Name";
            Search.Size = new Size(100, 18);
            Search.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(18, 170);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 66;
            label7.Text = "Phone";
            // 
            // phone
            // 
            phone.BackColor = Color.MistyRose;
            phone.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(159, 167);
            phone.Multiline = true;
            phone.Name = "phone";
            phone.Size = new Size(250, 34);
            phone.TabIndex = 65;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._10016491_27230;
            pictureBox2.Location = new Point(-6, -12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(803, 467);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 67;
            pictureBox2.TabStop = false;
            // 
            // Manage_Train
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 51, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(phone);
            Controls.Add(pictureBox1);
            Controls.Add(Search);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(trainName);
            Controls.Add(from);
            Controls.Add(ticketPrice);
            Controls.Add(dataGridView1);
            Controls.Add(to);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Manage_Train";
            Text = "Manage_Train";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private TextBox trainName;
        private TextBox from;
        private TextBox ticketPrice;
        private DataGridView dataGridView1;
        private TextBox to;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox Search;
        private Label label7;
        private TextBox phone;
        private PictureBox pictureBox2;
    }
}