<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="frmInicio.aspx.cs" Inherits="Directory_Service.frmInicio" %>

<asp:Content ID="menuContent" ContentPlaceHolderID="MenuContent" runat="server">
    <div class="clear hideSkiplink">
        <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="frmGrupo.aspx" Text="Grupos"/>
                <asp:MenuItem NavigateUrl="frmUsuario.aspx" Text="Usuarios"/>
                <asp:MenuItem NavigateUrl="frmRol.aspx" Text="Roles"/>
            </Items>
        </asp:Menu>
    </div>
</asp:Content>
<asp:Content ID="mainContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Usuario:"></asp:Label></td>
            <td><asp:TextBox ID="txtRegUsuario" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label></td>
            <td><asp:TextBox ID="txtRegNombre" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label3" runat="server" Text="Grupo:"></asp:Label></td>
            <td><asp:TextBox ID="txtRegGrupo" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label4" runat="server" Text="Rol:"></asp:Label></td>
            <td><asp:TextBox ID="txtRegRol" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label5" runat="server" Text="Contraseña:"></asp:Label></td>
            <td><asp:TextBox ID="txtRegPass" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label6" runat="server" Text="Repetir contraseña:"></asp:Label></td>
            <td><asp:TextBox ID="txtRepPass" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnNuevo" runat="server" Text="Crear" 
                    onclick="btnNuevo_Click" />
            </td>
        </tr>
    </table>
</asp:Content>