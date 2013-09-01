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
            <td>&nbsp;</td>
            <td><asp:Button ID="btnLogin" runat="server" Text="Iniciar" onclick="btnLogin_Click" /></td>
        </tr>
    </table>
    <div>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="usuario" DataSourceID="sqlUsers">
            <Columns>
                <asp:BoundField DataField="usuario" HeaderText="usuario" ReadOnly="True" 
                    SortExpression="usuario" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" 
                    SortExpression="nombre" />
                <asp:BoundField DataField="contraseña" HeaderText="contraseña" 
                    SortExpression="contraseña" />
                <asp:BoundField DataField="grupo" HeaderText="grupo" SortExpression="grupo" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="sqlUsers" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT [usuario], [nombre], [contraseña], [grupo] FROM [Usuario]">
        </asp:SqlDataSource>

    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Insertar" />
    <asp:Button ID="Modificar" runat="server" onclick="Button2_Click" 
        Text="Modificar" />
    <asp:Button ID="Modificar0" runat="server" onclick="Button3_Click" 
        Text="Eliminar" />
    <asp:Button ID="Modificar1" runat="server" onclick="Button4_Click" 
        Text="Consultar" />
    <asp:Button ID="Modificar2" runat="server" onclick="Button5_Click" 
        Text="ConsultarTodo" />
    <asp:Button ID="Modificar3" runat="server" onclick="Button6_Click" 
        Text="Usuario" />
</asp:Content>
