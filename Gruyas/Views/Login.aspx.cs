using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;

namespace Gruyas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void LoginBtn_Click(object sender, DirectEventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                if (txtEmail.Text == "admin" && txtPassword.Text == "admin")
                {
                    Response.Redirect("Desktop.aspx");
                    LoginWindow.Close();
                }
                else
                {
                    X.Msg.Alert("UPS! Un error :/", "Al parecer tu información no es correcta, intenta nuevamente.").Show();
                }
            }
            else
            {
                X.Msg.Alert("UPS! Un error :/", "Los campos email y contraseña no pueden ir vacios!!").Show();       
            }
        }

        protected void RegisterBtn_Click(object sender, DirectEventArgs e)
        {
            RegisterUserWindow.Hidden = false;  
        }

        protected void Register_AddNewUser_Click(object sender, DirectEventArgs e)
        {
            string Errors = "Errores encontrados:<br><br>";

            if (Register_txtName.Text == "")
            {
                Errors += "- El campo \"Nombre\" no puede estar vacio.<br>";
            }
            if (Register_txtLastName.Text == "")
            {
                Errors += "- El campo \"Apellido\" no puede estar vacio.<br>";
            }
            if (Register_txtEmail.Text == "")
            {
                Errors += "- El campo \"Email\" no puede estar vacio.<br>";
            }
            if (Register_txtPassword.Text == "")
            {
                Errors += "- El campo \"Contraseña\" no puede estar vacio.<br>";
            }
            if (Register_txtRepetePassword.Text == "")
            {
                Errors += "- El campo \"Repetir Contraseña\" no puede estar vacio.<br>";
            }
            if (Register_txtPassword.Text != Register_txtRepetePassword.Text)
            {
                Errors += "- Tu contraseña en los campos \"Contraseña\"  y \"Repetir Contraseña\" no son iguales.<br>";
            }
            if (Errors != "")
            {
                X.Msg.Alert("Ups! Un error :/", Errors).Show();
            }
            
        }

        protected void Register_CleanFields_Click(object sender, DirectEventArgs e)
        {
            Register_txtName.Value = "";
            Register_txtLastName.Value = "";
            Register_txtEmail.Value = "";
            Register_txtPassword.Value = "";
            Register_txtRepetePassword.Value = "";
        }
    }
}