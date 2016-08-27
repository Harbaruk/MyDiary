namespace MyDiary
{
    partial class Options
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
            this.Black = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.White = new System.Windows.Forms.Button();
            this.ChooseImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Black
            // 
            this.Black.Location = new System.Drawing.Point(2, 25);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(75, 23);
            this.Black.TabIndex = 0;
            this.Black.Text = "Black";
            this.Black.UseVisualStyleBackColor = true;
            this.Black.Click += new System.EventHandler(this.BlackBackground_Click);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(2, 54);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(75, 23);
            this.Blue.TabIndex = 1;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.Click += new System.EventHandler(this.BlueBackground_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Fon";
            // 
            // White
            // 
            this.White.Location = new System.Drawing.Point(2, 83);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(75, 23);
            this.White.TabIndex = 3;
            this.White.Text = "White";
            this.White.UseVisualStyleBackColor = true;
            this.White.Click += new System.EventHandler(this.WhiteBackground_Click);
            // 
            // ChooseImage
            // 
            this.ChooseImage.Location = new System.Drawing.Point(2, 112);
            this.ChooseImage.Name = "ChooseImage";
            this.ChooseImage.Size = new System.Drawing.Size(85, 23);
            this.ChooseImage.TabIndex = 4;
            this.ChooseImage.Text = "Choose Image";
            this.ChooseImage.UseVisualStyleBackColor = true;
            this.ChooseImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 331);
            this.Controls.Add(this.ChooseImage);
            this.Controls.Add(this.White);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Blue);
            this.Name = "Options";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button ChooseImage;
    }
}