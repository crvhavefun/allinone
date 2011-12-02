<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstLogin.aspx.cs" Inherits="RPS_Shop.FirstLogin" %>
<%@ OutputCache Duration="60" VaryByParam="None" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/encryption.js" type="text/javascript"></script>
    <script src="scripts/jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        function hashPassword() {
            /*if ($("#TB_NewPW").val() == $("#TB_ConfirmPW").val()) {
                if ($("#TB_NewPW").val() != "" && $("#TB_ConfirmPW").val() != "") {
                    $("#TB_NewPW").val(md5($("#TB_NewPW").val()));
                    $("#TB_ConfirmPW").val(md5($("#TB_ConfirmPW").val()));
                }
            }*/
            
        }
    </script>
    <style type="text/css">
        .style1
        {
            width: 108px;
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <strong>華潤零售報表系統(門店)</strong>
        <table align="center" bgcolor="#F7F7F7" 
            style="border-style: solid; border-width: thin; width: 320px; border-collapse: collapse;">
            <tr>
                <td align="center">
                    <table align="center" bgcolor="#F7F7F7" 
                        style="width: 300px; border-collapse: collapse;">
                        <tr>
                            <td colspan="2">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: left">
                                新密碼：</td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: left">
                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="TB_NewPW" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: left">
                                確認密碼：</td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: left">
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                                <asp:TextBox ID="TB_ConfirmPW" 
    runat="server" TextMode="Password" 
                                    Width="200px"></asp:TextBox>
                                            </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: left">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:Label ID="MessagePanel" runat="server" Text="MessagePanel"></asp:Label>
                                    </ContentTemplate>
                                    <Triggers>
                                        <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                                    </Triggers>
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: left">
                                <asp:Button ID="Button1" runat="server" BackColor="Black" BorderStyle="None" 
                                    Font-Bold="True" Font-Names="Tahoma" Font-Size="Medium" ForeColor="White" 
                                    Height="35px" onclick="Button1_Click" onclientclick="return hashPassword()" 
                                    Text="修改密碼" />
                            </td>
                            <td style="text-align: right">
                                <img alt="Microsoft ASP.NET" class="style1" src="images/logo.png" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <asp:HiddenField ID="HF_NewPW" runat="server" />
        <asp:HiddenField ID="HF_ConfirmPW" runat="server" />
        </div>
    </form>
</body>
</html>
