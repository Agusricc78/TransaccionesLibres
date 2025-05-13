using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TransaccionesLibres
{
	public partial class Inicio : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
	

		}


		protected void btnCalcular_Click(object sender,EventArgs e)
		{
            HttpCookie mycookie = new HttpCookie("PlazoInfo");

            mycookie.Values["capital"] = txtcapita.Text;
            mycookie.Values["plazo"] = txtplazo.Text;
            mycookie.Values["tasa"] = txttasa.Text;
			mycookie.Expires = DateTime.Now.AddDays(1);
			Response.Cookies.Add(mycookie);
            Response.Redirect("Cliente.aspx");

        }








    }
}