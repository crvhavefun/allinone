using System;
using RPS_Shop.library;

namespace RPS_Shop.modules.R10
{
    public partial class R1001_ItemSalesRanking_WUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = @"
                select   s.dw_plu, s.dw_longdesc, s.dw_amt, s.dw_qty,
                         RANK() over (order by s.dw_amt desc, s.dw_plu asc) as Amt_rank,
                         RANK() over (order by s.dw_qty desc, s.dw_plu asc) as Qty_rank
                from (
                     select	m.dw_plu, m.dw_longdesc, sum(i.dw_amt) dw_amt, SUM(i.dw_qty) dw_qty
                     from	dw_itemdsd i, dw_itemmas m
                     where	i.dw_bu = m.dw_bu and i.dw_plu = m.dw_plu 
    	                and i.dw_bu = '@bu' and m.dw_bu = '@bu'
	                    and i.dw_txdate between '@sdate' and '@edate'
	                    and i.dw_amt <> 0 and i.dw_storecode = '@shop'
                     group by m.dw_plu, m.dw_longdesc
                ) s ";

            User user = (User)Session["User"];

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, user.ReportParameters, "DataSet1"));

            sql = "select	'@shop' as shop, '@sdate' as sdate, '@edate' as edate";
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, user.ReportParameters, "DataSet2"));

            rpt1.LocalReport.Refresh();
        }
    }
}