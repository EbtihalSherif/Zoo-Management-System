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
    public partial class BookingTicket_usercontrol : UserControl
    {
        public BookingTicket_usercontrol()
        {
            InitializeComponent();
        }
        private void Book_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Book_Ticket", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Vis_ID", SqlDbType.Int));
            cmd.Parameters["@Vis_ID"].Value = Program.VisID;

            cmd.Parameters.Add(new SqlParameter("@Date_Of_Visit", SqlDbType.Date));
            cmd.Parameters["@Date_Of_Visit"].Value = dateTimePicker1.Text;

            cmd.Parameters.Add(new SqlParameter("@Adult_Tic", SqlDbType.Int));
            cmd.Parameters["@Adult_Tic"].Value = AdultQty_cbox.Text;
            var x = Convert.ToInt16(AdultQty_cbox.Text) * 20;

            cmd.Parameters.Add(new SqlParameter("@Child_Tic", SqlDbType.Int));
            cmd.Parameters["@Child_Tic"].Value = ChildQty_cbox.Text;
            var y = Convert.ToInt16(ChildQty_cbox.Text) * 15;

            cmd.Parameters.Add(new SqlParameter("@Camera_Tic", SqlDbType.Int));
            cmd.Parameters["@Camera_Tic"].Value = CamQty_cbox.Text;
            var z = Convert.ToInt16(CamQty_cbox.Text) * 5;
            cmd.Parameters.Add(new SqlParameter("@Total_Price", SqlDbType.Money));
            var Total = x + y + z;
            cmd.Parameters["@Total_Price"].Value = Total;

            cmd.ExecuteNonQuery();
            con.Close();
            label2.Text = Total.ToString()+ "$";
           
        }
    }
}
