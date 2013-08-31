<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Directory_Service._Default" %>

<asp:Content ID="headerContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="mainContent" runat="server" ContentPlaceHolderID="MainContent">
    <table>
        <tr>
            <td><asp:Label ID="Label1" cssClass="lblLogin" runat="server" Text="Usuario:"></asp:Label></td>
            <td><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="Label2" cssClass="lblLogin" runat="server" Text="Contraseña:"></asp:Label></td>
            <td><asp:TextBox ID="txtPass" runat="server" TextMode="password" ></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="btnLogin" runat="server" Text="Iniciar" onclick="btnLogin_Click" /></td>
        </tr>
    </table>
</asp:Content>
