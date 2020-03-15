namespace zoo_management_system
{
    partial class Admin_login_form
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
            System.Windows.Forms.Label logIn_lbl;
            System.Windows.Forms.Label label1;
            this.login_Header_pnl = new System.Windows.Forms.Panel();
            this.ExitLogIn_picbox = new System.Windows.Forms.PictureBox();
            this.PassLogIn_lbl = new System.Windows.Forms.Label();
            this.UserLogin_lbl = new System.Windows.Forms.Label();
            this.letsGo_Login_Admin_btn = new System.Windows.Forms.Button();
            this.Back_login_btn = new System.Windows.Forms.Button();
            this.PassLogIn_txtbox = new System.Windows.Forms.TextBox();
            this.userLogIn_txtbox = new System.Windows.Forms.TextBox();
            logIn_lbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.login_Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitLogIn_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // logIn_lbl
            // 
            logIn_lbl.AutoSize = true;
            logIn_lbl.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            logIn_lbl.Location = new System.Drawing.Point(15, 75);
            logIn_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            logIn_lbl.Name = "logIn_lbl";
            logIn_lbl.Size = new System.Drawing.Size(308, 28);
            logIn_lbl.TabIndex = 31;
            logIn_lbl.Text = "Log In to Jungle Zoo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(117, 38);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 28);
            label1.TabIndex = 39;
            label1.Text = "Admin";
            // 
            // login_Header_pnl
            // 
            this.login_Header_pnl.BackColor = System.Drawing.Color.Green;
            this.login_Header_pnl.Controls.Add(this.ExitLogIn_picbox);
            this.login_Header_pnl.Location = new System.Drawing.Point(0, 0);
            this.login_Header_pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.login_Header_pnl.Name = "login_Header_pnl";
            this.login_Header_pnl.Size = new System.Drawing.Size(345, 19);
            this.login_Header_pnl.TabIndex = 34;
            // 
            // ExitLogIn_picbox
            // 
            this.ExitLogIn_picbox.BackgroundImage = global::zoo_management_system.Properties.Resources.btnClose;
            this.ExitLogIn_picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitLogIn_picbox.Location = new System.Drawing.Point(317, 0);
            this.ExitLogIn_picbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitLogIn_picbox.Name = "ExitLogIn_picbox";
            this.ExitLogIn_picbox.Size = new System.Drawing.Size(26, 19);
            this.ExitLogIn_picbox.TabIndex = 7;
            this.ExitLogIn_picbox.TabStop = false;
            this.ExitLogIn_picbox.Click += new System.EventHandler(this.ExitLogIn_picbox_Click);
            // 
            // PassLogIn_lbl
            // 
            this.PassLogIn_lbl.AutoSize = true;
            this.PassLogIn_lbl.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLogIn_lbl.Location = new System.Drawing.Point(8, 209);
            this.PassLogIn_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassLogIn_lbl.Name = "PassLogIn_lbl";
            this.PassLogIn_lbl.Size = new System.Drawing.Size(97, 19);
            this.PassLogIn_lbl.TabIndex = 33;
            this.PassLogIn_lbl.Text = "Password";
            // 
            // UserLogin_lbl
            // 
            this.UserLogin_lbl.AutoSize = true;
            this.UserLogin_lbl.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogin_lbl.Location = new System.Drawing.Point(8, 158);
            this.UserLogin_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLogin_lbl.Name = "UserLogin_lbl";
            this.UserLogin_lbl.Size = new System.Drawing.Size(98, 19);
            this.UserLogin_lbl.TabIndex = 32;
            this.UserLogin_lbl.Text = "User Name";
            // 
            // letsGo_Login_Admin_btn
            // 
            this.letsGo_Login_Admin_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.letsGo_Login_Admin_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letsGo_Login_Admin_btn.Location = new System.Drawing.Point(132, 263);
            this.letsGo_Login_Admin_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.letsGo_Login_Admin_btn.Name = "letsGo_Login_Admin_btn";
            this.letsGo_Login_Admin_btn.Size = new System.Drawing.Size(80, 27);
            this.letsGo_Login_Admin_btn.TabIndex = 38;
            this.letsGo_Login_Admin_btn.Text = "Lets Go";
            this.letsGo_Login_Admin_btn.UseVisualStyleBackColor = false;
            this.letsGo_Login_Admin_btn.Click += new System.EventHandler(this.letsGo_Login_Admin_btn_Click);
            // 
            // Back_login_btn
            // 
            this.Back_login_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Back_login_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_login_btn.Location = new System.Drawing.Point(267, 388);
            this.Back_login_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back_login_btn.Name = "Back_login_btn";
            this.Back_login_btn.Size = new System.Drawing.Size(59, 26);
            this.Back_login_btn.TabIndex = 37;
            this.Back_login_btn.Text = "Back";
            this.Back_login_btn.UseVisualStyleBackColor = false;
            this.Back_login_btn.Click += new System.EventHandler(this.Back_login_btn_Click);
            // 
            // PassLogIn_txtbox
            // 
            this.PassLogIn_txtbox.Location = new System.Drawing.Point(110, 209);
            this.PassLogIn_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PassLogIn_txtbox.Name = "PassLogIn_txtbox";
            this.PassLogIn_txtbox.PasswordChar = '*';
            this.PassLogIn_txtbox.Size = new System.Drawing.Size(202, 20);
            this.PassLogIn_txtbox.TabIndex = 36;
            // 
            // userLogIn_txtbox
            // 
            this.userLogIn_txtbox.Location = new System.Drawing.Point(110, 158);
            this.userLogIn_txtbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userLogIn_txtbox.Name = "userLogIn_txtbox";
            this.userLogIn_txtbox.Size = new System.Drawing.Size(202, 20);
            this.userLogIn_txtbox.TabIndex = 35;
            // 
            // Admin_login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(344, 429);
            this.Controls.Add(label1);
            this.Controls.Add(this.login_Header_pnl);
            this.Controls.Add(logIn_lbl);
            this.Controls.Add(this.PassLogIn_lbl);
            this.Controls.Add(this.UserLogin_lbl);
            this.Controls.Add(this.letsGo_Login_Admin_btn);
            this.Controls.Add(this.Back_login_btn);
            this.Controls.Add(this.PassLogIn_txtbox);
            this.Controls.Add(this.userLogIn_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_login_form";
            this.login_Header_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExitLogIn_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login_Header_pnl;
        private System.Windows.Forms.PictureBox ExitLogIn_picbox;
        private System.Windows.Forms.Label PassLogIn_lbl;
        private System.Windows.Forms.Label UserLogin_lbl;
        private System.Windows.Forms.Button letsGo_Login_Admin_btn;
        private System.Windows.Forms.Button Back_login_btn;
        private System.Windows.Forms.TextBox PassLogIn_txtbox;
        private System.Windows.Forms.TextBox userLogIn_txtbox;
    }
}