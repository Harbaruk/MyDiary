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
    public partial class Login : Form
    {
        public bool IsLog;

        public Login()
        {
            InitializeComponent();

            if (!File.Exists("Hash.txt"))
            {
                File.Create("Hash.txt");
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string pass = File.ReadAllText("Hash.txt");
            if(pass != "")
            {
                if(pass == PassBox.Text.GetHashCode().ToString())
                {
                    IsLog = true;
                    this.Close();
                }
                else
                {
                    PassBox.Text = "";
                }
            }
            else
            {
                IsLog = true;
                File.WriteAllText("Hash.txt", PassBox.Text.GetHashCode().ToString());
                this.Close();
            }
        }

        private void PassBox_MouseDown(object sender, MouseEventArgs e)
        {
            PassBox.Text = "";
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsLog == false)
            {
                Application.Exit();
            }
        }
    }
}
