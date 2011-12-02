using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R2403
{
    public partial class R240399_SalesTesting1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String sql = @"SELECT	dw_plu, dw_group4desc, dw_edesc, dw_shortedesc, dw_group6, dw_itemstatus, 
                           dw_supplier, dw_category, dw_logisticsattrib, dw_longdesc, dw_desci, dw_du, 
                           dw_pu, dw_uom, dw_buyer, dw_buyername, dw_seluprice, dw_pprice, dw_unitcost, dw_group8 
                           FROM	dw_hbaitemmaster1 
                           where dw_plu = @plu
                           ORDER BY dw_plu";

            User user = (User)Session["User"];

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, user.ReportParameters, "DataSet1"));
            rpt1.LocalReport.Refresh();
        }
    }
}