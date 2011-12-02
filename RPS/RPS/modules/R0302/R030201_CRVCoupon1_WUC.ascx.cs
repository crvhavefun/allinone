using System;
using RPS.library;

namespace RPS.modules.R0302
{
    public partial class R030201_CRVCoupon1_WUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = @"select 	b.dw_txdate, b.dw_txtime, b.dw_storecode, b.dw_tillid, b.dw_docno, b.dw_payamount, 
		                            b.dw_tendercode, substring(b.dw_extendparam,1,14) dw_extendparam
                            from 	crvmkt_transsalestender b 
                            where 	b.dw_txdate between '@sdate' and '@edate' and 
		                            b.dw_extendparam like '%@couponno%'";

            User user = (User)Session["User"];

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, user.ReportParameters, "DataSet1"));
            rpt1.LocalReport.Refresh();
        }
    }
}