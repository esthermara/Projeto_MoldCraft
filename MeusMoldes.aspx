<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MeusMoldes.aspx.cs" Inherits="MoldCraft.MeusMoldes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="header">
        <h3>Meus Moldes</h3>
    </div>
    
    <!-- Lista de Moldes do Usuário -->
    <div class="product-list">
        <div class="product-item">
            <img src="./Images/kitlirio.PNG" alt="Molde 1">
            <div class="product-details">
                <h3>Molde 1</h3>
                <p>Descrição do molde 1.</p>
                <span>R$ 10,00</span>
                <div class="action-buttons">
                    <asp:Button ID="btnEditar" runat="server" Text="Editar" CssClass="btn-edit" OnClick="btnEditarMolde_Click" />
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn-delete" OnClick="btnExcluirMolde_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
