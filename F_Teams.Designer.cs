﻿namespace gym_management
{
    partial class F_Teams
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_teams = new System.Windows.Forms.DataGridView();
            this.btn_newTeam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_printTeam = new System.Windows.Forms.Button();
            this.btn_deleteTeam = new System.Windows.Forms.Button();
            this.btn_saveTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_coach = new System.Windows.Forms.ComboBox();
            this.cb_time = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.n_maxPeople = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_teams
            // 
            this.dgv_teams.AllowUserToAddRows = false;
            this.dgv_teams.AllowUserToDeleteRows = false;
            this.dgv_teams.AllowUserToResizeColumns = false;
            this.dgv_teams.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_teams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teams.EnableHeadersVisualStyles = false;
            this.dgv_teams.Location = new System.Drawing.Point(12, 12);
            this.dgv_teams.MultiSelect = false;
            this.dgv_teams.Name = "dgv_teams";
            this.dgv_teams.ReadOnly = true;
            this.dgv_teams.RowHeadersVisible = false;
            this.dgv_teams.RowTemplate.Height = 25;
            this.dgv_teams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_teams.Size = new System.Drawing.Size(345, 392);
            this.dgv_teams.TabIndex = 5;
            // 
            // btn_newTeam
            // 
            this.btn_newTeam.Location = new System.Drawing.Point(3, 3);
            this.btn_newTeam.Name = "btn_newTeam";
            this.btn_newTeam.Size = new System.Drawing.Size(130, 23);
            this.btn_newTeam.TabIndex = 6;
            this.btn_newTeam.Text = "New Team";
            this.btn_newTeam.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_printTeam);
            this.panel1.Controls.Add(this.btn_deleteTeam);
            this.panel1.Controls.Add(this.btn_saveTeam);
            this.panel1.Controls.Add(this.btn_newTeam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 30);
            this.panel1.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(547, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(72, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_printTeam
            // 
            this.btn_printTeam.Location = new System.Drawing.Point(411, 3);
            this.btn_printTeam.Name = "btn_printTeam";
            this.btn_printTeam.Size = new System.Drawing.Size(130, 23);
            this.btn_printTeam.TabIndex = 9;
            this.btn_printTeam.Text = "Print Team";
            this.btn_printTeam.UseVisualStyleBackColor = true;
            // 
            // btn_deleteTeam
            // 
            this.btn_deleteTeam.Location = new System.Drawing.Point(275, 3);
            this.btn_deleteTeam.Name = "btn_deleteTeam";
            this.btn_deleteTeam.Size = new System.Drawing.Size(130, 23);
            this.btn_deleteTeam.TabIndex = 8;
            this.btn_deleteTeam.Text = "Delete Team";
            this.btn_deleteTeam.UseVisualStyleBackColor = true;
            // 
            // btn_saveTeam
            // 
            this.btn_saveTeam.Location = new System.Drawing.Point(139, 3);
            this.btn_saveTeam.Name = "btn_saveTeam";
            this.btn_saveTeam.Size = new System.Drawing.Size(130, 23);
            this.btn_saveTeam.TabIndex = 7;
            this.btn_saveTeam.Text = "Save Changes";
            this.btn_saveTeam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Coach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status";
            // 
            // cb_coach
            // 
            this.cb_coach.FormattingEnabled = true;
            this.cb_coach.Location = new System.Drawing.Point(363, 30);
            this.cb_coach.Name = "cb_coach";
            this.cb_coach.Size = new System.Drawing.Size(248, 23);
            this.cb_coach.TabIndex = 1;
            // 
            // cb_time
            // 
            this.cb_time.FormattingEnabled = true;
            this.cb_time.Location = new System.Drawing.Point(363, 150);
            this.cb_time.Name = "cb_time";
            this.cb_time.Size = new System.Drawing.Size(248, 23);
            this.cb_time.TabIndex = 4;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(490, 89);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(121, 23);
            this.cb_status.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Max. People";
            // 
            // n_maxPeople
            // 
            this.n_maxPeople.Location = new System.Drawing.Point(364, 89);
            this.n_maxPeople.Name = "n_maxPeople";
            this.n_maxPeople.Size = new System.Drawing.Size(120, 23);
            this.n_maxPeople.TabIndex = 2;
            // 
            // F_Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 444);
            this.Controls.Add(this.n_maxPeople);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.cb_time);
            this.Controls.Add(this.cb_coach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_teams);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Teams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teams Management";
            this.Load += new System.EventHandler(this.F_Teams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_maxPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_teams;
        private Button btn_newTeam;
        private Panel panel1;
        private Button btn_close;
        private Button btn_printTeam;
        private Button btn_deleteTeam;
        private Button btn_saveTeam;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cb_coach;
        private ComboBox cb_time;
        private ComboBox cb_status;
        private Label label4;
        private NumericUpDown n_maxPeople;
    }
}