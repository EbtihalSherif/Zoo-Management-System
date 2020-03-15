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
    public partial class Animal : UserControl
    {
        public Animal()
        {
            InitializeComponent();
        }

        Label addlabl(string Anim_Birth, string Anim_Health, string Anim_Kind, string Anim_Nationality, string Species_Name, string Food,int I)
        {
            Label L = new Label();
            L.Name = "Animal" + I.ToString();
            L.AllowDrop = true;
            L.Text =  Species_Name  + " \n Health :" + Anim_Health + "\n Kind : " + Anim_Kind + " \n Nationality : " + Anim_Nationality + " \n Birth: " + Anim_Birth + " \n Eating "  + Food + " \n ";
            L.ForeColor = Color.Black;
            L.BackColor = Color.DarkKhaki;
            L.Font = new Font("Perpetua Titling MT", 15, FontStyle.Regular);

            L.Width = 820;
            L.Height = 200;
            L.TextAlign = ContentAlignment.MiddleCenter;
            L.Margin = new Padding(7);
            return L;
        }
        private void Animal_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GO15J7J;Initial Catalog=ZooMS;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Anim_Birth,Anim_Health,Anim_Kind,Anim_Nationality,Species_Name,Food FROM Animal ", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader Reader = cmd.ExecuteReader();

            int I = 1;
            while (Reader.Read())
            {
                string Anim_Birth = Reader["Anim_Birth"].ToString();
                string Anim_Health = (string)Reader["Anim_Health"];
                string Anim_Kind = (string)Reader["Anim_Kind"];
                string Anim_Nationality = (string)Reader["Anim_Nationality"];
                string Species_Name = (string)Reader["Species_Name"];
                string Food = (string)Reader["Food"];

                Label l = addlabl(Anim_Birth, Anim_Health, Anim_Kind, Anim_Nationality, Species_Name, Food,I);
                flwLyutPnlAnimals.Controls.Add(l);
                I++;
            }
           
            Reader.Close();
            con.Close();
        }
    }
}
