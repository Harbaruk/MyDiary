using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
   public class User 
    {
        private long Password { get; set; }

        public User() { }
        public User(string pass)
        {
            Password = pass.GetHashCode();
        }
        // Метод провіряє валідність пароля
        public bool Validation(string pass)
        {
            if (pass.GetHashCode() == Password)
            {
                return true;
            }
            return false;
        }
        // Метод змінює поточний пароль на новий 
        public void ChangePassword(string pass)
        {
            Password = pass.GetHashCode();
        }
    }
}
