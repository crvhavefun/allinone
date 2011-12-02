<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Panel.aspx.cs" Inherits="Shop_RS.Login_Panel1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery.js" type="text/javascript"></script>
    <script src="js/jquery-ui.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#LOGIN_BUTTON").button();
            $("#LOGIN_BUTTON").click(function () {
                alert("Hello");
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="LOGIN_BUTTON" runat="server" Text="Button" />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="LOGIN_BUTTON" EventName="Click">
            </asp:AsyncPostBackTrigger>
        </Triggers>
    </asp:UpdatePanel>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    </form>
</body>
</html>
