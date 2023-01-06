namespace gym_management
{
    partial class F_Schedule
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
            this.tb_timeId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_timeDesc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_schedule = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_timeId
            // 
            this.tb_timeId.Location = new System.Drawing.Point(12, 28);
            this.tb_timeId.Name = "tb_timeId";
            this.tb_timeId.ReadOnly = true;
            this.tb_timeId.Size = new System.Drawing.Size(61, 23);
            this.tb_timeId.TabIndex = 0;
            this.tb_timeId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // mtb_timeDesc
            // 
            this.mtb_timeDesc.Location = new System.Drawing.Point(79, 28);
            this.mtb_timeDesc.Mask = "99:99 \\to 99:99";
            this.mtb_timeDesc.Name = "mtb_timeDesc";
            this.mtb_timeDesc.Size = new System.Drawing.Size(78, 23);
            this.mtb_timeDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // dgv_schedule
            // 
            this.dgv_schedule.AllowUserToAddRows = false;
            this.dgv_schedule.AllowUserToDeleteRows = false;
            this.dgv_schedule.AllowUserToResizeColumns = false;
            this.dgv_schedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_schedule.EnableHeadersVisualStyles = false;
            this.dgv_schedule.Location = new System.Drawing.Point(12, 57);
            this.dgv_schedule.MultiSelect = false;
            this.dgv_schedule.Name = "dgv_schedule";
            this.dgv_schedule.ReadOnly = true;
            this.dgv_schedule.RowHeadersVisible = false;
            this.dgv_schedule.RowTemplate.Height = 25;
            this.dgv_schedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_schedule.Size = new System.Drawing.Size(345, 352);
            this.dgv_schedule.TabIndex = 4;
            this.dgv_schedule.SelectionChanged += new System.EventHandler(this.dgv_schedule_SelectionChanged);
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Location = new System.Drawing.Point(12, 415);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(82, 23);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "New Time";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(100, 415);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save Time";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Location = new System.Drawing.Point(188, 415);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete Time";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Location = new System.Drawing.Point(275, 415);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(82, 23);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 30);
            this.panel1.TabIndex = 9;
            // 
            // F_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 441);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.dgv_schedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_timeDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_timeId);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.F_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_schedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_timeId;
        private Label label1;
        private MaskedTextBox mtb_timeDesc;
        private Label label2;
        private DataGridView dgv_schedule;
        private Button btn_new;
        private Button btn_save;
        private Button btn_delete;
        private Button btn_close;
        private Panel panel1;
    }
}