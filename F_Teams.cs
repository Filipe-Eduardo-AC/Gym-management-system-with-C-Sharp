using System.Data;

namespace gym_management
{
    public partial class F_Teams : Form
    {
        string idSelected;

        public F_Teams()
        {
            InitializeComponent();
        }

        private void F_Teams_Load(object sender, EventArgs e)
        {
            string vqueryDGV = @"
                SELECT
                    tbt.N_IDTEAM as 'ID',
                    tbt.T_DESCTEAM as 'Team',
                    tbs.T_DESC as 'Time'
                FROM
                    tb_teams as tbt
                INNER JOIN
                    tb_schedule as tbs on tbs.N_IDSCHEDULE = tbt.N_IDTIME
            ";
            dgv_teams.DataSource = Database.dql(vqueryDGV);
            dgv_teams.Columns[0].Width = 40;
            dgv_teams.Columns[1].Width = 120;
            dgv_teams.Columns[2].Width = 85;

            //Popular combobox coaches
            string vqueryCoaches = @"
                SELECT
                    N_IDCOACH,
                    T_NAMEC
                FROM
                    tb_coaches
                ORDER BY
                    T_NAMEC
            ";
            cb_coach.Items.Clear();
            cb_coach.DataSource = Database.dql(vqueryCoaches);
            cb_coach.DisplayMember = "T_NAMEC";
            cb_coach.ValueMember = "N_IDCOACH";

            //Popular combobox status (Active = A, Paralised = P, Canceled = C)
            Dictionary<string, string> status = new Dictionary<string, string>();
            status.Add("A", "Active");
            status.Add("P", "Paralised");
            status.Add("C", "Canceled");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(status, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //Popular combobox Time
            string vqueryTime = @"
                SELECT
                    *
                FROM
                    tb_schedule
                ORDER BY
                    T_DESC
            ";
            cb_time.Items.Clear();
            cb_time.DataSource = Database.dql(vqueryTime);
            cb_time.DisplayMember = "T_DESC";
            cb_time.ValueMember = "N_IDSCHEDULE";

        }

        private void dgv_teams_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countLine = dgv.SelectedRows.Count;

            if (countLine > 0)
            {
                idSelected = dgv_teams.Rows[dgv_teams.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryField = @"
                    SELECT
                        T_DESCTEAM,
                        N_IDCOACH,
                        N_IDTIME,
                        N_MAXCUSTOMER,
                        T_STATUS
                    FROM
                        tb_teams
                    WHERE
                        N_IDTEAM=" + idSelected;
                DataTable dt = Database.dql(vqueryField);
                tb_descTeam.Text = dt.Rows[0].Field<string>("T_DESCTEAM");
                cb_coach.SelectedValue = dt.Rows[0].Field<Int64>("N_IDCOACH").ToString();
                n_maxPeople.Value = dt.Rows[0].Field<Int64>("N_MAXCUSTOMER");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_time.SelectedValue = dt.Rows[0].Field<Int64>("N_IDTIME");
            }
        }
    }
}
