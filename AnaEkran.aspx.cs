using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EkütüphaneWEB1
{
    public partial class AnaEkran : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void girisyap_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("GirisEkran.aspx?s=2");


        }

        protected void kayıtol_button_Click(object sender, EventArgs e)
        {
            Response.Redirect("KayıtEkran.aspx?s=1");
        }
    }
}