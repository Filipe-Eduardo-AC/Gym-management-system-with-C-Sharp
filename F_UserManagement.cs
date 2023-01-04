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
    }
}
