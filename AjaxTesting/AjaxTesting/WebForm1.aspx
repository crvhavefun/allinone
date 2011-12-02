<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AjaxTesting.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:UpdateProgress ID="UpdateProgress1" runat="server" DisplayAfter="0">
                    <ProgressTemplate>
                        Loading...
                    </ProgressTemplate>
                </asp:UpdateProgress>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="dw_plu" HeaderText="dw_plu" 
                            SortExpression="dw_plu" />
                        <asp:BoundField DataField="dw_longdesc" HeaderText="dw_longdesc" 
                            SortExpression="dw_longdesc" />
                        <asp:BoundField DataField="Column1" HeaderText="Column1" ReadOnly="True" 
                            SortExpression="Column1" />
                        <asp:BoundField DataField="Column2" HeaderText="Column2" ReadOnly="True" 
                            SortExpression="Column2" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:CRRHKDWConnectionString %>" SelectCommand="select dw_plu, dw_longdesc,  sum(dw_amt), sum(dw_qty)
from dw_itemms
where dw_bu = 'CRV' and dw_txmonth = @txmonth
group by dw_plu, dw_longdesc">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TextBox1" Name="txmonth" PropertyName="Text" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
