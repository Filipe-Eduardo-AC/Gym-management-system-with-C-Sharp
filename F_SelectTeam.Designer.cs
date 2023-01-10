namespace gym_management
{
    partial class F_SelectTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_SelectTeam));
            this.dgv_teams = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_teams
            // 
            this.dgv_teams.AllowUserToAddRows = false;
            this.dgv_teams.AllowUserToDeleteRows = false;
            this.dgv_teams.AllowUserToResizeColumns = false;
            this.dgv_teams.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_teams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_teams.EnableHeadersVisualStyles = false;
            this.dgv_teams.Location = new System.Drawing.Point(12, 12);
            this.dgv_teams.MultiSelect = false;
            this.dgv_teams.Name = "dgv_teams";
            this.dgv_teams.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_teams.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_teams.RowHeadersVisible = false;
            this.dgv_teams.RowTemplate.Height = 25;
            this.dgv_teams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_teams.Size = new System.Drawing.Size(731, 426);
            this.dgv_teams.TabIndex = 0;
            this.dgv_teams.DoubleClick += new System.EventHandler(this.dgv_teams_DoubleClick);
            // 
            // F_SelectTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.dgv_teams);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_SelectTeam";
            this.Text = "Select Team";
            this.Load += new System.EventHandler(this.F_SelectTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_teams;
    }
}