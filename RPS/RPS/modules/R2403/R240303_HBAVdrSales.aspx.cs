using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R2403
{
    public partial class R240302_HBAVdrSales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            user.ResetReportParameter();

            user.AddReportParameter("@vdrid", TB_VdrID.Text.Trim());
            
            UpdatePanel1.ContentTemplateContainer.Controls.Clear();

            UpdatePanel1.ContentTemplateContainer.Controls.Add((UserControl)LoadControl("/modules/R2403/R240303_HBAVdrSales_WUC.ascx"));
        }
    }
}