using System.Data;

namespace gym_management
{
    public partial class F_Schedule : Form
    {
        public F_Schedule()
        {
            InitializeComponent();
        }

        private void F_Schedule_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_IDSCHEDULE as 'Time ID',
                    T_DESC as 'Time'
                FROM
                    tb_schedule
                ORDER BY
                    T_DESC
            ";
            dgv_schedule.DataSource = Database.dql(vquery);
            dgv_schedule.Columns[0].Width = 60;
            dgv_schedule.Columns[1].Width = 150;

            tb_timeId.Clear();
            mtb_timeDesc.Clear();
            mtb_timeDesc.Focus();
        }

        private void dgv_schedule_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countLines = dgv.SelectedRows.Count;

            if (countLines > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = @"
                    SELECT
                        *
                    FROM
                        tb_schedule
                    WHERE
                        N_IDSCHEDULE =" + vid;
                dt = Database.dql(vquery);
                tb_timeId.Text = dt.Rows[0].Field<Int64>("N_IDSCHEDULE").ToString();
                mtb_timeDesc.Text = dt.Rows[0].Field<string>("T_DESC");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            tb_timeId.Clear();
            mtb_timeDesc.Clear();
            mtb_timeDesc.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if (mtb_timeDesc.Text == "  :   to   :")
            {
                MessageBox.Show("Please insert a valid time", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string vquery;

                if (tb_timeId.Text == "")
                {
                    vquery = "INSERT INTO tb_schedule (T_DESC) VALUES ('" + mtb_timeDesc.Text + "')";
                }
                else
                {
                    vquery = "UPDATE tb_schedule SET T_DESC='" + mtb_timeDesc.Text + "' WHERE N_IDSCHEDULE=" + tb_timeId.Text;
                }

                Database.dml(vquery);
                vquery = @"
                SELECT
                    N_IDSCHEDULE as 'Time ID',
                    T_DESC as 'Time'
                FROM
                    tb_schedule
                ORDER BY
                    T_DESC
            ";
                dgv_schedule.DataSource = Database.dql(vquery);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete it?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_schedule WHERE N_IDSCHEDULE=" + tb_timeId.Text;
                Database.dml(vquery);
                dgv_schedule.Rows.Remove(dgv_schedule.CurrentRow);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
