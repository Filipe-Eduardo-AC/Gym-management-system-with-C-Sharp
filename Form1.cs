namespace gym_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_access.Text = "0";
            lb_name.Text = "---";
            pb_ledlogged.Image = Properties.Resources.red_led;
            Global.level = 0;
            Global.logged = false;
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                if (Global.level >= 2)
                {
                    //procedimento
                }
                else
                {
                    MessageBox.Show("Access denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A user needs to be logged in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                if (Global.level >= 1)
                {
                    //procedimento
                }
                else
                {
                    MessageBox.Show("Access denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A user needs to be logged in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                //procedimento
            }
            else
            {
                MessageBox.Show("A user needs to be logged in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}