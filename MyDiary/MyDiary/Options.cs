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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
            // Встановлення фонового малюнка за замовчуванням
            BackgroundImage = Image.FromFile(Properties.Settings.Default.Start_Fon);
        }

       OpenFileDialog fileDialog = new OpenFileDialog();

        // Чорний фон
        private void BlackFon_Click(object sender, EventArgs e)
        {
            string blackFon = "..//..//Content/Black_Fon.jpg";
            BackgroundImage = Image.FromFile(blackFon);
            Properties.Settings.Default.Start_Fon = blackFon;
            Properties.Settings.Default.Save();
        }
        // Синій фон
        private void BlueFon_Click(object sender, EventArgs e)
        {
            string blueFon = "..//..//Content/Blue_Fon.jpg";
            BackgroundImage = Image.FromFile(blueFon);
            Properties.Settings.Default.Start_Fon = blueFon;
            Properties.Settings.Default.Save();
        }
        // Білий фон
        private void WhiteFon_Click(object sender, EventArgs e)
        {
            string whiteFon = "..//..//Content/White_Fon.jpg";
            BackgroundImage = Image.FromFile(whiteFon);
            Properties.Settings.Default.Start_Fon = whiteFon;
            Properties.Settings.Default.Save();
        }
        // Вибір фону через FileDialog
        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = Image.FromFile(openFileDialog.FileName);
                Properties.Settings.Default.Start_Fon = openFileDialog.FileName;

                Properties.Settings.Default.Save();
            }

        }
    }
}
