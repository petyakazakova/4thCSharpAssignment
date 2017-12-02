<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PatientDashboard.aspx.cs" Inherits="_4thCSharpHandIn.PatientDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">

        <br />
        <br />
        <asp:Label ID="LabelPDash" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonEditP" runat="server" CssClass="button" OnClick="ButtonEditP_Click" Text="Edit patient" />
        <asp:Button ID="ButtonLogout" runat="server" CssClass="button" OnClick="ButtonLogout_Click" Text="Logout" />
        <br />
        <br />
        <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>
        <br />

    </div>
    <br />
</asp:Content>
