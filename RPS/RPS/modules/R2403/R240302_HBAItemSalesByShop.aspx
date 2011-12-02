<%@ Page Title="" Language="C#" MasterPageFile="~/RPS.Master" AutoEventWireup="true" CodeBehind="R240302_HBAItemSalesByShop.aspx.cs" Inherits="RPS.modules.R2403.R240302_HBAItemSalesByShop" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style2
        {
            font-family: Verdana;
        }
        .style3
        {
            width: 128px;
            height: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="1" style="width: 600px; border-collapse: collapse;">
        <tr>
            <td class="style2" colspan="4">
                <strong>R240302 HBA Item Sales By Shop</strong></td>
        </tr>
        <tr>
            <td class="style2">
                Start Date: (Y-M-D)</td>
            <td>
                <asp:TextBox ID="TB_SDATE" runat="server" ValidationGroup="G1" Width="80px"></asp:TextBox>
                <asp:MaskedEditExtender ID="TB_SDATE_MaskedEditExtender" runat="server" 
                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                    Mask="9999-99-99" TargetControlID="TB_SDATE">
                </asp:MaskedEditExtender>
            </td>
            <td class="style2">
                End Date: (Y-M-D)</td>
            <td>
                <asp:TextBox ID="TB_EDATE" runat="server" ValidationGroup="G1" Width="80px"></asp:TextBox>
                <asp:MaskedEditExtender ID="TB_EDATE_MaskedEditExtender" runat="server" 
                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                    Mask="9999-99-99" TargetControlID="TB_EDATE">
                </asp:MaskedEditExtender>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Start Shop: (6D)</td>
            <td>
                <asp:TextBox ID="TB_SSHOP" runat="server" ValidationGroup="G1" Width="80px"></asp:TextBox>
                <asp:MaskedEditExtender ID="TB_SSHOP_MaskedEditExtender" runat="server" 
                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                    Mask="999999" MaskType="Number" TargetControlID="TB_SSHOP">
                </asp:MaskedEditExtender>
            </td>
            <td class="style2">
                End Shop: (6D)</td>
            <td>
                <asp:TextBox ID="TB_ESHOP" runat="server" ValidationGroup="G1" Width="80px"></asp:TextBox>
                <asp:MaskedEditExtender ID="TB_ESHOP_MaskedEditExtender" runat="server" 
                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                    Mask="999999" MaskType="Number" TargetControlID="TB_ESHOP">
                </asp:MaskedEditExtender>
            </td>
        </tr>
        <tr>
            <td colspan="4" style="text-align: center">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
            </td>
        </tr>
    </table>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <img class="style3" src="../../images/ajax-loader.gif" />
                </ProgressTemplate>
            </asp:UpdateProgress>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
