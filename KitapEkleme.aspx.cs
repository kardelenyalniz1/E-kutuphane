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
    public partial class KitapEkleme : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        bool durum;
        void kontrol()
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

        protected void Button1_Click1(object sender, EventArgs e)
        {
      
            kontrol();
            if (durum == true)
            {
                //Görüntü işleme
                //https://stackoverflow.com/questions/38567100/failed-to-initialise-tesseract-engine-cant-find-correct-version
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                path = Path.Combine(path, "tessdata");
                path = path.Replace("file:\\", "");
                TextBox3.Text = path;
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
                TextBox5.Text = str;
                //ısbn no alma
                string ısbn = values[index + 1];
                string ısbn2 = values[index + 2];
                string ısbn3 = values[index + 3];
                string ısbnreel = ısbn + ısbn2 + ısbn3;
                int sayı = values.Length;
                string str1 = Convert.ToString(sayı);
                TextBox4.Text = ısbnreel;
                /* for (int i = 0; i < values.Length; i++)
                 {
                     TextBox4.Text =TextBox4.Text+ values[i] ;
                 }*/
                if (index == -1)
                {
                    Label2.Text = "index bulunamadı";

                }

                String name = "Images/" + FileUpload1.FileName;

                SqlConnection baglanti;
                SqlCommand komut;
                SqlDataAdapter da;
                baglanti = new SqlConnection("Data Source = .; Initial Catalog=EKütüphane; Integrated Security=true;");
                da = new SqlDataAdapter("Select *From KitapTable", baglanti);
                string sorgu = "Insert into KitapTable(KitapAdi,KitapYolu,ISBN) values (@kitapadi,@kitapyolu,@ısbn)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@kitapadi", TextBox1.Text);
                komut.Parameters.AddWithValue("@kitapyolu", name);
                komut.Parameters.AddWithValue("@ısbn", ısbnreel);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Label1.Text = "Kitap ekleme başarılı";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {

                TextBox6.Text = "Kitap zaten mevcut ";
            }
        }
    }
}
