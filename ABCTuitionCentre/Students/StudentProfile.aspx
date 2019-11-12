<%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="StudentProfile.aspx.cs" Inherits="Students_StudentProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>
                 <telerik:RadLabel ID="RadLabel1" Font-Bold="true" runat="server">
                     Student Name:
             </telerik:RadLabel>
             
            </td>
            <td>
                <telerik:RadLabel ID="RLStudentName"  runat="server">
                    
                </telerik:RadLabel>
            </td>
            <td>
                 <telerik:RadLabel ID="RadLabel2" Font-Bold="true" runat="server">
                    Grade:
                </telerik:RadLabel>
            </td>
            <td>
                 <telerik:RadLabel ID="RLGrade" runat="server">
                    
                </telerik:RadLabel>
            </td>
        </tr>
        <tr>
            <td>
                 <telerik:RadLabel ID="RadLabel3" Font-Bold="true" runat="server">
                      Subject:
             </telerik:RadLabel>
             
            </td>
            <td>
                <telerik:RadComboBox ID="RCBSubject" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RCBSubject_SelectedIndexChanged"></telerik:RadComboBox>
            </td>
            <td>
                 <telerik:RadLabel ID="RadLabel5" Font-Bold="true" runat="server">
                    Attendance:
                </telerik:RadLabel>
            </td>
            <td>
                 <telerik:RadLabel ID="RLAttendance" runat="server">
                    
                </telerik:RadLabel>
            </td>
        </tr>
    </table>

        
</asp:Content>

