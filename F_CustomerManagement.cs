namespace gym_management
{
    public partial class F_CustomerManagement : Form
    {
        string vqueryDGV = "";
        string currentTeam = "";
        string selectedId = "";
        string team = "";
        int line = 0

        public F_CustomerManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
        }
    }
}
