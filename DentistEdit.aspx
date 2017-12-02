<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DentistEdit.aspx.cs" Inherits="_4thCSharpHandIn.DentistEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">

        <br />

        <asp:Button ID="ButtonGoBack" runat="server" CssClass="button" OnClick="ButtonGoBack_Click" Text="Go back" />

        <br />
        <br />
        <asp:Label ID="LabelDDash" runat="server"></asp:Label>
        <div class="row">
            <br />
            <asp:Label ID="LabelCreateDentist" runat="server" CssClass="label" Text="Dentist name"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxNameDentist" runat="server" Width="352px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelCRDAge" runat="server" CssClass="label" Text="Dentist age"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxAgeDentist" runat="server" Width="352px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelCRDPass" runat="server" CssClass="label" Text="Dentist password"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxPassDentist" runat="server" Width="352px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelCRDEmail" runat="server" CssClass="label" Text="Dentist email"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxEmailDentist" runat="server" Width="352px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelCPR" runat="server" CssClass="label" Text="Dentist CPR"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxCPRDentist" runat="server" Width="352px"></asp:TextBox>
            <br />
            <br />
        </div>
        <div style="display:flex; justify-content:center; height: 64px;">
            <asp:Button ID="ButtonUpdateSelectedDentist" runat="server" CssClass="button" OnClick="ButtonUpdateSelectedDentist_Click" Text="1. Update dentist" Width="271px" />
        <asp:Button ID="ButtonSaveDentistFile" runat="server" CssClass="button" Text="2. Save to file" OnClick="ButtonSaveDentistFile_Click" />
            <asp:Button ID="ButtonDeleteSelectedDentist" runat="server" CssClass="button" OnClick="ButtonDeleteSelectedDentist_Click" Text="Delete dentist" Width="271px" />
        </div>
    <br />
        <asp:Label ID="MessageDentistForm" runat="server" CssClass="label" Font-Size="Medium" ForeColor="Green"></asp:Label>
        <asp:Label ID="MessageNewFormDent" runat="server" CssClass="label" Font-Size="Medium" ForeColor="Green"></asp:Label>

    </div>
</asp:Content>
