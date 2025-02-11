using System;
using System.Web.UI;

namespace MoldCraft
{
    public partial class DetalhesMolde : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Recupera o nome do molde da query string
                string nomeMolde = Request.QueryString["molde"];

                if (!string.IsNullOrEmpty(nomeMolde))
                {
                    // Exibe os detalhes do molde correspondente
                    ExibirDetalhesMolde(nomeMolde);
                }
                else
                {
                    lblMensagemErro.Text = "Molde não especificado.";
                    lblMensagemErro.Visible = true;
                }
            }
        }

        private void ExibirDetalhesMolde(string nomeMolde)
        {
            // Mapeia o nome do molde para os detalhes correspondentes
            switch (nomeMolde)
            {
                case "Molde Mala Tulipa":
                    imgMolde.ImageUrl = "~/Images/Mtulipa.png";
                    lblNomeMolde.Text = "Molde Mala Tulipa";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 0,5 mm a 1cm.";
                    break;
                case "Molde Kit Mochila e Necessaire Mimo":
                    imgMolde.ImageUrl = "~/Images/Mmimo.png";
                    lblNomeMolde.Text = "Molde Kit Mochila e Necessaire Mimo";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 0,5 mm a 1cm.";
                    break;
                case "Molde Kit Mala e Necessaire Lírio":
                    imgMolde.ImageUrl = "~/Images/kitlirio.png";
                    lblNomeMolde.Text = "Molde Kit Mala e Necessaire Lírio";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 0,5 mm a 1cm.";
                    break;
                case "Molde Necessaire Rocambole":
                    imgMolde.ImageUrl = "~/Images/Nrocambole.png";
                    lblNomeMolde.Text = "Molde Necessaire Rocambole";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 0,5 mm a 1cm.";
                    break;
                case "Molde Necessaire Íris":
                    imgMolde.ImageUrl = "~/Images/Niris.png";
                    lblNomeMolde.Text = "Molde Necessaire Íris";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 1cm.";
                    break;
                case "Molde Necessaire Cravo":
                    imgMolde.ImageUrl = "~/Images/Ncravo.png";
                    lblNomeMolde.Text = "Molde Necessaire Cravo";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 0,5 mm a 1cm.";
                    break;
                case "Molde kit Necessaire Maleta Girassol":
                    imgMolde.ImageUrl = "~/Images/Ngirassol.png";
                    lblNomeMolde.Text = "Molde kit Necessaire Maleta Girassol";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 0,5 mm a 1cm.";
                    break;
                case "Molde Necessaire Orquídea":
                    imgMolde.ImageUrl = "~/Images/Norquidea.png";
                    lblNomeMolde.Text = "Molde Necessaire Orquídea";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 0,5 mm a 1cm.";
                    break;
                case "Molde Necessaire Jasmim":
                    imgMolde.ImageUrl = "~/Images/Njasmim.png";
                    lblNomeMolde.Text = "Molde Necessaire Jasmim";
                    lblCategoria.Text = "Acessórios";
                    lblCriador.Text = "Esther";
                    lblDescricao.Text = "Este molde já contém margem de costura de 1cm.";
                    break;
                default:
                    imgMolde.ImageUrl = "~/Images/logoMoldCraft.png";
                    lblMensagemErro.Text = "Molde não encontrado.";
                    lblMensagemErro.Visible = true;
                    break;
            }
        }

        protected void btnDownload_Click(object sender, EventArgs e)
        {
            // Recupera o nome do molde da query string
            string nomeMolde = Request.QueryString["molde"];

            if (!string.IsNullOrEmpty(nomeMolde))
            {
                // Redireciona para o link do Google Drive correspondente
                switch (nomeMolde)
                {
                    case "Molde Mala Tulipa":
                        Response.Redirect("https://drive.google.com/drive/folders/1A49r3feZq40zgcOA2DrVd-Z00qjJnDHK?usp=sharing");
                        break;
                    case "Molde Kit Mochila e Necessaire Mimo":
                        Response.Redirect("https://drive.google.com/drive/folders/1-TGAwJFj1ITbt61gVCLtSGfgqV8lDF0h?usp=sharing");
                        break;
                    case "Molde Kit Mala e Necessaire Lírio":
                        Response.Redirect("https://drive.google.com/drive/folders/1-Qalf4hhiyQcAGjDAKp7yJUaBQIPkeMD?usp=sharing");
                        break;
                    case "Molde Necessaire Rocambole":
                        Response.Redirect("https://drive.google.com/drive/folders/1jd26tDZHmxGQQ3Cvxlgnw-Vyjk_sSgAZ?usp=sharing");
                        break;
                    case "Molde Necessaire Íris":
                        Response.Redirect("https://drive.google.com/drive/folders/1JBU4UAh3HvjECQko49HsZTHFm_LjjdzS?usp=sharing");
                        break;
                    case "Molde Necessaire Cravo":
                        Response.Redirect("https://drive.google.com/drive/folders/1-Gsb7vT4sp-BDz-QqRp8flyWW-kcl1dV?usp=sharing");
                        break;
                    case "Molde kit Necessaire Maleta Girassol":
                        Response.Redirect("https://drive.google.com/drive/folders/1sQyk1r6gyi5f1hGcr6oDfOYZ1dGiHI3N?usp=sharing");
                        break;
                    case "Molde Necessaire Orquídea":
                        Response.Redirect("https://drive.google.com/drive/folders/1lKb5BgBsHKKUev1PpLACoU_66qYUMfYl?usp=sharing");
                        break;
                    case "Molde Necessaire Jasmim":
                        Response.Redirect("https://drive.google.com/drive/folders/1KR5_Rw-1tWOosG8DMfeXjf7GypXWSB3t?usp=sharing");
                        break;
                    default:
                        lblMensagemErro.Text = "Molde não encontrado.";
                        lblMensagemErro.Visible = true;
                        break;
                }
            }
            else
            {
                lblMensagemErro.Text = "Molde não especificado.";
                lblMensagemErro.Visible = true;
            }
        }
    }
}