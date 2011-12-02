using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R2301
{
    public partial class R230101_VOILADept5SalesRawData : System.Web.UI.Page
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

            UpdatePanel1.ContentTemplateContainer.Controls.Clear();
            UpdatePanel1.ContentTemplateContainer.Controls.Add((UserControl)LoadControl("/modules/R2301/R230101_VOILADept5SalesRawData_WUC.ascx"));
        }
    }
}