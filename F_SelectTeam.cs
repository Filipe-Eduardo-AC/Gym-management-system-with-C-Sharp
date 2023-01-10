namespace gym_management
{
    public partial class F_SelectTeam : Form
    {
        F_NewCustomer formNewCustomer;
        public F_SelectTeam(F_NewCustomer f)
        {
            InitializeComponent();
            formNewCustomer = f;
        }

        private void F_SelectTeam_Load(object sender, EventArgs e)
        {
            string queryTeams = String.Format(@"
                SELECT 
                    tbt.N_IDTEAM as 'ID',
                    tbt.T_DESCTEAM as 'Team',
                    tbs.T_DESC as 'Time',
                    tbc.T_NAMEC as 'Coach',
                    tbt.N_MAXCUSTOMER as 'Max. Customer',
                    ( SELECT
                          count(N_IDCUSTOMER)
                      FROM
                          tb_customers as tbcus
                      WHERE
                          tbcus.N_IDTEAM = tbt.N_IDTEAM and T_STATUS = 'A'   
                    )as 'Customers'
                FROM
                    tb_teams as tbt   
                INNER JOIN
                    tb_coaches as tbc on tbc.N_IDCOACH = tbt.N_IDCOACH
                INNER JOIN
                    tb_schedule as tbs on tbs.N_IDSCHEDULE = tbt.N_IDTIME
            ");
            dgv_teams.DataSource = Database.dql(queryTeams);
        }

        private void dgv_teams_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int maxCustomer = 0;
            int qtdeCustomer = 0;
            maxCustomer = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeCustomer = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());

            if (qtdeCustomer >= maxCustomer)
            {
                MessageBox.Show("This team is full", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                formNewCustomer.tb_team.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                formNewCustomer.tb_team.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
