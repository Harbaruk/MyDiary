using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            ExitButton.Parent = this;
            ExitButton.BackColor = Color.Transparent;
            BackgroundImage = Image.FromFile(Properties.Settings.Default.Start_Background);
           
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            // Встав свій connection string 
            string connectionstring = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\Gitab Project\\SenjorBogdan\\MyDiary\\MyDiary\\MyDiary\\MyDiary\\bin\\Debug\\Diary.mdf; Integrated Security = True;";
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            string log = LoginBox.Text;
            int pass = (PassBox.Text).GetHashCode();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Login = @log AND Password = @pass", connect);
            cmd.Parameters.Add(new SqlParameter("@log", log));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));

            connect.Open();
            reader = cmd.ExecuteReader();
            

            if (!reader.HasRows)
            {
                MessageBox.Show("Sorry, you're not registred", "Oops", MessageBoxButtons.OK);
                connect.Close();
                LoginBox.Text = "Login";
                PassBox.Text = "********";
            }

            else
            {
                IsLog = true;
                connect.Close();
                this.Hide();
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

        private void LoginBox_MouseDown(object sender, MouseEventArgs e)
        {
            LoginBox.Text = "";
            LoginBox.ForeColor = Color.Black;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            Registration regform = new Registration();
            DialogResult res = regform.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                IsLog = true;
                this.Hide();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
