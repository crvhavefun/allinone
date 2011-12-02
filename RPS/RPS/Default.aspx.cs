using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPS.library;

namespace RPS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String[] IPAddress = Request.ServerVariables["REMOTE_ADDR"].Split('.');
            ShowMessage("&nbsp;", MessagePanel, TB_UserID);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TB_UserID.Text.Equals(""))
                ShowMessage("請輸入用戶名稱！", MessagePanel, TB_UserID);
            else if (TB_UserPw.Text.Equals(""))
                ShowMessage("請輸入用戶密碼！", MessagePanel, TB_UserPw);
            else
            {
                String UserPW = "";
                String sql = "select user_pw from rps_userinfo where user_id = '" + TB_UserID.Text.Trim() + "'";
                try
                {
                    Database db = new Database("rpsdb", sql, Database.WebConfig);
                    SqlDataReader reader = db.GetReader();

                    while (reader.Read())
                        UserPW = reader["user_pw"].ToString();

                    if (!reader.HasRows || !TB_UserPw.Text.Trim().Equals(UserPW.Trim()))
                    {
                        TB_UserPw.Text = "";
                        ShowMessage("登入失敗！", MessagePanel, TB_UserPw);
                        db.Close();
                    }
                    else
                    {
                        Session[HF_UserToken.Value] = true;
                        Session["User"] = new User(TB_UserID.Text, TB_UserPw.Text, Request.UserHostAddress, HF_UserToken.Value);
                        db.Close();
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ClientScript", "location.replace('/Main.aspx');", true);
                    }
                }
                catch (SqlException)
                {
                    TB_UserPw.Text = "";
                    TB_UserPw.Text = "";
                    MessagePanel.Text = "資料庫連接失敗！";
                    //MessagePanel.Text = ex.Message;
                }
            }
        }
        
        /// <summary>
        /// Put message to message panel and focus on a specific textbox.
        /// </summary>
        /// <param name="Message">String</param>
        /// <param name="Label">Label</param>
        /// <param name="TextBox">TextBox</param>
        private void ShowMessage(String Message, Label Label, TextBox TextBox)
        {
            Label.Text = Message;
            TextBox.Focus();
        }
    }
}