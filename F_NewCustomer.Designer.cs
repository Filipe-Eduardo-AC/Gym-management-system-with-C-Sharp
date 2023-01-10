namespace gym_management
{
    partial class F_NewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NewCustomer));
            this.tb_name = new System.Windows.Forms.TextBox();
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_team = new System.Windows.Forms.TextBox();
            this.btn_selTeam = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pb_photo = new System.Windows.Forms.PictureBox();
            this.btn_addPic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Enabled = false;
            this.tb_name.Location = new System.Drawing.Point(12, 27);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(260, 23);
            this.tb_name.TabIndex = 0;
            // 
            // mtb_phone
            // 
            this.mtb_phone.Enabled = false;
            this.mtb_phone.Location = new System.Drawing.Point(278, 27);
            this.mtb_phone.Mask = "(00) 00000-0000";
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(108, 23);
            this.mtb_phone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 95);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(108, 23);
            this.cb_status.TabIndex = 4;
            // 
            // tb_team
            // 
            this.tb_team.Location = new System.Drawing.Point(126, 95);
            this.tb_team.Name = "tb_team";
            this.tb_team.ReadOnly = true;
            this.tb_team.Size = new System.Drawing.Size(260, 23);
            this.tb_team.TabIndex = 5;
            this.tb_team.TabStop = false;
            // 
            // btn_selTeam
            // 
            this.btn_selTeam.Location = new System.Drawing.Point(359, 95);
            this.btn_selTeam.Name = "btn_selTeam";
            this.btn_selTeam.Size = new System.Drawing.Size(27, 23);
            this.btn_selTeam.TabIndex = 7;
            this.btn_selTeam.Text = "...";
            this.btn_selTeam.UseVisualStyleBackColor = true;
            this.btn_selTeam.Click += new System.EventHandler(this.btn_selTeam_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 30);
            this.panel1.TabIndex = 9;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(401, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(86, 23);
            this.btn_close.TabIndex = 16;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Enabled = false;
            this.btn_cancel.Location = new System.Drawing.Point(205, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 23);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(104, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 23);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(3, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(95, 23);
            this.btn_new.TabIndex = 13;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*png";
            // 
            // pb_photo
            // 
            this.pb_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_photo.Location = new System.Drawing.Point(400, 41);
            this.pb_photo.Name = "pb_photo";
            this.pb_photo.Size = new System.Drawing.Size(85, 113);
            this.pb_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_photo.TabIndex = 13;
            this.pb_photo.TabStop = false;
            // 
            // btn_addPic
            // 
            this.btn_addPic.Location = new System.Drawing.Point(400, 12);
            this.btn_addPic.Name = "btn_addPic";
            this.btn_addPic.Size = new System.Drawing.Size(85, 23);
            this.btn_addPic.TabIndex = 14;
            this.btn_addPic.Text = "Add Picture";
            this.btn_addPic.UseVisualStyleBackColor = true;
            this.btn_addPic.Click += new System.EventHandler(this.btn_addPic_Click);
            // 
            // F_NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 192);
            this.Controls.Add(this.btn_addPic);
            this.Controls.Add(this.pb_photo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_selTeam);
            this.Controls.Add(this.tb_team);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_phone);
            this.Controls.Add(this.tb_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_NewCustomer";
            this.Text = "New Customer";
            this.Load += new System.EventHandler(this.F_NewCustomer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_name;
        private MaskedTextBox mtb_phone;
        private Label label1;
        private Label label2;
        private ComboBox cb_status;
        private Button btn_selTeam;
        private Panel panel1;
        private Button btn_close;
        private Button btn_cancel;
        private Button btn_save;
        private Button btn_new;
        private Label label3;
        private Label label5;
        public TextBox tb_team;
        private OpenFileDialog openFileDialog1;
        private PictureBox pb_photo;
        private Button btn_addPic;
    }
}