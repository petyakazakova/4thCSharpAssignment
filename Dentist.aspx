<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dentist.aspx.cs" Inherits="_4thCSharpHandIn.Dentist1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">

        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="CREATE NEW DENTIST ACCOUNT"></asp:Label>

        <br />
        <div class="row">
            <div class="col-md-6">
                <div style="display:flex; justify-content:center; padding:0.5%;">
                    <br />
                </div>
            </div>
            <asp:Label ID="LabelCreateDentist" runat="server" CssClass="label" Text="Dentist name"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxNameDentist" runat="server" Width="271px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelCRDAge" runat="server" CssClass="label" Text="Dentist age"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxAgeDentist" runat="server" Width="271px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelCRDPass" runat="server" CssClass="label" Text="Dentist password"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxPassDentist" runat="server" Width="271px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelCRDEmail" runat="server" CssClass="label" Text="Dentist email"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxEmailDentist" runat="server" Width="271px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelCPR" runat="server" CssClass="label" Text="Dentist CPR"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxCPRDentist" runat="server" Width="271px"></asp:TextBox>
            <br />
            <br />
        </div>
        <div style="display:flex; justify-content:center; height: 64px;">
            <asp:Button ID="ButtonCRNewDentist" runat="server" CssClass="button" OnClick="ButtonCRNewDentist_Click" Style="vertical-align: middle; text-align: center;" Text="1. Add new dentist to list" />
        <asp:Button ID="ButtonSaveDentistFile" runat="server" CssClass="button" OnClick="ButtonSaveDentistFile_Click" Text="2. Save to File"/>
            <br />
        </div>
        <br />
        <asp:Label ID="MessageDentistForm" runat="server" CssClass="label" Font-Size="Medium" ForeColor="Green"></asp:Label>
        <asp:Label ID="MessageNewFormDent" runat="server" CssClass="label" Font-Size="Medium" ForeColor="Green"></asp:Label>

    </div>
</asp:Content>
