using System.Data;

namespace gym_management
{
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();

        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Invalid password or username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_username.Focus();
                return;
            }

            string sql = "SELECT * FROM tb_users WHERE T_USERNAME = '" + username + "' AND T_USERPASSWORD= '" + password + "'";
            dt = Database.dql(sql);

            if (dt.Rows.Count == 1)
            {
                form1.lb_access.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_name.Text = dt.Rows[0].Field<string>("T_NAME");
                form1.pb_ledlogged.Image = Properties.Resources.green_led;
                Global.level = int.Parse(dt.Rows[0].Field<Int64>("N_LEVEL").ToString());
                Global.logged = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_username.Focus();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
