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
    public partial class DayShift_usercontrol : UserControl
    {
        public DayShift_usercontrol()
        {
            InitializeComponent();
        }

        private void View_Shift_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Show_Each_Staff_Shift", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Day", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@Staff_ID", SqlDbType.Int));

            cmd.Parameters["@Staff_ID"].Value = Program.StaffID;
            cmd.Parameters["@Day"].Value = DayShift_dtpick.Value.Date;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable StaffShif = new DataTable();

            StaffShif.Columns.Add("Name");
            StaffShif.Columns.Add("Position");
            StaffShif.Columns.Add("Day");
            StaffShif.Columns.Add("Start_Time");
            StaffShif.Columns.Add("End_Time");

            DataRow row;
            while(reader.Read())
            {
                row = StaffShif.NewRow();
                row["Name"] = reader["Emp_Name"];
                row["position"] = reader["Emp_Position"];
                row["Day"] = reader["Day"];
                row["Start_Time"] = reader["Start_Time"];
                row["End_Time"] = reader["End_Time"];
                StaffShif.Rows.Add(row);
            }
              reader.Close();
              con.Close();

            Viewed_Shift_DGV.DataSource = StaffShif;
        }
    }
}
