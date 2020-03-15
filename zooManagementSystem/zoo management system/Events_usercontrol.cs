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
    public partial class Events_usercontrol : UserControl
    {
        int Event_Id;
        public Events_usercontrol()
        {
            InitializeComponent();
        }
        void buttonDoulbeClick(object sender, EventArgs e)
        {
            Label currentbutton = (Label)sender;

            SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Reserve_Event", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Vistor_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Event_ID", SqlDbType.Int));


            cmd.Parameters["@Vistor_ID"].Value = Program.VisID;
            cmd.Parameters["@Event_ID"].Value = Event_Id;


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Reserve IS Done Wish you a Happy Day :) ");

        }

        Label addlabl(string EventName, string Description, int I, string StartDay, string EndDay, string Price)
        {
            Label L = new Label();
            L.Name = "Event" + I.ToString();
            L.AllowDrop = true;
            L.Text = " OUR Event : " + EventName + " \n " + Description + "\n Start at : " + StartDay + " \n End at : " + EndDay + " \n price ticket : " + Price + "$";
            L.ForeColor = Color.Black;
            L.BackColor = Color.DarkKhaki;
            L.Font = new Font("Perpetua Titling MT", 15, FontStyle.Regular);
            // 861, 143
            L.Width = 820;
            L.Height = 150;
            L.TextAlign = ContentAlignment.TopLeft;
            L.Margin = new Padding(7);
            return L;
        }
        Label addbutton(int I)
        {
            Label B = new Label();
            B.Name = "Event" + I.ToString();
            B.Text = "Reserve NOW!!!";
            B.ForeColor = Color.Beige;
            B.BackColor = Color.DarkOrange;
            B.Font = new Font("Perpetua Titling MT", 16, FontStyle.Italic);
            B.Width = 200;
            B.Height = 50;
            B.TextAlign = ContentAlignment.MiddleCenter;
            B.Margin = new Padding(7);
            return B;
        }
        private void Events_usercontrol_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Event_ID,Event_Name,Description,Sart_Day,End_Day,Tic_Price FROM Event ", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader Reader = cmd.ExecuteReader();

            int I = 1;
            while (Reader.Read())
            {
                string EventName = (string)Reader["Event_Name"];
                string Description = (string)Reader["Description"];
                string Price = Reader["Tic_Price"].ToString();
                string StartDay = Reader["Sart_Day"].ToString();
                string EndDay = Reader["End_Day"].ToString();
                Event_Id = (int)Reader["Event_ID"];
                DateTime End = Convert.ToDateTime(Reader["End_Day"]).Date;
                DateTime now = DateTime.Now;

                Label l = addlabl(EventName, Description, I, StartDay, EndDay, Price);
                flowLayoutPanel1.Controls.Add(l);
                if (End > now)
                {
                    Label B = addbutton(I);
                    flowLayoutPanel1.Controls.Add(B);
                    B.DoubleClick += new EventHandler(this.buttonDoulbeClick);
                }
            }

            Reader.Close();
            con.Close();
        }
    }
}
