using System;
using System.Web.UI.HtmlControls;

namespace WebApplication1
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        // Propiedad pública para acceder a LabelBienvenida
        public HtmlAnchor LabelBienvenida
        {
            get { return lblBienvenida; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Verificar si el usuario ha iniciado sesión
                if (Session["Username"] != null)
                {
                    lblBienvenida.InnerText = "Bienvenido, " + Session["Username"];
                    lblBienvenida.HRef = "~/Bienvenida"; // Página de bienvenida
                }
                else
                {
                    lblBienvenida.InnerText = "Iniciar sesión";
                    lblBienvenida.HRef = "~/Login"; // Página de inicio de sesión
                }
            }
        }
    }
}
