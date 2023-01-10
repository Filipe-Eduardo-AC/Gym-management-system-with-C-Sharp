using System.Data;

namespace gym_management
{
    public partial class F_CustomerManagement : Form
    {
        string vqueryDGV = "";
        string currentTeam = "";
        string selectedId = "";
        string team = "";
        int line = 0;

        string originComplete = "";
        string picture = "";
        string destinyFolder = Global.pathPictures;
        string destinyComplete = "";

        public F_CustomerManagement()
        {
            InitializeComponent();
        }

        private void F_CustomerManagement_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
                SELECT
                    N_IDCUSTOMER as 'ID',
                    T_NAMECUSTOMER as 'Customer'
                FROM
                    tb_customers
            ";
            dgv_customer.DataSource = Database.dql(vqueryDGV);
            dgv_customer.Columns[0].Width = 40;
            dgv_customer.Columns[1].Width = 120;

            tb_name.Text = dgv_customer.Rows[dgv_customer.SelectedRows[0].Index].Cells[1].Value.ToString();

            //popular ComboBox Teams
            string vqueryTeams = @"
                SELECT
                    N_IDTEAM,
                    ('Free spaces: '|| (
                                            (N_MAXCUSTOMER) - (
                                                                SELECT
                                                                    count(tbc.N_IDCUSTOMER)
                                                                FROM
                                                                    tb_customers as tbc
                                                                WHERE
                                                                    tbc.T_STATUS='A' and tbc.N_IDTEAM = N_IDTEAM
                                                              )
                                        ) || ' / Team: ' || T_DESCTEAM
                    )as 'Team'
                FROM
                    tb_teams
                ORDER BY
                    N_IDTEAM
            ";
            cb_teams.Items.Clear();
            cb_teams.DataSource = Database.dql(vqueryTeams);
            cb_teams.DisplayMember = "Team";
            cb_teams.ValueMember = "N_IDTEAM";

            //Popular ComboBox Status (Active = A, Blocked = B, Canceled = C)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Active");
            status.Add("B", "Blocked");
            status.Add("C", "Canceled");
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            team = cb_teams.Text;
            currentTeam = cb_teams.Text;
            selectedId = dgv_customer.Rows[0].Cells[0].Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || mtb_phone.Text == "(  )      -")
            {
                MessageBox.Show("Please fill all the required spaces", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (destinyComplete == "")
                {
                    if (MessageBox.Show("There is no picture selected, continue anyway?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                if (destinyComplete != "")
                {
                    System.IO.File.Copy(originComplete, destinyComplete, true);
                    if (File.Exists(destinyComplete))
                    {
                        pb_photo.ImageLocation = destinyComplete;
                    }
                    else
                    {
                        if (MessageBox.Show("Picture was not found, continue anyway?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }

                team = cb_teams.Text;

                if (currentTeam != team)
                {
                    string[] t = team.Split(' ');
                    int spaces = int.Parse(t[2]);

                    if (spaces < 1)
                    {
                        MessageBox.Show("The selected team is full, please choose another team.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cb_teams.Focus();
                        return;
                    }
                    //line = dgv_customer.SelectedRows[0].Index;
                    string queryUpdateCustomer = String.Format(@"
                    UPDATE
                        tb_customers
                    SET
                        T_NAMECUSTOMER ='{0}',
                        T_PHONE ='{1}',
                        T_STATUS ='{2}',
                        N_IDTEAM ='{3}',
                        T_PICTURE = '{4}'
                    WHERE
                        N_IDCUSTOMER ={5}
                ", tb_name.Text, mtb_phone.Text, cb_status.SelectedValue, cb_teams.SelectedValue, destinyComplete, selectedId);
                    Database.dml(queryUpdateCustomer);
                    MessageBox.Show("Changes Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //dgv_customer[1, line].Value = tb_name.Text;
                }
                if (currentTeam == team)
                {
                    string queryUpdateCustomer = String.Format(@"
                    UPDATE
                        tb_customers
                    SET
                        T_NAMECUSTOMER ='{0}',
                        T_PHONE ='{1}',
                        T_STATUS ='{2}',
                        N_IDTEAM ='{3}',
                        T_PICTURE = '{4}'
                    WHERE
                        N_IDCUSTOMER ={5}
                ", tb_name.Text, mtb_phone.Text, cb_status.SelectedValue, cb_teams.SelectedValue, destinyComplete, selectedId);
                    Database.dml(queryUpdateCustomer);
                    MessageBox.Show("Changes Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to delete this customer?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (File.Exists(pb_photo.ImageLocation))
                {
                    File.Delete(pb_photo.ImageLocation);
                }

                string vqueryDeleteCustomer = String.Format(@"
                    DELETE FROM
                        tb_customers
                    WHERE
                        N_IDCUSTOMER={0}", selectedId);
                Database.dml(vqueryDeleteCustomer);
                dgv_customer.Rows.Remove(dgv_customer.CurrentRow);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_customer_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                selectedId = dgv_customer.Rows[0].Cells[0].Value.ToString();
                tb_name.Text = dgv_customer.Rows[dgv_customer.SelectedRows[0].Index].Cells[1].Value.ToString();

                selectedId = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryFields = String.Format(@"
                    SELECT
                        N_IDCUSTOMER,
                        T_NAMECUSTOMER,
                        T_PHONE,
                        T_STATUS,
                        N_IDTEAM,
                        T_PICTURE
                    FROM
                        tb_customers
                    WHERE N_IDCUSTOMER={0}
                ", selectedId);
                DataTable dt = Database.dql(vqueryFields);
                tb_name.Text = dt.Rows[0].Field<string>("T_NAMECUSTOMER");
                mtb_phone.Text = dt.Rows[0].Field<string>("T_PHONE");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_teams.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTEAM");
                currentTeam = cb_teams.Text;
                pb_photo.ImageLocation = dt.Rows[0].Field<string>("T_PICTURE");
            }
        }

        private void pb_photo_DoubleClick(object sender, EventArgs e)
        {
            originComplete = "";
            picture = "";
            destinyFolder = Global.pathPictures;
            destinyComplete = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                originComplete = openFileDialog1.FileName;
                picture = openFileDialog1.SafeFileName;
                destinyComplete = destinyFolder + picture;
            }
            if (File.Exists(destinyComplete))
            {
                if (MessageBox.Show("File already exists, wish to replace it?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            pb_photo.ImageLocation = originComplete;
        }
    }
}
