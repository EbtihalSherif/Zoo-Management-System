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
    public partial class Feedback_usercontrol : UserControl
    {
        public Feedback_usercontrol()
        {
            InitializeComponent();
        }

        private void Send_Fb_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Write_Feedback", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Feedback", SqlDbType.Text));
            cmd.Parameters.Add(new SqlParameter("@Date_Of_Visit", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@Vis_ID", SqlDbType.Int));
            cmd.Parameters["@Vis_ID"].Value = Program.VisID;
            cmd.Parameters["@Date_Of_Visit"].Value = FB_dtpick.Text;
            cmd.Parameters["@Feedback"].Value = Feedback_txtbox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thank you");
        }
    }
}
