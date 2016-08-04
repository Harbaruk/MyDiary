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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(LoginBox.Text == "")
            {
                MessageBox.Show("Please choose your login");
            }

            else if(PassBox.Text == "")
            {
                MessageBox.Show("Create choose your password");
            }

            else if(PassBox.Text !="" && PassBox.Text != ConfirmBox.Text)
            {
                MessageBox.Show("Did you forget your password? :)");
            }

            else
            {
                User temp = new User(LoginBox.Text,PassBox.Text);
                CRUD.AddUser(temp);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
