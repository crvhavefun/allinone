using System;
using RPS_Shop.library;

namespace RPS_Shop.modules.R00
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                User user = (User)Session["User"];
                user.UserLog("Manual Logout System.");
            }
            catch (NullReferenceException)
            {

            }
            finally
            {
                Session.Clear();
                Session.Abandon();
                String ClientScript = "location.replace('/');";
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "ClientScript", ClientScript, true);
            }
        }
    }
}