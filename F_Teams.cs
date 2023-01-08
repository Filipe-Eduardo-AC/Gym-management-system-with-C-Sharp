using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Diagnostics;

namespace gym_management
{
    public partial class F_Teams : Form
    {
        string idSelected;
        int mode = 0; //0 = default, 1=edição, 2=inserção
        string vqueryDGV;

        public F_Teams()
        {
            InitializeComponent();
        }

        private void F_Teams_Load(object sender, EventArgs e)
        {
            vqueryDGV = @"
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
                mode = 0;
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

                tb_space.Text = calcSpace();
            }
        }

        private string calcSpace()
        {
            //Cálculo de Vagas
            string querySpaceAv = String.Format(@"
                    SELECT
                        count(N_IDCUSTOMER) as 'contSpace'
                    FROM
                        tb_customers
                    WHERE
                        T_STATUS = 'A' and N_IDTEAM={0}", idSelected);
            DataTable dt = Database.dql(querySpaceAv);
            int space = Int32.Parse(Math.Round(n_maxPeople.Value, 0).ToString());
            space -= Int32.Parse(dt.Rows[0].Field<Int64>("contSpace").ToString());
            return space.ToString();
        }

        private void btn_newTeam_Click(object sender, EventArgs e)
        {
            tb_descTeam.Clear();
            cb_coach.SelectedIndex = -1;
            n_maxPeople.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_time.SelectedIndex = -1;
            tb_descTeam.Focus();
            mode = 2;
        }

        private void btn_saveTeam_Click(object sender, EventArgs e)
        {
            if (tb_descTeam.Text == "" || cb_coach.Text == "" || n_maxPeople.Value == 0 || cb_status.Text == "" || cb_time.Text == "")
            {
                MessageBox.Show("Please fill all the required spaces", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (mode != 0)
                {
                    string queryTeam = "";
                    string msg = "";
                    if (mode == 1)
                    {
                        msg = "Data updated";
                        queryTeam = String.Format(@"
                    UPDATE
                        tb_teams
                    SET
                        T_DESCTEAM='{0}',
                        N_IDCOACH={1},
                        N_IDTIME={2},
                        N_MAXCUSTOMER={3},
                        T_STATUS='{4}'
                    WHERE
                        N_IDTEAM={5}", tb_descTeam.Text, cb_coach.SelectedValue, cb_time.SelectedValue, Int32.Parse(Math.Round(n_maxPeople.Value).ToString()), cb_status.SelectedValue, idSelected);
                    }
                    else
                    {
                        msg = "New team created";
                        queryTeam = String.Format(@"
                        INSERT INTO tb_teams
                        (T_DESCTEAM, N_IDCOACH, N_IDTIME, N_MAXCUSTOMER, T_STATUS)
                        VALUES('{0}',{1},{2},{3},'{4}')", tb_descTeam.Text, cb_coach.SelectedValue, cb_time.SelectedValue, Int32.Parse(Math.Round(n_maxPeople.Value).ToString()), cb_status.SelectedValue);
                    }
                    int line = dgv_teams.SelectedRows[0].Index;
                    Database.dml(queryTeam);

                    if (mode == 1)
                    {
                        dgv_teams[1, line].Value = tb_descTeam.Text;
                        dgv_teams[2, line].Value = cb_time.Text;
                        tb_space.Text = calcSpace();
                    }
                    else
                    {
                        dgv_teams.DataSource = Database.dql(vqueryDGV);
                    }

                    MessageBox.Show(msg, "Successfully saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_deleteTeam_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you really want to delete this team?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                string queryDeleteTeam = String.Format(@"
                    DELETE
                    FROM
                        tb_teams
                    WHERE
                        N_IDTEAM = {0}", idSelected);
                Database.dml(queryDeleteTeam);
                dgv_teams.Rows.Remove(dgv_teams.CurrentRow);

                tb_descTeam.Clear();
                cb_coach.SelectedIndex = -1;
                n_maxPeople.Value = 0;
                cb_status.SelectedIndex = -1;
                cb_time.SelectedIndex = -1;
                tb_descTeam.Focus();
                mode = 2;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_descTeam_TextChanged(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                mode = 1;
            }
        }

        private void cb_coach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                mode = 1;
            }
        }

        private void n_maxPeople_ValueChanged(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                mode = 1;
            }
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                mode = 1;
            }
        }

        private void cb_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                mode = 1;
            }
        }

        private void btn_printTeam_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = Global.path + @"\Teams.pdf";
                FileStream filePDF = new FileStream(fileName, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter escritoPDF = PdfWriter.GetInstance(doc, filePDF);

                //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Global.path + @"\logo-c#.png");
                //logo.ScaleToFit(140f, 120f);
                //logo.Alignment = Element.ALIGN_LEFT;
                //logo.SetAbsolutePosition(100f, 700f); //X, -Y (Valor do Y É invertido)

                string data = "";
                //Paragrafo1
                Paragraph p1 = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
                p1.Alignment = Element.ALIGN_CENTER;
                p1.Add("Teams Report\n\n");

                //Paragrafo2
                Paragraph p2 = new Paragraph(data, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                p2.Alignment = Element.ALIGN_CENTER;
                p2.Add("Gym Management System with C#\n Made by: Filipe Eduardo");

                //Criação de Tabela

                PdfPTable table = new PdfPTable(3);// 3Colunas
                table.DefaultCell.FixedHeight = 20;

                table.AddCell("Team ID");
                table.AddCell("Team");
                table.AddCell("Time");

                DataTable dtTeams = Database.dql(vqueryDGV);
                for (int i = 0; i < dtTeams.Rows.Count; i++)
                {
                    table.AddCell(dtTeams.Rows[i].Field<Int64>("ID").ToString());
                    table.AddCell(dtTeams.Rows[i].Field<string>("Team"));
                    table.AddCell(dtTeams.Rows[i].Field<string>("Time"));
                }


                doc.Open();
                //doc.Add(logo);
                doc.Add(p1);
                doc.Add(table);
                doc.Add(p2);
                doc.Close();

                DialogResult res = MessageBox.Show("Do you wish to print the report?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var p = new Process();
                    p.StartInfo = new ProcessStartInfo(fileName)
                    {
                        UseShellExecute = true
                    };
                    p.Start();
                    //string fName = "Teams.pdf";
                    //System.Diagnostics.Process.Start(fName);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("PDF file open! Please close it and print again");
            }
        }
    }
}

