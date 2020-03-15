namespace zoo_management_system
{
    partial class Feedback_read_usercontrol
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
            this.admin_feedback_GridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.admin_feedback_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_feedback_GridView
            // 
            this.admin_feedback_GridView.AllowUserToAddRows = false;
            this.admin_feedback_GridView.AllowUserToDeleteRows = false;
            this.admin_feedback_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.admin_feedback_GridView.BackgroundColor = System.Drawing.Color.Beige;
            this.admin_feedback_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.admin_feedback_GridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.admin_feedback_GridView.GridColor = System.Drawing.Color.Beige;
            this.admin_feedback_GridView.Location = new System.Drawing.Point(37, 81);
            this.admin_feedback_GridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.admin_feedback_GridView.Name = "admin_feedback_GridView";
            this.admin_feedback_GridView.ReadOnly = true;
            this.admin_feedback_GridView.RowTemplate.Height = 24;
            this.admin_feedback_GridView.Size = new System.Drawing.Size(631, 341);
            this.admin_feedback_GridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "All FeedBack";
            // 
            // Feedback_read_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.admin_feedback_GridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Feedback_read_usercontrol";
            this.Size = new System.Drawing.Size(711, 452);
            ((System.ComponentModel.ISupportInitialize)(this.admin_feedback_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView admin_feedback_GridView;
        private System.Windows.Forms.Label label1;
    }
}
