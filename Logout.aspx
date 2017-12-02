<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="_4thCSharpHandIn.Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">

        <br />
        <br />
        
        <asp:Button ID="ButtonLogout" runat="server" CssClass="button" OnClick="ButtonLogout_Click1" Text="Logout" />
        
        <br />
        <asp:Label ID="LabelMessageLogout" runat="server" ForeColor="Green"></asp:Label>
        <br />

    </div>
</asp:Content>
