<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="MoldCraft.Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-container">
        <h1>Entre em Contato</h1>
        <p>Tem dúvidas ou precisa de suporte? Preencha o formulário abaixo.</p>

        <label for="nome">Nome:</label>
        <asp:TextBox ID="TextBoxNome" runat="server" />

        <label for="email">E-mail:</label>
        <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" />

        <label for="mensagem">Mensagem:</label>
        <asp:TextBox ID="TextBoxMensagem" runat="server" TextMode="MultiLine" Rows="5" />

        <%--<asp:Button ID="btnEnviar" runat="server" Text="Enviar Mensagem" OnClick="btnEnviar_Click" />--%>
    </div>
</asp:Content>
