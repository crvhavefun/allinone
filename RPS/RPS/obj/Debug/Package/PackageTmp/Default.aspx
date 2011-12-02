<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RPS.Default" %>
<%@ OutputCache Duration="60" VaryByParam="None" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>華潤零售報表系統</title>
    <script src="scripts/encryption.js" type="text/javascript"></script>
    <script src="scripts/jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        function hashPassword() {
            var hashCode = md5($("#TB_UserPw").val());
            var randCode = Math.random() * new Date().getSeconds();
            var token = md5(sha1(randCode));

            if ($("#TB_UserPw").val() != "" && $("#TB_UserID").val() != "") {
                $("#TB_UserPw").val(hashCode);
                $("#HF_UserToken").val(token);
            }
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
    <noscript><center><b>Your browser does not support JavaScript!</b></center></noscript>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <strong>華潤零售報表系統</strong><table align="center" bgcolor="#F7F7F7" 
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
                                用戶名稱：</td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: left">
                                <asp:TextBox ID="TB_UserID" runat="server" MaxLength="12" Width="200px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: left">
                                用戶密碼：</td>
                        </tr>
                        <tr>
                            <td colspan="2" style="text-align: left">
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <asp:TextBox ID="TB_UserPw" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
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
                                    Height="35px" onclick="Button1_Click" Text="LOGIN" 
                                    onclientclick="hashPassword()" />
                            </td>
                            <td style="text-align: right">
                                <img alt="Microsoft ASP.NET" class="style1" src="images/logo.png" /></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
        <asp:HiddenField ID="HF_UserToken" runat="server" />
    
    </div>
    </form>
</body>
</html>
