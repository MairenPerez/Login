using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Label = System.Web.UI.WebControls.Label;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected HtmlGenericControl h1; // Add this line to declare h1  

        private void page_Load(object sender, EventArgs e)
        {
            // Verificiamos si la página se está cargando por primera vez
            if (!IsPostBack)
            {
                // Verificamos si el usuario ya se había logeado antes
                if (Session["Username"] != null)
                {
                    // Una vez logeado, saludamoos al usuario.
                    string username = Session["Username"].ToString();
                    h1.InnerText = $"!Hola, {username}";
                }
            }
        }
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtPassword.Text;

            // Verificamos si los campos no son null
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblPassword.Text = "Por favor, ingrese correctamente los datos";
                return;
            }
            else
            {
                Label h1Element = (Label)(FindControl("aspnetTitle"));
                if (h1Element != null)
                {
                    h1Element.Text = $"!Hola, {username}";
                }
            }
        }
    }
}