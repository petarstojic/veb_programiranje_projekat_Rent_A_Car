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
    public partial class admin_dashboard : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        protected void Page_Load(object sender, EventArgs e)
        {
            popuni();
            popuni_rezervacije();
            popuni_lokacije();
            foreach (GridViewRow row in GridView1.Rows)
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
                GridView3.DataSource = reader;
                GridView3.DataBind();
            }
        }

        private void popuni_rezervacije()
        {
            SqlConnection conect = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            using (conect)
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand("select id as 'ID Klijenta', ime as Ime, prezime as Prezime, id_rezervisanog_auta as 'ID rezervisanog automobila', id_lokacije as 'ID lokacije preuzimanja' from rezervacije", conect);
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            TextBox1.Text = row.Cells[1].Text;
            TextBox2.Text = row.Cells[2].Text;
            TextBox3.Text = row.Cells[3].Text;
            TextBox4.Text = row.Cells[4].Text;
            TextBox5.Text = row.Cells[5].Text;
            TextBox6.Text = row.Cells[6].Text;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "")
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    using (conn)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("insert into automobili values('" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", conn);
                        cmd.ExecuteNonQuery();
                        popuni();
                        Response.Write("<script>alert('Podaci uneti!');</script>");
                    }
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                }
                else
                {
                    Response.Write("<script>alert('Popunite sva polja!');</script>");
                }
            }
            catch (Exception x)
            {
                Response.Write("<script>alert('Greska na serveru!');</script>");
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text != "")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    using (con)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("delete from automobili where id = " + TextBox1.Text, con);
                        cmd.ExecuteNonQuery();
                        popuni();
                        Response.Write("<script>alert('Podaci obrisani!');</script>");
                    }
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                }
                else Response.Write("<script>alert('Unesite ID automobila!');</script>");
            }
            catch (Exception x)
            {
                Response.Write("<script>alert('Greska na serveru!');</script>");
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text != "" && TextBox4.Text != "" && TextBox5.Text != "" && TextBox6.Text != "")
                {
                    SqlConnection kon = new SqlConnection(@"Data Source=DESKTOP-F2S0UAG\SQLEXPRESS;Initial Catalog=baza;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    using (kon)
                    {
                        kon.Open();
                        SqlCommand cmd = new SqlCommand("update automobili set marka_i_model = '" + TextBox2.Text + "', karoserija = '" + TextBox3.Text + "', tip_menjaca = '" + TextBox4.Text + "', broj_brzina = '" + TextBox5.Text + "', broj_dostupnih = '" + TextBox6.Text + "' where id = " + TextBox1.Text, kon);
                        cmd.ExecuteNonQuery();
                        popuni();
                        Response.Write("<script>alert('Podaci izmenjeni!');</script>");
                    }
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                }
                else
                {
                    Response.Write("<script>alert('Popunite sva polja!');</script>");
                }
            }
            catch (Exception x)
            {
                Response.Write("<script>alert('Greska na serveru!');</script>");
                System.Diagnostics.Debug.WriteLine(x.Message);
                System.Diagnostics.Debug.WriteLine(x.StackTrace);
            }
        }
    }
}