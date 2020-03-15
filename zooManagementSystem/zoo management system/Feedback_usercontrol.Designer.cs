namespace zoo_management_system
{
    partial class Feedback_usercontrol
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
            this.label5 = new System.Windows.Forms.Label();
            this.Feedback_txtbox = new System.Windows.Forms.TextBox();
            this.Send_Fb_btn = new System.Windows.Forms.Button();
            this.FB_dtpick = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Date Of visit ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Your Feedback";
            // 
            // Feedback_txtbox
            // 
            this.Feedback_txtbox.Location = new System.Drawing.Point(270, 116);
            this.Feedback_txtbox.Margin = new System.Windows.Forms.Padding(2);
            this.Feedback_txtbox.Multiline = true;
            this.Feedback_txtbox.Name = "Feedback_txtbox";
            this.Feedback_txtbox.Size = new System.Drawing.Size(314, 176);
            this.Feedback_txtbox.TabIndex = 15;
            // 
            // Send_Fb_btn
            // 
            this.Send_Fb_btn.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_Fb_btn.Location = new System.Drawing.Point(704, 304);
            this.Send_Fb_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Send_Fb_btn.Name = "Send_Fb_btn";
            this.Send_Fb_btn.Size = new System.Drawing.Size(103, 37);
            this.Send_Fb_btn.TabIndex = 16;
            this.Send_Fb_btn.Text = "Send";
            this.Send_Fb_btn.UseVisualStyleBackColor = true;
            this.Send_Fb_btn.Click += new System.EventHandler(this.Send_Fb_btn_Click);
            // 
            // FB_dtpick
            // 
            this.FB_dtpick.CustomFormat = "yyyy-MM-dd";
            this.FB_dtpick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FB_dtpick.Location = new System.Drawing.Point(270, 60);
            this.FB_dtpick.Margin = new System.Windows.Forms.Padding(2);
            this.FB_dtpick.Name = "FB_dtpick";
            this.FB_dtpick.Size = new System.Drawing.Size(201, 20);
            this.FB_dtpick.TabIndex = 17;
            // 
            // Feedback_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.FB_dtpick);
            this.Controls.Add(this.Send_Fb_btn);
            this.Controls.Add(this.Feedback_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Feedback_usercontrol";
            this.Size = new System.Drawing.Size(870, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Feedback_txtbox;
        private System.Windows.Forms.Button Send_Fb_btn;
        private System.Windows.Forms.DateTimePicker FB_dtpick;
    }
}
