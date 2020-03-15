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
    public partial class WorkingHours_usercontrol : UserControl
    {
        public WorkingHours_usercontrol()
        {
            InitializeComponent();
        }


        private void Ok_Check_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Cal_Worked_Hours_Month", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Start_Day", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@End_Day", SqlDbType.Date));
            cmd.Parameters["@Emp_ID"].Value = Program.StaffID;
            cmd.Parameters["@Start_Day"].Value = WH_StartDate_dtpick.Text;
            cmd.Parameters["@End_Day"].Value = WH_EndDate_dtpick.Text;
            object sum;
            sum = cmd.ExecuteScalar();
            con.Close();
            string Worked_hours = Convert.ToString(sum);
            label4.Text = Worked_hours;
        }
    }
}
