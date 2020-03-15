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
    public partial class JungleHome_form : Form
    {
        public JungleHome_form()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            bookingTicket_usercontrol1.BringToFront();
            
        }

        private void Explore_btn_Click(object sender, EventArgs e)
        {
            explore_The_zoo_userControl1.BringToFront();
        }

       

        private void Feedback_btn_Click(object sender, EventArgs e)
        {
            feedback_usercontrol1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visitor_Profile_usercontrol1.BringToFront();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            Welcome_form open = new Welcome_form();
            open.Show();
            this.Hide();

        }

        private void WhatsNew_btn_Click(object sender, EventArgs e)
        {
            events_usercontrol1.BringToFront();
        }

        private void Animals_btn_Click(object sender, EventArgs e)
        {
            animal1.BringToFront();
        }
    }
}
