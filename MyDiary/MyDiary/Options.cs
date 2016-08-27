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
            BackgroundImage = Image.FromFile(Properties.Settings.Default.Start_Background);
        }
        // Чорний фон
        private void BlackBackground_Click(object sender, EventArgs e)
        {
            string blackBackground = "..//..//Content/Black_Background.jpg";
            BackgroundImage = Image.FromFile(blackBackground);
            Properties.Settings.Default.Start_Background = blackBackground;
            Properties.Settings.Default.Save();
        }
        // Синій фон
        private void BlueBackground_Click(object sender, EventArgs e)
        {
            string blueBackground = "..//..//Content/Blue_Background.jpg";
            BackgroundImage = Image.FromFile(blueBackground);
            Properties.Settings.Default.Start_Background = blueBackground;
            Properties.Settings.Default.Save();
        }
        // Білий фон
        private void WhiteBackground_Click(object sender, EventArgs e)
        {
            string whiteBackground = "..//..//Content/White_Background.jpg";
            BackgroundImage = Image.FromFile(whiteBackground);
            Properties.Settings.Default.Start_Background = whiteBackground;
            Properties.Settings.Default.Save();
        }
        // Вибір фону через FileDialog
        private void AddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = Image.FromFile(openFileDialog.FileName);
                Properties.Settings.Default.Start_Background = openFileDialog.FileName;

                Properties.Settings.Default.Save();
            }

        }
    }
}
