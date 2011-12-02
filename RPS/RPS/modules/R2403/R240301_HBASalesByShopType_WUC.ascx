<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="R240301_HBASalesByShopType_WUC.ascx.cs" Inherits="RPS.modules.R2403.R240301_HBASalesByShopType_WUC" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<rsweb:ReportViewer ID="rpt1" runat="server" Font-Names="Verdana" 
    Font-Size="8pt" Height="100%" InteractiveDeviceInfos="(Collection)" 
    SizeToReportContent="True" WaitMessageFont-Names="Verdana" 
    WaitMessageFont-Size="14pt" Width="100%" AsyncRendering="False" 
    ShowPageNavigationControls="False" ShowPrintButton="False">
    <LocalReport ReportPath="reports\R240301_HBASalesByShopType.rdlc">
    </LocalReport>
</rsweb:ReportViewer>

