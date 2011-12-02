<%@ Page Title="" Language="C#" MasterPageFile="~/RPS.Master" AutoEventWireup="true" CodeBehind="R0101_UserMaintenance.aspx.cs" Inherits="RPS.modules.R01.UserMaintenance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="新增用戶" onclick="Button1_Click" />
    <br />
    <br />
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" 
    AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
    DataKeyNames="user_id" DataSourceID="SqlDataSource1" ForeColor="#333333" 
    GridLines="None">
                <AlternatingRowStyle BackColor="White" 
        ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="user_id" HeaderText="User ID" ReadOnly="True" 
                        SortExpression="user_id" />
                    <asp:BoundField DataField="user_name" HeaderText="User Name" 
                        SortExpression="user_name" />
                    <asp:BoundField DataField="user_deptname" HeaderText="Department" 
                        ReadOnly="True" SortExpression="user_deptname" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" 
        ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" 
        ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" 
        HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" 
        ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="GridView1" EventName="PageIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="Data Source=172.16.4.6;Initial Catalog=ReportPlatformDB;Persist Security Info=True;User ID=rpsdb;Password=rpsdb1234*" 
        ProviderName="System.Data.SqlClient" SelectCommand="select	u.user_id, u.user_name, d.user_deptname
from	rps_userinfo u, rps_deptinfo d
where	u.user_dept = d.user_dept
order by u.user_id"></asp:SqlDataSource>
    <br />
</asp:Content>
