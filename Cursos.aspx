<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="MoldCraft.Cursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Banner Superior -->
    <div class="banner">
        <img src="./Images/bannerCursos.jpg" alt="Banner Cursos">
        <div class="banner-text">
            <p>Aprenda técnicas incríveis e aperfeiçoe suas habilidades com nossos tutoriais.</p>
        </div>
    </div>

    <!-- Filtros -->
    <div class="search-filters">
        <h4>Filtros</h4>
        <br />
        <asp:Panel ID="filterPanel" runat="server" CssClass="filter-panel">
            <!-- Filtro por nome -->
            <div class="form-group">
                <label for="txtSearchName">Nome:</label>
                <asp:TextBox ID="txtSearchName" runat="server" CssClass="form-control" placeholder="Digite o nome do vídeo" />
            </div>

            <div class="form-group">
                <asp:Button ID="btnFilter" runat="server" Text="Filtrar" CssClass="btn-filter" OnClick="btnFilter_Click" />
            </div>
        </asp:Panel>
    </div>

    <!-- Lista de Vídeos -->
    <div class="video-section">
        <h3>Vídeos Disponíveis</h3>
        <br />
        <asp:Repeater ID="repeaterVideos" runat="server">
            <ItemTemplate>
                <div class="video-item">
                    <img src='<%# Eval("Imagem") %>' alt='<%# Eval("Nome") %>' style="width: 100%; max-width: 200px;" />
                    <div class="video-details">
                        <h3><%# Eval("Nome") %></h3>
                        <p>Duração: <%# Eval("Duracao") %></p>
                        <asp:Button ID="btnAssistir" runat="server" Text="Assistir" CssClass="btn-watch" 
                            CommandArgument='<%# Eval("Link") %>' OnClick="btnAssistir_Click" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

</asp:Content>