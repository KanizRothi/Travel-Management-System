namespace Trip_Maker_Travel_Management_System_
{
    partial class UserId_Paschange
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
            label4 = new Label();
            UserId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pass = new TextBox();
            newPassword = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(227, 237);
            label4.Name = "label4";
            label4.Size = new Size(89, 31);
            label4.TabIndex = 46;
            label4.Text = " UserId";
            // 
            // UserId
            // 
            UserId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserId.Location = new Point(488, 237);
            UserId.Margin = new Padding(3, 4, 3, 4);
            UserId.Multiline = true;
            UserId.Name = "UserId";
            UserId.Size = new Size(212, 43);
            UserId.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(227, 327);
            label3.Name = "label3";
            label3.Size = new Size(167, 31);
            label3.TabIndex = 44;
            label3.Text = "Prev Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(227, 161);
            label2.Name = "label2";
            label2.Size = new Size(168, 31);
            label2.TabIndex = 43;
            label2.Text = "New Password";
            // 
            // pass
            // 
            pass.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pass.Location = new Point(488, 315);
            pass.Margin = new Padding(3, 4, 3, 4);
            pass.Multiline = true;
            pass.Name = "pass";
            pass.Size = new Size(212, 43);
            pass.TabIndex = 42;
            // 
            // newPassword
            // 
            newPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newPassword.Location = new Point(488, 161);
            newPassword.Margin = new Padding(3, 4, 3, 4);
            newPassword.Multiline = true;
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(212, 43);
            newPassword.TabIndex = 41;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Black;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(60, 511);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 28);
            linkLabel1.TabIndex = 40;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Done";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(613, 411);
            button1.Name = "button1";
            button1.Size = new Size(190, 54);
            button1.TabIndex = 39;
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
            label1.Location = new Point(60, 56);
            label1.Name = "label1";
            label1.Size = new Size(463, 41);
            label1.TabIndex = 38;
            label1.Text = "Account Settings  (Pass change)";
            // 
            // UserId_Paschange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(917, 582);
            Controls.Add(label4);
            Controls.Add(UserId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pass);
            Controls.Add(newPassword);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UserId_Paschange";
            Text = "UserId_Paschange";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox UserId;
        private Label label3;
        private Label label2;
        private TextBox pass;
        private TextBox newPassword;
        private LinkLabel linkLabel1;
        private Button button1;
        private Label label1;
    }
}