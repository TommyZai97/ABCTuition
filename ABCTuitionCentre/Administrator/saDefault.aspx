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

    <telerik:RadGrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" AllowPaging="True" OnUpdateCommand="RadGrid1_UpdateCommand" AutoGenerateEditColumn="true" AllowSorting="True" CellSpacing="-1" GridLines="Both" AutoGenerateColumns="False" OnNeedDataSource="RadGrid1_NeedDataSource" OnSelectedCellChanged="RadGrid1_SelectedCellChanged" OnSelectedIndexChanged="RadGrid1_SelectedIndexChanged">
<GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
        <ClientSettings>
            <Scrolling AllowScroll="True" UseStaticHeaders="True" />
            <Selecting AllowRowSelect="true" />
        </ClientSettings>
        <MasterTableView DataKeyNames="StudentID">
            <Columns>
                <telerik:GridBoundColumn DataField="StudentID" FilterControlAltText="Filter StudentID column" HeaderText="Student ID" UniqueName="StudentID">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="StudentName" FilterControlAltText="Filter StudentName column" HeaderText="Student Name" UniqueName="StudentName">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="PhoneNo" FilterControlAltText="Filter PhoneNo column" HeaderText="Phone No" UniqueName="PhoneNo">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Address" FilterControlAltText="Filter Address column" HeaderText="Address" UniqueName="Address">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="DOB" FilterControlAltText="Filter DOB column" HeaderText="Date Of Birth" UniqueName="DOB">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
              <%--  <telerik:GridBoundColumn DataField="CreatedBy" FilterControlAltText="Filter CreatedBy column" HeaderText="Created By" UniqueName="CreatedBy">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="CreatedAt" FilterControlAltText="Filter CreatedAt column" HeaderText="Created At" UniqueName="CreatedAt">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>--%>
            </Columns>
             
        </MasterTableView>
    </telerik:RadGrid>
</asp:Content>

