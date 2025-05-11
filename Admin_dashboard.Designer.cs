namespace Trip_Maker_Travel_Management_System_
{
    partial class Admin_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_dashboard));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button6 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(171, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(2, 3, 2, 3);
            pictureBox1.Size = new Size(811, 577);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(757, 27);
            label1.Name = "label1";
            label1.Size = new Size(207, 41);
            label1.TabIndex = 11;
            label1.Text = "ADMIN PAGE";
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(21, 33);
            button6.Name = "button6";
            button6.Size = new Size(128, 43);
            button6.TabIndex = 12;
            button6.Text = "Hotels";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(21, 108);
            button1.Name = "button1";
            button1.Size = new Size(128, 43);
            button1.TabIndex = 13;
            button1.Text = "Flights";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(21, 189);
            button2.Name = "button2";
            button2.Size = new Size(128, 43);
            button2.TabIndex = 14;
            button2.Text = "Trains";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(21, 268);
            button3.Name = "button3";
            button3.Size = new Size(128, 43);
            button3.TabIndex = 15;
            button3.Text = "Busses";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(21, 351);
            button4.Name = "button4";
            button4.Size = new Size(128, 43);
            button4.TabIndex = 16;
            button4.Text = "Launches";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(21, 431);
            button5.Name = "button5";
            button5.Size = new Size(128, 43);
            button5.TabIndex = 17;
            button5.Text = "Regstered acc";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(30, 493);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 28);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "LOG OUT";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Lavender;
            linkLabel2.LinkColor = Color.Red;
            linkLabel2.Location = new Point(829, 507);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(139, 20);
            linkLabel2.TabIndex = 19;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Create new account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Lavender;
            linkLabel3.LinkColor = Color.Red;
            linkLabel3.Location = new Point(680, 507);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(129, 20);
            linkLabel3.TabIndex = 20;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Customer Support";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // button7
            // 
            button7.BackColor = Color.Aquamarine;
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(843, 431);
            button7.Name = "button7";
            button7.Size = new Size(125, 58);
            button7.TabIndex = 21;
            button7.Text = "Sales & Payment";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 51, 82);
            ClientSize = new Size(974, 545);
            Controls.Add(button7);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Admin_dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Button button7;
    }
}