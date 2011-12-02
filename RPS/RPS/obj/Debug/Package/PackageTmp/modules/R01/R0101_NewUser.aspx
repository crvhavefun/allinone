<%@ Page Title="" Language="C#" MasterPageFile="~/RPS.Master" AutoEventWireup="true" CodeBehind="R0101_NewUser.aspx.cs" Inherits="RPS.modules.R01.R0101_NewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table border="1" style="width: 300px; border-collapse: collapse;">
            <tr>
                <td>
                    User Id:</td>
                <td>
                    <asp:TextBox ID="TB_UserID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    User Name:</td>
                <td>
                    <asp:TextBox ID="TB_UserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    User PW:</td>
                <td>
                    <asp:TextBox ID="TB_UserPw" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Department:</td>
                <td>
                    <asp:DropDownList ID="DDL_Dept" runat="server" DataSourceID="SqlDataSource1" 
                        DataTextField="user_deptname" DataValueField="user_dept">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="Data Source=172.16.4.6;Initial Catalog=ReportPlatformDB;Persist Security Info=True;User ID=rpsdb;Password=rpsdb1234*" 
                        ProviderName="System.Data.SqlClient" 
                        SelectCommand="SELECT [user_dept], [user_deptname] FROM [rps_deptinfo] ORDER BY [user_deptname]">
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="MessagePanel" runat="server" Text="MessagePanel"></asp:Label>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="Btn_AddUser" EventName="Click" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Btn_AddUser" runat="server" onclick="Btn_AddUser_Click" 
                        Text="Add User" />
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
