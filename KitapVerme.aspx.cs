using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tesseract;

namespace EkütüphaneWEB1
{
    public partial class KitapVerme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string ısbnreel;

        bool durum;
        void kontol()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            path = Path.Combine(path, "tessdata");
            path = path.Replace("file:\\", "");
            using (var engine = new TesseractEngine(path, "eng", EngineMode.Default))
            {

                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream);

                engine.SetVariable("tessedit_char_whitelist", "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                engine.SetVariable("tessedit_unrej_any_wd", true);

                var page = engine.Process(bitmap);
                TextBox2.Text = page.GetText();


            }
            //Parçalama
            String metin = TextBox2.Text;
            String[] values = metin.Split(' ');
            String search = "ISBN";
            int index = Array.IndexOf(values, search);
            string str = Convert.ToString(index);
            //ısbn no alma
            string ısbn = values[index + 1];
            string ısbn2 = values[index + 2];
            string ısbn3 = values[index + 3];
            ısbnreel = ısbn + ısbn2 + ısbn3;
            int sayı = values.Length;
            string str1 = Convert.ToString(sayı);
            SqlConnection baglanti;
            SqlCommand komut;
            baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
            komut = new SqlCommand("Select * from KullaniciKitap1 where ISBN=@k", baglanti);
            baglanti.Open();
            komut.Parameters.AddWithValue("@k",ısbnreel );
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
            if (durum == false)
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                path = Path.Combine(path, "tessdata");
                path = path.Replace("file:\\", "");
                using (var engine = new TesseractEngine(path, "eng", EngineMode.Default))
                {

                    System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(FileUpload1.PostedFile.InputStream);

                    engine.SetVariable("tessedit_char_whitelist", "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                    engine.SetVariable("tessedit_unrej_any_wd", true);

                    var page = engine.Process(bitmap);
                    TextBox2.Text = page.GetText();


                }
                //Parçalama
                String metin = TextBox2.Text;
                String[] values = metin.Split(' ');
                String search = "ISBN";
                int index = Array.IndexOf(values, search);
                string str = Convert.ToString(index);
                //ısbn no alma
                string ısbn = values[index + 1];
                string ısbn2 = values[index + 2];
                string ısbn3 = values[index + 3];
                ısbnreel = ısbn + ısbn2 + ısbn3;
                int sayı = values.Length;
                string str1 = Convert.ToString(sayı);

                String name = "Images/" + FileUpload1.FileName;
                SqlConnection baglanti;
                SqlCommand komut;
                SqlDataReader reader;
                baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
                string sorgu = "Delete From KullaniciKitap1 where ISBN Like '" + ısbnreel + "'";
                komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Response.Write("Kitap iadesi başarılı");
            }
            else
            {
                Response.Write("Bu ısbn numaralı kayıt yoktur.");

            }


        }
    }
}