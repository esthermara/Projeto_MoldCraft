<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MoldCraft._Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="header">
        <h3>Bem-vindo à Plataforma de Moldes Digitais</h3>
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

    <!-- Lista de Moldes -->
    <div class="product-list">
        <asp:Repeater ID="repeaterMoldes" runat="server">
            <ItemTemplate>
                <div class="product-item">
                    <img src='<%# Eval("Imagem") %>' alt='<%# Eval("Nome") %>' style="width: 100%; max-width: 200px;" />
                    <div class="product-details">
                        <h3><%# Eval("Nome") %></h3>
                        <p>Categoria: <%# Eval("Categoria") %></p>
                        <asp:Button ID="btnBaixar" runat="server" Text="BAIXAR PDF GRÁTIS" CssClass="btn-baixar" 
                            CommandArgument='<%# Eval("Nome") %>' OnClick="btnBaixar_Click" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <!-- Anuncios -->
    <div class="anuncios">
        <h4>Anúncios</h4>
    </div>
</asp:Content>