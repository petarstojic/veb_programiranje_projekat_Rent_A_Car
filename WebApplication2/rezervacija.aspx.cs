using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication2
{
    public partial class rezervacija : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            popuni();
            popuni_lokacije();
            foreach (GridViewRow row in GridView1.Rows)
            {
                LinkButton lb = (LinkButton)row.Cells[0].Controls[0];
                lb.Text = "Izaberi";
            }
            foreach (GridViewRow row in GridView2.Rows)
            {
                LinkButton lb = (LinkButton)row.Cells[0].Controls[0];
                lb.Text = "Izaberi";
            }
        }
        private void popuni_lokacije()
        {
            SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            using (conect)
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand("select id as 'ID lokacije', naziv as 'Naziv', adresa as 'Adresa' from lokacije", conect);
                SqlDataReader reader = cmd.ExecuteReader();
                GridView2.DataSource = reader;
                GridView2.DataBind();
            }
        }
        private void popuni()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            using (connect)
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("select id as 'ID Vozila', marka_i_model as 'Marka i model', karoserija as Karoserija, tip_menjaca as 'Tip menjaca', broj_brzina as 'Broj stepeni prenosa', broj_dostupnih as 'Broj dostupnih vozila' from automobili", connect);
                SqlDataReader reader = cmd.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "")
                {
                    int ind = 0;
                    bool ok = false;
                    for (int i = 0; i < GridView1.Rows.Count; i++)
                    {
                        if (TextBox3.Text == GridView1.Rows[i].Cells[1].Text)
                        {
                            if (Convert.ToInt32(GridView1.Rows[i].Cells[6].Text) > 0)
                            {
                                ind = i;
                                ok = true;
                            }
                        }
                    }
                    if (ok == false)
                    {
                        Response.Write("<script>alert('Trenutno nema slobodnih automobila za marku koju ste odabrali!');</script>");
                    }
                    if (ok)
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                        using (conn)
                        {
                            conn.Open();
                            SqlCommand sqlCommand = new SqlCommand("insert into rezervacije values ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "')", conn);
                            sqlCommand.ExecuteNonQuery();
                            Response.Write("<script>alert('Rezervacija uspesno obavljena!');</script>");
                        }
                        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                        using (con)
                        {
                            con.Open();
                            SqlCommand sqlCommand = new SqlCommand("update automobili set broj_dostupnih = '" + (Convert.ToInt32(GridView1.Rows[ind].Cells[6].Text) - 1) + "' where id = " + TextBox3.Text, con);
                            sqlCommand.ExecuteNonQuery();
                            popuni();
                        }

                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                    }
                }
                else Response.Write("<script>alert('Popunite sva polja!');</script>");
            }
            catch (Exception x)
            {
                Response.Write("<script>alert('Neki podaci nisu pravilno uneti!');</script>");
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox3.Text = GridView1.Rows[GridView1.SelectedIndex].Cells[1].Text;
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox4.Text = GridView2.Rows[GridView2.SelectedIndex].Cells[1].Text;
        }
    }
}