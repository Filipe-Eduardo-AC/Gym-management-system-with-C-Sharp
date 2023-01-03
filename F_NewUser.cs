namespace gym_management
{
    public partial class F_NewUser : Form
    {
        public F_NewUser()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.name = tb_name.Text;
            user.username = tb_username.Text;
            user.password = tb_password.Text;
            user.status = cb_status.Text;
            user.level = Convert.ToInt32(Math.Round(n_level.Value, 0));
        }
    }
}
