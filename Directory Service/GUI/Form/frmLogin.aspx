<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" MasterPageFile="~/Site.master" Inherits="Directory_Service.GUI.Form.frmLogin" %>

<html>
<head runat="server">
    <title></title>
</head>
<body>
<asp:Content ID="Content" ContentPlaceHolderID="MenuContent" runat="server">
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="Label1" cssClass="lblLogin" runat="server" Text="Usuario:"></asp:Label></td>
                <td><asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label2" cssClass="lblLogin" runat="server" Text="Contraseña:"></asp:Label></td>
                <td><asp:TextBox ID="txtPass" runat="server" type="password" ></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnLogin" runat="server" Text="Iniciar" onclick="btnLogin_Click" /></td>
            </tr>
        </table>
    </form>
</asp:Content>
</body>
</html>
