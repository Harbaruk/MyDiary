﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
    class User
    {
        private long password { get; set; }
        public User(string pass)
        {
            password = pass.GetHashCode();
        }
    }
}
