namespace zoo_management_system
{
    partial class SalaryPerMonth_usercontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.S_Month_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.S_S_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sal_StartDate_dtpick = new System.Windows.Forms.DateTimePicker();
            this.Sal_EndDate_dtpick = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Salary For ";
            // 
            // S_Month_lbl
            // 
            this.S_Month_lbl.AutoSize = true;
            this.S_Month_lbl.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_Month_lbl.Location = new System.Drawing.Point(272, 216);
            this.S_Month_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.S_Month_lbl.Name = "S_Month_lbl";
            this.S_Month_lbl.Size = new System.Drawing.Size(80, 29);
            this.S_Month_lbl.TabIndex = 1;
            this.S_Month_lbl.Text = "Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Is :";
            // 
            // S_S_btn
            // 
            this.S_S_btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S_S_btn.Location = new System.Drawing.Point(290, 134);
            this.S_S_btn.Margin = new System.Windows.Forms.Padding(2);
            this.S_S_btn.Name = "S_S_btn";
            this.S_S_btn.Size = new System.Drawing.Size(84, 32);
            this.S_S_btn.TabIndex = 25;
            this.S_S_btn.Text = "Ok";
            this.S_S_btn.UseVisualStyleBackColor = true;
            this.S_S_btn.Click += new System.EventHandler(this.Save_Anim_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Enter Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Enter End Date";
            // 
            // Sal_StartDate_dtpick
            // 
            this.Sal_StartDate_dtpick.CustomFormat = "yyyy,MM,dd";
            this.Sal_StartDate_dtpick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Sal_StartDate_dtpick.Location = new System.Drawing.Point(70, 73);
            this.Sal_StartDate_dtpick.Margin = new System.Windows.Forms.Padding(2);
            this.Sal_StartDate_dtpick.Name = "Sal_StartDate_dtpick";
            this.Sal_StartDate_dtpick.Size = new System.Drawing.Size(188, 20);
            this.Sal_StartDate_dtpick.TabIndex = 32;
            // 
            // Sal_EndDate_dtpick
            // 
            this.Sal_EndDate_dtpick.CustomFormat = "yyyy,MM,dd";
            this.Sal_EndDate_dtpick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Sal_EndDate_dtpick.Location = new System.Drawing.Point(406, 73);
            this.Sal_EndDate_dtpick.Margin = new System.Windows.Forms.Padding(2);
            this.Sal_EndDate_dtpick.Name = "Sal_EndDate_dtpick";
            this.Sal_EndDate_dtpick.Size = new System.Drawing.Size(188, 20);
            this.Sal_EndDate_dtpick.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(449, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Salary";
            // 
            // SalaryPerMonth_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sal_EndDate_dtpick);
            this.Controls.Add(this.Sal_StartDate_dtpick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.S_S_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.S_Month_lbl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalaryPerMonth_usercontrol";
            this.Size = new System.Drawing.Size(711, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label S_Month_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button S_S_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Sal_StartDate_dtpick;
        private System.Windows.Forms.DateTimePicker Sal_EndDate_dtpick;
        private System.Windows.Forms.Label label4;
    }
}
