<%@ Page Title="" Language="C#" MasterPageFile="~/RPS.Master" AutoEventWireup="true" CodeBehind="R0201_SC001.aspx.cs" Inherits="RPS.modules.R02.R0201_SC0011" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="1" style="width: 450px; border-collapse: collapse;">
        <tr>
            <td>
                品管報表 SC001</td>
            <td>
                類型:</td>
            <td>
                <asp:DropDownList ID="DDL_PTYPE" runat="server">
                    <asp:ListItem>LIVE</asp:ListItem>
                    <asp:ListItem>WIP</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td style="margin-left: 40px">
                <asp:Button ID="BTN_SUBMIT" runat="server" onclick="BTN_SUBMIT_Click" 
                    style="margin-bottom: 0px" Text="提交" />
            </td>
            <td style="margin-left: 40px">
                <asp:Button ID="BTN_EXPORT" runat="server" onclick="BTN_EXPORT_Click" 
                    Text="輸出至Excel" />
            </td>
        </tr>
    </table>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    Loading....
                </ProgressTemplate>
            </asp:UpdateProgress>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="BTN_SUBMIT" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
