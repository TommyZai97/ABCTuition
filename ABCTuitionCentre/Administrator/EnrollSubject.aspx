<%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="EnrollSubject.aspx.cs" Inherits="Administrator_EnrollSubject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%">
        <tr style="width:"100%">
            <td>
                <telerik:RadLabel ID="RadLabel1" runat="server">
                    Subject: 
                </telerik:RadLabel>
            </td>
            <td>
                <telerik:RadComboBox ID="RCBSubject" runat="server" OnSelectedIndexChanged="RCBSubject_SelectedIndexChanged"></telerik:RadComboBox>
            </td>
            <td>
                <telerik:RadLabel ID="RadLabel2" runat="server">
                    Student: 
                </telerik:RadLabel>
            </td>
            <td>
                <telerik:RadComboBox ID="RCBStudent" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
    </table>
    <div align="right">
        <telerik:RadButton ID="RBSubmit" runat="server" Text="Enroll" OnClick="RBSubmit_Click"></telerik:RadButton>
    </div>
</asp:Content>

