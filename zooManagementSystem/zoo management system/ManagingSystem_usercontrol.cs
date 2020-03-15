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
    public partial class ManagingSystem_usercontrol : UserControl
    {
        int index, index0, index1;
        public ManagingSystem_usercontrol()
        {
            InitializeComponent();
            remove__Animal_button.Enabled = false;
            edit_Animal_button.Enabled = false;
            Remove_Staff_btn.Enabled = false;
            Remove_event_btn.Enabled = false;
            Show_All_Animal();
            Show_All_Staff();
            Show_All_Event();
            Show_All_StaffForShift();
        }
        public void Show_All_Visitor()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Show_All_Visitor", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable Tbl_Visitor = new DataTable();
            Tbl_Visitor.Columns.Add("Vis_ID");
            Tbl_Visitor.Columns.Add("Admin_ID");
            Tbl_Visitor.Columns.Add("Vis_Name");
            Tbl_Visitor.Columns.Add("Vis_Email");
            DataRow row;
            while (reader.Read())
            {
                row = Tbl_Visitor.NewRow();
                row["Vis_ID"] = reader["Vis_ID"];
                row["Admin_ID"] = reader["Admin_ID"];
                row["Vis_Name"] = reader["Vis_Name"];
                row["Vis_Email"] = reader["Vis_Email"];
                Tbl_Visitor.Rows.Add(row);
            }

            reader.Close();
            con.Close();
            vistors_GridView.DataSource = Tbl_Visitor;
        }
        public void Show_All_Animal()
        {
            SqlConnection CON = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            CON.Open();
            SqlCommand CMD = new SqlCommand("Show_All_Animals", CON);
            CMD.CommandType = CommandType.StoredProcedure;

            SqlDataReader READER = CMD.ExecuteReader();
            DataTable Tbl_Animal = new DataTable();
            Tbl_Animal.Columns.Add("ID");
            Tbl_Animal.Columns.Add("Birth");
            Tbl_Animal.Columns.Add("Health");
            Tbl_Animal.Columns.Add("Kind");
            Tbl_Animal.Columns.Add("nation");
            Tbl_Animal.Columns.Add("Species_Name");
            Tbl_Animal.Columns.Add("Food");
            DataRow ROW;
            while (READER.Read())
            {
                ROW = Tbl_Animal.NewRow();
                ROW["ID"] = READER["Anim_ID"];
                ROW["Birth"] = READER["Anim_birth"];
                ROW["Health"] = READER["Anim_Health"];
                ROW["Kind"] = READER["Anim_Kind"];
                ROW["nation"] = READER["Anim_Nationality"];
                ROW["Species_Name"] = READER["Species_Name"];
                ROW["Food"] = READER["Food"];

                Tbl_Animal.Rows.Add(ROW);
            }

            READER.Close();
            CON.Close();

            anim_gridview.DataSource = Tbl_Animal;
        }
        public void Show_All_Staff()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Get_AllStaff", conn);
            cmmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader read = cmmd.ExecuteReader();
            DataTable Tbl_Staff = new DataTable();
            Tbl_Staff.Columns.Add("Emp_ID");
            Tbl_Staff.Columns.Add("Emp_Name");
            Tbl_Staff.Columns.Add("Emp_Email");
            Tbl_Staff.Columns.Add("Salary_Hours");
            Tbl_Staff.Columns.Add("Emp_Position");
            Tbl_Staff.Columns.Add("Emp_Phone");
            Tbl_Staff.Columns.Add("Emp_Address");
            DataRow r;
            while (read.Read())
            {
                r = Tbl_Staff.NewRow();
                r["Emp_ID"] = read["Emp_ID"];
                r["Emp_Name"] = read["Emp_Name"];
                r["Emp_Email"] = read["Emp_Email"];
                r["Salary_Hours"] = read["Salary_Hours"];
                r["Emp_Position"] = read["Emp_Position"];
                r["Emp_Phone"] = read["Emp_Phone"];
                r["Emp_Address"] = read["Emp_Address"];

                Tbl_Staff.Rows.Add(r);
            }

            read.Close();
            conn.Close();

            staff_gridveiw.DataSource = Tbl_Staff;
        }
        public void Show_All_Event()
        {
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

            EnentDGV.DataSource = Tbl_Event;
        }
        public void Show_All_StaffForShift()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            conn.Open();
            SqlCommand cmmd = new SqlCommand("Get_AllStafff", conn);
            cmmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader read = cmmd.ExecuteReader();
            DataTable Tbl_Staff = new DataTable();
            Tbl_Staff.Columns.Add("Emp_ID");
            Tbl_Staff.Columns.Add("Emp_Name");
            DataRow r;
            while (read.Read())
            {
                r = Tbl_Staff.NewRow();
                r["Emp_ID"] = read["Emp_ID"];
                r["Emp_Name"] = read["Emp_Name"];
                Tbl_Staff.Rows.Add(r);
            }

            read.Close();
            conn.Close();
            View_Staff_To_Assign_Shift_DGV.DataSource = Tbl_Staff;
        }
        private void ManagingSystem_usercontrol_Load(object sender, EventArgs e)
        {
            Show_All_Visitor();
            Show_All_Animal();
            Show_All_Staff();
            Show_All_Event();
            Show_All_StaffForShift();
        }

        private void staff_gridveiw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Remove_Staff_btn.Enabled = true;
            Add_Staff_btn.Enabled = false;
            index0 = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvgrow = staff_gridveiw.Rows[e.RowIndex];
                staff_name_txtbox.Text = dvgrow.Cells[1].Value.ToString();
                staff_mail_txtbox.Text = dvgrow.Cells[2].Value.ToString();
                staff_salary_txtbox.Text = dvgrow.Cells[3].Value.ToString();
                staff_possion_txtbox.Text = dvgrow.Cells[4].Value.ToString();
                staff_phone_txtbox.Text = dvgrow.Cells[5].Value.ToString();
                staff_address_txtbox.Text = dvgrow.Cells[6].Value.ToString();
            }
        }

        private void add_animal_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert_Animal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Anim_Birth", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@Anim_Health", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Anim_Kind", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Anim_Nationality", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@species_Name", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Food", SqlDbType.Text));
            cmd.Parameters["@Anim_Birth"].Value = Anim_birth_txtbox.Text;
            cmd.Parameters["@Anim_Health"].Value = anim_health_txtbox.Text;
            cmd.Parameters["@Anim_Kind"].Value = anim_kin_txtbox.Text;
            cmd.Parameters["@Anim_Nationality"].Value = anim_nation_txtbox.Text;
            cmd.Parameters["@species_Name"].Value = anim_name_txtbox.Text;
            cmd.Parameters["@Food"].Value = anim_food_txtbox.Text;

            cmd.ExecuteNonQuery();
            MessageBox.Show("Done :)");
            Show_All_Animal();
            con.Close();
        }

        private void edit_Animal_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("EditAnimal", con);
            cmd.CommandType = CommandType.StoredProcedure;

            DataGridViewRow row = anim_gridview.Rows[index];
            cmd.Parameters.AddWithValue("Anim_ID", row.Cells[0].Value);
            cmd.Parameters.AddWithValue("Species_Name", anim_name_txtbox.Text);
            cmd.Parameters.AddWithValue("Anim_Kind", anim_kin_txtbox.Text);
            cmd.Parameters.AddWithValue("Anim_Birth", Anim_birth_txtbox.Text);
            cmd.Parameters.AddWithValue("Anim_Health", anim_health_txtbox.Text);
            cmd.Parameters.AddWithValue("Anim_Nationality", anim_nation_txtbox.Text);
            cmd.Parameters.AddWithValue("Food", anim_food_txtbox.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated :)");
            Show_All_Animal();
            con.Close();
        }

        private void remove__Animal_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteAnimal", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataGridViewRow row = anim_gridview.Rows[index];
            cmd.Parameters.AddWithValue("Anim_ID", row.Cells[0].Value);
            cmd.ExecuteNonQuery();      
            MessageBox.Show("Deleted");
            Show_All_Animal();
            con.Close();
        }

        private void Add_Staff_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Add_Staff", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Emp_Name", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Emp_Password", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Emp_Email", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Salary_Hours", SqlDbType.Money));
            cmd.Parameters.Add(new SqlParameter("@Emp_position", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Emp_Phone", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Emp_Address", SqlDbType.Text));
            cmd.Parameters["@Emp_Name"].Value = staff_name_txtbox.Text;
            cmd.Parameters["@Emp_Password"].Value = initPasswordtxt.Text;
            cmd.Parameters["@Emp_Email"].Value = staff_mail_txtbox.Text;
            cmd.Parameters["@Salary_Hours"].Value = staff_salary_txtbox.Text;
            cmd.Parameters["@Emp_Position"].Value = staff_possion_txtbox.Text;
            cmd.Parameters["@Emp_Phone"].Value = staff_phone_txtbox.Text;
            cmd.Parameters["@Emp_Address"].Value = staff_address_txtbox.Text;

            cmd.ExecuteNonQuery();
           
            MessageBox.Show("Done :)");
            Show_All_Staff();
            con.Close();
        }

        private void Remove_Staff_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteStaff", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataGridViewRow row = staff_gridveiw.Rows[index0];
            cmd.Parameters.AddWithValue("Emp_ID", row.Cells[0].Value);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Done :)");
            Show_All_Staff();
            con.Close();
        }

        private void Remove_event_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DeleteEvent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataGridViewRow row = EnentDGV.Rows[index1];
            cmd.Parameters.AddWithValue("Event_ID", row.Cells[0].Value);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("IT IS DELETED :( ");
            Show_All_Event();
            con.Close();
        }

        private void Reset_Anim_btn_Click(object sender, EventArgs e)
        {
            Anim_ID_txtbox.Text = Anim_birth_txtbox.Text = anim_health_txtbox.Text = anim_kin_txtbox.Text = anim_nation_txtbox.Text = anim_name_txtbox.Text = anim_food_txtbox.Text = "";
            add_animal_button.Enabled = true;
            remove__Animal_button.Enabled = false;
            edit_Animal_button.Enabled = false;
        }

        private void Reset_Staff_btn_Click(object sender, EventArgs e)
        {
            staff_name_txtbox.Text = staff_mail_txtbox.Text = staff_salary_txtbox.Text = staff_possion_txtbox.Text = staff_phone_txtbox.Text = staff_address_txtbox.Text = "";
            Remove_Staff_btn.Enabled = false;
            Add_Staff_btn.Enabled = true;
        }

        private void View_Staff_To_Assign_Shift_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvgrow = View_Staff_To_Assign_Shift_DGV.Rows[e.RowIndex];
                StaffID_txtBox.Text = dvgrow.Cells[0].Value.ToString();
            }
        }

        private void AssignShift_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(Local);Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Assgin_Shift", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
            cmd.Parameters["@Emp_ID"].Value = StaffID_txtBox.Text;
            cmd.Parameters.Add(new SqlParameter("@Day", SqlDbType.Date));
            cmd.Parameters["@Day"].Value = dateTimePicker1.Text;
            cmd.Parameters.Add(new SqlParameter("@Start_Time", SqlDbType.Time));
            cmd.Parameters["@Start_Time"].Value = StartTime_txtbox.Text;
            cmd.Parameters.Add(new SqlParameter("@End_Time", SqlDbType.Time));
            cmd.Parameters["@End_Time"].Value = EndTime_txtbox.Text;
            cmd.ExecuteNonQuery();
            SqlCommand comd = new SqlCommand("Calu_Worked_hours", con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
            comd.Parameters["@Emp_ID"].Value = StaffID_txtBox.Text;
            comd.Parameters.Add(new SqlParameter("@Day", SqlDbType.Date));
            comd.Parameters["@Day"].Value = dateTimePicker1.Text;
            comd.ExecuteNonQuery();
            
            MessageBox.Show("Thank you");
            Show_All_StaffForShift();
            con.Close();
        }

        private void EnentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Remove_event_btn.Enabled = true;
            index1 = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvgrow = EnentDGV.Rows[e.RowIndex];
                event_txtbox.Text = dvgrow.Cells[0].Value.ToString();

            }
        }

        private void anim_gridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            add_animal_button.Enabled = false;
            remove__Animal_button.Enabled = edit_Animal_button.Enabled = true;
            index = e.RowIndex;
            if (e.RowIndex != -1)
            {
                DataGridViewRow dvgrow = anim_gridview.Rows[e.RowIndex];
                Anim_ID_txtbox.Text = dvgrow.Cells[0].Value.ToString();
                Anim_birth_txtbox.Text = dvgrow.Cells[1].Value.ToString();
                anim_health_txtbox.Text = dvgrow.Cells[2].Value.ToString();
                anim_kin_txtbox.Text = dvgrow.Cells[3].Value.ToString();
                anim_nation_txtbox.Text = dvgrow.Cells[4].Value.ToString();
                anim_name_txtbox.Text = dvgrow.Cells[5].Value.ToString();
                anim_food_txtbox.Text = dvgrow.Cells[6].Value.ToString();
            }
        }
    }
}
