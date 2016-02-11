using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class enviacorreo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Correo objCorreo = new Correo("eepertuz6@misena.edu.co","prueba de notificaciones","eva sabeeee ");
            if (objCorreo.Estado)
            {
                Response.Write("la prueba ha sido un exito");
            }
            else
            {
                Response.Write("prueba fallida"+objCorreo.mensade_error);
            }
            
    }
    }
}