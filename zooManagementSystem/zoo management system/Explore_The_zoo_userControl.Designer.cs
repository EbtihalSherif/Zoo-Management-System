namespace zoo_management_system
{
    partial class Explore_The_zoo_userControl
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
            this.Zoo_Map_PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Zoo_Map_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Zoo_Map_PicBox
            // 
            this.Zoo_Map_PicBox.BackColor = System.Drawing.SystemColors.Window;
            this.Zoo_Map_PicBox.BackgroundImage = global::zoo_management_system.Properties.Resources.image__1_;
            this.Zoo_Map_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Zoo_Map_PicBox.Location = new System.Drawing.Point(216, 3);
            this.Zoo_Map_PicBox.Name = "Zoo_Map_PicBox";
            this.Zoo_Map_PicBox.Size = new System.Drawing.Size(831, 569);
            this.Zoo_Map_PicBox.TabIndex = 0;
            this.Zoo_Map_PicBox.TabStop = false;
            // 
            // Explore_The_zoo_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.Zoo_Map_PicBox);
            this.Name = "Explore_The_zoo_userControl";
            this.Size = new System.Drawing.Size(1305, 575);
            ((System.ComponentModel.ISupportInitialize)(this.Zoo_Map_PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Zoo_Map_PicBox;
    }
}
