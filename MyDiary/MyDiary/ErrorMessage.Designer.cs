namespace MyDiary
{
    partial class ErrorMessage
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
            this.ErrorButton = new System.Windows.Forms.Button();
            this.ErrorLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ErrorButton
            // 
            this.ErrorButton.Location = new System.Drawing.Point(102, 120);
            this.ErrorButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ErrorButton.Name = "ErrorButton";
            this.ErrorButton.Size = new System.Drawing.Size(138, 42);
            this.ErrorButton.TabIndex = 0;
            this.ErrorButton.Text = "ОК";
            this.ErrorButton.UseVisualStyleBackColor = true;
            this.ErrorButton.Click += new System.EventHandler(this.ErrorButton_Click);
            // 
            // ErrorLable
            // 
            this.ErrorLable.AutoSize = true;
            this.ErrorLable.ForeColor = System.Drawing.Color.Red;
            this.ErrorLable.Location = new System.Drawing.Point(48, 63);
            this.ErrorLable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ErrorLable.Name = "ErrorLable";
            this.ErrorLable.Size = new System.Drawing.Size(239, 24);
            this.ErrorLable.TabIndex = 1;
            this.ErrorLable.Text = "Невірно вказаний пароль";
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 192);
            this.Controls.Add(this.ErrorLable);
            this.Controls.Add(this.ErrorButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ErrorMessage";
            this.Text = "ErrorMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ErrorButton;
        private System.Windows.Forms.Label ErrorLable;
    }
}