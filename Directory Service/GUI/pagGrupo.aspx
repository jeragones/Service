<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="pagGrupo.aspx.cs" Inherits="Directory_Service._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" CssClass="panelBody" runat="server" ContentPlaceHolderID="MainContent" Orientation="Horizontal">
    
    <div class="backMenu">
        <asp:Menu ID="OptionMenu" runat="server" CssClass="option" EnableViewState="false" IncludeStyleBlock="false" Orientation="Vertical">
            <Items>
                <asp:MenuItem NavigateUrl="" Text="Nuevo"/>
                <asp:MenuItem NavigateUrl="" Text="Buscar"/>
            </Items>
        </asp:Menu>
    </div>
    <h2>
        Grupos
    </h2>
    jajajaja si funca
</asp:Content>
