using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R0302
{
    public partial class R030201_CRVCoupon1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            user.ResetReportParameter();
            user.AddReportParameter("@sdate", TB_SDATE.Text.Trim());
            user.AddReportParameter("@edate", TB_EDATE.Text.Trim());
            user.AddReportParameter("@couponno", TB_COUPON.Text.Trim());

            UpdatePanel1.ContentTemplateContainer.Controls.Clear();
            UpdatePanel1.ContentTemplateContainer.Controls.Add((UserControl)LoadControl("/modules/R0302/R030201_CRVCoupon1_WUC.ascx"));

        }
    }
}