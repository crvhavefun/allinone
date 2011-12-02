<%@ Page Title="" Language="C#" MasterPageFile="~/RPS.Master" AutoEventWireup="true" CodeBehind="R0201_SC001_.aspx.cs" Inherits="RPS.modules.R02.R0201_SC001" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Planogram Type:"></asp:Label>&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>LIVE</asp:ListItem>
        <asp:ListItem>WIP</asp:ListItem>
    </asp:DropDownList>&nbsp;
    <asp:Button ID="Button1" runat="server" 
        Text="Button" onclick="Button1_Click" />
    <br />
    <br />
    <rsweb:ReportViewer ID="rpt1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" Height="100%" InteractiveDeviceInfos="(Collection)" 
        SizeToReportContent="True" WaitMessageFont-Names="Verdana" 
        WaitMessageFont-Size="14pt" Width="100%" Enabled="False">
        <LocalReport ReportPath="reports\R0201_SC001.rdlc">
        </LocalReport>
    </rsweb:ReportViewer>
    <br />
    </asp:Content>
