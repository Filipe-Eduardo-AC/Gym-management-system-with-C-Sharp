namespace gym_management
{
    public partial class F_NewCustomer : Form
    {
        public F_NewCustomer()
        {
            InitializeComponent();
        }

        private void F_NewCustomer_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Active");
            status.Add("B", "Blocked");
            status.Add("C", "Canceled");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            tb_name.Enabled = true;
            mtb_phone.Enabled = true;
            cb_status.Enabled = true;
            tb_name.Clear();
            mtb_phone.Clear();
            tb_team.Clear();
            cb_status.SelectedIndex = 0;
            tb_name.Focus();
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            btn_new.Enabled = false;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_name.Enabled = false;
            mtb_phone.Enabled = false;
            cb_status.Enabled = false;
            tb_name.Clear();
            mtb_phone.Clear();
            tb_team.Clear();
            cb_status.SelectedIndex = 0;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_new.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string queryInsertCustomer = String.Format(@"
                INSERT INTO tb_customers
                (T_NAMECUSTOMER,T_PHONE,T_STATUS,N_IDTEAM)
                VALUES('{0}','{1}','{2}',{3})
            ", tb_name.Text, mtb_phone.Text, cb_status.SelectedValue, tb_team.Tag.ToString());
            Database.dml(queryInsertCustomer);
            MessageBox.Show("New Customer created", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tb_name.Enabled = false;
            mtb_phone.Enabled = false;
            cb_status.Enabled = false;
            tb_name.Clear();
            mtb_phone.Clear();
            tb_team.Clear();
            cb_status.SelectedIndex = 0;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_new.Enabled = true;
        }

        private void btn_selTeam_Click(object sender, EventArgs e)
        {
            F_SelectTeam f_SelectTeam = new F_SelectTeam(this);
            f_SelectTeam.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
