namespace gym_management
{
    partial class F_NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NewUser));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.n_level = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.n_level)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(12, 27);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(206, 23);
            this.tb_name.TabIndex = 1;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(247, 27);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 23);
            this.tb_username.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(247, 79);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 23);
            this.tb_password.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A - (Active)",
            "B - (Blocked)",
            "D - (Disconnected)"});
            this.cb_status.Location = new System.Drawing.Point(12, 79);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(100, 23);
            this.cb_status.TabIndex = 6;
            // 
            // n_level
            // 
            this.n_level.Location = new System.Drawing.Point(118, 79);
            this.n_level.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.n_level.Name = "n_level";
            this.n_level.Size = new System.Drawing.Size(100, 23);
            this.n_level.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Level";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 29);
            this.panel1.TabIndex = 13;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Location = new System.Drawing.Point(272, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.Location = new System.Drawing.Point(165, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Location = new System.Drawing.Point(84, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new.Location = new System.Drawing.Point(3, 3);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // F_NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 140);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_level);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            ((System.ComponentModel.ISupportInitialize)(this.n_level)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_name;
        private TextBox tb_username;
        private Label label2;
        private TextBox tb_password;
        private Label label3;
        private ComboBox cb_status;
        private NumericUpDown n_level;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button btn_close;
        private Button btn_cancel;
        private Button btn_save;
        private Button btn_new;
    }
}