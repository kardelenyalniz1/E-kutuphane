using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkütüphaneWEB1
{
    public partial class KitapArama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool durum;
        bool durum2;

        void kontol()
        {
            SqlConnection baglanti;
            SqlCommand komut;
            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            komut = new SqlCommand("Select * from KitapTable where KitapAdi=@k", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@k", TextBox1.Text);
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
        void kontol2()
        {
            SqlConnection baglanti;
            SqlCommand komut;
            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            komut = new SqlCommand("Select * from KitapTable where ISBN=@m", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@m", TextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum2 = false;
            }
            else
            {
                durum2 = true;
            }
            baglanti.Close();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            kontol();
            if (durum == false)
            {
                Label3.Text = "Kitap mevcuttur . ";

            }
            else
            {
                Label3.Text = "Bu kitap bulunmamaktadır.   ";

            }
         //   Response.Redirect("KullanıcıEkranı.aspx");

        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            kontol2();
            if (durum2 == false)
            {
                Label4.Text = "Kitap mevcuttur . ";

            }
            else
            {
                Label4.Text = "Bu kitap bulunmamaktadır.   ";

            }
         //   Response.Redirect("KullanıcıEkranı.aspx");
        }

    }
}