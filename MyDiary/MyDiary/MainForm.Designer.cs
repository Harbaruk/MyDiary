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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotesButton
            // 
            this.NotesButton.BackColor = System.Drawing.Color.Transparent;
            this.NotesButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesButton.ForeColor = System.Drawing.Color.Blue;
            this.NotesButton.Location = new System.Drawing.Point(12, 12);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(88, 32);
            this.NotesButton.TabIndex = 0;
            this.NotesButton.Text = "Notes";
            this.NotesButton.UseVisualStyleBackColor = false;
            this.NotesButton.Click += new System.EventHandler(this.NotesButton_Click);
            // 
            // EventsButton
            // 
            this.EventsButton.BackColor = System.Drawing.Color.Transparent;
            this.EventsButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventsButton.ForeColor = System.Drawing.Color.Blue;
            this.EventsButton.Location = new System.Drawing.Point(12, 70);
            this.EventsButton.Name = "EventsButton";
            this.EventsButton.Size = new System.Drawing.Size(88, 32);
            this.EventsButton.TabIndex = 1;
            this.EventsButton.Text = "Events";
            this.EventsButton.UseVisualStyleBackColor = false;
            // 
            // Calendar
            // 
            this.Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Calendar.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calendar.Location = new System.Drawing.Point(410, 2);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 3;
            this.Calendar.TrailingForeColor = System.Drawing.Color.Gray;
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.OptionsButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OptionsButton.ForeColor = System.Drawing.Color.Blue;
            this.OptionsButton.Location = new System.Drawing.Point(12, 131);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(88, 32);
            this.OptionsButton.TabIndex = 4;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(485, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.EventsButton);
            this.Controls.Add(this.NotesButton);
            this.Name = "MainForm";
            this.Text = "MyDiary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.Button EventsButton;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button button1;
    }
}

