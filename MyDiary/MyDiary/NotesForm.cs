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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            text = NoteTextBox.Text;
            Note note = new Note(text, dayMark);
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dayMark = (DayMark)comboBox1.SelectedIndex;
        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
