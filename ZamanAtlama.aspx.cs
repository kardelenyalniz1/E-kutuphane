using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkütüphaneWEB1
{
    public partial class ZamanAtlama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String atlanacakzaman = TextBox1.Text;
            int sayi = Convert.ToInt32(atlanacakzaman);
            SqlConnection baglanti;
            SqlCommand komut;
            SqlCommand komut2;

            SqlDataReader reader;

            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");

            /*string sorgu = "Select Tarih From KullaniciKitap1  ";
            baglanti.Open();
            komut = new SqlCommand(sorgu, baglanti);
            reader = komut.ExecuteReader();
            while(reader.Read())
            {
                String trh = reader["Tarih"].ToString();
                TextBox2.Text = trh;
                DateTime myDate = DateTime.Parse(trh);
                myDate=myDate.AddDays(sayi);
                String yeni = myDate.ToString("MM/dd/yyyy");
                TextBox3.Text = yeni;
                string sorgu2 = "Update KullaniciKitap1 set Tarih= @newtarih";
                komut2 = new SqlCommand(sorgu2, baglanti);
                komut2.Parameters.AddWithValue("newtarih", myDate);

            }

            reader.Close();
            komut.ExecuteNonQuery();
            //komut2.ExecuteNonQuery();
            */

        string sorgu = "Update KullaniciKitap1 set Tarih=DATEADD(dd,@gün,Tarih) ";
        komut = new SqlCommand(sorgu, baglanti);
        komut.Parameters.AddWithValue("@gün", sayi);
            baglanti.Open();
            komut.ExecuteNonQuery();
         baglanti.Close();



}
}
}
 