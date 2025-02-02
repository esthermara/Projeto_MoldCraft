using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoldCraft
{
    public partial class Cursos : System.Web.UI.Page
    {
        // Classe para representar um vídeo
        [Serializable]
        public class Video
        {
            public string Nome { get; set; }
            public string Duracao { get; set; }
            public string Imagem { get; set; }
            public string Link { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cria uma lista de vídeos em memória
                List<Video> videos = new List<Video>
                {
                    new Video { Nome = "Como Fazer Moldes Básicos", Duracao = "10:15", Imagem = "./Images/imgvideos.jpg", Link = "https://www.youtube.com/watch?v=exemplo1" },
                    new Video { Nome = "Aprenda a Cortar Tecidos Corretamente", Duracao = "15:30", Imagem = "./Images/imgvideos.jpg", Link = "https://www.youtube.com/watch?v=exemplo2" },
                    new Video { Nome = "Técnicas de Acabamento em Costura", Duracao = "20:00", Imagem = "./Images/imgvideos.jpg", Link = "https://www.youtube.com/watch?v=exemplo3" },
                    new Video { Nome = "Costura Avançada para Iniciantes", Duracao = "25:45", Imagem = "./Images/imgvideos.jpg", Link = "https://www.youtube.com/watch?v=exemplo4" }
                };

                // Armazena a lista em ViewState para reutilização
                ViewState["Videos"] = videos;

                // Associa a lista ao Repeater
                repeaterVideos.DataSource = videos;
                repeaterVideos.DataBind();
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            // Recupera a lista de vídeos do ViewState
            List<Video> videos = ViewState["Videos"] as List<Video>;

            // Filtra por nome (se fornecido)
            string nomeFiltro = txtSearchName.Text.Trim();
            if (!string.IsNullOrEmpty(nomeFiltro))
            {
                videos = videos.Where(v => v.Nome.IndexOf(nomeFiltro, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            // Atualiza o Repeater com os resultados filtrados
            repeaterVideos.DataSource = videos;
            repeaterVideos.DataBind();
        }

        protected void btnAssistir_Click(object sender, EventArgs e)
        {
            // Recupera o botão que foi clicado
            Button btnAssistir = (Button)sender;

            // Recupera o argumento (link do vídeo) do botão
            string linkVideo = btnAssistir.CommandArgument;

            // Redireciona para o link do vídeo
            Response.Redirect(linkVideo);
        }
    }
}