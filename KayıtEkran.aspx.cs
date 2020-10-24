using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace EkütüphaneWEB1
{
    public partial class KayıtEkran : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool durum;
        void kontol()
        {
            SqlConnection baglanti;
            SqlCommand komut;
            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            komut = new SqlCommand("Select * from KullaniciTable1 where KullaniciAdi=@k", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@k", kullanicitxt.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            kontol();
            if (durum == true)
            {

                SqlConnection con = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
                con.Open();

                SqlCommand cmd = new SqlCommand("Insert into KullaniciTable1(Kullaniciadi,Adi,Soyadi,Sifre) values ('" + kullanicitxt.Text + "','" + aditxt.Text + "','" + soyaditxt.Text + "','" + sifretxt.Text + "') ", con);
                cmd.ExecuteNonQuery();
                Response.Redirect("GirisEkran.aspx");
            }
            else
            {
                Response.Write("Kullanici zaten kayıtlı");
            }
        }


    }
}