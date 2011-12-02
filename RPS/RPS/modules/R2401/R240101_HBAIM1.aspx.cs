using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R2401
{
    public partial class R240101_HBAItemMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                String sql = @"SELECT	dw_plu, dw_group4desc, dw_edesc, dw_shortedesc, dw_group6, dw_itemstatus, 
                             dw_supplier, dw_category, dw_logisticsattrib, dw_longdesc, dw_desci, dw_du, 
                             dw_pu, dw_uom, dw_buyer, dw_buyername, dw_seluprice, dw_pprice, dw_unitcost, dw_group8 
                             FROM	dw_hbaitemmaster1 ORDER BY dw_plu";

                rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("crrhkdw", sql, "DataSet1"));
                rpt1.LocalReport.Refresh();
            }
        }
    }
}