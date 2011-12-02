using System;
using RPS.library;

namespace RPS.modules.R2403
{
    public partial class R240301_HBASalesByShopType_WUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = @"
				SELECT	m.[dw_group3] AS MINOR,
						m.[dw_group3desc] AS C_MINOR_DESC,
						m.[dw_plu] AS PLU,
						m.[dw_longdesc] AS E_DESC,
						SUM(i.[dw_qty]) AS SALES_QTY,
						SUM(i.[dw_amt]) AS SALES_AMT,
						SUM(i.[dw_amt])/nullif(SUM(i.[dw_qty]), 0) AS AVE_PRICE,
						SUM(i.[dw_cost])/nullif(SUM(i.[dw_qty]), 0) AS AVE_COST,
						SUM(i.[dw_cost]) AS SALES_COST,
						SUM(i.[dw_amt]-i.[dw_cost])/nullif(SUM(i.[dw_amt]),0) AS GP_PERCENT , 
						SUM(i.[dw_amt]-i.[dw_cost]) AS GP
				FROM    dw_itemdsd i, dw_itemmas m
				WHERE   i.dw_plu = m.dw_plu and i.dw_bu = m.dw_bu and
						i.dw_bu = 'HBA' and m.dw_bu = 'HBA' and
					    dw_txdate between '@sdate' and '@edate' and
	                    dw_storecode between '@sshop' and '@eshop'
				GROUP BY m.[dw_group3], m.[dw_group3desc], m.[dw_plu], m.[dw_longdesc]
				ORDER BY m.[dw_group3]";
            
            User user = (User)Session["User"];

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, user.ReportParameters, "DataSet1"));
            rpt1.LocalReport.Refresh();
        }
    }
}