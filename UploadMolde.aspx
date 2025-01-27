<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadMolde.aspx.cs" Inherits="MoldCraft.UploadMolde" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="form-container">
        <h3>Cadastro de Molde</h3>

        <!-- Nome do Molde -->
        <br />
        <label for="NomeMolde">Nome do Molde:</label>
        <asp:TextBox ID="TextBoxNomeMolde" runat="server" CssClass="form-input" />
        <br />

        <!-- Categoria do Molde -->
        <label for="CategoriaMolde">Categoria:</label>
        <asp:DropDownList ID="DropDownListCategoria" runat="server" CssClass="form-input">
            <asp:ListItem Text="Escolha a categoria" Value="" />
            <asp:ListItem Text="Roupas" Value="Roupas" />
            <asp:ListItem Text="Acessórios" Value="Acessórios" />
            <asp:ListItem Text="Decoração" Value="Decoração" />
            <asp:ListItem Text="Infantil" Value="Infantil" />
            <asp:ListItem Text="Outros" Value="Outros" />
        </asp:DropDownList>
        <br />

        <!-- Descrição do Molde -->
        <label for="DescricaoMolde">Descrição do Molde:</label>
        <asp:TextBox ID="TextBoxDescricaoMolde" runat="server" TextMode="MultiLine" Rows="4" CssClass="form-input" />
        <br />

        <!-- Link do Molde -->
        <label for="LinkMolde">Link para o Molde (ex: Google Drive):</label>
        <asp:TextBox ID="TextBoxLinkMolde" runat="server" CssClass="form-input" Placeholder="Cole o link aqui" />
        <br />

        <!-- Preço do Molde -->
        <label for="NomeCriador">Nome do criador do molde:</label>
        <asp:TextBox ID="TextBoxNome" runat="server" CssClass="form-input" />
        <br />

        <!-- Botão de Salvar -->
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar Molde" OnClick="btnSalvarMolde_Click" CssClass="btn-save" />
    </div>

</asp:Content>
