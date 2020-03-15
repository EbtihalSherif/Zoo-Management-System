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
    public partial class AddEvent_usercontrol : UserControl
    {
        public AddEvent_usercontrol()
        {
            InitializeComponent();
        }

        private void Add_Event_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Add_Event", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Event_Name", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.Text));
            cmd.Parameters.Add(new SqlParameter("@Start_Day", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@End_Day", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@Tic_price", SqlDbType.Money));
            cmd.Parameters["@Event_Name"].Value = Event_Name_txtbox.Text;
            cmd.Parameters["@Description"].Value = Event_desc_txtbox.Text;
            cmd.Parameters["@Start_Day"].Value = dateTimePicker1.Text;
            cmd.Parameters["@End_Day"].Value = dateTimePicker2.Text;
            cmd.Parameters["@Tic_Price"].Value = EV_Price_txtbox.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done :) ");
        }

    
    }
}
