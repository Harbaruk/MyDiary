using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiary
{
    public partial class NotesForm : Form
    {
        public string text;
        public DayMark dayMark;
        public NotesForm()

        {
            InitializeComponent();
        }

        private void Save(object sender, EventArgs e)
        {
            
            text = NoteTextBox.Text;
            dayMark = (DayMark)comboBox1.SelectedIndex;
            if ((int)dayMark != -1)
            {
                Note note = new Note(text, dayMark);
            }
            else
            {
                Note note = new Note(text);
            }
            this.Close();
        }

    }
}
