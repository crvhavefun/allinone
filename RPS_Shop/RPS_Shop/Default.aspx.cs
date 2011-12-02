using System;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPS_Shop.library;

namespace RPS_Shop
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowMessage("&nbsp;", MessagePanel, TB_UserPw);

                String[] IPAddress = Request.ServerVariables["REMOTE_ADDR"].Split('.');

                //Testing Code (Local Only)
                if (IPAddress[0].Equals("172"))
                {
                    IPAddress[0] = "10"; IPAddress[1] = "211"; IPAddress[2] = "105";
                }

                String sql = "select shop_bu, shop_id from rps_shopinfo " +
                    "where shop_ip1 = '" + IPAddress[0] + "' and shop_ip2 = '" + IPAddress[1] + "' and " +
                    "shop_ip3 = '" + IPAddress[2] + "' and shop_active = 'T'";

                Database db = new Database("rpsdb", sql, Database.WebConfig);
                SqlDataReader reader = db.GetReader();

                while (reader.Read())
                {
                    Session["bu"] = reader["shop_bu"];
                    Session["shop"] = reader["shop_id"];
                }

                if (!reader.HasRows)
                {
                    Response.Write("您沒有權限開啟此系統！");
                    Response.End();
                }
                else
                {
                    TB_UserID.Text = (String)Session["shop"];
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TB_UserPw.Text.Equals(""))
                ShowMessage("請輸入用戶密碼！", MessagePanel, TB_UserPw);
            else
            {
                String ShopPW = String.Empty;
                String ShopBU = String.Empty;
                Boolean ShopFirst = true;
                String sql = "select shop_pw, shop_first, shop_bu from rps_shopinfo where shop_id = '" + TB_UserID.Text.Trim() + "'";
                try
                {
                    Database db = new Database("rpsdb", sql, Database.WebConfig);
                    SqlDataReader reader = db.GetReader();

                    while (reader.Read())
                    {
                        ShopPW = reader["shop_pw"].ToString();
                        ShopFirst = reader["shop_first"].ToString().Equals("T");
                        ShopBU = reader["shop_bu"].ToString();
                    }

                    if (!reader.HasRows || !TB_UserPw.Text.Trim().Equals(ShopPW.Trim()))
                    {
                        TB_UserPw.Text = String.Empty;
                        ShowMessage("登入失敗！", MessagePanel, TB_UserPw);
                        db.Close();
                    }
                    else
                    {
                        Session[HF_UserToken.Value] = true;
                        Session["User"] = new User(TB_UserID.Text, TB_UserPw.Text, Request.UserHostAddress, HF_UserToken.Value, ShopBU);
                        db.Close();
                        
                        String location = "";
                        if (ShopFirst)
                            location = "location.replace('/FirstLogin.aspx');";
                        else
                            location = "location.replace('/Main.aspx');";

                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ClientScript", location, true);
                    }
                }
                catch (SqlException)
                {
                    TB_UserPw.Text = String.Empty;
                    MessagePanel.Text = "資料庫連接失敗！";
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