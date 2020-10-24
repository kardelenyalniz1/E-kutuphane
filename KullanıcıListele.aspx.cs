using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkütüphaneWEB1
{
    public partial class KullanıcıListele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataAdapter da;
            SqlDataReader reader;

            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            komut = new SqlCommand("SELECT Kullaniciadi,Adi,Soyadi,Sifre FROM KullaniciTable1", baglanti);

            try
            {
                baglanti.Open();
                reader = komut.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                reader.Close();
            }
            catch
            {
                Response.Write("Bir hata oluştu");
            }
            finally
            {
                baglanti.Close();
            }
        }
     
    
    }
}