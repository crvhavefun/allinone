<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="R1001_ItemSalesRanking_WUC.ascx.cs" Inherits="RPS_Shop.modules.R10.R1001_ItemSalesRanking_WUC" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<rsweb:ReportViewer ID="rpt1" runat="server" AsyncRendering="False" 
    Font-Names="Verdana" Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
    ShowBackButton="False" ShowDocumentMapButton="False" ShowFindControls="False" 
    ShowPageNavigationControls="False" 
    ShowPrintButton="False" SizeToReportContent="True" 
    WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%" 
    Height="100%" ShowRefreshButton="False">
    <LocalReport ReportPath="reports\R1001_ItemSalesRanking.rdlc">
    </LocalReport>
</rsweb:ReportViewer>
