using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace zoo_management_system
{
    public partial class SignUp_form : Form
    {
        static Regex ValidEmailRegex = CreateValidEmailRegex();
        public SignUp_form()
        {
            InitializeComponent();
        }
        internal static bool EmailIsValid(string emailAddress)
        {
            bool isValid = ValidEmailRegex.IsMatch(emailAddress);

            return isValid;
        }
        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        private void letsgo_btn1_Click(object sender, EventArgs e)
        {
            string username = UserNameSign_txtbox.Text;
            string password = PassSign_txtbox.Text;
            string emailUser = Email_txtbox.Text;
            if(username.Equals(string.Empty) || password.Equals(string.Empty) || emailUser.Equals(string.Empty))
            {
                MessageBox.Show("Empty Field Detected.\n\nPlease Fillout All The Feilds.", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               
                if (EmailIsValid(emailUser))
                {
                    SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=ZooMS;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Visitor_SginUP", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Vis_Name", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@Vis_Email", SqlDbType.NVarChar));
                    cmd.Parameters.Add(new SqlParameter("@Vis_Password", SqlDbType.NVarChar));

                    cmd.Parameters["@Vis_Name"].Value = UserNameSign_txtbox.Text;
                    cmd.Parameters["@Vis_Email"].Value = Email_txtbox.Text;
                    cmd.Parameters["@Vis_Password"].Value = PassSign_txtbox.Text;

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("WELCOME IN OUR ZOOOO :) ");
                    JungleHome_form openform = new JungleHome_form();
                    openform.Show();
                    Visible = false;
                }
                else MessageBox.Show("Please Enter a Correct Email To SignUP", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Signup_btn_Click(object sender, EventArgs e)
        {
            Welcome_form openFrom = new Welcome_form();
            openFrom.Show();
            this.Hide();
        }
    }
}
