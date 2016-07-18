using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary
{
    public partial class MainForm : Form
    {
        Login login = new Login();
        NotesForm note = new NotesForm();

        public MainForm()
        {
            InitializeComponent();
           
            login.ShowDialog();

            NotesButton.Parent = this;
            EventsButton.Parent = this;

            
            note.FormClosing += Note_FormClosing;            

            BackgroundImage = new Bitmap(@"..\..\Content\background.jpg");
            
        }

        private void Note_FormClosing(object sender, FormClosingEventArgs e)
        {
            label1.Text = note.text;
            string text = note.text;
        }

        private void NotesButton_Click(object sender, EventArgs e)
        {
            note.Show();
        }
    }
}
