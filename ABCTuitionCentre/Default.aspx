    <%@ Page Title="" Language="C#" MasterPageFile="~/abc.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Charting" tagprefix="telerik" %>

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
        <td style="width:125px">
    <telerik:RadLabel ID="RadLabel1" Font-Bold="true" runat="server">
        Name:
    </telerik:RadLabel>
            </td>
            <td >
    <telerik:RadLabel ID="RLName" runat="server">
        
    </telerik:RadLabel>
            </td>
            <td style="width:250px">
    <telerik:RadLabel ID="RadLabel3" Font-Bold="true" runat="server">
       Overall Attendance:
    </telerik:RadLabel>
            </td>
            <td>
    <telerik:RadLabel ID="RLAttendance" runat="server">
    </telerik:RadLabel> 
            </td>
    </tr>
                <tr>
        <td style="width:125px">
    <telerik:RadLabel ID="RadLabel2" Font-Bold="true" runat="server">
        Phone No:
    </telerik:RadLabel>
            </td>
            <td style="width:250px">
    <telerik:RadLabel ID="RLPhoneNo" runat="server">
        
    </telerik:RadLabel>
            </td>
            <td>
    <telerik:RadLabel ID="RadLabel5" Font-Bold="true" runat="server">
       Address:
    </telerik:RadLabel>
            </td>
            <td>
    <telerik:RadLabel ID="RLAddress" runat="server">
    </telerik:RadLabel> 
            </td>
    </tr>
   </table>
    <div align="center" style="background-color:#f0f0f0">
    <telerik:RadChart ID="RCStudent" runat="server" Height="512px" Width="512px" Skin="Mac" >

        <Appearance Corners="Round, Round, Round, Round, 6">
            <FillStyle FillType="Image">
                <FillSettings BackgroundImage="{chart}" ImageDrawMode="Flip" ImageFlip="FlipX">
                </FillSettings>
            </FillStyle>
            <Border Color="138, 138, 138" />
        </Appearance>
        <Legend>
            <Appearance Dimensions-Margins="15.4%, 3%, 1px, 1px" Position-AlignedPosition="TopRight">
                <ItemMarkerAppearance Figure="Square">
                    <Border Color="134, 134, 134" />
                </ItemMarkerAppearance>
                <FillStyle MainColor="">
                </FillStyle>
                <Border Color="Transparent" />
            </Appearance>
        </Legend>
        <PlotArea>
            <XAxis>
                <Appearance Color="134, 134, 134" MajorTick-Color="134, 134, 134">
                    <MajorGridLines Color="209, 222, 227" PenStyle="Solid" />
                    <TextAppearance TextProperties-Color="51, 51, 51">
                    </TextAppearance>
                </Appearance>
                <AxisLabel>
                    <TextBlock>
                        <Appearance TextProperties-Color="51, 51, 51">
                        </Appearance>
                    </TextBlock>
                </AxisLabel>
            </XAxis>
            <YAxis>
                <Appearance Color="134, 134, 134" MajorTick-Color="134, 134, 134" MinorTick-Color="134, 134, 134" MinorTick-Width="0">
                    <MajorGridLines Color="209, 222, 227" />
                    <MinorGridLines Color="233, 239, 241" />
                    <TextAppearance TextProperties-Color="51, 51, 51">
                    </TextAppearance>
                </Appearance>
                <AxisLabel>
                    <TextBlock>
                        <Appearance TextProperties-Color="51, 51, 51">
                        </Appearance>
                    </TextBlock>
                </AxisLabel>
            </YAxis>
            <Appearance>
                <FillStyle FillType="Solid" MainColor="White">
                </FillStyle>
                <Border Color="134, 134, 134" />
            </Appearance>
        </PlotArea>

        <ChartTitle>
            <Appearance Position-AlignedPosition="Top">
                <FillStyle MainColor="">
                </FillStyle>
            </Appearance>
            <TextBlock Text="Overall Grades">
                <Appearance TextProperties-Font="Tahoma, 13pt">
                </Appearance>
            </TextBlock>
        </ChartTitle>
    </telerik:RadChart>
        </div>
   
</asp:Content>

