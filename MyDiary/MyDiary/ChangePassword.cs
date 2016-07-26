﻿using System;
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
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (user.Validation(CurrentPassword.Text) == true)
            {
                if (NewPassword == СonfirmNewPassword)
                {
                    user.ChangePassword(СonfirmNewPassword.Text);
                }
            }
        }

    }
}
