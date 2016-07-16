using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
    class User
    {
        private long Password { get; }
        public User(string pass)
        {
            Password = pass.GetHashCode();
        }
    }
}
