namespace zoo_management_system
{
    partial class AddAnimal_usercontrol
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Anim_Species_Name_txtbox = new System.Windows.Forms.TextBox();
            this.Anim_Kind_txtbox = new System.Windows.Forms.TextBox();
            this.Anim_Birth_txtbox = new System.Windows.Forms.TextBox();
            this.Anim_Health_txtbox = new System.Windows.Forms.TextBox();
            this.Anim_Nation_txtbox = new System.Windows.Forms.TextBox();
            this.Anim_Food_txtbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add_Anim_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Species Name ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Animal Kind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Animal BirthDate ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Animal Health state";
            // 
            // Anim_Species_Name_txtbox
            // 
            this.Anim_Species_Name_txtbox.Location = new System.Drawing.Point(277, 39);
            this.Anim_Species_Name_txtbox.Multiline = true;
            this.Anim_Species_Name_txtbox.Name = "Anim_Species_Name_txtbox";
            this.Anim_Species_Name_txtbox.Size = new System.Drawing.Size(368, 37);
            this.Anim_Species_Name_txtbox.TabIndex = 4;
            this.Anim_Species_Name_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Anim_Kind_txtbox
            // 
            this.Anim_Kind_txtbox.Location = new System.Drawing.Point(277, 134);
            this.Anim_Kind_txtbox.Multiline = true;
            this.Anim_Kind_txtbox.Name = "Anim_Kind_txtbox";
            this.Anim_Kind_txtbox.Size = new System.Drawing.Size(368, 37);
            this.Anim_Kind_txtbox.TabIndex = 5;
            this.Anim_Kind_txtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Anim_Birth_txtbox
            // 
            this.Anim_Birth_txtbox.Location = new System.Drawing.Point(277, 231);
            this.Anim_Birth_txtbox.Multiline = true;
            this.Anim_Birth_txtbox.Name = "Anim_Birth_txtbox";
            this.Anim_Birth_txtbox.Size = new System.Drawing.Size(368, 37);
            this.Anim_Birth_txtbox.TabIndex = 6;
            this.Anim_Birth_txtbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Anim_Health_txtbox
            // 
            this.Anim_Health_txtbox.Location = new System.Drawing.Point(315, 327);
            this.Anim_Health_txtbox.Multiline = true;
            this.Anim_Health_txtbox.Name = "Anim_Health_txtbox";
            this.Anim_Health_txtbox.Size = new System.Drawing.Size(368, 37);
            this.Anim_Health_txtbox.TabIndex = 7;
            this.Anim_Health_txtbox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Anim_Nation_txtbox
            // 
            this.Anim_Nation_txtbox.Location = new System.Drawing.Point(209, 423);
            this.Anim_Nation_txtbox.Multiline = true;
            this.Anim_Nation_txtbox.Name = "Anim_Nation_txtbox";
            this.Anim_Nation_txtbox.Size = new System.Drawing.Size(368, 37);
            this.Anim_Nation_txtbox.TabIndex = 8;
            // 
            // Anim_Food_txtbox
            // 
            this.Anim_Food_txtbox.Location = new System.Drawing.Point(209, 512);
            this.Anim_Food_txtbox.Multiline = true;
            this.Anim_Food_txtbox.Name = "Anim_Food_txtbox";
            this.Anim_Food_txtbox.Size = new System.Drawing.Size(368, 37);
            this.Anim_Food_txtbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 44);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nationality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 44);
            this.label6.TabIndex = 11;
            this.label6.Text = "Food ";
            // 
            // Add_Anim_btn
            // 
            this.Add_Anim_btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Anim_btn.Location = new System.Drawing.Point(915, 605);
            this.Add_Anim_btn.Name = "Add_Anim_btn";
            this.Add_Anim_btn.Size = new System.Drawing.Size(109, 56);
            this.Add_Anim_btn.TabIndex = 12;
            this.Add_Anim_btn.Text = "Add ";
            this.Add_Anim_btn.UseVisualStyleBackColor = true;
            // 
            // AddAnimal_usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.Add_Anim_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Anim_Food_txtbox);
            this.Controls.Add(this.Anim_Nation_txtbox);
            this.Controls.Add(this.Anim_Health_txtbox);
            this.Controls.Add(this.Anim_Birth_txtbox);
            this.Controls.Add(this.Anim_Kind_txtbox);
            this.Controls.Add(this.Anim_Species_Name_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAnimal_usercontrol";
            this.Size = new System.Drawing.Size(1067, 695);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Anim_Species_Name_txtbox;
        private System.Windows.Forms.TextBox Anim_Kind_txtbox;
        private System.Windows.Forms.TextBox Anim_Birth_txtbox;
        private System.Windows.Forms.TextBox Anim_Health_txtbox;
        private System.Windows.Forms.TextBox Anim_Nation_txtbox;
        private System.Windows.Forms.TextBox Anim_Food_txtbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add_Anim_btn;
    }
}
