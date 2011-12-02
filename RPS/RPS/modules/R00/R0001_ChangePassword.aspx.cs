using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPS.library;

namespace RPS.modules.R00
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.user = (User)Session["User"];
            if (!this.Page.IsPostBack)
            {
                TB_OldPassword.Focus();
                MessagePanel.Text = "&nbsp;";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TB_OldPassword.Text.Equals(""))
                ShowMessage("請輸入舊密碼！", MessagePanel, TB_OldPassword);
            else if (TB_NewPassword.Text.Equals(""))
                ShowMessage("請輸入新密碼！", MessagePanel, TB_NewPassword);
            else if (TB_ConfirmPassword.Text.Equals(""))
                ShowMessage("請輸入確認密碼！", MessagePanel, TB_ConfirmPassword);
            else if (!TB_ConfirmPassword.Text.Equals(TB_NewPassword.Text))
            {
                ShowMessage("新密碼與確認密碼不吻合！", MessagePanel, TB_NewPassword);
                TB_NewPassword.Text = "";
                TB_ConfirmPassword.Text = "";
            }
            else if (!this.user.ValidatePassword(TB_OldPassword.Text))
            {
                ShowMessage("舊密碼不正確！", MessagePanel, TB_OldPassword);
            }
            else
            {
                MessagePanel.Text = "&nbsp;";
                try
                {
                    String HashPW = Cryptography.MD5(TB_NewPassword.Text);
                    String sql = "update rps_userinfo set user_pw = '" + HashPW + "' where user_id = '" + user.ID + "'";
                    Database db = new Database("rpsdb", sql, Database.WebConfig);
                    db.ExecuteSql(sql);
                    MessagePanel.Text = "&nbsp;";
                    TB_OldPassword.Text = "";
                    TB_NewPassword.Text = "";
                    TB_ConfirmPassword.Text = "";
                    String script = "alert('密碼成功更新！'); location.replace('/Main.aspx');";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ClientScript", script, true);
                }
                catch (Exception)
                {
                    String script = "alert('密碼更新失敗！'); location.replace('/Main.aspx');";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ClientScript", script, true);
                }
            }
        }

        private void ShowMessage(String Message, Label Label, TextBox TextBox)
        {
            Label.Text = Message;
            TextBox.Focus();
        }
    }
}