using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace zoo_management_system
{
    public partial class Admin_login_form : Form
    {
        public Admin_login_form()
        {
            InitializeComponent();
        }

        private void letsGo_Login_Admin_btn_Click(object sender, EventArgs e)
        {
            string username = userLogIn_txtbox.Text;
            string password = PassLogIn_txtbox.Text;
            if (username.Equals(string.Empty) || password.Equals(string.Empty))
            {
                MessageBox.Show("Empty Field Detected.\n\nPlease Fillout All The Feilds.", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
                string query = "SELECT Adm_Name,Adm_Password FROM Admin WHERE Adm_Name = '" + userLogIn_txtbox.Text.Trim() + "' AND Adm_Password = '" + PassLogIn_txtbox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                //if there is a match...
                if (dtbl.Rows.Count == 1)
                {
                    Admin_form openHome = new Admin_form(); //creates the new object
                    openHome.Show(); //opens the new window
                    Visible = false;  //hiding the loginform
                    SqlCommand cmd = new SqlCommand("GetAdmID", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // set up the parameters
                    cmd.Parameters.AddWithValue("Adm_Name", username);
                    cmd.Parameters.AddWithValue("Adm_pass", password);
                    cmd.Parameters.Add("@@AdmId", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    Program.AdmID = Convert.ToInt32(cmd.Parameters["@@AdmId"].Value);
                    sqlcon.Close();
                }
                else
                {
                    MessageBox.Show("You Have Entered Wrong Username Or Password!", "Dinied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Back_login_btn_Click(object sender, EventArgs e)
        {
            Welcome_form open = new Welcome_form();
            open.Show();
            this.Hide();
        }

        private void ExitLogIn_picbox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
