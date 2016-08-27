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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            BackgroundImage = Image.FromFile(Properties.Settings.Default.Start_Background);
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.Validation(CurrentPassword.Text) == true)
            {
                if (NewPassword == ConfirmNewPassword)
                {
                    user.ChangePassword(ConfirmNewPassword.Text);
                }
            }
            else
            {
                MessageBox.Show("Неправильно введений пароль ","Помилка авторизації",MessageBoxButtons.OK,MessageBoxIcon.Error);
                CurrentPassword.Clear();
                NewPassword.Clear();
                ConfirmNewPassword.Clear();
            }
        }

    }
}
