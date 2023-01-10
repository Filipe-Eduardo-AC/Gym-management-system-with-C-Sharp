namespace gym_management
{
    public partial class F_NewCustomer : Form
    {
        string originComplete = "";
        string picture = "";
        string destinyFolder = Global.pathPictures;
        string destinyComplete = "";

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

            string queryInsertCustomer = String.Format(@"
                INSERT INTO tb_customers
                (T_NAMECUSTOMER,T_PHONE,T_STATUS,N_IDTEAM,T_PICTURE)
                VALUES('{0}','{1}','{2}',{3},'{4}')
            ", tb_name.Text, mtb_phone.Text, cb_status.SelectedValue, tb_team.Tag.ToString(), destinyComplete);
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
            pb_photo.ImageLocation = destinyComplete;
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

        private void btn_addPic_Click(object sender, EventArgs e)
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
