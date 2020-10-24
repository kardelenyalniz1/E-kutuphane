using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkütüphaneWEB1
{
    public partial class KullanıcıEkranı : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("KitapArama.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("KitapAlma.aspx");


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("KitapVerme.aspx");

        }
    }
}