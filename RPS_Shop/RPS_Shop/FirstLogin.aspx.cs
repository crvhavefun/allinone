using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPS_Shop.library;

namespace RPS_Shop
{
    public partial class FirstLogin : System.Web.UI.Page
    {
        private User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.user = (User)Session["User"];
            if (!Page.IsPostBack)
            {
                ShowMessage("閣下第一次登入，為保障安全，麻煩您修改密碼！密碼最少六個位。", MessagePanel, TB_NewPW);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String UserPW = "";

            if (TB_NewPW.Text.Length < 6)
                ShowMessage("密碼最少六個位！", MessagePanel, TB_NewPW);
            else if (TB_ConfirmPW.Text.Length < 6)
                ShowMessage("密碼最少六個位！", MessagePanel, TB_ConfirmPW);
            else if (TB_NewPW.Text.Equals(""))
                ShowMessage("請輸入新密碼！", MessagePanel, TB_NewPW);
            else if (TB_ConfirmPW.Text.Equals(""))
                ShowMessage("請輸入確認密碼！", MessagePanel, TB_ConfirmPW);
            else if (!TB_NewPW.Text.Equals(TB_ConfirmPW.Text))
            {
                ShowMessage("新密碼及確認密碼不相符！", MessagePanel, TB_NewPW);
            }
            else
            {
                String sql = "select shop_pw from rps_shopinfo where shop_id = '" + this.user.ID + "'";
                Database db = new Database("rpsdb", sql, Database.WebConfig);
                SqlDataReader reader = db.GetReader();

                while (reader.Read())
                    UserPW = reader["shop_pw"].ToString();

                db.Close();
                if (UserPW.Equals(Cryptography.MD5(TB_NewPW.Text)))
                {
                    ShowMessage("不能使用舊密碼！請更改！", MessagePanel, TB_NewPW);
                    TB_NewPW.Text = String.Empty;
                    TB_ConfirmPW.Text = String.Empty;
                }
                else
                {
                    String HashPW = Cryptography.MD5(TB_NewPW.Text);
                    String ShopID = user.ID;
                    sql = "update rps_shopinfo set shop_first = 'F', shop_pw = '" + HashPW + "' " +
                          "where shop_id = '" + ShopID + "'";
                    db = new Database("rpsdb", sql, Database.WebConfig);
                    db.ExecuteSql(sql);
                    db.Close();
                    String script = "alert('密碼成功更新！'); location.replace('/Main.aspx');";
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