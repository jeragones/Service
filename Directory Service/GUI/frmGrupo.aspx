<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="frmGrupo.aspx.cs" Inherits="Directory_Service.frmGrupo" %>

<asp:Content ID="menuContent" ContentPlaceHolderID="MenuContent" runat="server">
    <div class="clear hideSkiplink">
        <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="frmInicio.aspx" Text="Inicio"/>
                <asp:MenuItem NavigateUrl="frmUsuario.aspx" Text="Usuarios"/>
                <asp:MenuItem NavigateUrl="frmRol.aspx" Text="Roles"/>
            </Items>
        </asp:Menu>
    </div>
</asp:Content>
<asp:Content ID="mainContent" ContentPlaceHolderID="MainContent" runat="server">
    <h4>
        Grupos
    </h4>
    <table id="tablaGrupo">
    </table>
    
</asp:Content>
