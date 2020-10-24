using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkütüphaneWEB1
{
    public partial class GirisEkran : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from KullaniciTable1 Where Kullaniciadi='" + kullanicitxt.Text + "'and Sifre='" + sifretxt.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            Session.Add("KullaniciAdi", kullanicitxt);
            if (dr.Read())
            {
                Session["KullaniciAdi"] = dr["KullaniciAdi"].ToString();
                String k = dr["KullaniciAdi"].ToString();
                if (k == "admin")
                {
                    Response.Redirect("AdminEkranı.aspx");

                }
                else
                {
                    Response.Redirect("KullanıcıEkranı.aspx");

                }

            }
            else
            {
                Response.Write("Kullanıcı adı veya sifresi yanlış!");
            }
        }
    }
}