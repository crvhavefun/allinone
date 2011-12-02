using System;
using System.Web.UI;
using RPS_Shop.library;

namespace RPS_Shop.modules.R10
{
    public partial class R1001_ItemSalesRanking : System.Web.UI.Page
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
            user.AddReportParameter("@bu", user.bu.Trim());
            user.AddReportParameter("@shop", user.ID.Trim());

            UpdatePanel1.ContentTemplateContainer.Controls.Clear();
            UpdatePanel1.ContentTemplateContainer.Controls.Add((UserControl)LoadControl("/modules/R10/R1001_ItemSalesRanking_WUC.ascx"));
        }
    }
}