using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoo_management_system
{
    public partial class Staff_Form : Form
    {
       

        public Staff_Form()
        {
            InitializeComponent();
        }

      

        private void ExitWelcome_picBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staff_Profile_usercontrol2.BringToFront();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            addEvent_usercontrol1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            salaryPerMonth_usercontrol1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dayShift_usercontrol1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            workingHours_usercontrol1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Welcome_form openForm = new Welcome_form();
            openForm.Show();
            Visible = false;
        }

        private void S_Edit_Anim_btn_Click(object sender, EventArgs e)
        {
            editDataBase_Staff__usercontrol1.BringToFront();
        }


        //private void S_Header_pnl_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        this.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
        //    }
        //}
    }
}
