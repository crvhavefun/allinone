using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R2403
{
    public partial class R240301_HBASalesByShopType1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TB_SSHOP.Text = "099100";
                TB_ESHOP.Text = "099599";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            user.ResetReportParameter();
            user.AddReportParameter("@sdate", TB_SDATE.Text.Trim());
            user.AddReportParameter("@edate", TB_EDATE.Text.Trim());
            user.AddReportParameter("@sshop", TB_SSHOP.Text.Trim());
            user.AddReportParameter("@eshop", TB_ESHOP.Text.Trim());

            UpdatePanel1.ContentTemplateContainer.Controls.Clear();
            UpdatePanel1.ContentTemplateContainer.Controls.Add((UserControl)LoadControl("/modules/R2403/R240301_HBASalesByShopType_WUC.ascx"));
        }
    }
}