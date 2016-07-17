namespace MyDiary
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NotesButton = new System.Windows.Forms.Button();
            this.EventsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotesButton
            // 
            this.NotesButton.BackColor = System.Drawing.Color.Transparent;
            this.NotesButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesButton.ForeColor = System.Drawing.Color.Blue;
            this.NotesButton.Location = new System.Drawing.Point(12, 12);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(77, 32);
            this.NotesButton.TabIndex = 0;
            this.NotesButton.Text = "Notes";
            this.NotesButton.UseVisualStyleBackColor = false;
            // 
            // EventsButton
            // 
            this.EventsButton.BackColor = System.Drawing.Color.Transparent;
            this.EventsButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventsButton.ForeColor = System.Drawing.Color.Blue;
            this.EventsButton.Location = new System.Drawing.Point(12, 50);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(77, 32);
            this.EventsButton.TabIndex = 1;
            this.EventsButton.Text = "Events";
            this.EventsButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(584, 319);
            this.Controls.Add(this.EventsButton);
            this.Controls.Add(this.NotesButton);
            this.Name = "MainForm";
            this.Text = "MyDiary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.Button EventsButton;
    }
}

