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
        // Чорний фон
        private void BlackBackground_Click(object sender, EventArgs e)
        {
            string blackFon = "..//..//Content/Black_Background.jpg";
            BackgroundImage = Image.FromFile(blackFon);
            Properties.Settings.Default.Start_Fon = blackFon;
            Properties.Settings.Default.Save();
        }
        // Синій фон
        private void BlueBackground_Click(object sender, EventArgs e)
        {
            string blueFon = "..//..//Content/Blue_Background.jpg";
            BackgroundImage = Image.FromFile(blueFon);
            Properties.Settings.Default.Start_Fon = blueFon;
            Properties.Settings.Default.Save();
        }
        // Білий фон
        private void WhiteBackground_Click(object sender, EventArgs e)
        {
            string whiteFon = "..//..//Content/White_Background.jpg";
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
