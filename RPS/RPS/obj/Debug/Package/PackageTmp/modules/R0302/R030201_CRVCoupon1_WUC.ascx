﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="R030201_CRVCoupon1_WUC.ascx.cs" Inherits="RPS.modules.R0302.R030201_CRVCoupon1_WUC" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<rsweb:ReportViewer ID="rpt1" runat="server" AsyncRendering="False" 
    Font-Names="Verdana" Font-Size="8pt" Height="100%" 
    InteractiveDeviceInfos="(Collection)" ShowPageNavigationControls="False" 
    ShowPrintButton="False" SizeToReportContent="True" 
    WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
    <LocalReport ReportPath="reports\R030201_CRVCoupon1.rdlc">
    </LocalReport>
</rsweb:ReportViewer>

