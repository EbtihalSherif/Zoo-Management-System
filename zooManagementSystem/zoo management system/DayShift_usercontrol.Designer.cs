namespace zoo_management_system
{
    partial class DayShift_usercontrol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Viewed_Shift_DGV = new System.Windows.Forms.DataGridView();
            this.View_Shift_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DayShift_dtpick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Viewed_Shift_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Date ";
            // 
            // Viewed_Shift_DGV
            // 
            this.Viewed_Shift_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Viewed_Shift_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.Viewed_Shift_DGV.BackgroundColor = System.Drawing.Color.Beige;
            this.Viewed_Shift_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Viewed_Shift_DGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.Viewed_Shift_DGV.Location = new System.Drawing.Point(24, 180);
            this.Viewed_Shift_DGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Viewed_Shift_DGV.Name = "Viewed_Shift_DGV";
            this.Viewed_Shift_DGV.RowTemplate.Height = 28;
            this.Viewed_Shift_DGV.Size = new System.Drawing.Size(654, 98);
            this.Viewed_Shift_DGV.TabIndex = 7;
            // 
            // View_Shift_btn
            // 
            this.View_Shift_btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_Shift_btn.Location = new System.Drawing.Point(363, 41);
            this.View_Shift_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.View_Shift_btn.Name = "View_Shift_btn";
            this.View_Shift_btn.Size = new System.Drawing.Size(93, 28);
            this.View_Shift_btn.TabIndex = 22;
            this.View_Shift_btn.Text = "View Shift";
            this.View_Shift_btn.UseVisualStyleBackColor = true;
            this.View_Shift_btn.Click += new System.EventHandler(this.View_Shift_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 23;
            this.label5.Text = "Your Shift Is : ";
            // 
            // DayShift_dtpick
            // 
            this.DayShift_dtpick.Location = new System.Drawing.Point(148, 47);
            this.DayShift_dtpick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DayShift_dtpick.Name = "DayShift_dtpick";
            this.DayShift_dtpick.Size = new System.Drawing.Size(199, 20);
            this.DayShift_dtpick.TabIndex = 24;
            // 
            // DayShift_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.DayShift_dtpick);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.View_Shift_btn);
            this.Controls.Add(this.Viewed_Shift_DGV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DayShift_usercontrol";
            this.Size = new System.Drawing.Size(711, 452);
            ((System.ComponentModel.ISupportInitialize)(this.Viewed_Shift_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button View_Shift_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Viewed_Shift_DGV;
        private System.Windows.Forms.DateTimePicker DayShift_dtpick;
    }
}
