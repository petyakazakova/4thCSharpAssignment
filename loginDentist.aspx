<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="loginDentist.aspx.cs" Inherits="_4thCSharpHandIn.loginDentist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign" >
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Login as a dentist:"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LabelLoginDemail" runat="server" CssClass="label" Text="Email"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBoxDEmailLogin" runat="server"></asp:TextBox>
        &nbsp;<br />
        <br />
        <asp:Label ID="LabelLoginDpass" runat="server" CssClass="label" Text="Password"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBoxLoginDpass" runat="server"></asp:TextBox>
        &nbsp;<br />
        <br />
        <asp:Button ID="ButtonLoginD" runat="server" CssClass="button" OnClick="ButtonLoginD_Click" Text="Login" />
        <asp:Button ID="ButtonReadFromFIle" runat="server" CssClass="button" OnClick="ButtonReadFromFIle_Click" Text="Read from file" />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="You don't have an account?"></asp:Label>
        <asp:Button ID="ButtonAddDentist" runat="server" CssClass="button" Text="Sign up" OnClick="ButtonAddDentist_Click" />
        <br />
        <asp:Label ID="LoginErrorMessage" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <asp:Label ID="AdminLoginMessage" runat="server" ForeColor="Green"></asp:Label>
        <br />
        <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>
        <br />
        <br />
        <br />
        <asp:GridView ID="GridViewDList" runat="server" Width="764px" Caption="Dentists list" HorizontalAlign="Center" OnSelectedIndexChanged="GridViewDList_SelectedIndexChanged">
        </asp:GridView>
    </div>
</asp:Content>
