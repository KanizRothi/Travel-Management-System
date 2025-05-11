namespace Trip_Maker_Travel_Management_System_
{
    partial class Registered_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registered_Accounts));
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            label3 = new Label();
            label2 = new Label();
            userID = new TextBox();
            pass = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Search = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(12, 411);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(400, 108);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 56;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(40, 108);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 55;
            label2.Text = "User ID";
            label2.Click += label2_Click;
            // 
            // userID
            // 
            userID.BackColor = Color.MistyRose;
            userID.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            userID.Location = new Point(143, 103);
            userID.Multiline = true;
            userID.Name = "userID";
            userID.Size = new Size(228, 34);
            userID.TabIndex = 53;
            // 
            // pass
            // 
            pass.BackColor = Color.MistyRose;
            pass.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            pass.Location = new Point(510, 103);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(249, 34);
            pass.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(718, 213);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(279, 37);
            label1.TabIndex = 48;
            label1.Text = "Registered Accounts";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(730, 55);
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
            Search.Location = new Point(625, 62);
            Search.Multiline = true;
            Search.Name = "Search";
            Search.PlaceholderText = "Search By Userid";
            Search.Size = new Size(100, 18);
            Search.TabIndex = 63;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dark_gray_wall_with_wooden_plank_product_background;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(815, 461);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 65;
            pictureBox2.TabStop = false;
            // 
            // Registered_Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 51, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(Search);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userID);
            Controls.Add(pass);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "Registered_Accounts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registered_Accounts";
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
        private Label label3;
        private Label label2;
        private TextBox userID;
        private TextBox pass;
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox Search;
        private PictureBox pictureBox2;
    }
}