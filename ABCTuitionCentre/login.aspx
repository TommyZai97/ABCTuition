<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/blank.master" CodeFile="login.aspx.cs" Inherits="login" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
        <div>
            
        </div>
        <table style="width:100%;background-color:#f0f0f0">
            <tr style="text-align:center">
                <%--<td style="text-align:right;width:250px"> 
                    <telerik:RadLabel ID="RLUsername" Text="Username" Font-Bold="true" runat="server"></telerik:RadLabel>
                </td>--%>
                 <td style="text-align:center">
                    
                     <telerik:RadTextBox ID="RTBUsername" Width="500px"  EmptyMessage="Username" runat="server"></telerik:RadTextBox>
                </td>
            </tr>
               <tr style="text-align:center">
              <%--  <td style="text-align:right;width:250px"> 
                    <telerik:RadLabel ID="RLPassword" Text="Password" Font-Bold="true" runat="server"></telerik:RadLabel>
                </td>--%>
                 <td style="text-align:center">
                    
                     <telerik:RadTextBox ID="RTBPassword" Width="500px"  TextMode="Password" EmptyMessage="Password" runat="server"></telerik:RadTextBox>
                </td>
            </tr>
         
        </table>

           <table style="width:100%">
                <tr>
                <td style="text-align:right">
                    <telerik:RadButton ID="RBLogin" Font-Bold="true" Width="150px" runat="server" Text="Login" OnClick="RBLogin_Click"></telerik:RadButton>
                </td>
                    </tr>
            </table>

</asp:Content>

