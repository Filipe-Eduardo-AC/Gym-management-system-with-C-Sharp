namespace gym_management
{
    internal class Global
    {
        public static string Version = "1.0";
        public static bool logged = false;
        public static int level = 0; //0=Default - 1=Manager - 2=Master
        public static string path = System.Environment.CurrentDirectory;
        public static string nameDatabase = "db_gym.db";
        public static string pathDatabase = path + @"\database\";
        public static string pathPictures = path + @"\pictures\";

        /*
        tb_users
        N_USERID
        T_NAME
        T_USERNAME
        T_USERPASSWORD
        T_STATUS
        N_LEVEL
        */
    }
}
