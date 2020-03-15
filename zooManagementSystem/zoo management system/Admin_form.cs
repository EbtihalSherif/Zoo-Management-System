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
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
        }

        private void admin_profile_button_Click(object sender, EventArgs e)
        {
            show_info_Admin_usercontrol2.BringToFront();
        }

        private void admin_feedback_button_Click(object sender, EventArgs e)
        {
            feedback_read_usercontrol1.BringToFront();
        }

        private void admin_system_button_Click(object sender, EventArgs e)
        {
            managingSystem_usercontrol1.BringToFront();
        }

        private void admin_signout_button_Click(object sender, EventArgs e)
        {
            Welcome_form open = new Welcome_form();
            open.Show();
            this.Hide();
        }

        private void ExitStaff_picBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
