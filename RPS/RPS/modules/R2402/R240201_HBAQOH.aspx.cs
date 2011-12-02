using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R2402
{
    public partial class HBAQOH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                String sql = "select 	m.xf_plu code, m.xf_longdesc name, m.xf_buyer buyer, q.xf_storecode storecode, " +
                    "round(sum(q.xf_qoh/s.xf_ratio),2) du_qoh, s.xf_itemspecdesc du, m.xf_suppcode suppcode, " +
                    "u.xf_name suppname, e.xf_logisticsattrib " +
                    "from 	xf_itemmas m, xf_qohbal q, xf_itemspec s, xf_supplier u, xf_itemextstat e " +
                    "where 	m.xf_plu = q.xf_plu and m.xf_plu = s.xf_style and m.xf_suppcode = u.xf_suppcode and " +
                    "m.xf_plu = e.xf_plu and e.xf_storecode = '009901' and " +
                    "(q.xf_storecode between '099002' and '099999' or q.xf_storecode = '009901') and " +
                    "q.xf_baldate = to_date(to_char(sysdate-1,'yyyymmdd'),'yyyymmdd') and s.xf_specid = 'DU' " +
                    "group by m.xf_plu, m.xf_longdesc, m.xf_buyer, s.xf_itemspecdesc, q.xf_storecode, m.xf_suppcode, u.xf_name, e.xf_logisticsattrib " +
                    "order by m.xf_plu";

                rpt1.LocalReport.DataSources.Clear();
                rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("hbahk", sql, "DataSet1"));
                rpt1.LocalReport.Refresh();
            }
        }
    }
}