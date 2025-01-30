using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace MoldCraft
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnFilter_Click(object sender, EventArgs e)
        {

        }
        
        protected void btnComprarRepeater_Click(object sender, EventArgs e)
        {

        }

        protected void btnNbaby_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 0;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }

        protected void btnMmimo_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 1;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }

        protected void btnkitlirio_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 2;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }

        protected void btnNrocambole_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 3;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }

        protected void btnNiris_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 4;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }
        protected void btnNcravo_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 5;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }

        protected void btnNgirassol_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 6;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }

        protected void btnNorquidia_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 7;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }

        protected void btnNjasmim_Click(object sender, EventArgs e)
        {
            Session.Remove("ssnDetalhes");
            int detalhes = 8;
            Session["ssnDetalhes"] = detalhes;

            Response.Redirect("DetalhesMolde.aspx");
        }

       
    }
}