namespace zoo_management_system
{
    partial class Staff_Form
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
            this.S_Header_pnl = new System.Windows.Forms.Panel();
            this.ExitStaff_picBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.S_Signout_btn = new System.Windows.Forms.Button();
            this.S_Edit_Anim_btn = new System.Windows.Forms.Button();
            this.S_work_Hrs_btn = new System.Windows.Forms.Button();
            this.S_Day_Shift_btn = new System.Windows.Forms.Button();
            this.S_Salary_btn = new System.Windows.Forms.Button();
            this.S_Add_Event_btn = new System.Windows.Forms.Button();
            this.Jungle_Logo_picbox = new System.Windows.Forms.PictureBox();
            this.S_Profile_btn = new System.Windows.Forms.Button();
            this.staff_Profile_usercontrol1 = new zoo_management_system.Staff_Profile_usercontrol();
            this.staff_Profile_usercontrol2 = new zoo_management_system.Staff_Profile_usercontrol();
            this.addEvent_usercontrol1 = new zoo_management_system.AddEvent_usercontrol();
            this.salaryPerMonth_usercontrol1 = new zoo_management_system.SalaryPerMonth_usercontrol();
            this.dayShift_usercontrol1 = new zoo_management_system.DayShift_usercontrol();
            this.workingHours_usercontrol1 = new zoo_management_system.WorkingHours_usercontrol();
            this.editDataBase_Staff__usercontrol1 = new zoo_management_system.EditDataBase_Staff__usercontrol();
            this.S_Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitStaff_picBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Jungle_Logo_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // S_Header_pnl
            // 
            this.S_Header_pnl.BackColor = System.Drawing.Color.DarkOrange;
            this.S_Header_pnl.Controls.Add(this.ExitStaff_picBox);
            this.S_Header_pnl.Location = new System.Drawing.Point(202, -1);
            this.S_Header_pnl.Margin = new System.Windows.Forms.Padding(2);
            this.S_Header_pnl.Name = "S_Header_pnl";
            this.S_Header_pnl.Size = new System.Drawing.Size(713, 21);
            this.S_Header_pnl.TabIndex = 10;
            // 
            // ExitStaff_picBox
            // 
            this.ExitStaff_picBox.BackgroundImage = global::zoo_management_system.Properties.Resources.btnClose;
            this.ExitStaff_picBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitStaff_picBox.Location = new System.Drawing.Point(687, 0);
            this.ExitStaff_picBox.Margin = new System.Windows.Forms.Padding(2);
            this.ExitStaff_picBox.Name = "ExitStaff_picBox";
            this.ExitStaff_picBox.Size = new System.Drawing.Size(25, 22);
            this.ExitStaff_picBox.TabIndex = 9;
            this.ExitStaff_picBox.TabStop = false;
            this.ExitStaff_picBox.Click += new System.EventHandler(this.ExitWelcome_picBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::zoo_management_system.Properties.Resources.header;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.S_Signout_btn);
            this.panel1.Controls.Add(this.S_Edit_Anim_btn);
            this.panel1.Controls.Add(this.S_work_Hrs_btn);
            this.panel1.Controls.Add(this.S_Day_Shift_btn);
            this.panel1.Controls.Add(this.S_Salary_btn);
            this.panel1.Controls.Add(this.S_Add_Event_btn);
            this.panel1.Controls.Add(this.Jungle_Logo_picbox);
            this.panel1.Controls.Add(this.S_Profile_btn);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 473);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(204, 21);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(711, 452);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(204, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 452);
            this.panel3.TabIndex = 11;
            // 
            // S_Signout_btn
            // 
            this.S_Signout_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.S_Signout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_Signout_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Signout_btn.Location = new System.Drawing.Point(2, 384);
            this.S_Signout_btn.Margin = new System.Windows.Forms.Padding(2);
            this.S_Signout_btn.Name = "S_Signout_btn";
            this.S_Signout_btn.Size = new System.Drawing.Size(202, 45);
            this.S_Signout_btn.TabIndex = 9;
            this.S_Signout_btn.Text = "Sign Out";
            this.S_Signout_btn.UseVisualStyleBackColor = false;
            this.S_Signout_btn.Click += new System.EventHandler(this.button8_Click);
            // 
            // S_Edit_Anim_btn
            // 
            this.S_Edit_Anim_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.S_Edit_Anim_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_Edit_Anim_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Edit_Anim_btn.Location = new System.Drawing.Point(2, 339);
            this.S_Edit_Anim_btn.Margin = new System.Windows.Forms.Padding(2);
            this.S_Edit_Anim_btn.Name = "S_Edit_Anim_btn";
            this.S_Edit_Anim_btn.Size = new System.Drawing.Size(202, 45);
            this.S_Edit_Anim_btn.TabIndex = 8;
            this.S_Edit_Anim_btn.Text = "Edit Database";
            this.S_Edit_Anim_btn.UseVisualStyleBackColor = false;
            this.S_Edit_Anim_btn.Click += new System.EventHandler(this.S_Edit_Anim_btn_Click);
            // 
            // S_work_Hrs_btn
            // 
            this.S_work_Hrs_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.S_work_Hrs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_work_Hrs_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_work_Hrs_btn.Location = new System.Drawing.Point(2, 282);
            this.S_work_Hrs_btn.Margin = new System.Windows.Forms.Padding(2);
            this.S_work_Hrs_btn.Name = "S_work_Hrs_btn";
            this.S_work_Hrs_btn.Size = new System.Drawing.Size(202, 57);
            this.S_work_Hrs_btn.TabIndex = 7;
            this.S_work_Hrs_btn.Text = "Working Hours/Month";
            this.S_work_Hrs_btn.UseVisualStyleBackColor = false;
            this.S_work_Hrs_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // S_Day_Shift_btn
            // 
            this.S_Day_Shift_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.S_Day_Shift_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_Day_Shift_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Day_Shift_btn.Location = new System.Drawing.Point(2, 237);
            this.S_Day_Shift_btn.Margin = new System.Windows.Forms.Padding(2);
            this.S_Day_Shift_btn.Name = "S_Day_Shift_btn";
            this.S_Day_Shift_btn.Size = new System.Drawing.Size(202, 45);
            this.S_Day_Shift_btn.TabIndex = 6;
            this.S_Day_Shift_btn.Text = "Day Shift";
            this.S_Day_Shift_btn.UseVisualStyleBackColor = false;
            this.S_Day_Shift_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // S_Salary_btn
            // 
            this.S_Salary_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.S_Salary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_Salary_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Salary_btn.Location = new System.Drawing.Point(2, 193);
            this.S_Salary_btn.Margin = new System.Windows.Forms.Padding(2);
            this.S_Salary_btn.Name = "S_Salary_btn";
            this.S_Salary_btn.Size = new System.Drawing.Size(202, 45);
            this.S_Salary_btn.TabIndex = 5;
            this.S_Salary_btn.Text = "Salary/Month";
            this.S_Salary_btn.UseVisualStyleBackColor = false;
            this.S_Salary_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // S_Add_Event_btn
            // 
            this.S_Add_Event_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.S_Add_Event_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_Add_Event_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Add_Event_btn.Location = new System.Drawing.Point(2, 149);
            this.S_Add_Event_btn.Margin = new System.Windows.Forms.Padding(2);
            this.S_Add_Event_btn.Name = "S_Add_Event_btn";
            this.S_Add_Event_btn.Size = new System.Drawing.Size(202, 45);
            this.S_Add_Event_btn.TabIndex = 3;
            this.S_Add_Event_btn.Text = "Add Event";
            this.S_Add_Event_btn.UseVisualStyleBackColor = false;
            this.S_Add_Event_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Jungle_Logo_picbox
            // 
            this.Jungle_Logo_picbox.BackgroundImage = global::zoo_management_system.Properties.Resources.jungle_zoo;
            this.Jungle_Logo_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Jungle_Logo_picbox.Location = new System.Drawing.Point(0, 0);
            this.Jungle_Logo_picbox.Margin = new System.Windows.Forms.Padding(2);
            this.Jungle_Logo_picbox.Name = "Jungle_Logo_picbox";
            this.Jungle_Logo_picbox.Size = new System.Drawing.Size(204, 104);
            this.Jungle_Logo_picbox.TabIndex = 2;
            this.Jungle_Logo_picbox.TabStop = false;
            // 
            // S_Profile_btn
            // 
            this.S_Profile_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.S_Profile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.S_Profile_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Profile_btn.Location = new System.Drawing.Point(2, 104);
            this.S_Profile_btn.Margin = new System.Windows.Forms.Padding(2);
            this.S_Profile_btn.Name = "S_Profile_btn";
            this.S_Profile_btn.Size = new System.Drawing.Size(202, 45);
            this.S_Profile_btn.TabIndex = 1;
            this.S_Profile_btn.Text = "Profile";
            this.S_Profile_btn.UseVisualStyleBackColor = false;
            this.S_Profile_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // staff_Profile_usercontrol1
            // 
            this.staff_Profile_usercontrol1.BackColor = System.Drawing.Color.Beige;
            this.staff_Profile_usercontrol1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staff_Profile_usercontrol1.Location = new System.Drawing.Point(270, 25);
            this.staff_Profile_usercontrol1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.staff_Profile_usercontrol1.Name = "staff_Profile_usercontrol1";
            this.staff_Profile_usercontrol1.Size = new System.Drawing.Size(948, 556);
            this.staff_Profile_usercontrol1.TabIndex = 22;
            // 
            // staff_Profile_usercontrol2
            // 
            this.staff_Profile_usercontrol2.BackColor = System.Drawing.Color.Beige;
            this.staff_Profile_usercontrol2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staff_Profile_usercontrol2.Location = new System.Drawing.Point(202, 20);
            this.staff_Profile_usercontrol2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staff_Profile_usercontrol2.Name = "staff_Profile_usercontrol2";
            this.staff_Profile_usercontrol2.Size = new System.Drawing.Size(711, 452);
            this.staff_Profile_usercontrol2.TabIndex = 11;
            // 
            // addEvent_usercontrol1
            // 
            this.addEvent_usercontrol1.BackColor = System.Drawing.Color.Beige;
            this.addEvent_usercontrol1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addEvent_usercontrol1.Location = new System.Drawing.Point(202, 20);
            this.addEvent_usercontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.addEvent_usercontrol1.Name = "addEvent_usercontrol1";
            this.addEvent_usercontrol1.Size = new System.Drawing.Size(711, 452);
            this.addEvent_usercontrol1.TabIndex = 12;
            // 
            // salaryPerMonth_usercontrol1
            // 
            this.salaryPerMonth_usercontrol1.BackColor = System.Drawing.Color.Beige;
            this.salaryPerMonth_usercontrol1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salaryPerMonth_usercontrol1.Location = new System.Drawing.Point(202, 18);
            this.salaryPerMonth_usercontrol1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salaryPerMonth_usercontrol1.Name = "salaryPerMonth_usercontrol1";
            this.salaryPerMonth_usercontrol1.Size = new System.Drawing.Size(711, 452);
            this.salaryPerMonth_usercontrol1.TabIndex = 13;
            // 
            // dayShift_usercontrol1
            // 
            this.dayShift_usercontrol1.BackColor = System.Drawing.Color.Beige;
            this.dayShift_usercontrol1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dayShift_usercontrol1.Location = new System.Drawing.Point(203, 20);
            this.dayShift_usercontrol1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dayShift_usercontrol1.Name = "dayShift_usercontrol1";
            this.dayShift_usercontrol1.Size = new System.Drawing.Size(711, 452);
            this.dayShift_usercontrol1.TabIndex = 14;
            // 
            // workingHours_usercontrol1
            // 
            this.workingHours_usercontrol1.BackColor = System.Drawing.Color.Beige;
            this.workingHours_usercontrol1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.workingHours_usercontrol1.Location = new System.Drawing.Point(202, 20);
            this.workingHours_usercontrol1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.workingHours_usercontrol1.Name = "workingHours_usercontrol1";
            this.workingHours_usercontrol1.Size = new System.Drawing.Size(711, 452);
            this.workingHours_usercontrol1.TabIndex = 15;
            // 
            // editDataBase_Staff__usercontrol1
            // 
            this.editDataBase_Staff__usercontrol1.BackColor = System.Drawing.Color.Beige;
            this.editDataBase_Staff__usercontrol1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editDataBase_Staff__usercontrol1.Location = new System.Drawing.Point(204, 18);
            this.editDataBase_Staff__usercontrol1.Margin = new System.Windows.Forms.Padding(2);
            this.editDataBase_Staff__usercontrol1.Name = "editDataBase_Staff__usercontrol1";
            this.editDataBase_Staff__usercontrol1.Size = new System.Drawing.Size(711, 452);
            this.editDataBase_Staff__usercontrol1.TabIndex = 16;
            // 
            // Staff_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(914, 472);
            this.Controls.Add(this.editDataBase_Staff__usercontrol1);
            this.Controls.Add(this.workingHours_usercontrol1);
            this.Controls.Add(this.dayShift_usercontrol1);
            this.Controls.Add(this.salaryPerMonth_usercontrol1);
            this.Controls.Add(this.addEvent_usercontrol1);
            this.Controls.Add(this.staff_Profile_usercontrol2);
            this.Controls.Add(this.S_Header_pnl);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Staff_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff_Form";
            this.S_Header_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitStaff_picBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Jungle_Logo_picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Jungle_Logo_picbox;
        private System.Windows.Forms.Button S_Profile_btn;
        private System.Windows.Forms.Button S_Day_Shift_btn;
        private System.Windows.Forms.Button S_Salary_btn;
        private System.Windows.Forms.Button S_Add_Event_btn;
        private System.Windows.Forms.PictureBox ExitStaff_picBox;
        private System.Windows.Forms.Panel S_Header_pnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button S_work_Hrs_btn;
        private System.Windows.Forms.Button S_Signout_btn;
        private System.Windows.Forms.Button S_Edit_Anim_btn;
        private System.Windows.Forms.Panel panel4;
     
        private Staff_Profile_usercontrol staff_Profile_usercontrol1;
        private Staff_Profile_usercontrol staff_Profile_usercontrol2;
        private AddEvent_usercontrol addEvent_usercontrol1;
        private SalaryPerMonth_usercontrol salaryPerMonth_usercontrol1;
        private DayShift_usercontrol dayShift_usercontrol1;
        private WorkingHours_usercontrol workingHours_usercontrol1;
        private EditDataBase_Staff__usercontrol editDataBase_Staff__usercontrol1;
    }
}