<%@ Page Title="" Language="C#" MasterPageFile="~/RPS.Master" AutoEventWireup="true" CodeBehind="R0001_ChangePassword.aspx.cs" Inherits="RPS.modules.R00.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="width:100%;">
        <tr>
            <td style="text-align: center">
                <table border="1" 
                    style="width: 400px; border-collapse: collapse;">
                    <tr>
                        <td colspan="2">
                            修改密碼</td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            舊密碼：</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="TB_OldPassword" runat="server" TextMode="Password" 
                                Width="180px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right">
                            新密碼：</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="TB_NewPassword" runat="server" style="text-align: left" 
                                TextMode="Password" Width="180px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr >
                        <td style="text-align: right">
                            確認密碼：</td>
                        <td style="text-align: left">
                            <asp:TextBox ID="TB_ConfirmPassword" runat="server" TextMode="Password" 
                                Width="180px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Label ID="MessagePanel" runat="server" Text="MessagePanel"></asp:Label>
                                    <br />
                                </ContentTemplate>
                                <Triggers>
                                    <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                                </Triggers>
                            </asp:UpdatePanel>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="修改密碼" />
                        </td>
                    </tr>
                </table>
                <br />
            </td>
        </tr>
    </table>
</asp:Content>
