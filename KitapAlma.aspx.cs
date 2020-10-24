using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkütüphaneWEB1
{
    public partial class KitapAlma : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            SqlConnection baglanti;
            SqlCommand komut;
            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            SqlDataReader reader;
            SqlDataAdapter adptr = new SqlDataAdapter("Select KitapAdi from KitapTable", baglanti);
            baglanti.Open();
            DataTable tbl = new DataTable();
            adptr.Fill(tbl);
            DropDownList1.DataSource = tbl;
            DropDownList1.DataValueField = "KitapAdi";
            DropDownList1.DataBind();


        }
        bool durum1;
        bool durum2;
        bool durum3;

        //aynı kitap varsa engelleme durum 
        //false ise kitap var demektir engel ol
        void kontrol1()
        {
            String kitapadi = DropDownList1.SelectedItem.Value;

            SqlConnection baglanti;
            SqlCommand komut;
            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            komut = new SqlCommand("Select * from KullaniciKitap1 where Kitap=@k", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@k", kitapadi);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum1 = false;
            }
            else
            {
                durum1 = true;
            }
            baglanti.Close();
        }

        //kullanici adı 3 ü geçtiyse engelleme false dönüyorsa alamaz
        void kontrol2()
        {
            object kullaniciadi = Session["KullaniciAdi"].ToString();
            String kaddi = kullaniciadi.ToString();
            SqlConnection baglanti;
            SqlCommand komut;
            SqlDataReader reader;

            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            baglanti.Open();
            String sorgu = "Select COUNT(KullaniciAdi) As Adet From KullaniciKitap1 Where KullaniciAdi Like '" + kaddi + "'";
            komut = new SqlCommand(sorgu, baglanti);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                String isbn = reader["Adet"].ToString();
                int adet;
                adet = Convert.ToInt32(isbn);

                if (adet >=3)
                {
                    durum2 = false;
                }
                else
                {
                    durum2 = true;
                }
            }
            reader.Close();

            baglanti.Close();

        }
        //teslim tarihi gecikmiş kitap engeli
        //true ise kitap verilmez
        void kontrol3()
        {
            object kullaniciadi = Session["KullaniciAdi"].ToString();
            String kitapadi = DropDownList1.SelectedItem.ToString();

            String kaddi = kullaniciadi.ToString();
            SqlConnection baglanti;
            SqlConnection baglanti2;

            SqlCommand komut;
            SqlCommand komut2;


            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            baglanti2 = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");

            String sorgu = "Select Tarih From KullaniciKitap1 Where KullaniciAdi Like '" + kaddi + "' AND Kitap Like '" + kitapadi + "'";
            String sorgu2 = "Select TeslimTarihi From KullaniciKitap1 Where KullaniciAdi Like '" + kaddi + "' AND Kitap Like '" + kitapadi + "'";

            komut = new SqlCommand(sorgu, baglanti);
            komut2 = new SqlCommand(sorgu2, baglanti2);
            baglanti.Open();
            baglanti2.Open();

            SqlDataReader reader = komut.ExecuteReader();
            SqlDataReader reader2 = komut2.ExecuteReader();

            while (reader.Read() && reader2.Read())
            {
                String tarih = reader["Tarih"].ToString();
                String Teslimtarih = reader2["TeslimTarihi"].ToString();
                DateTime tarih1 = DateTime.Parse(tarih);
                DateTime Teslimt = DateTime.Parse(Teslimtarih);
                int result = DateTime.Compare(tarih1, Teslimt);

                if (result < 0)
                {//tarih Teslimtarihten küçükse
                 //tarih geçmemiş
                    durum3 = false;
                }
                else if(result>0)
                {//Ttarih geçmiş
                    durum3 = true;
                }
            }
            reader.Close();
            baglanti.Close();
            baglanti2.Close();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            kontrol1();
            kontrol2();
            kontrol3();
            //&& durum1==true durum2 == true && durum3 == false
            if ( durum1 == true && durum2==true && durum3 == false)
            {
                String kitapadi = DropDownList1.SelectedItem.Value;
                TextBox1.Text = kitapadi;
                DateTime dateTime = DateTime.Now;
                String date = dateTime.ToString("MM/dd/yyyy");
                TextBox2.Text = date;
                object kullaniciadi = Session["KullaniciAdi"].ToString();
                String kaddi = kullaniciadi.ToString();
                DateTime BirHaftaSonrası = DateTime.Now.AddDays(7);
                String dateafter = BirHaftaSonrası.ToString("MM/dd/yyyy");
                TextBox3.Text = dateafter;

                SqlConnection baglanti;
                SqlConnection baglanti2;

                SqlCommand komut;
                SqlCommand komut2;
                SqlDataReader reader;
          
                baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
                baglanti2 = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
                string sorgu = "Insert into KullaniciKitap1(KullaniciAdi,Kitap,ISBN,Tarih,TeslimTarihi) values " +
                            "(@kadi,@kitap,@isbn,@tarih,@teslimtarihi)";
                komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                komut.Parameters.AddWithValue("@kadi", kaddi);
                komut.Parameters.AddWithValue("@kitap", kitapadi);
                komut.Parameters.AddWithValue("@tarih", date);
                komut.Parameters.AddWithValue("@teslimtarihi", dateafter);

                // string sorgu2 = "Select ISBN From KitapTable where KitapAdi Like '" + kitapadi + "'";
                // komut2 = new SqlCommand(sorgu2, baglanti2);
                string sorgu2 = "Select ISBN From KitapTable where KitapAdi=@kitapadi ";
                komut2 = new SqlCommand(sorgu2, baglanti2);
                komut2.Parameters.AddWithValue("@kitapadi", kitapadi);
                baglanti2.Open();
                reader = komut2.ExecuteReader();

                if (reader.Read())
                {


                    String isbn1 = reader["ISBN"].ToString();
                    komut.Parameters.AddWithValue("@isbn", isbn1);
                }
                else
                {
                    Response.Write("Bir hata var");
                }

                reader.Close();

                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                baglanti.Close();
                baglanti2.Close();


                Label1.Text = "Kitap alma başarılı";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {/*
                if(durum1==false && durum2==false && durum3==false)
                {
                    Response.Redirect("UYARI KİTABI ALAMIYORSUNUZ ." +
                        "DİKKATE ALMADIĞINIZ UYARILARIMIZ :" +
                        "Alınmış bir kitabı seçmişsiniz " +
                        " En fazla 3 kitap alabilirsiniz" +
                        "Teslim Tarihi gemiş kitabınız bulunmaktadır");
                       
                }
                if(durum1==false && durum2== false && durum3==true)
                {
                    Response.Redirect("UYARI KİTABI ALAMIYORSUNUZ ." +
                        "DİKKATE ALMADIĞINIZ UYARILARIMIZ :" +
                        "En fazla 3 kitap alabilirsiniz" +
                        "Alınmış bir kitabı seçmişsiniz" );

                }
                if (durum1==false && durum2==true && durum3 == false)
                {
                    Response.Redirect("UYARI KİTABI ALAMIYORSUNUZ ." +
                        "DİKKATE ALMADIĞINIZ UYARILARIMIZ :" +
                        "Alınmış bir kitabı seçmişsiniz " +
                        "Teslim Tarihi gemiş kitabınız bulunmaktadır");
                       

                }
                if (durum1 == true && durum2 == false && durum3 == false)
                {

                    Response.Redirect("UYARI KİTABI ALAMIYORSUNUZ ." +
                        "DİKKATE ALMADIĞINIZ UYARILARIMIZ :" +
                        " En fazla 3 kitap alabilirsiniz" +
                        "Teslim Tarihi gemiş kitabınız bulunmaktadır");
                }
                if (durum1 == true && durum2 == false && durum3 == true)
                {

                    Response.Redirect("UYARI KİTABI ALAMIYORSUNUZ ." +
                        "DİKKATE ALMADIĞINIZ UYARILARIMIZ :" +
                        " En fazla 3 kitap alabilirsiniz");
                       
                }
                if (durum1 == true && durum2 == true && durum3 == false)
                {

                    Response.Redirect("UYARI KİTABI ALAMIYORSUNUZ ." +
                        "DİKKATE ALMADIĞINIZ UYARILARIMIZ :" +
                        "Teslim Tarihi gemiş kitabınız bulunmaktadır");
                }
                if (durum1 == false && durum2 == true && durum3 == true)
                {

                    Response.Redirect("UYARI KİTABI ALAMIYORSUNUZ ." +
                        "DİKKATE ALMADIĞINIZ UYARILARIMIZ :" +
                        "Alınmış bir kitabı seçmişsiniz ");
                }*/
               Label1.Text = "başarısız";
              }
        

        }
    }
}

 