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


    public partial class LogIn_form : Form
    {
        public LogIn_form()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button2_Click(object sender, EventArgs e)
        {

            string username = userLogIn_txtbox.Text;
            string password = PassLogIn_txtbox.Text;
            if (username.Equals(string.Empty) || password.Equals(string.Empty))
            {
                MessageBox.Show("Empty Field Detected.\n\nPlease Fillout All The Feilds.", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
                string query = "SELECT Vis_Name,Vis_Password FROM Visitor WHERE Vis_Name = '" + userLogIn_txtbox.Text.Trim() + "' AND Vis_Password = '" + PassLogIn_txtbox.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                //if there is a match...
                if (dtbl.Rows.Count == 1)
                {
                   
                    JungleHome_form openHome = new JungleHome_form(); //creates the new object
                    openHome.Show(); //opens the new window
                    Visible = false;  //hiding the loginform
                        SqlCommand cmd = new SqlCommand("GetVisitorID", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        // set up the parameters
                        cmd.Parameters.AddWithValue("Vis_Name", username);
                        cmd.Parameters.AddWithValue("Vis_pass", password);
                        cmd.Parameters.Add("@@VisId", SqlDbType.Int).Direction = ParameterDirection.Output;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        Program.VisID = Convert.ToInt32(cmd.Parameters["@@VisId"].Value);
                        con.Close();
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


    }
}
