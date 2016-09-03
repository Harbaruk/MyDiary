using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
    public static class CRUD
    {
        public static void AddUser(User arg)
        {
            string connectionstring = " Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\Gitab Project\\SenjorBogdan\\MyDiary\\MyDiary\\MyDiary\\MyDiary\\Diary.mdf; Integrated Security = True; Connect Timeout = 30";//я й без нього пробував,без нього взашалі помилку видає яку я тобі скріном скидував
            SqlConnection connect = new SqlConnection(connectionstring);
            SqlDataReader reader;

            string log = arg.Login;
            string pass = arg.GetPass();
            SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES (@log,@pass)", connect);
            cmd.Parameters.Add(new SqlParameter("@log", log));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));

            connect.Open();
            reader = cmd.ExecuteReader();
        }
    }
}
