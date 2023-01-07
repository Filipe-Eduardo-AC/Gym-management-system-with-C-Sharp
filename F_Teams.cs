namespace gym_management
{
    public partial class F_Teams : Form
    {
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
    }
}
