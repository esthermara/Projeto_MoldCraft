<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Configuracoes.aspx.cs" Inherits="MoldCraft.Configuracoes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="config-form">
        <h3>Configurações de Conta</h3>
        <br />
        <label for="TextBoxNome">Nome:</label>
        <asp:TextBox ID="TextBoxNome" runat="server" CssClass="form-input" />

        <br />
        <label for="TextBoxEmail">E-mail:</label>
        <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="form-input" />

        <br />
        <label for="TextBoxSenha">Senha:</label>
        <asp:TextBox ID="TextBoxSenha" runat="server" TextMode="Password" CssClass="form-input" />

        <br />
        <label for="TextBoxNovaSenha">Nova Senha:</label>
        <asp:TextBox ID="TextBoxNovaSenha" runat="server" TextMode="Password" CssClass="form-input" />

        <br />
        <label for="TextBoxConfirmarNovaSenha">Confirmar Nova Senha:</label>
        <asp:TextBox ID="TextBoxConfirmarNovaSenha" runat="server" TextMode="Password" CssClass="form-input" />

        <br />
        <h4>Escolha o tipo de conta:</h4>
        <asp:RadioButtonList ID="rblTipoUsuario" runat="server" CssClass="form-radio">
            <asp:ListItem Text="Usuário Comum" Value="usuario" Selected="True"></asp:ListItem>
            <asp:ListItem Text="Criador" Value="Criador"></asp:ListItem>
        </asp:RadioButtonList>

        <br />
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar Configurações" OnClick="btnSalvar_Click" CssClass="btn-save" />
    </div>
</asp:Content>
