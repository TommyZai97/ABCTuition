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
    <telerik:RadLabel ID="RadLabel1" Font-Bold="true" runat="server">
        Name:
    </telerik:RadLabel>
            </td>
            <td>
    <telerik:RadLabel ID="RLName" runat="server">
        
    </telerik:RadLabel>
            </td>
            <td>
    <telerik:RadLabel ID="RadLabel3" Font-Bold="true" runat="server">
       Overall Attendance:
    </telerik:RadLabel>
            </td>
            <td>
    <telerik:RadLabel ID="RLAttendance" runat="server">
    </telerik:RadLabel> 
            </td>
    </tr>
   </table>


</asp:Content>

