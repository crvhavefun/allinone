using System;
using RPS.library;

namespace RPS.modules.R2301
{
    public partial class R230101_VOILADept5SalesRawData_WUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = @"select	
	                            m.dw_plu, m.dw_longdesc, m.dw_group3, m.dw_group3desc, m.dw_buyer, 
                                m.dw_suppcode, m.dw_suppname, i.dw_storecode, 
	                            sum(i.dw_amt) samt, sum(i.dw_cost) scost, sum(i.dw_qty) sqty
                        from    dw_itemdsd i, dw_itemmas m
                        where   i.dw_bu = m.dw_bu and i.dw_plu = m.dw_plu and
                                m.dw_group0 = '5' and i.dw_txdate between '@sdate' and '@edate'
                        group by m.dw_plu, m.dw_longdesc, m.dw_group3, m.dw_group3desc, m.dw_buyer, 
                                 m.dw_suppcode, m.dw_suppname, i.dw_storecode";

            User user = (User)Session["User"];

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, user.ReportParameters, "DataSet1"));
            rpt1.LocalReport.Refresh();
        }
    }
}