﻿using System;
using System.IO;
using System.Web.UI;
using RPS_Shop.library;

namespace RPS_Shop
{
    public partial class RPS_Shop : System.Web.UI.MasterPage
    {
        private User user;
        private String fname;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.user = (User)Session["User"];
            this.fname = Path.GetFileNameWithoutExtension(Request.Path).Replace("Master", "");

            if (!Page.IsPostBack)
                this.user.UserLog(this.fname + ".aspx");

            try
            {
                if (!Page.IsPostBack && !user.CheckMenuPermission(this.fname))
                    redirect("/Main.aspx");
                else if (!this.user.CheckSession())
                    relogin("Session 錯誤！請再重新登入！");
                else
                {
                    Menu1.Items[0].Text = "主菜單";
                    Menu1.Items[0].Selectable = false;
                    if (!Page.IsPostBack)
                        Menu1 = user.UserMenu(Menu1);
                }
            }
            catch (NullReferenceException)
            {
                relogin("請先登入系統！");
            }
        }
        private void relogin(String str)
        {
            String ClientScript = "alert('" + str + "'); location.replace('/');";
            this.user.UserLog("Session Error.");
            Page.ClientScript.RegisterStartupScript(GetType(), "CS_Relogin", ClientScript, true);
        }

        private void redirect(String url)
        {
            String ClientScript = "location.replace('" + url + "');";
            this.user.UserLog("No Permission.");
            Page.ClientScript.RegisterStartupScript(GetType(), "CS_Redirect", ClientScript, true);
        }
    }
}