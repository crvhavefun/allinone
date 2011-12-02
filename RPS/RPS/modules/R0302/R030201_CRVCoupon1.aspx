<%@ Page Title="" Language="C#" MasterPageFile="~/RPS.Master" AutoEventWireup="true" CodeBehind="R030201_CRVCoupon1.aspx.cs" Inherits="RPS.modules.R0302.R030201_CRVCoupon1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 128px;
            height: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table border="1" style="width: 400px; border-collapse: collapse;">
            <tr>
                <td colspan="2" style="text-align: center">
                    <strong>CRV禮卷使用情況</strong></td>
            </tr>
            <tr>
                <td>
                    Start Date: (Y-M-D)</td>
                <td>
                    <asp:TextBox ID="TB_SDATE" runat="server"></asp:TextBox>
                    <asp:MaskedEditExtender ID="TB_SDATE_MaskedEditExtender" runat="server" 
                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                        Mask="9999-99-99" TargetControlID="TB_SDATE">
                    </asp:MaskedEditExtender>
                </td>
            </tr>
            <tr>
                <td>
                    End Date: (Y-M-D)</td>
                <td>
                    <asp:TextBox ID="TB_EDATE" runat="server"></asp:TextBox>
                    <asp:MaskedEditExtender ID="TB_EDATE_MaskedEditExtender" runat="server" 
                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                        Mask="9999-99-99" TargetControlID="TB_EDATE">
                    </asp:MaskedEditExtender>
                </td>
            </tr>
            <tr>
                <td>
                    Coupon No: (13D)</td>
                <td>
                    <asp:TextBox ID="TB_COUPON" runat="server"></asp:TextBox>
                    <asp:MaskedEditExtender ID="TB_COUPON_MaskedEditExtender" runat="server" 
                        CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                        CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                        CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                        Mask="9999999999999" TargetControlID="TB_COUPON">
                    </asp:MaskedEditExtender>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
                </td>
            </tr>
        </table>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <img class="style2" src="../../images/ajax-loader.gif" />
                </ProgressTemplate>
            </asp:UpdateProgress>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
