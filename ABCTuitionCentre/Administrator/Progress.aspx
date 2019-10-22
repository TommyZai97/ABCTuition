<%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="Progress.aspx.cs" Inherits="Administrator_Progress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    ---- WIP ----

    <table>
        <tr>
            <td>
                <telerik:RadLabel ID="RadLabel1" runat="server">
                    Student:
                </telerik:RadLabel>
            </td>
            <td>
                <telerik:RadComboBox ID="RCBStudentName" Runat="server" OnSelectedIndexChanged="RCBStudentName_SelectedIndexChanged">
                </telerik:RadComboBox>
            </td>
            <td>
            </td>
            <td></td>
        </tr>
         <tr>
            <td>
                <telerik:RadLabel ID="RadLabel2" runat="server">
                    Student Name:
                </telerik:RadLabel>
                
            </td>
            <td style="width:75%">
               <telerik:RadLabel ID="RLStudentName" runat="server">
                    PLEASE SELECT A STUDENT
                </telerik:RadLabel>
            </td>
             <td>
                 <telerik:RadLabel ID="RadLabel3" runat="server">
                     Attendance
                 </telerik:RadLabel>
             </td>
             <td>
                 <telerik:RadTextBox ID="RTBAttendance" runat="server"></telerik:RadTextBox>
             </td>
        </tr>
    </table>
</asp:Content>

