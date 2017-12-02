<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_4thCSharpHandIn.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div style="background: url(/Styles/background.jpg) no-repeat center center fixed; background-size: cover; height: 700px; width: 100%;">
        
    <div class="myMenuBar">
</div>
<div class="header-wrap">
    <div style="display: flex; justify-content: center;">
        <br />
    </div>
    <div>
        &nbsp;</div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div>
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" style="font-size: 30px; font-family: 'Helvetica'; font-weight: 600;" Text="Welcome to Lyngby Tandplejecenter."></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" style="font-size: 22px; font-family: 'Helvetica'; font-weight: 600;" Text="Create new user account:"></asp:Label>
        <br />
        <br />
        <asp:Button ID="ButtonGoDentistsP" runat="server" CssClass="button" PostBackUrl="~/Dentist.aspx" Style="vertical-align: middle; text-align: center;" Text="Dentist" OnClick="ButtonGoDentistsP_Click" />
        <asp:Button ID="ButtonGoPatientsP" runat="server" CssClass="button" PostBackUrl="~/Patients.aspx" Text="Patient" OnClick="ButtonGoPatientsP_Click" />
    </div>
</div>
 </div> 
</asp:Content>
