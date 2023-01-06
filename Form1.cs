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

        private void openForm(int level, Form f)
        {
            if (Global.logged)
            {
                if (Global.level >= level)
                {
                    f.ShowDialog();
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
                    F_NewUser f_NewUser = new F_NewUser();
                    f_NewUser.ShowDialog();
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

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.logged)
            {
                if (Global.level >= 1)
                {
                    F_UserManagement f_UserManagement = new F_UserManagement();
                    f_UserManagement.ShowDialog();
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

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Schedule f_Schedule = new F_Schedule();
            openForm(2, f_Schedule);
        }
    }
}