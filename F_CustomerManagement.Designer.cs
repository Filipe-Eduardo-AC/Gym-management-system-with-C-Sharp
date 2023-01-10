namespace gym_management
{
    partial class F_CustomerManagement
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
            this.dgv_customer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_financial = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_teams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customer
            // 
            this.dgv_customer.AllowUserToAddRows = false;
            this.dgv_customer.AllowUserToDeleteRows = false;
            this.dgv_customer.AllowUserToResizeColumns = false;
            this.dgv_customer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customer.EnableHeadersVisualStyles = false;
            this.dgv_customer.Location = new System.Drawing.Point(12, 12);
            this.dgv_customer.MultiSelect = false;
            this.dgv_customer.Name = "dgv_customer";
            this.dgv_customer.ReadOnly = true;
            this.dgv_customer.RowHeadersVisible = false;
            this.dgv_customer.RowTemplate.Height = 25;
            this.dgv_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customer.Size = new System.Drawing.Size(277, 416);
            this.dgv_customer.TabIndex = 30;
            this.dgv_customer.SelectionChanged += new System.EventHandler(this.dgv_customer_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_financial);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 30);
            this.panel1.TabIndex = 31;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(417, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(132, 23);
            this.btn_close.TabIndex = 45;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(132, 23);
            this.btn_save.TabIndex = 42;
            this.btn_save.Text = "Save Changes";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_financial
            // 
            this.btn_financial.Location = new System.Drawing.Point(279, 3);
            this.btn_financial.Name = "btn_financial";
            this.btn_financial.Size = new System.Drawing.Size(132, 23);
            this.btn_financial.TabIndex = 44;
            this.btn_financial.Text = "Financial";
            this.btn_financial.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(141, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 23);
            this.btn_delete.TabIndex = 43;
            this.btn_delete.Text = "Delete Customer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(299, 33);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(243, 23);
            this.tb_name.TabIndex = 32;
            // 
            // mtb_phone
            // 
            this.mtb_phone.Location = new System.Drawing.Point(299, 93);
            this.mtb_phone.Mask = "(00) 00000-0000";
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(99, 23);
            this.mtb_phone.TabIndex = 33;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(404, 93);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(138, 23);
            this.cb_status.TabIndex = 34;
            // 
            // cb_teams
            // 
            this.cb_teams.FormattingEnabled = true;
            this.cb_teams.Location = new System.Drawing.Point(299, 156);
            this.cb_teams.Name = "cb_teams";
            this.cb_teams.Size = new System.Drawing.Size(243, 23);
            this.cb_teams.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Teams";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "Double Click to change picture";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(299, 199);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(243, 23);
            this.btn_print.TabIndex = 41;
            this.btn_print.Text = "Print ID";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(299, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 124);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // F_CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 464);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_teams);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.mtb_phone);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_customer);
            this.Name = "F_CustomerManagement";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.F_CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_customer;
        private Panel panel1;
        private TextBox tb_name;
        private MaskedTextBox mtb_phone;
        private ComboBox cb_status;
        private ComboBox cb_teams;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_print;
        private Button btn_close;
        private Button btn_save;
        private Button btn_financial;
        private Button btn_delete;
        private PictureBox pictureBox1;
    }
}