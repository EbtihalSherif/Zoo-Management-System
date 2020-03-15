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
    public partial class EditDataBase_Staff__usercontrol : UserControl
    {
        int index;
        public EditDataBase_Staff__usercontrol()
        {
            InitializeComponent();
            View_All_Animal_DGV_Data();
            View_All_Event_DGV_Data();

        }
        private void View_All_Anim_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvgrow = View_All_Anim_DGV.Rows[e.RowIndex];
                Anim_ID_txtbox.Text = dvgrow.Cells[0].Value.ToString();
                Edt_Anim_Species_txtbox.Text = dvgrow.Cells[5].Value.ToString();
                Edt_Anim_Kind_txtbox.Text = dvgrow.Cells[3].Value.ToString();
                Edit_Anim_Birth_txtbox.Text = dvgrow.Cells[1].Value.ToString();
                Edt_Anim_Health_txtbox.Text = dvgrow.Cells[2].Value.ToString();
                Edit_Anim_Nation_txtbox.Text = dvgrow.Cells[4].Value.ToString();
                Edit_Anim_Food_txtbox.Text = dvgrow.Cells[6].Value.ToString();
            }
        }

        private void Update_Anim_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("EditAnimal", con);
            cmd.CommandType = CommandType.StoredProcedure; 

            cmd.Parameters.Add(new SqlParameter("@Anim_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Anim_Birth", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@Anim_Health", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Anim_Kind", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Anim_Nationality", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Species_Name", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Food", SqlDbType.Text));
      
            cmd.Parameters["@Anim_ID"].Value = Anim_ID_txtbox.Text;
            cmd.Parameters["@Anim_Birth"].Value = Edit_Anim_Birth_txtbox.Text;
            cmd.Parameters["@Anim_Health"].Value = Edt_Anim_Health_txtbox.Text;
            cmd.Parameters["@Anim_Kind"].Value = Edt_Anim_Kind_txtbox.Text;
            cmd.Parameters["@Anim_Nationality"].Value = Edit_Anim_Nation_txtbox.Text;
            cmd.Parameters["@Species_Name"].Value = Edt_Anim_Species_txtbox.Text;
            cmd.Parameters["@Food"].Value = Edit_Anim_Food_txtbox.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("UPDATED");
            View_All_Animal_DGV_Data();
           

            con.Close();
           
        }
        public void View_All_Event_DGV_Data()
        {
            //====================================================================================================
            SqlConnection CONN = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            CONN.Open();
            SqlCommand CMMD = new SqlCommand("Get_AllEvent", CONN);
            CMMD.CommandType = CommandType.StoredProcedure;

            SqlDataReader READ = CMMD.ExecuteReader();
            DataTable Tbl_Event = new DataTable();
            Tbl_Event.Columns.Add("Event_ID");
            Tbl_Event.Columns.Add("Event_Name");
            Tbl_Event.Columns.Add("Description");
            Tbl_Event.Columns.Add("Sart_Day");
            Tbl_Event.Columns.Add("End_Day");
            Tbl_Event.Columns.Add("Tic_Price");

            DataRow R;
            while (READ.Read())
            {
                R = Tbl_Event.NewRow();
                R["Event_ID"] = READ["Event_ID"];
                R["Event_Name"] = READ["Event_Name"];
                R["Description"] = READ["Description"];
                R["Sart_Day"] = READ["Sart_Day"];
                R["End_Day"] = READ["End_Day"];
                R["Tic_Price"] = READ["Tic_Price"];

                Tbl_Event.Rows.Add(R);
            }

            READ.Close();
            CONN.Close();

            View_All_Events_DGV.DataSource = Tbl_Event;
        }
        public void View_All_Animal_DGV_Data()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Show_All_Animals", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable Tbl_Animal = new DataTable();
            Tbl_Animal.Columns.Add("ID");
            Tbl_Animal.Columns.Add("Birth");
            Tbl_Animal.Columns.Add("Health");
            Tbl_Animal.Columns.Add("Kind");
            Tbl_Animal.Columns.Add("nation");
            Tbl_Animal.Columns.Add("Species_Name");
            Tbl_Animal.Columns.Add("Food");
            DataRow row;
            while (reader.Read())
            {
                row = Tbl_Animal.NewRow();
                row["Id"] = reader["Anim_ID"];
                row["Birth"] = reader["Anim_birth"];
                row["Health"] = reader["Anim_Health"];
                row["Kind"] = reader["Anim_Kind"];
                row["nation"] = reader["Anim_Nationality"];
                row["Species_Name"] = reader["Species_Name"];
                row["Food"] = reader["Food"];

                Tbl_Animal.Rows.Add(row);
            }

            reader.Close();
            con.Close();
            View_All_Anim_DGV.DataSource = Tbl_Animal;
        }


        private void EditDataBase_Staff__usercontrol_Load(object sender, EventArgs e)
        {
            View_All_Animal_DGV_Data();
            View_All_Event_DGV_Data();
        }

        private void Update_Event_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();

            SqlCommand com = new SqlCommand("EditEvent", con);
            com.CommandType = CommandType.StoredProcedure;
            DataGridViewRow row = View_All_Events_DGV.Rows[index];
            com.Parameters.AddWithValue("Event_ID", row.Cells[0].Value);
            com.Parameters.AddWithValue("Event_Name", Ev_Name_txtbox.Text);
            com.Parameters.AddWithValue("Description", Ev_Desc_txtbox.Text);
            com.Parameters.AddWithValue("Sart_Day", EV_StartDate_dtpick.Text);
            com.Parameters.AddWithValue("End_Day", EV_Enddate_dtpick.Text);
            com.Parameters.AddWithValue("Tic_Price", EV_Price_txtbox.Text);

            com.ExecuteNonQuery();
            MessageBox.Show("Updated :)");
            View_All_Event_DGV_Data();
            con.Close();
        }

        private void View_All_Events_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvgrow = View_All_Events_DGV.Rows[e.RowIndex];
                txtBoxID.Text = dvgrow.Cells[0].Value.ToString();
                Ev_Name_txtbox.Text = dvgrow.Cells[1].Value.ToString();
                EV_StartDate_dtpick.Text = dvgrow.Cells[3].Value.ToString();
                EV_Enddate_dtpick.Text = dvgrow.Cells[4].Value.ToString();
                Ev_Desc_txtbox.Text = dvgrow.Cells[2].Value.ToString();
                EV_Price_txtbox.Text = dvgrow.Cells[5].Value.ToString();

            }
        }
    }
}
