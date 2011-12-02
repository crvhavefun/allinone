using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPS.library;

namespace RPS.modules.R02
{
    public partial class R0201_SC0011 : System.Web.UI.Page
    {

        User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.user = (User)Session["User"];
        }

        protected void BTN_EXPORT_Click(object sender, EventArgs e)
        {
            user.ResetReportParameter();
        }

        protected void BTN_SUBMIT_Click(object sender, EventArgs e)
        {
            user.ResetReportParameter();
            user.AddReportParameter("@ptype", DDL_PTYPE.SelectedValue);
            UpdatePanel1.ContentTemplateContainer.Controls.Clear();
            UpdatePanel1.ContentTemplateContainer.Controls.Add((UserControl)LoadControl("/modules/R02/R0201_SC001_WUC.ascx"));
        }
    }
}