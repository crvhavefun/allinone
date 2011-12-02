using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPS.library;
using System.Data.SqlClient;

namespace RPS.modules.R01
{
    public partial class R0101_NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                ShowMessage("&nbsp;", MessagePanel, TB_UserID);
        }

        protected void Btn_AddUser_Click(object sender, EventArgs e)
        {
            if (TB_UserID.Text.Equals(""))
                ShowMessage("請輸入用戶ID！", MessagePanel, TB_UserID);
            else if (TB_UserPw.Text.Equals(""))
                ShowMessage("請輸入用戶密碼！", MessagePanel, TB_UserPw);
            else if (TB_UserName.Text.Equals(""))
                ShowMessage("請輸入用戶名稱！", MessagePanel, TB_UserName);
            else
            {
                String UserID = TB_UserID.Text.Trim();
                String UserName = TB_UserName.Text.Trim();
                String UserPW = Cryptography.MD5(TB_UserPw.Text);
                String UserDept = DDL_Dept.SelectedValue;
                
                String sql = "select * from rps_userinfo where user_id = '" + UserID + "'";
                Database db = new Database("rpsdb", sql, Database.WebConfig);
                SqlDataReader reader = db.GetReader();

                if (reader.HasRows)
                    ShowMessage("用戶ID己存在！", MessagePanel, TB_UserID);
                else
                {
                    reader.Close();
                    sql = "insert into rps_userinfo values (" +
                        "'" + UserID + "', '" + UserPW + "', '" + UserName + "', '" + UserDept + "', '1900-01-01 00:00:00.000', 'T')";
                    db.ExecuteSql(sql);
                    sql = "insert into rps_usermenu values ('" + UserID + "','R00')";
                    db.ExecuteSql(sql);
                    sql = "insert into rps_usermenu values ('" + UserID + "','R0002')";
                    db.ExecuteSql(sql);
                    String ClientScript = "alert('用戶新增成功！'); location.replace('R0101_UserMaintenance.aspx'); ";
                    ScriptManager.RegisterClientScriptBlock(UpdatePanel1, GetType(), "Alert", ClientScript, true);
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