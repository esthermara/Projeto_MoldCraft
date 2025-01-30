using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoldCraft
{
    public partial class DetalhesMolde : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MetodoDetalhes();
            }
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            MetodoBaixar();
        }

        private void MetodoBaixar()
        {
            int detalhes = Convert.ToInt32(Session["ssnDetalhes"]);

            switch (detalhes)
            {
                case 0:
                    Response.Redirect("https://drive.google.com/drive/folders/1A49r3feZq40zgcOA2DrVd-Z00qjJnDHK?usp=sharing");

                    break;
                case 1:
                    Response.Redirect("https://drive.google.com/drive/folders/1-TGAwJFj1ITbt61gVCLtSGfgqV8lDF0h?usp=sharing");

                    break;
                case 2:
                    Response.Redirect("https://drive.google.com/drive/folders/1-Qalf4hhiyQcAGjDAKp7yJUaBQIPkeMD?usp=sharing");

                    break;
                case 3:
                    Response.Redirect("https://drive.google.com/drive/folders/1jd26tDZHmxGQQ3Cvxlgnw-Vyjk_sSgAZ?usp=sharing");
                    break;
                case 4:
                    Response.Redirect("https://drive.google.com/drive/folders/1JBU4UAh3HvjECQko49HsZTHFm_LjjdzS?usp=sharing");
                    break;
                case 5:
                    Response.Redirect("https://drive.google.com/drive/folders/1-Gsb7vT4sp-BDz-QqRp8flyWW-kcl1dV?usp=sharing");

                    break;
                case 6:
                    Response.Redirect("https://drive.google.com/drive/folders/1sQyk1r6gyi5f1hGcr6oDfOYZ1dGiHI3N?usp=sharing");

                    break;
                case 7:
                    Response.Redirect("https://drive.google.com/drive/folders/1lKb5BgBsHKKUev1PpLACoU_66qYUMfYl?usp=sharing");
                    break;
                case 8:
                    Response.Redirect("https://drive.google.com/drive/folders/1KR5_Rw-1tWOosG8DMfeXjf7GypXWSB3t?usp=sharing");

                    break;
                default:
                    
                    break;
            }
        }

        private void MetodoDetalhes()
        {
            int detalhes = Convert.ToInt32(Session["ssnDetalhes"]);

            switch (detalhes)
            {
                case 0:
                    imgMolde.ImageUrl = "~/Images/Mtulipa.png";
                    lblCategoria.Text = "Bolsas";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Linda necessaire.";
                    break;
                case 1:
                    imgMolde.ImageUrl = "~/Images/Mmimo.png";
                    lblCategoria.Text = "Mochilas";
                    lblCriador.Text = "Esther Mara";
                    lblDescricao.Text = "Mochila para o bebê.";
                    break;
                case 2:
                    imgMolde.ImageUrl = "~/Images/kitlirio.png";
                    lblCategoria.Text = "Mochilas";
                    lblCriador.Text = "Esther Mara";
                    lblDescricao.Text = "Mochila para o bebê.";
                    break;
                case 3:
                    imgMolde.ImageUrl = "~/Images/Nrocambole.png";
                    lblCategoria.Text = "Mochilas";
                    lblCriador.Text = "Esther Mara";
                    lblDescricao.Text = "Mochila para o bebê.";
                    break;
                case 4:
                    imgMolde.ImageUrl = "~/Images/Niris.png";
                    break;
                case 5:
                    imgMolde.ImageUrl = "~/Images/Ncravo.png";
                    lblCategoria.Text = "Mochilas";
                    lblCriador.Text = "Esther Mara";
                    lblDescricao.Text = "Mochila para o bebê.";
                    break;
                case 6:
                    imgMolde.ImageUrl = "~/Images/Ngirassol.png";
                    lblCategoria.Text = "Mochilas";
                    lblCriador.Text = "Esther Mara";
                    lblDescricao.Text = "Mochila para o bebê.";
                    break;
                case 7:
                    imgMolde.ImageUrl = "~/Images/Norquidea.png";
                    lblCategoria.Text = "Mochilas";
                    lblCriador.Text = "Esther Mara";
                    lblDescricao.Text = "Mochila para o bebê.";
                    break;
                case 8:
                    imgMolde.ImageUrl = "~/Images/Njasmim.png";
                    lblCategoria.Text = "Mochilas";
                    lblCriador.Text = "Esther Mara";
                    lblDescricao.Text = "Mochila para o bebê.";
                    break;
                default:
                    imgMolde.ImageUrl = "~/Images/logoMoldCraft.png";
                    break;
            }
        }
    }
}