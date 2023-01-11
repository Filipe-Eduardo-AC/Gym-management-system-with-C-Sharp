using System.Data;

namespace gym_management
{
    public partial class F_UserManagement : Form
    {
        public F_UserManagement()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void F_UserManagement_Load(object sender, EventArgs e)
        {
            dgv_users.DataSource = Database.GetUsersIdName();
            dgv_users.Columns[0].Width = 85;
            dgv_users.Columns[1].Width = 190;
        }

        private void dgv_users_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int lineCount = dgv.SelectedRows.Count;

            if (lineCount > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Database.GetUsersData(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_USERID").ToString();
                tb_name.Text = dt.Rows[0].Field<string>("T_NAME").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_password.Text = dt.Rows[0].Field<string>("T_USERPASSWORD").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUS").ToString();
                n_level.Value = dt.Rows[0].Field<Int64>("N_LEVEL");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            F_NewUser f_NewUser = new F_NewUser();
            f_NewUser.ShowDialog();
            dgv_users.DataSource = Database.GetUsersIdName();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int line = dgv_users.SelectedRows[0].Index;
            User u = new User();
            u.id = Convert.ToInt32(tb_id.Text);
            u.name = tb_name.Text;
            u.username = tb_username.Text;
            u.password = tb_password.Text;
            u.status = cb_status.Text;
            u.level = Convert.ToInt32(Math.Round(n_level.Value, 0));

            Database.UpdateUsers(u);
            //dgv_users.DataSource = Database.GetUsersIdName();
            //dgv_users.CurrentCell = dgv_users[0, line];
            dgv_users[1, line].Value = tb_name.Text;
            MessageBox.Show("Changes Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                Database.DeleteUser(tb_id.Text);
                dgv_users.Rows.Remove(dgv_users.CurrentRow);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
