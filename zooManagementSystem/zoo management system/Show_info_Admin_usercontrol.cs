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
    public partial class Show_info_Admin_usercontrol : UserControl
    {
        public Show_info_Admin_usercontrol()
        {
            InitializeComponent();
            admin_mail_txtbox.ReadOnly = false;
            admin_name_txtbox.ReadOnly = false;
            admin_pass_txtbox.ReadOnly = false;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Get_Admin", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.Add(new SqlParameter("@Admin_ID", SqlDbType.Int));
            cmd.Parameters["@Admin_ID"].Value = Program.AdmID;
            SqlDataReader readData = cmd.ExecuteReader();
            while (readData.Read())
            {
                admin_name_txtbox.Text = readData["Adm_Name"].ToString();
                admin_mail_txtbox.Text = readData["Adm_Email"].ToString();
                admin_pass_txtbox.Text = readData["Adm_Password"].ToString();

            }
            con.Close();
        }

     

        private void admin_edit_button_Click(object sender, EventArgs e)
        {
           
            admin_save_button.Visible = true;

        }

        private void admin_save_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Edit_Admin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Adm_ID", SqlDbType.Int));
            cmd.Parameters["@Adm_ID"].Value = Program.AdmID;
            cmd.Parameters.Add(new SqlParameter("@Adm_Name", SqlDbType.NVarChar));
            cmd.Parameters["@Adm_Name"].Value = admin_name_txtbox.Text;
            cmd.Parameters.Add(new SqlParameter("@Adm_Email", SqlDbType.NVarChar));
            cmd.Parameters["@Adm_Email"].Value = admin_mail_txtbox.Text;
            cmd.Parameters.Add(new SqlParameter("@Adm_Password", SqlDbType.NVarChar));
            cmd.Parameters["@Adm_Password"].Value = admin_pass_txtbox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated");

            admin_mail_txtbox.ReadOnly = true;
            admin_name_txtbox.ReadOnly = true;
            admin_pass_txtbox.ReadOnly = true;
            admin_save_button.Visible = false;
        }
    }
}
