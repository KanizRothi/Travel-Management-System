namespace Trip_Maker_Travel_Management_System_
{
    partial class User_name_change
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
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label1 = new Label();
            newUserid = new TextBox();
            pass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            prevUserId = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(35, 481);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 28);
            linkLabel1.TabIndex = 30;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Done";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(579, 394);
            button1.Name = "button1";
            button1.Size = new Size(190, 54);
            button1.TabIndex = 27;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(491, 41);
            label1.TabIndex = 26;
            label1.Text = "Account Settings  (UserId change)";
            // 
            // newUserid
            // 
            newUserid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newUserid.Location = new Point(454, 144);
            newUserid.Margin = new Padding(3, 4, 3, 4);
            newUserid.Multiline = true;
            newUserid.Name = "newUserid";
            newUserid.Size = new Size(212, 43);
            newUserid.TabIndex = 32;
            // 
            // pass
            // 
            pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pass.Location = new Point(454, 298);
            pass.Margin = new Padding(3, 4, 3, 4);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(212, 43);
            pass.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(193, 144);
            label2.Name = "label2";
            label2.Size = new Size(137, 31);
            label2.TabIndex = 34;
            label2.Text = "New UserId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(193, 310);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 35;
            label3.Text = "Password";
            // 
            // prevUserId
            // 
            prevUserId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            prevUserId.Location = new Point(454, 220);
            prevUserId.Margin = new Padding(3, 4, 3, 4);
            prevUserId.Multiline = true;
            prevUserId.Name = "prevUserId";
            prevUserId.Size = new Size(212, 43);
            prevUserId.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(193, 220);
            label4.Name = "label4";
            label4.Size = new Size(136, 31);
            label4.TabIndex = 37;
            label4.Text = "Prev UserId";
            // 
            // User_name_change
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(917, 582);
            Controls.Add(label4);
            Controls.Add(prevUserId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pass);
            Controls.Add(newUserid);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "User_name_change";
            Text = "User_name_change";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button button1;
        private Label label1;
        private TextBox newUserid;
        private TextBox pass;
        private Label label2;
        private Label label3;
        private TextBox prevUserId;
        private Label label4;
    }
}