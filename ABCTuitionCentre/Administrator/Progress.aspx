<%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="Progress.aspx.cs" Inherits="Administrator_Progress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server" DefaultLoadingPanelID="RadAjaxLoadingPanel1">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="RCBStudentName">
                <UpdatedControls>
                    <telerik:AjaxUpdatedControl ControlID="RLStudentName" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RDDLAttendance" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RDDLGrade" UpdatePanelCssClass="" />
                    <telerik:AjaxUpdatedControl ControlID="RBModify" UpdatePanelCssClass="" />
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="RadAjaxLoadingPanel1" runat="server" Skin="Default"></telerik:RadAjaxLoadingPanel>
    <table>
        <tr>
            <td>
                <telerik:RadLabel ID="RadLabel1" Font-Bold="true" runat="server">
                    Student:
                </telerik:RadLabel>
            </td>
            <td>
                <telerik:RadComboBox ID="RCBStudentName" Runat="server" OnSelectedIndexChanged="RCBStudentName_SelectedIndexChanged" AutoPostBack="True">
                </telerik:RadComboBox>
            </td>
            <td>
                <telerik:RadLabel ID="RadLabel5" Font-Bold="true" runat="server">
                    Subject:
                </telerik:RadLabel>
            </td>
            <td>
                <telerik:RadComboBox ID="RCBSubject" runat="server">
                </telerik:RadComboBox>
            </td>
        </tr>
         <tr>
            <td>
                <telerik:RadLabel ID="RadLabel2" Font-Bold="true" runat="server">
                    Student Name:
                </telerik:RadLabel>
                
            </td>
            <td style="width:75%">
               <telerik:RadLabel ID="RLStudentName"  runat="server">
                    
                </telerik:RadLabel>
            </td>
             <td>
                 <telerik:RadLabel ID="RadLabel3" Font-Bold="true" runat="server">
                     Attendance
                 </telerik:RadLabel>
             </td>
             <td>
                 <telerik:RadDropDownList ID="RDDLAttendance" runat="server" SelectedText="Present" SelectedValue="Present">
                     <Items>
                         <telerik:DropDownListItem runat="server" Selected="True" Text="Present" Value="Present" />
                         <telerik:DropDownListItem runat="server" Text="Absent" Value="Absent" />
                         <telerik:DropDownListItem runat="server" Text="No Data" Value="NoData" />
                     </Items>
                 </telerik:RadDropDownList>
             </td>
        </tr>
        <tr>
            <td>
                
                <telerik:RadLabel ID="RadLabel4" Font-Bold="true" runat="server">
                    Grades:
                </telerik:RadLabel>
                
            </td>
            <td>
                
                <telerik:RadDropDownList ID="RDDLGrade" runat="server" SelectedText="Please Select A Student">
                    <Items>
                        <telerik:DropDownListItem runat="server" Selected="True" Text="Please Select A Student" />
                        <telerik:DropDownListItem runat="server" Text="A" Value="A" />
                        <telerik:DropDownListItem runat="server" Text="B" Value="B" />
                        <telerik:DropDownListItem runat="server" Text="C" Value="C" />
                        <telerik:DropDownListItem runat="server" Text="D" Value="D" />
                        <telerik:DropDownListItem runat="server" Text="E" Value="E" />
                        <telerik:DropDownListItem runat="server" Text="F" Value="F" />
                    </Items>
                </telerik:RadDropDownList>
                
            </td>
            <td>
                
            </td>
            <td>
                
                <telerik:RadButton ID="RBModify" runat="server" Text="Modify" OnClick="RBModify_Click">
                </telerik:RadButton>
                
            </td>
        </tr>
    </table>

    <telerik:RadGrid ID="RGClassMaster" runat="server" AutoGenerateColumns="False" OnNeedDataSource="RGClassMaster_NeedDataSource">
          <ClientSettings>
            <Scrolling AllowScroll="True" UseStaticHeaders="True" />
        </ClientSettings>
        <MasterTableView DataKeyNames="ClassID">
            <Columns>
                <telerik:GridBoundColumn DataField="ClassID" FilterControlAltText="Filter ClassID column" HeaderText="ClassID" UniqueName="ClassID">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="true"/>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="ClassName" FilterControlAltText="Filter ClassName column" HeaderText="ClassName" UniqueName="ClassName">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="true"/>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="SubjectID" FilterControlAltText="Filter SubjectID column" HeaderText="SubjectID" UniqueName="SubjectID">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="true"/>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="StudentiD" FilterControlAltText="Filter StudentiD column" HeaderText="Student ID" UniqueName="StudentiD">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="true"/>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Grade" FilterControlAltText="Filter Grade column" HeaderText="Grade" UniqueName="Grade">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="true"/>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="Attendance" FilterControlAltText="Filter Attendance column" HeaderText="Attendance" UniqueName="Attendance">
                                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Font-Bold="true"/>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
               </telerik:GridBoundColumn>
               
            </Columns>
        </MasterTableView>
    </telerik:RadGrid>
</asp:Content>

