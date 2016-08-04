namespace MyDiary
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.EnterButton = new System.Windows.Forms.Button();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnterButton.Location = new System.Drawing.Point(225, 253);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(74, 29);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Log In";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.PassBox.Location = new System.Drawing.Point(99, 232);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 1;
            this.PassBox.Text = "Enter password";
            this.PassBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PassBox_MouseDown);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.PapayaWhip;
            this.WelcomeLabel.Location = new System.Drawing.Point(36, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(216, 53);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "WELCOME!";
            // 
            // LoginBox
            // 
            this.LoginBox.BackColor = System.Drawing.Color.PapayaWhip;
            this.LoginBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginBox.Location = new System.Drawing.Point(99, 206);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 3;
            this.LoginBox.Text = "Login";
            this.LoginBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginBox_MouseDown);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.RegButton.Location = new System.Drawing.Point(0, 253);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(74, 29);
            this.RegButton.TabIndex = 4;
            this.RegButton.Text = "Registration";
            this.RegButton.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(299, 282);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.EnterButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Button RegButton;
    }
}