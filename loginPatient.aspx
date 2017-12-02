<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginPatient.aspx.cs" Inherits="_4thCSharpHandIn.loginPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">

        <br />
        <br />
        <asp:Label ID="LabelLoginPheadline" runat="server" Text="Login as a patient:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelLoginPemail" runat="server" CssClass="label" Text="Email"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBoxPEmailLogIn" runat="server"></asp:TextBox>
        &nbsp;<br />
        <br />
        <asp:Label ID="LabelLoginPpass" runat="server" CssClass="label" Text="Password"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBoxLoginPpass" runat="server"></asp:TextBox>
        &nbsp;<br />
        <br />
        <asp:Button ID="ButtonLoginP" runat="server" CssClass="button" OnClick="ButtonLoginP_Click" Text="Login" />
        <asp:Button ID="ReadFileButton" runat="server" CssClass="button" OnClick="ReadFileButton_Click" Text="Read from file" />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="You don't have an account?"></asp:Label>
        <asp:Button ID="ButtonAddPatient" runat="server" CssClass="button" Text="Sign up" OnClick="ButtonAddPatient_Click" />
        <br />
        <br />
        <asp:Label ID="PatientLoginErrorMessage" runat="server" ForeColor="Red"></asp:Label>
        <asp:Label ID="PatientLoginMessage" runat="server" ForeColor="Green"></asp:Label>
        <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="PatGridview" align="center" runat="server" CssClass="centerAlign" OnSelectedIndexChanged="PatGridview_SelectedIndexChanged" Width="808px" Caption="Patients list">
        </asp:GridView>
        <br />
        <br />

    </div>
</asp:Content>
