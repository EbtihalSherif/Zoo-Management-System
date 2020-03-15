using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace zoo_management_system
{
    public partial class Staff_Profile_usercontrol : UserControl
    {
        public Staff_Profile_usercontrol()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Find_Staff", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.Add(new SqlParameter("@staff_ID", SqlDbType.Int));
            cmd1.Parameters["@staff_ID"].Value = Program.StaffID;
            SqlDataReader readData = cmd1.ExecuteReader();
            while (readData.Read())
            {
                Staff_Name_txtbox.Text = readData["Emp_Name"].ToString();
                Staff_Password_txtbox.Text = readData["Emp_Password"].ToString();
                Staff_Position_txtbox.Text = readData["Emp_Position"].ToString();
                Staff_Email_txtbox.Text = readData["Emp_Email"].ToString();
                Staff_Phone_txtbox.Text = readData["Emp_Phone"].ToString();
                Staff_Address_txtbox.Text = readData["Emp_Address"].ToString();

            }

            con.Close();



        }

        private void Edit_Staff_Profile_btn_Click(object sender, EventArgs e)
        {
            Save_Profile_btn.Visible = true;
            Staff_Name_txtbox.ReadOnly = false;
            Staff_Phone_txtbox.ReadOnly = false;
            Staff_Position_txtbox.ReadOnly = false;
            Staff_Email_txtbox.ReadOnly = false;
            Staff_Address_txtbox.ReadOnly = false;
            Staff_Password_txtbox.ReadOnly = false;
            
        }

        private void Save_Profile_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
          

            SqlCommand cmd = new SqlCommand("Update_Staff_Data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Staff_name", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Staff_Password", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Staff_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Staff_Email", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Staff_Phone", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Staff_Address", SqlDbType.Text));
            cmd.Parameters.Add(new SqlParameter("@Staff_position", SqlDbType.NVarChar));

            cmd.Parameters["@Staff_name"].Value = Staff_Name_txtbox.Text;
            cmd.Parameters["@Staff_Password"].Value = Staff_Password_txtbox.Text;
            cmd.Parameters["@Staff_ID"].Value = Program.StaffID;
            cmd.Parameters["@Staff_Email"].Value = Staff_Email_txtbox.Text;
            cmd.Parameters["@Staff_Phone"].Value = Staff_Phone_txtbox.Text;
            cmd.Parameters["@Staff_Address"].Value = Staff_Address_txtbox.Text;
            cmd.Parameters["@Staff_position"].Value = Staff_Position_txtbox.Text;

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("UPDATED");
            Staff_Name_txtbox.ReadOnly = true;
            Staff_Phone_txtbox.ReadOnly = true;
            Staff_Password_txtbox.ReadOnly = true;
            Staff_Position_txtbox.ReadOnly = true;
            Staff_Email_txtbox.ReadOnly = true;
            Staff_Address_txtbox.ReadOnly = true;
            Save_Profile_btn.Visible = true;
           
        }

    }
}
