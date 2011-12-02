using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R01
{
    public partial class UserMaintenance : System.Web.UI.Page
    {
        Database db;
        String sql;
        protected void Page_Load(object sender, EventArgs e)
        {
            sql = "select	u.user_id, u.user_name, d.user_deptname " +
                "from	rps_userinfo u, rps_deptinfo d " +
                "where	u.user_dept = d.user_dept " +
                "order by u.user_id";
            this.db = new Database("rpsdb", this.sql, Database.WebConfig);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ClientScript = "location.replace('R0101_NewUser.aspx');";
            Page.ClientScript.RegisterStartupScript(GetType(), "CS_Redirect", ClientScript, true);
        }
    }
}