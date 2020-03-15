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
    public partial class Welcome_form : Form
    {
        //public bool Staff_btn_clicked =false ;
        //public bool Admin_btn_clicked = false;
        //public bool Visitor_btn_clicked = false;
        public Welcome_form()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Welcome_form_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_form openform = new SignUp_form();
            openform.Show();
            Visible = false;

        }

        public void Admin_btn_Click(object sender, EventArgs e)
        {


            Admin_login_form openform = new Admin_login_form();
            openform.Show();
            Visible = false;
        }

        public void Staff_btn_Click(object sender, EventArgs e)
        {

            Staff_login_form openform = new Staff_login_form();
            openform.Show();
            Visible = false;
        }

        public void Visitor_btn_Click(object sender, EventArgs e)
        {

            LogIn_form openform = new LogIn_form();
            openform.Show();
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Wlcome_Header_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(Cursor.Position.X + e.X, Cursor.Position.Y + e.Y);
            }
        }
    }
}

