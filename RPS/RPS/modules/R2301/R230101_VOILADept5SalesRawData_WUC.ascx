<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="R230101_VOILADept5SalesRawData_WUC.ascx.cs" Inherits="RPS.modules.R2301.R230101_VOILADept5SalesRawData_WUC" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<rsweb:ReportViewer ID="rpt1" runat="server" AsyncRendering="False" 
    Height="100%" ShowPageNavigationControls="False" ShowPrintButton="False" 
    SizeToReportContent="True" Width="100%" Font-Names="Verdana" 
    Font-Size="8pt" InteractiveDeviceInfos="(Collection)" 
    WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
    <LocalReport ReportPath="reports\R230101_VOILADept5SalesRawData.rdlc">
    </LocalReport>
</rsweb:ReportViewer>

