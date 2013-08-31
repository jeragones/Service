<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmInicio.aspx.cs" MasterPageFile="~/Site.master" Inherits="Directory_Service.GUI.Form.frmUsuario" %>

<asp:Content ID="headContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="menuContent" ContentPlaceHolderID="MenuContent" runat="server">
    <form id="Form1" runat="server">
    <div class="clear hideSkiplink">
        <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="frmGrupo.aspx" Text="Usuarios"/>
                <asp:MenuItem NavigateUrl="frmUsuario.aspx" Text="Usuarios"/>
                <asp:MenuItem NavigateUrl="frmRol.aspx" Text="Roles"/>
            </Items>
        </asp:Menu>
    </div>
    </form>
</asp:Content>
<asp:Content ID="mainContent" ContentPlaceHolderID="MainContent" runat="server">
    grupos
</asp:Content>