<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="MoldCraft.Cursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Banner Superior -->
    <div class="banner">
        <img src="./Images/bannerCursos.PNG" alt="Banner Cursos">
        <div class="banner-text">
            <h1>Venha aprender</h1>
            <p>Aprenda técnicas incríveis e aperfeiçoe suas habilidades com nossos tutoriais.</p>
        </div>
    </div>

    <!-- Lista de Vídeos -->
    <div class="video-section">
        <h3>Vídeos Disponíveis</h3>
        <br />
        <div class="video-list">
            <!-- Exemplo de vídeo -->
            <div class="video-item">
                <img src="./Images/imgvideos.jpg" alt="Título do Vídeo">
                <div class="video-details">
                    <h3>Como Fazer Moldes Básicos</h3>
                    <p>Duração: 10:15</p>
                    <asp:Button ID="btnAssistir1" runat="server" Text="Assistir" CssClass="btn-watch" />
                </div>
            </div>
            <!-- Repetir este bloco para outros vídeos -->
            <div class="video-item">
                <img src="./Images/imgvideos.jpg" alt="Título do Vídeo">
                <div class="video-details">
                    <h3>Aprenda a Cortar Tecidos Corretamente</h3>
                    <p>Duração: 15:30</p>
                    <asp:Button ID="btnAssistir2" runat="server" Text="Assistir" CssClass="btn-watch" />
                </div>
            </div>
            <div class="video-item">
                <img src="./Images/imgvideos.jpg" alt="Título do Vídeo">
                <div class="video-details">
                    <h3>Técnicas de Acabamento em Costura</h3>
                    <p>Duração: 20:00</p>
                    <asp:Button ID="btnAssistir3" runat="server" Text="Assistir" CssClass="btn-watch" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
