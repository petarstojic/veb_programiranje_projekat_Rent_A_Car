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
    public partial class prijava : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        List<prijave> prijaves = new List<prijave>();
        protected void Page_Load(object sender, EventArgs e)
        {
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from prijave", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        prijaves.Add(new prijave(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3])));
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int br = 0;
            for (int i = 0; i < prijaves.Count; i++)
            {
                if (username.Text == prijaves[i].Username)
                {
                    if (password.Text == prijaves[i].Password)
                    {
                        br = 1;
                        if (prijaves[i].Admin == 1)
                        {
                            Response.Redirect("~/admin_dashboard.aspx");
                        }
                        if (prijaves[i].Admin == 0)
                        {
                            Response.Redirect("~/rezervacija.aspx");
                        }

                    }
                }
            }
            if (br==0)
            {
                ErrorLabel.Text = "Korisnicko ime ne postoji ili je lozinka neispravna!";
            }
        }
    }
}