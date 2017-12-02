<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PatientEdit.aspx.cs" Inherits="_4thCSharpHandIn.PatientEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">


        <div class="centerAlign">


        <br />
            <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Go back" />
            <br />
            <br />
        <asp:Label ID="LabelPatDash" runat="server" Text=""></asp:Label>
        <br />
 &nbsp;&nbsp;<br />
            <div class="col-md-6">
                <div style="display:flex; justify-content:center; padding:1%;" class="centerAlign">
                    <asp:GridView ID="GridViewDNames" runat="server" Width="515px" Caption="Dentists list names">
                    </asp:GridView>
                </div>
                <div class="col-md-6">
                    <div>
                    </div>
                </div>
            </div>
        </div>
     <div class="centerAlign">
         <br />
         <asp:Label ID="LabelPatientName" runat="server" CssClass="label" Text="Patient name:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientName" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <br />
         <asp:Label ID="LabelPatientAge" runat="server" CssClass="label" Text="Patient age:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientAge" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <br />
         <asp:Label ID="LabelPatientPassword" runat="server" CssClass="label" Text="Patient password:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientPassword" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <br />
         <asp:Label ID="LabelPatientEmail" runat="server" CssClass="label" Text="Patient email:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientEmail" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <br />
         <asp:Label ID="LabelPatientCPR" runat="server" CssClass="label" Text="Patient CPR:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientCPR" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
&nbsp;<asp:Button ID="ButtonUpdateSelectedPatient" runat="server" CssClass="button" Text="1. Update patient" OnClick="ButtonUpdateSelectedPatient_Click" />
     <asp:Button ID="ButtonSavePatientFile" runat="server" CssClass="button" OnClick="ButtonSavePatientFile_Click" Text="2. Save to File" Width="271px" />
         <asp:Button ID="ButtonDeleteSelectedPatient" runat="server" CssClass="button" Text="Delete patient" OnClick="ButtonDeleteSelectedPatient_Click" />
         <br />
         <br />
         <asp:Label ID="MessagePatientForm" runat="server" CssClass="label" Font-Size="Medium" ForeColor="Green"></asp:Label>
         &nbsp;<asp:Label ID="MessageNewFormPat" runat="server" CssClass="label" Font-Size="Medium" ForeColor="Green"></asp:Label>
     </div>


    </div>
</asp:Content>
