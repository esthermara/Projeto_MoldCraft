using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MoldCraft
{
    public partial class _Default : Page
    {
        // Classe para representar um molde
        [Serializable]
        public class Molde
        {
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public string Imagem { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Cria uma lista de moldes em memória
                List<Molde> moldes = new List<Molde>
                {
                    new Molde { Nome = "Molde Mala Tulipa", Categoria = "Acessórios", Imagem = "./Images/Mtulipa.PNG" },
                    new Molde { Nome = "Molde Kit Mochila e Necessaire Mimo", Categoria = "Outros", Imagem = "./Images/Mmimo.PNG" },
                    new Molde { Nome = "Molde Kit Mala e Necessaire Lírio", Categoria = "Acessórios", Imagem = "./Images/kitlirio.PNG" },
                    new Molde { Nome = "Molde Necessaire Rocambole", Categoria = "Acessórios", Imagem = "./Images/Nrocambole.PNG" },
                    new Molde { Nome = "Molde Necessaire Íris", Categoria = "Acessórios", Imagem = "./Images/Niris.PNG" },
                    new Molde { Nome = "Molde Necessaire Cravo", Categoria = "Acessórios", Imagem = "./Images/Ncravo.PNG" },
                    new Molde { Nome = "Molde kit Necessaire Maleta Girassol", Categoria = "Acessórios", Imagem = "./Images/Ngirassol.PNG" },
                    new Molde { Nome = "Molde Necessaire Orquídea", Categoria = "Acessórios", Imagem = "./Images/Norquidea.PNG" },
                    new Molde { Nome = "Molde Necessaire Jasmim", Categoria = "Acessórios", Imagem = "./Images/NJasmim.PNG" }
                };

                // Armazena a lista em ViewState para reutilização
                ViewState["Moldes"] = moldes;

                // Associa a lista ao Repeater
                repeaterMoldes.DataSource = moldes;
                repeaterMoldes.DataBind();
            }
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            // Recupera a lista de moldes do ViewState
            List<Molde> moldes = ViewState["Moldes"] as List<Molde>;

            // Filtra por nome (se fornecido)
            string nomeFiltro = txtSearchName.Text.Trim();
            if (!string.IsNullOrEmpty(nomeFiltro))
            {
                moldes = moldes.Where(m => m.Nome.IndexOf(nomeFiltro, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }

            // Filtra por categoria (se selecionada)
            string categoriaFiltro = ddlCategory.SelectedValue;
            if (!string.IsNullOrEmpty(categoriaFiltro))
            {
                moldes = moldes.Where(m => m.Categoria.Equals(categoriaFiltro, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Atualiza o Repeater com os resultados filtrados
            repeaterMoldes.DataSource = moldes;
            repeaterMoldes.DataBind();
        }

        protected void btnBaixar_Click(object sender, EventArgs e)
        {
            // Recupera o botão que foi clicado
            Button btnBaixar = (Button)sender;

            // Recupera o argumento (nome do molde) do botão
            string nomeMolde = btnBaixar.CommandArgument;

            // Redireciona para a página de detalhes, passando o nome do molde como parâmetro
            Response.Redirect($"DetalhesMolde.aspx?molde={Server.UrlEncode(nomeMolde)}");
        }
    }
}