<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MoldCraft._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header">
        <h3>Bem-vindo à Plataforma de Moldes Digitais</h3>
    </div>

    <!-- Exemplo de Lista de Moldes -->
    <div class="product-list">
        

        <div class="product-item">
            <img src="./Images/Nbaby.PNG" alt="Molde 1">
            <div class="product-details">
                <h3>Molde Necessaire Baby</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
        </div>

        <div class="product-item">
            <img src="./Images/Mmimo.PNG" alt="Molde 2">
            <div class="product-details">
                <h3>Molde Mochila Mimo</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
        </div>

        <div class="product-item">
            <img src="./Images/kitlirio.PNG" alt="Molde 2">
            <div class="product-details">
                <h3>Molde Kit Mala e Necessaire Lírio</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
        </div>

        <div class="product-item">
            <img src="./Images/Nrocambole.PNG" alt="Molde 1">
            <div class="product-details">
                <h3>Molde Necessaire Rocambole</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
        </div>

        <div class="product-item">
            <img src="./Images/Niris.PNG" alt="Molde 2">
            <div class="product-details">
                <h3>Molde Necessaire Íris</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
        </div>

        <div class="product-item">
            <img src="./Images/Ncravo.PNG" alt="Molde 2">
            <div class="product-details">
                <h3>Molde Necessaire Cravo</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
        </div>


         <div class="product-item">
            <img src="./Images/Ngirassol.PNG" alt="Molde 2">
            <div class="product-details">
                <h3>Molde Necessaire Maleta Girassol</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
        </div>

        <div class="product-item">
            <img src="./Images/Norquidea.PNG" alt="Molde 1">
            <div class="product-details">
                <h3>Molde Necessaire Orquídea</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
        </div>

        <div class="product-item">
            <img src="./Images/NJasmim.PNG" alt="Molde 2">
            <div class="product-details">
                <h3>Molde Necessaire Jasmim</h3>
                <a href="DetalhesMolde.aspx?id=<%# Eval("Id") %>">BAIXAR PDF GRÁTIS</a>
            </div>
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
                <asp:TextBox ID="txtSearchName" runat="server" CssClass="form-control" placeholder="Digite o nome" />
            </div>

            <!-- Filtro por categoria -->
            <div class="form-group">
                <label for="ddlCategory">Categoria:</label>
                <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Escolha a categoria" Value="" />
                    <asp:ListItem Text="Roupas" Value="Roupas" />
                    <asp:ListItem Text="Acessórios" Value="Acessórios" />
                    <asp:ListItem Text="Decoração" Value="Decoração" />
                    <asp:ListItem Text="Infantil" Value="Infantil" />
                    <asp:ListItem Text="Outros" Value="Outros" />
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <asp:Button ID="btnFilter" runat="server" Text="Filtrar" CssClass="btn-filter" OnClick="btnFilter_Click" />
            </div>
        </asp:Panel>
    </div>

    <!-- Anuncios -->
    <div class="anuncios">
        <h4>Anúncios</h4>
    </div>

    <!-- Lista de produtos -->
    <div class="product-list">
        <asp:Repeater ID="productRepeater" runat="server">
            <ItemTemplate>
                <div class="product-item">
                    <img src='<%# Eval("ImageURL") %>' alt="Produto" />
                    <div class="product-details">
                        <h3><%# Eval("Name") %></h3>
                        <p><%# Eval("Category") %></p>
                        <span>R$ <%# Eval("Price") %></span>
                        <asp:Button ID="btnBuy" runat="server" Text="Comprar" CssClass="btn-buy" OnClick="btnComprarRepeater_Click" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
