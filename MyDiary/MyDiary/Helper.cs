using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
    public static class Helper
    {
        public static bool IsEqual(string a, string b)
        {
            if (a.GetHashCode() == b.GetHashCode())
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsEqual(string a, long b)
        {
            if (a.GetHashCode() == b)
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsEqual(string a, User b)
        {
            if (a.GetHashCode() == int.Parse(b.GetPass()))
            {
                return true;
            }
            else
                return false;
        }
    }
}
