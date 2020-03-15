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
    public partial class Feedback_read_usercontrol : UserControl
    {
        public Feedback_read_usercontrol()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Show_All_Feedback", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable Tbl_Order = new DataTable();
            Tbl_Order.Columns.Add("Order_ID");
            Tbl_Order.Columns.Add("Vis_ID");
            Tbl_Order.Columns.Add("Date_Of_Visit");
            Tbl_Order.Columns.Add("Feedback");
            DataRow row;
            while (reader.Read())
            {
                row = Tbl_Order.NewRow();
                row["Order_ID"] = reader["Order_ID"];
                row["Vis_ID"] = reader["Vis_ID"];
                row["Date_Of_Visit"] = reader["Date_Of_Visit"];
                row["Feedback"] = reader["Feedback"];
                Tbl_Order.Rows.Add(row);
            }

            reader.Close();
            con.Close();

            admin_feedback_GridView.DataSource = Tbl_Order;
        }

    }
}
