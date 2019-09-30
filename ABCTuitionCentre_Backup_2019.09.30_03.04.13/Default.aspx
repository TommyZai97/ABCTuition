<%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>
                <%--<telerik:RadScriptManager ID="RadScriptManager1" runat="server"></telerik:RadScriptManager>--%>
            </td>
        </tr>
        <tr>
        <td>
    <telerik:RadLabel ID="RadLabel1" runat="server">
        Test Labels
    </telerik:RadLabel>
    <telerik:RadTextBox ID="RadTextBox1" Runat="server" EmptyMessage="Search..." LabelWidth="64px" Resize="None" Width="160px">
    </telerik:RadTextBox>
            </td>
    </tr>
   </table>
</asp:Content>

