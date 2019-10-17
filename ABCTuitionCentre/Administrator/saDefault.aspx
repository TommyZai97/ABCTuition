<%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="saDefault.aspx.cs" Inherits="Administrator_saDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-family: "segoe ui", arial, sans-serif;
            font-size: 12px;
            vertical-align: middle;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td style="width:25%">
                 <telerik:RadLabel ID="RadLabel1" runat="server" Font-Bold="true">
        Student Name:
    </telerik:RadLabel>
            </td>
            <td style="width:25%">
                 
                 <telerik:RadTextBox ID="RTBStudentName" runat="server" Width="100%"></telerik:RadTextBox>

            </td>
            <td style="width:25%">
                 <telerik:RadLabel ID="RadLabel2" runat="server" Font-Bold="true" Width="100%">
        Phone No:
    </telerik:RadLabel>
            </td>
            <td style="width:25%">
                 
               <telerik:RadTextBox ID="RTBPhoneNo" runat="server" Width="100%"></telerik:RadTextBox>

            </td>
        </tr>
          <tr>
            <td style="width:25%">
                 <telerik:RadLabel ID="RadLabel3" runat="server" Font-Bold="true">
             Address:
    </telerik:RadLabel>
            </td>
            <td style="width:25%">
                 
                 <telerik:RadTextBox ID="RTBAddress" runat="server" Width="100%"></telerik:RadTextBox>

            </td>
            <td style="width:25%">
                 <telerik:RadLabel ID="RadLabel4" runat="server" Font-Bold="true">
                      Date Of Birth:
                  </telerik:RadLabel>
            </td>
            <td style="width:25%" class="auto-style1">
                 
                <telerik:RadDatePicker ID="RDPDob" Runat="server">
                </telerik:RadDatePicker>

            </td>
        </tr>
    </table>
  
     <div align="right">
            <telerik:RadButton ID="RBEnrollStudent" runat="server" Font-Bold="true" Text="Enroll Student" OnClick="RBEnrollStudent_Click"></telerik:RadButton>
        </div>

</asp:Content>

