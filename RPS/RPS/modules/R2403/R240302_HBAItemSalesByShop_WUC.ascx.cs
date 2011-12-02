using System;
using RPS.library;

namespace RPS.modules.R2403
{
    public partial class R240302_HBAItemSalesByShop_WUC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = @"
                    SELECT
	                    ITEMDSD.dw_txdate AS sales_date,
	                    ITEMDSD.dw_storecode AS shop,
	                    ITEMMAS.dw_group3 AS MINOR,
	                    ITEMMAS.dw_group3desc AS C_MINOR_DESC,
	                    ITEMDSD.dw_plu AS PLU,
	                    ITEMMAS.dw_longdesc AS E_DESC,
	                    ITEMMAS.dw_group4desc AS BRAND,
	                    SUM(dw_qty) AS SALES_QTY,
	                    SUM(dw_amt) AS SALES_AMT,
	                    SUM(dw_amt)/nullif(SUM(dw_qty), 0) AS AVE_PRICE,
	                    SUM(dw_cost)/nullif(SUM(dw_qty), 0) AS AVE_COST,
	                    SUM(dw_cost) AS SALES_COST,
	                    SUM(dw_amt-dw_cost)/nullif(SUM(dw_amt),0) AS GP_PERCENT, 
	                    SUM(dw_amt-dw_cost) AS GP
                    FROM 
	                    dw_itemdsd ITEMDSD, dw_itemmas ITEMMAS
                    WHERE 
	                    ITEMDSD.dw_plu = ITEMMAS.dw_plu and ITEMDSD.dw_bu = ITEMMAS.dw_bu
	                    and ITEMDSD.dw_bu = 'HBA' and ITEMMAS.dw_bu = 'HBA'
	                    and ITEMDSD.dw_txdate between '@sdate' and '@edate'
	                    and ITEMDSD.dw_storecode between '@sshop' and '@eshop'
                    GROUP BY 
	                    ITEMDSD.dw_txdate, ITEMDSD.dw_storecode, 
	                    ITEMMAS.dw_group3, ITEMMAS.dw_group3desc, 
	                    ITEMDSD.dw_plu, ITEMMAS.dw_longdesc, 
	                    ITEMMAS.dw_group4desc
                    ORDER BY 
	                    ITEMDSD.dw_txdate, ITEMDSD.dw_storecode, ITEMMAS.dw_group3";

            User user = (User)Session["User"];

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, user.ReportParameters, "DataSet1"));
            rpt1.LocalReport.Refresh();
        }
    }
}