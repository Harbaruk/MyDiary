using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
    class User
    {
        private long password;
        public long Password
        {
            get { return password; }
            set { password = value; }
        }
        public User(string pass)
        {
            password = pass.GetHashCode();
        }
    }
}
