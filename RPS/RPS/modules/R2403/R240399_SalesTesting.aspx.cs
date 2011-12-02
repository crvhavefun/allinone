using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RPS.library;

namespace RPS.modules.R2403
{
    public partial class R240399_SalesTesting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            user.ResetReportParameter();
            user.AddReportParameter("@plu", TextBox1.Text.Trim());

            UpdatePanel1.ContentTemplateContainer.Controls.Clear();
            UpdatePanel1.ContentTemplateContainer.Controls.Add((UserControl)LoadControl("/modules/R2403/R240399_SalesTesting_WUC.ascx"));
        }
    }
}