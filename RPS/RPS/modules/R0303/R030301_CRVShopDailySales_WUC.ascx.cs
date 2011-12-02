using System;
using RPS.library;

namespace RPS.modules.R0303
{
    public partial class R030301_CRVShopDailySales_WUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = @"select dw_storecode, dw_txdate, SUM(dw_amt) samt
                           from crvmkt_itemdsd
                           where dw_txdate between '@sdate' and '@edate'
                           group by dw_storecode, dw_txdate";
            
            User user = (User)Session["User"];

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, user.ReportParameters, "DataSet1"));
            rpt1.LocalReport.Refresh();
        }
    }
}