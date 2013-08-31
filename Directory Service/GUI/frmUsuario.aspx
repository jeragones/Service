<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="frmUsuario.aspx.cs" Inherits="Directory_Service.frmUsuario" %>

<asp:Content ID="headContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="menuContent" ContentPlaceHolderID="MenuContent" runat="server">
    <div class="clear hideSkiplink">
        <asp:Menu ID="NavigationMenu1" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="frmInicio.aspx" Text="Inicio"/>
                <asp:MenuItem NavigateUrl="frmGrupo.aspx" Text="Grupos"/>
                <asp:MenuItem NavigateUrl="frmRol.aspx" Text="Roles"/>
            </Items>
        </asp:Menu>
    </div>
</asp:Content>
<asp:Content ID="mainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Usuarios
    </h4>
    <table id="tablaUsuario">
    </table>
</asp:Content>
