using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        private readonly Dictionary<string, string> users = new Dictionary<string, string>
            {
                { "admin", "admin" },
                { "usuario1", "1234" }
            };

        protected void Page_Load(object sender, EventArgs e)
        {
            // Verificar si ya hay una sesión activa
            if (Session["Username"] != null)
            {
                LabelMessage.Text = "Bienvenido " + Session["Username"];
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                LabelMessage.Text = "Por favor, ingrese correctamente los datos.";
                return;
            }

            if (users.TryGetValue(username, out string storedPassword) && storedPassword == password)
            {
                Session["Username"] = username;
                LabelMessage.Text = "Bienvenido " + username;

                // Actualizar el LabelBienvenida en SiteMaster
                if (Master is SiteMaster master)
                {
                    master.LabelBienvenida.InnerText = "Hola, " + username;
                    master.LabelBienvenida.HRef = "~/Bienvenida";
                }
            }
            else
            {
                LabelMessage.Text = "Usuario o contraseña incorrectos.";
            }
        }
    }
}
