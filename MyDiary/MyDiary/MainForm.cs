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
        public MainForm()
        {
            InitializeComponent();
            
            Login login = new Login();
            login.ShowDialog();

            NotesButton.Parent = this;
            EventsButton.Parent = this;

            BackgroundImage = new Bitmap(@"..\..\Content\background.jpg");
            
        }
    }
}
