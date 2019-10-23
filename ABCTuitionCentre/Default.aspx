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

    <telerik:RadGrid ID="RadGrid1" runat="server" AllowFilteringByColumn="True" AllowPaging="True" AllowSorting="True" CellSpacing="-1" GridLines="Both" AutoGenerateColumns="False" AutoGenerateEditColumn="True" OnNeedDataSource="RadGrid1_NeedDataSource">
<GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
        <ClientSettings>
            <Scrolling AllowScroll="True" UseStaticHeaders="True" />
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
                <telerik:GridBoundColumn DataField="CreatedBy" FilterControlAltText="Filter CreatedBy column" HeaderText="Created By" UniqueName="CreatedBy">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="CreatedAt" FilterControlAltText="Filter CreatedAt column" HeaderText="Created At" UniqueName="CreatedAt">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
</asp:Content>

