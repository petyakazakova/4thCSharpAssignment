<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DentistDashboard.aspx.cs" Inherits="_4thCSharpHandIn.DentistDashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">
        <br />
        <br />
        <asp:Label ID="LabelDDash" runat="server"></asp:Label>
        &nbsp;<br />
        <br />
        <asp:Button ID="ButtonEditD" runat="server" CssClass="button" Text="Edit dentist" OnClick="ButtonEditD_Click" />
        <asp:Button ID="ButtonLogout" runat="server" CssClass="button" OnClick="ButtonLogout_Click" Text="Logout" />
        <br />
        <br />
        <asp:Button ID="ButtonReadD" runat="server" CssClass="button" OnClick="ButtonReadD_Click" Text="Read from dentists list" />
        <asp:Button ID="ButtonReadP" runat="server" CssClass="button" OnClick="ButtonReadP_Click" Text="Read from patients list" />
        <br />
        <br />
        <asp:Label ID="LabelMessage" runat="server" ForeColor="Green"></asp:Label>
        &nbsp;<asp:Label ID="LabelMessageP" runat="server" ForeColor="Green"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridViewDList" runat="server" Width="624px" Caption="Dentists list" HorizontalAlign="Center">
        </asp:GridView>
        <br />
        <asp:GridView ID="GridViewPList" runat="server" Caption="Patients list" OnSelectedIndexChanged="GridViewPList_SelectedIndexChanged" Width="620px" HorizontalAlign="Center">
        </asp:GridView>
&nbsp;</div>
</asp:Content>
