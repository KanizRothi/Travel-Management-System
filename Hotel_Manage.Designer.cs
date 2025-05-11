namespace Trip_Maker_Travel_Management_System_
{
    partial class Hotel_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel_Manage));
            label1 = new Label();
            phone = new TextBox();
            dataGridView1 = new DataGridView();
            price = new TextBox();
            address = new TextBox();
            hotelName = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            Search = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            destination = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 37);
            label1.TabIndex = 0;
            label1.Text = "Manage Hotels";
            // 
            // phone
            // 
            phone.BackColor = Color.MistyRose;
            phone.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            phone.Location = new Point(576, 124);
            phone.Multiline = true;
            phone.Name = "phone";
            phone.Size = new Size(206, 34);
            phone.TabIndex = 1;
            phone.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 145);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // price
            // 
            price.BackColor = Color.MistyRose;
            price.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            price.Location = new Point(576, 73);
            price.Multiline = true;
            price.Name = "price";
            price.Size = new Size(206, 34);
            price.TabIndex = 3;
            // 
            // address
            // 
            address.BackColor = Color.MistyRose;
            address.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            address.Location = new Point(162, 121);
            address.Multiline = true;
            address.Name = "address";
            address.Size = new Size(210, 34);
            address.TabIndex = 4;
            // 
            // hotelName
            // 
            hotelName.BackColor = Color.MistyRose;
            hotelName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            hotelName.Location = new Point(162, 71);
            hotelName.Multiline = true;
            hotelName.Name = "hotelName";
            hotelName.Size = new Size(210, 34);
            hotelName.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(56, 385);
            button1.Name = "button1";
            button1.Size = new Size(113, 40);
            button1.TabIndex = 6;
            button1.Text = "Add New";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 73);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 10;
            label2.Text = "Hotel Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(396, 73);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 11;
            label3.Text = "Price Per Night";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(10, 126);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 12;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(395, 126);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 13;
            label5.Text = "Phone Number";
            // 
            // button2
            // 
            button2.BackColor = Color.Plum;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateBlue;
            button2.Location = new Point(251, 385);
            button2.Name = "button2";
            button2.Size = new Size(113, 40);
            button2.TabIndex = 14;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(455, 385);
            button3.Name = "button3";
            button3.Size = new Size(113, 40);
            button3.TabIndex = 15;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Goldenrod;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.MidnightBlue;
            button4.Location = new Point(649, 385);
            button4.Name = "button4";
            button4.Size = new Size(113, 40);
            button4.TabIndex = 16;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Teal;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(706, 17);
            label6.Name = "label6";
            label6.Size = new Size(60, 25);
            label6.TabIndex = 17;
            label6.Text = "Done";
            label6.Click += label6_Click;
            // 
            // Search
            // 
            Search.BackColor = Color.MistyRose;
            Search.Location = new Point(625, 193);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.PlaceholderText = "Search By Name";
            Search.Size = new Size(102, 18);
            Search.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(732, 186);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(10, 170);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 68;
            label7.Text = "Destination";
            // 
            // destination
            // 
            destination.BackColor = Color.MistyRose;
            destination.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            destination.Location = new Point(161, 167);
            destination.Multiline = true;
            destination.Name = "destination";
            destination.Size = new Size(210, 34);
            destination.TabIndex = 67;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.neoned_lines_futuristic_aesthetics_glowing_neon_futuristic_style_smoked_dark;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(807, 459);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 69;
            pictureBox2.TabStop = false;
            // 
            // Hotel_Manage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 51, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(destination);
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
            Controls.Add(hotelName);
            Controls.Add(address);
            Controls.Add(price);
            Controls.Add(dataGridView1);
            Controls.Add(phone);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Hotel_Manage";
            Text = "Hotel_Manage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox phone;
        private DataGridView dataGridView1;
        private TextBox price;
        private TextBox address;
        private TextBox hotelName;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label6;
        private TextBox Search;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox destination;
        private PictureBox pictureBox2;
    }
}