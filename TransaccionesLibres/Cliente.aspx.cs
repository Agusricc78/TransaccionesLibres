using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TransaccionesLibres
{
	public partial class Cliente : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["PlazoInfo"];

                if (cookie != null)
                {

                    double taza = new int();
                    int plazo = new int();
                    double capital = new double();



                    taza = double.Parse(cookie["tasa"]);
                    plazo = int.Parse(cookie["plazo"]);
                    capital = double.Parse(cookie["capital"]);

                    cookie.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Add(cookie);

                    double montofinal = capital * Math.Pow((1 + (taza / 100)), plazo);

                    cookie["MontoFinal"] = montofinal.ToString();

                    lblCapital.Text = "Capital: $" + capital.ToString("F2");
                    lblPlazo.Text = "Plazo: " + plazo + " períodos";
                    lblTasa.Text = "Tasa: " + taza.ToString("F2") + "%";
                    lblResultado.Text = "Monto Final: $" + montofinal.ToString("F2");
                }
                else
                {
                    lblResultado.Text = "No se encontraron datos en la cookie";
                }
            }
        }

		
		





    }
}