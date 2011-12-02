<%@ Page Title="" Language="C#" MasterPageFile="~/RPS_Shop.Master" AutoEventWireup="true" CodeBehind="R1001_ItemSalesRanking.aspx.cs" Inherits="RPS_Shop.modules.R10.R1001_ItemSalesRanking" %>
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
    <table border="1" style="width: 550px; border-collapse: collapse;">
        <tr>
            <td class="style2" colspan="4"><strong>R1001 商品銷售排名</strong></td>
        </tr>
        <tr>
            <td class="style2">開始日期: (年-月-日)</td>
            <td>
                <asp:TextBox ID="TB_SDATE" runat="server" ValidationGroup="G1" Width="80px"></asp:TextBox>
                <asp:MaskedEditExtender ID="TB_SDATE_MaskedEditExtender" runat="server" 
                    CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" 
                    CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" 
                    CultureThousandsPlaceholder="" CultureTimePlaceholder="" Enabled="True" 
                    Mask="9999-99-99" TargetControlID="TB_SDATE">
                </asp:MaskedEditExtender>
            </td>
            <td class="style2">結束日期: (年-月-日)</td>
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
            <td colspan="4" style="text-align: center">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="預覽報表" />
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
