<%@ Page Title="" Language="C#" MasterPageFile="~/RPS.Master" AutoEventWireup="true" CodeBehind="R240201_HBAQOH.aspx.cs" Inherits="RPS.modules.R2402.HBAQOH" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <rsweb:ReportViewer ID="rpt1" runat="server" Font-Names="Verdana" 
        Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
        SizeToReportContent="True" WaitMessageFont-Names="Verdana" 
        WaitMessageFont-Size="14pt" Height="100%" Width="100%">
        <LocalReport ReportPath="reports\R240201_HBAQOH.rdlc">
        </LocalReport>
    </rsweb:ReportViewer>
</asp:Content>
