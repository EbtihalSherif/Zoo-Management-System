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
    public partial class Staff_login_form : Form
    {
        public Staff_login_form()
        {
            InitializeComponent();
        }

      

        private void letsGo_Login_Staff_btn_Click(object sender, EventArgs e)
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
                string query = "SELECT Emp_Name,Emp_Password FROM Staff WHERE Emp_Name = '" + userLogIn_txtbox.Text.Trim() + "' AND Emp_Password = '" + PassLogIn_txtbox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                //if there is a match...
                if (dtbl.Rows.Count == 1)
                {
                    Staff_Form openHome = new Staff_Form(); //creates the new object
                    openHome.Show(); //opens the new window
                    Visible = false;  //hiding the loginform
                    SqlCommand cmd = new SqlCommand("GetStaffID", sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // set up the parameters
                    cmd.Parameters.AddWithValue("Staff_Name", username);
                    cmd.Parameters.AddWithValue("Staff_pass", password);
                    cmd.Parameters.Add("@@StaffId", SqlDbType.Int).Direction = ParameterDirection.Output;
                    sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    Program.StaffID = Convert.ToInt32(cmd.Parameters["@@StaffId"].Value);
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
