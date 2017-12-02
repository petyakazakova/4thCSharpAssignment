<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Patients.aspx.cs" Inherits="_4thCSharpHandIn.CreatePatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="centerAlign">

     <br />
 &nbsp;<div class="row">
         <div class="col-md-6">
             <div class="col-md-6">
                 <div>
        <asp:Label ID="Label1" runat="server" Text="CREATE NEW PATIENT ACCOUNT"></asp:Label>

                     <br />

                     <br />
                 </div>
             </div>
         </div>
     </div>
     <div>
         <br />
         <asp:Label ID="LabelPatientName" runat="server" CssClass="label" Text="Patient name:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientName" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="LabelPatientAge" runat="server" CssClass="label" Text="Patient age:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientAge" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="LabelPatientPassword" runat="server" CssClass="label" Text="Patient password:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientPassword" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="LabelPatientEmail" runat="server" CssClass="label" Text="Patient email:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientEmail" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="LabelPatientCPR" runat="server" CssClass="label" Text="Patient CPR:"></asp:Label>
         &nbsp;<asp:TextBox ID="TextBoxPatientCPR" runat="server" Width="271px"></asp:TextBox>
         <br />
         <br />
         <asp:Button ID="ButtonAddPatientList" runat="server" CssClass="button" OnClick="ButtonAddPatientList_Click" Text="1. Add new patient" />
&nbsp;<asp:Button ID="ButtonSavePatientFile" runat="server" CssClass="button" OnClick="ButtonSavePatientFile_Click" Text="2. Save to File" />
         <br />
         <asp:Label ID="MessagePatientForm" runat="server" CssClass="label" Font-Size="Medium" ForeColor="Green"></asp:Label>
         &nbsp;<asp:Label ID="MessageNewFormPat" runat="server" CssClass="label" Font-Size="Medium" ForeColor="Green"></asp:Label>
     </div>
 </div>
</asp:Content>
