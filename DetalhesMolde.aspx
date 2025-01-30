<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalhesMolde.aspx.cs" Inherits="MoldCraft.DetalhesMolde" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="content">
        <div class="detalhes-molde">
            <div class="imagem">
                <asp:Image ID="imgMolde" runat="server" Width="20%" AlternateText="Imagem do Molde" />
            </div>
            <div class="info">
                <h1>
                    <asp:Label ID="lblNomeMolde" runat="server" /></h1>
                <p>
                    <strong>Categoria: </strong>
                    <asp:Label ID="lblCategoria" runat="server" />
                </p>
                <p>
                    <strong>Criador: </strong>
                    <asp:Label ID="lblCriador" runat="server" />
                </p>
                <p>
                    <strong>Descrição: </strong>
                    <asp:Label ID="lblDescricao" runat="server" />
                </p>
                <asp:Button ID="btnDownload" CssClass="button" runat="server" Text="Baixar Agora" OnClick="btnDownload_Click" />
            </div>
        </div>
        <asp:Label ID="lblMensagemErro" runat="server" CssClass="error-message" Visible="false"></asp:Label>
        <br />
        <!-- Direitos Autorais -->
        <div class="card">
            <h2>Direitos Autorais e Uso Responsável</h2>
            <p>Todos os moldes disponibilizados em nossa plataforma são protegidos por direitos autorais. Eles foram criados para uso pessoal e não devem ser revendidos, redistribuídos ou utilizados para fins comerciais sem a autorização do autor original.</p>
            <ul>
                <li>📜 Respeite os direitos dos criadores ao usar os moldes.</li>
                <li>🚫 A revenda ou redistribuição dos moldes disponíveis aqui é estritamente proibida.</li>
                <li>⚠️ Ao baixar um molde, você concorda em utilizá-lo apenas para fins pessoais e dentro das diretrizes da plataforma.</li>
            </ul>
            <p>Se você tiver dúvidas sobre os direitos de uso ou quiser relatar algum abuso, entre em contato com nossa equipe de suporte.</p>
        </div>

        <!-- Informações adicionais -->
        <div class="card">
            <h2>Por que escolher nossa plataforma?</h2>
            <ul>
                <li>✅ Moldes em formato PDF para facilitar a impressão</li>
                <li>✂️ Todos os moldes já incluem margem de costura, prontos para o corte</li>
                <li>📂 Links diretos para download sem complicações</li>
                <li>📄 Importante: Todos os moldes foram projetados para serem impressos exclusivamente em folha A4. Certifique-se de ajustar a configuração da sua impressora corretamente para evitar distorções no tamanho.</li>
                <li>💡 Dica de segurança: Sempre escaneie os arquivos baixados com um antivírus confiável antes de abri-los</li>
            </ul>
        </div>

        <!-- Seção de Download Seguro -->
        <div class="card">
            <h2>Download Seguro de Moldes Gratuitos</h2>
            <p>Oferecemos uma plataforma confiável para encontrar moldes gratuitos de alta qualidade. Garantimos a segurança do site, mas alertamos sobre a importância de ter cautela ao acessar links externos.</p>
            <ul>
                <li>🔒 Moldes 100% gratuitos, sem necessidade de cadastro ou pagamento</li>
                <li>⚠️ Verifique os arquivos antes de baixar para evitar riscos de vírus</li>
                <li>📧 Suporte ao usuário 24/7</li>
            </ul>
        </div>
    </div>
</asp:Content>
