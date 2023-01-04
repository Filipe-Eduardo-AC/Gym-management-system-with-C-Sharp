using System.Data;
using System.Data.SQLite;

namespace gym_management
{
    internal class Database
    {
        private static SQLiteConnection connection;

        private static SQLiteConnection DB_Connection()
        {
            connection = new SQLiteConnection("Data Source=C:\\Users\\filip\\Desktop\\Coding\\Projects\\C#\\gym_management\\database\\db_gym.db");
            connection.Open();
            return connection;
        }

        public static DataTable GetAllUsers()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DB_Connection();
                var cmd = DB_Connection().CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_users";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable consult(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DB_Connection();
                var cmd = DB_Connection().CreateCommand();

                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetUsersIdName()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DB_Connection();
                var cmd = DB_Connection().CreateCommand();

                cmd.CommandText = "SELECT N_USERID as 'User ID', T_NAME as 'Name' FROM tb_users";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetUsersData(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = DB_Connection();
                var cmd = DB_Connection().CreateCommand();

                cmd.CommandText = "SELECT * FROM tb_users WHERE N_USERID=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void NewUser(User u)
        {
            if (usernameExists(u))
            {
                MessageBox.Show("Username already existis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                var vcon = DB_Connection();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_users (T_NAME, T_USERNAME, T_USERPASSWORD, T_STATUS, N_LEVEL) VALUES (@name, @username, @password, @status, @level)";
                cmd.Parameters.AddWithValue("@name", u.name);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@level", u.level);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New user created successfully", "New user created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static bool usernameExists(User u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = DB_Connection();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_users WHERE T_USERNAME = '" + u.username + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }

    }
}
