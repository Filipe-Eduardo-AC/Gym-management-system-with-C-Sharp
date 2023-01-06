using System.Data;

namespace gym_management
{
    public partial class F_Coaches : Form
    {
        public F_Coaches()
        {
            InitializeComponent();
        }

        private void F_Coaches_Load(object sender, EventArgs e)
        {
            string vquery = @"
                SELECT
                    N_IDCOACH as 'Coach ID',
                    T_NAMEC as 'Name',
                    T_PHONE as 'Phone'
                FROM
                    tb_coaches
                ORDER BY
                    T_NAMEC
            ";
            dgv_coaches.DataSource = Database.dql(vquery);
            dgv_coaches.Columns[0].Width = 60;
            dgv_coaches.Columns[1].Width = 170;
            dgv_coaches.Columns[2].Width = 100;

            tb_coachId.Clear();
            tb_coachName.Clear();
            mtb_coachPhone.Clear();
            tb_coachName.Focus();
        }

        private void dgv_coaches_SelectionChanged(object sender, EventArgs e)
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
                        tb_coaches
                    WHERE
                        N_IDCOACH =" + vid;
                dt = Database.dql(vquery);
                tb_coachId.Text = dt.Rows[0].Field<Int64>("N_IDCOACH").ToString();
                tb_coachName.Text = dt.Rows[0].Field<string>("T_NAMEC");
                mtb_coachPhone.Text = dt.Rows[0].Field<string>("T_PHONE");
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            tb_coachId.Clear();
            tb_coachName.Clear();
            mtb_coachPhone.Clear();
            tb_coachName.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_coachName.Text == "" || mtb_coachPhone.Text == "(  )      -")
            {
                MessageBox.Show("Please fill all the required spaces", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string vquery;

                if (tb_coachId.Text == "")
                {
                    vquery = "INSERT INTO tb_coaches (T_NAMEC, T_PHONE) VALUES ('" + tb_coachName.Text + "','" + mtb_coachPhone.Text + "')";
                }
                else
                {
                    vquery = "UPDATE tb_coaches SET T_NAMEC='" + tb_coachName.Text + "', T_PHONE='" + mtb_coachPhone.Text + "' WHERE N_IDCOACH=" + tb_coachId.Text;
                }

                Database.dml(vquery);
                vquery = @"
                SELECT
                    N_IDCOACH as 'Coach ID',
                    T_NAMEC as 'Name',
                    T_PHONE as 'Phone'
                FROM
                    tb_coaches
                ORDER BY
                    T_NAMEC
            ";
                dgv_coaches.DataSource = Database.dql(vquery);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete this coach?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                string vquery = "DELETE FROM tb_coaches WHERE N_IDCOACH=" + tb_coachId.Text;
                Database.dml(vquery);
                dgv_coaches.Rows.Remove(dgv_coaches.CurrentRow);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
