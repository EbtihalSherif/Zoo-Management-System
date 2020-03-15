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



    public partial class Visitor_Profile_usercontrol : UserControl
    {

     
        public Visitor_Profile_usercontrol( )
        {
            
            // string id,username;
            InitializeComponent();
            Visitor_save_button.Visible = false;
            LogIn_form log = new LogIn_form();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("View_Visitor_Profile", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("Visitor_ID", Program.VisID);
            SqlDataReader readData = cmd.ExecuteReader();
            while(readData.Read())
            {
                Visitor_name_txtbox.Text = readData["Vis_Name"].ToString();
                Visitor_Email_txtbox.Text = readData["Vis_Email"].ToString();
                Visitor_pass_txtbox.Text = readData["Vis_Password"].ToString();

            }
            con.Close();
        }



        private void Visitor_edit_button_Click(object sender, EventArgs e)
        {
            Visitor_name_txtbox.ReadOnly = false;
            Visitor_pass_txtbox.ReadOnly = false;
            Visitor_Email_txtbox.ReadOnly = false;
            Visitor_save_button.Visible = true;
        }

        private void Visitor_save_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();


            SqlCommand cmd = new SqlCommand("Update_Visitor_Data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@vis_name", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@vis_pass", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@vis_Email", SqlDbType.NVarChar));
           
            cmd.Parameters.Add(new SqlParameter("@vis_id", SqlDbType.Int));


            cmd.Parameters["@vis_name"].Value = Visitor_name_txtbox.Text;
            cmd.Parameters["@vis_pass"].Value = Visitor_pass_txtbox.Text;
            cmd.Parameters["@vis_Email"].Value = Visitor_Email_txtbox.Text;
           
            cmd.Parameters["@vis_id"].Value = Program.VisID;

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("PROFILE UPDATED");

            Visitor_name_txtbox.ReadOnly = true;
            Visitor_pass_txtbox.ReadOnly = true;
            Visitor_Email_txtbox.ReadOnly = true;
          
        }

    }
}
