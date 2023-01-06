namespace gym_management
{
    partial class F_Coaches
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.dgv_coaches = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.mtb_coachPhone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_coachId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_coachName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coaches)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Location = new System.Drawing.Point(282, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(84, 23);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Location = new System.Drawing.Point(192, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 23);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(102, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(84, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Location = new System.Drawing.Point(12, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(84, 23);
            this.btn_new.TabIndex = 15;
            this.btn_new.Text = "New Coach";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // dgv_coaches
            // 
            this.dgv_coaches.AllowUserToAddRows = false;
            this.dgv_coaches.AllowUserToDeleteRows = false;
            this.dgv_coaches.AllowUserToResizeColumns = false;
            this.dgv_coaches.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_coaches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_coaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_coaches.EnableHeadersVisualStyles = false;
            this.dgv_coaches.Location = new System.Drawing.Point(12, 57);
            this.dgv_coaches.MultiSelect = false;
            this.dgv_coaches.Name = "dgv_coaches";
            this.dgv_coaches.ReadOnly = true;
            this.dgv_coaches.RowHeadersVisible = false;
            this.dgv_coaches.RowTemplate.Height = 25;
            this.dgv_coaches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_coaches.Size = new System.Drawing.Size(354, 352);
            this.dgv_coaches.TabIndex = 14;
            this.dgv_coaches.SelectionChanged += new System.EventHandler(this.dgv_coaches_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone";
            // 
            // mtb_coachPhone
            // 
            this.mtb_coachPhone.Location = new System.Drawing.Point(275, 27);
            this.mtb_coachPhone.Mask = "(00) 00000-0000";
            this.mtb_coachPhone.Name = "mtb_coachPhone";
            this.mtb_coachPhone.Size = new System.Drawing.Size(91, 23);
            this.mtb_coachPhone.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // tb_coachId
            // 
            this.tb_coachId.Location = new System.Drawing.Point(12, 28);
            this.tb_coachId.Name = "tb_coachId";
            this.tb_coachId.ReadOnly = true;
            this.tb_coachId.Size = new System.Drawing.Size(61, 23);
            this.tb_coachId.TabIndex = 10;
            this.tb_coachId.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 30);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Coach";
            // 
            // tb_coachName
            // 
            this.tb_coachName.Location = new System.Drawing.Point(79, 27);
            this.tb_coachName.Name = "tb_coachName";
            this.tb_coachName.Size = new System.Drawing.Size(190, 23);
            this.tb_coachName.TabIndex = 21;
            // 
            // F_Coaches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 441);
            this.Controls.Add(this.tb_coachName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_coaches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_coachPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_coachId);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Coaches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coach Management";
            this.Load += new System.EventHandler(this.F_Coaches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_coaches)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_close;
        private Button btn_delete;
        private Button btn_save;
        private Button btn_new;
        private DataGridView dgv_coaches;
        private Label label2;
        private MaskedTextBox mtb_coachPhone;
        private Label label1;
        private TextBox tb_coachId;
        private Panel panel1;
        private Label label3;
        private TextBox tb_coachName;
    }
}