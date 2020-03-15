using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoo_management_system
{

    public partial class Show_Info_userControl : UserControl
    {
        public Show_Info_userControl()
        {
            InitializeComponent();
        }

        private void Edit_Staff_Profile_btn_Click(object sender, EventArgs e)
        {
            Save_Profile_btn.Visible = true;
            Staff_Name_txtbox.ReadOnly = true;
            Staff_Phone_txtbox.ReadOnly = true;
            Staff_Position_txtbox.ReadOnly = true;
            Staff_Email_txtbox.ReadOnly = true;
            Staff_Address_txtbox.ReadOnly = true;
         
        }

        private void Show_Info_userControl_Load(object sender, EventArgs e)
        {
            Visible = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
