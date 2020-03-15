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
    public partial class SalaryPerMonth_usercontrol : UserControl
    {
        public SalaryPerMonth_usercontrol()
        {
            InitializeComponent();
        }

        private void Save_Anim_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Select Salary_Hours From Staff where Emp_ID=@Emp_ID", con);
            cmd1.CommandType = CommandType.Text;
            cmd1.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
            cmd1.Parameters["@Emp_ID"].Value = Program.StaffID;
            object Salary;
            Salary = cmd1.ExecuteScalar();
            SqlCommand cmd = new SqlCommand("Cal_Worked_Hours_Month", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Emp_ID", SqlDbType.Int));
            cmd.Parameters.Add(new SqlParameter("@Start_Day", SqlDbType.Date));
            cmd.Parameters.Add(new SqlParameter("@End_Day", SqlDbType.Date));
            cmd.Parameters["@Emp_ID"].Value = Program.StaffID;
            cmd.Parameters["@Start_Day"].Value = Sal_StartDate_dtpick.Text;
            cmd.Parameters["@End_Day"].Value = Sal_EndDate_dtpick.Text;
            object sum;
            sum = cmd.ExecuteScalar();
            con.Close();
            int Worked_hours = Convert.ToInt32(sum);
            decimal Salary_hours = (decimal)(Salary);
            decimal the_amount = Worked_hours * Salary_hours;
            label4.Text = the_amount.ToString() + "$";
        }

     
    }
}
