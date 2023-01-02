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
                using (var cmd = DB_Connection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_users";
                    da = new SQLiteDataAdapter(cmd.CommandText, DB_Connection());
                    da.Fill(dt);
                    DB_Connection().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                DB_Connection().Close();
                throw ex;
            }

        }

        public static DataTable consult(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = DB_Connection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DB_Connection());
                    da.Fill(dt);
                    DB_Connection().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                DB_Connection().Close();
                throw ex;
            }
        }
    }
}
