namespace zoo_management_system
{
    partial class Admin_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.S_Header_pnl = new System.Windows.Forms.Panel();
            this.ExitStaff_picBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.admin_signout_button = new System.Windows.Forms.Button();
            this.admin_profile_button = new System.Windows.Forms.Button();
            this.admin_system_button = new System.Windows.Forms.Button();
            this.admin_feedback_button = new System.Windows.Forms.Button();
            this.managingSystem_usercontrol1 = new zoo_management_system.ManagingSystem_usercontrol();
            this.feedback_read_usercontrol1 = new zoo_management_system.Feedback_read_usercontrol();
            this.show_info_Admin_usercontrol1 = new zoo_management_system.Show_info_Admin_usercontrol();
            this.show_info_Admin_usercontrol2 = new zoo_management_system.Show_info_Admin_usercontrol();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.S_Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitStaff_picBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(198, -78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 37);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::zoo_management_system.Properties.Resources.btnClose;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1064, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 30);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // S_Header_pnl
            // 
            this.S_Header_pnl.BackColor = System.Drawing.Color.DarkOrange;
            this.S_Header_pnl.Controls.Add(this.ExitStaff_picBox);
            this.S_Header_pnl.Location = new System.Drawing.Point(269, 0);
            this.S_Header_pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.S_Header_pnl.Name = "S_Header_pnl";
            this.S_Header_pnl.Size = new System.Drawing.Size(952, 26);
            this.S_Header_pnl.TabIndex = 15;
            // 
            // ExitStaff_picBox
            // 
            this.ExitStaff_picBox.BackgroundImage = global::zoo_management_system.Properties.Resources.btnClose;
            this.ExitStaff_picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitStaff_picBox.Location = new System.Drawing.Point(916, 0);
            this.ExitStaff_picBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitStaff_picBox.Name = "ExitStaff_picBox";
            this.ExitStaff_picBox.Size = new System.Drawing.Size(33, 26);
            this.ExitStaff_picBox.TabIndex = 9;
            this.ExitStaff_picBox.TabStop = false;
            this.ExitStaff_picBox.Click += new System.EventHandler(this.ExitStaff_picBox_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::zoo_management_system.Properties.Resources.header;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.admin_signout_button);
            this.panel2.Controls.Add(this.admin_profile_button);
            this.panel2.Controls.Add(this.admin_system_button);
            this.panel2.Controls.Add(this.admin_feedback_button);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 582);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::zoo_management_system.Properties.Resources.jungle_zoo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 128);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // admin_signout_button
            // 
            this.admin_signout_button.BackColor = System.Drawing.Color.DarkOrange;
            this.admin_signout_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_signout_button.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_signout_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_signout_button.Location = new System.Drawing.Point(1, 293);
            this.admin_signout_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_signout_button.Name = "admin_signout_button";
            this.admin_signout_button.Size = new System.Drawing.Size(269, 55);
            this.admin_signout_button.TabIndex = 9;
            this.admin_signout_button.Text = "SIGN OUT";
            this.admin_signout_button.UseVisualStyleBackColor = false;
            this.admin_signout_button.Click += new System.EventHandler(this.admin_signout_button_Click);
            // 
            // admin_profile_button
            // 
            this.admin_profile_button.BackColor = System.Drawing.Color.DarkOrange;
            this.admin_profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_profile_button.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_profile_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_profile_button.Location = new System.Drawing.Point(0, 128);
            this.admin_profile_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_profile_button.Name = "admin_profile_button";
            this.admin_profile_button.Size = new System.Drawing.Size(269, 55);
            this.admin_profile_button.TabIndex = 1;
            this.admin_profile_button.Text = "PROFILE";
            this.admin_profile_button.UseVisualStyleBackColor = false;
            this.admin_profile_button.Click += new System.EventHandler(this.admin_profile_button_Click);
            // 
            // admin_system_button
            // 
            this.admin_system_button.BackColor = System.Drawing.Color.DarkOrange;
            this.admin_system_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_system_button.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_system_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_system_button.Location = new System.Drawing.Point(0, 238);
            this.admin_system_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_system_button.Name = "admin_system_button";
            this.admin_system_button.Size = new System.Drawing.Size(269, 55);
            this.admin_system_button.TabIndex = 3;
            this.admin_system_button.Text = "MANAGING SYSTEM";
            this.admin_system_button.UseVisualStyleBackColor = false;
            this.admin_system_button.Click += new System.EventHandler(this.admin_system_button_Click);
            // 
            // admin_feedback_button
            // 
            this.admin_feedback_button.BackColor = System.Drawing.Color.DarkOrange;
            this.admin_feedback_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_feedback_button.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_feedback_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin_feedback_button.Location = new System.Drawing.Point(0, 183);
            this.admin_feedback_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin_feedback_button.Name = "admin_feedback_button";
            this.admin_feedback_button.Size = new System.Drawing.Size(269, 55);
            this.admin_feedback_button.TabIndex = 2;
            this.admin_feedback_button.Text = "FEEDBACK";
            this.admin_feedback_button.UseVisualStyleBackColor = false;
            this.admin_feedback_button.Click += new System.EventHandler(this.admin_feedback_button_Click);
            // 
            // managingSystem_usercontrol1
            // 
            this.managingSystem_usercontrol1.Location = new System.Drawing.Point(269, 26);
            this.managingSystem_usercontrol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.managingSystem_usercontrol1.Name = "managingSystem_usercontrol1";
            this.managingSystem_usercontrol1.Size = new System.Drawing.Size(948, 556);
            this.managingSystem_usercontrol1.TabIndex = 18;
            // 
            // feedback_read_usercontrol1
            // 
            this.feedback_read_usercontrol1.BackColor = System.Drawing.Color.Beige;
            this.feedback_read_usercontrol1.Location = new System.Drawing.Point(269, 26);
            this.feedback_read_usercontrol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedback_read_usercontrol1.Name = "feedback_read_usercontrol1";
            this.feedback_read_usercontrol1.Size = new System.Drawing.Size(948, 556);
            this.feedback_read_usercontrol1.TabIndex = 17;
            // 
            // show_info_Admin_usercontrol1
            // 
            this.show_info_Admin_usercontrol1.BackColor = System.Drawing.Color.Beige;
            this.show_info_Admin_usercontrol1.Location = new System.Drawing.Point(269, 26);
            this.show_info_Admin_usercontrol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_info_Admin_usercontrol1.Name = "show_info_Admin_usercontrol1";
            this.show_info_Admin_usercontrol1.Size = new System.Drawing.Size(948, 556);
            this.show_info_Admin_usercontrol1.TabIndex = 16;
            // 
            // show_info_Admin_usercontrol2
            // 
            this.show_info_Admin_usercontrol2.BackColor = System.Drawing.Color.Beige;
            this.show_info_Admin_usercontrol2.Location = new System.Drawing.Point(269, 26);
            this.show_info_Admin_usercontrol2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.show_info_Admin_usercontrol2.Name = "show_info_Admin_usercontrol2";
            this.show_info_Admin_usercontrol2.Size = new System.Drawing.Size(948, 556);
            this.show_info_Admin_usercontrol2.TabIndex = 19;
            // 
            // Admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1219, 581);
            this.Controls.Add(this.show_info_Admin_usercontrol2);
            this.Controls.Add(this.S_Header_pnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.managingSystem_usercontrol1);
            this.Controls.Add(this.feedback_read_usercontrol1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.S_Header_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitStaff_picBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin_signout_button;
        private System.Windows.Forms.Button admin_profile_button;
        private System.Windows.Forms.Button admin_system_button;
        private System.Windows.Forms.Button admin_feedback_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel S_Header_pnl;
        private System.Windows.Forms.PictureBox ExitStaff_picBox;
        private Show_info_Admin_usercontrol show_info_Admin_usercontrol1;
        private Feedback_read_usercontrol feedback_read_usercontrol1;
        private ManagingSystem_usercontrol managingSystem_usercontrol1;
        private Show_info_Admin_usercontrol show_info_Admin_usercontrol2;
    }
}