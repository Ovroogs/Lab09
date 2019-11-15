using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace g374_L09_Manin_Alekseev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g374_Manin_AlekseevDataSet._l09_planets' table. You can move, or remove it, as needed.
            this.l09_planetsTableAdapter.Fill(this.g374_Manin_AlekseevDataSet._l09_planets);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=sql.wsr;Initial Catalog=g374_Manin_Alekseev;User ID=student;Password=student";
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            string sql = "Select PlanetName,DistanceFromSun FROM [l09-planets];";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string name = rdr.GetString(0);
                float dist = (float) rdr.GetDouble(1);

                MessageBox.Show(name + " " + dist.ToString());
            }

            rdr.Close();
            con.Close();
        }
    }
}
