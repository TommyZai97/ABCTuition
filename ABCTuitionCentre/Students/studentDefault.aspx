<%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="studentDefault.aspx.cs" Inherits="Students_studentDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%">
        <tr>
            <td>
                <telerik:RadLabel ID="RadLabel1" Width="150px" Font-Bold="true" Font-Size="15px" Text="Name: " runat="server"></telerik:RadLabel>
            </td>
            <td>
                <telerik:RadLabel ID="RLName" Width="500px" Text="Missing Name Data"  Font-Size="15px" runat="server"></telerik:RadLabel>
            </td>
              <td>
                <telerik:RadLabel ID="RadLabel2" Width="150px" Font-Bold="true"  Font-Size="15px" Text="Student ID: " runat="server"></telerik:RadLabel>
            </td>
            <td>
                <telerik:RadLabel ID="RLStuID" Width="500px" Text="Missing ID Data"  Font-Size="15px" runat="server"></telerik:RadLabel>
            </td>
        </tr>
    </table>
</asp:Content>

