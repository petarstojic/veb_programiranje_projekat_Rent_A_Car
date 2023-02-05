using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Automobili : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            prikazi();
        }

        private void prikazi()
        {
            using (connection)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("select marka_i_model as 'Marka i model', karoserija as Karoserija, tip_menjaca as 'Tip menjaca', broj_brzina as 'Broj stepeni prenosa', broj_dostupnih as 'Broj dostupnih vozila' from automobili", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
        }
    }
}