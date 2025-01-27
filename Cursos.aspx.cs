using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoldCraft
{
    public partial class Cursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAssistir1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Video1.aspx"); // Página ou link do vídeo
        }

        protected void btnAssistir2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Video2.aspx");
        }

        protected void btnAssistir3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Video3.aspx");
        }
    }
}