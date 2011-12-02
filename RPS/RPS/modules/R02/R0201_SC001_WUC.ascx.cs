using System;
using RPS.library;

namespace RPS.modules.R02
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];

            if (Session.Count > 0)
                for (int i = 0; i < Session.Count; i++)
                    if (Session[i].GetType().ToString().Equals("Microsoft.Reporting.WebForms.ReportHierarchy"))
                        Session.RemoveAt(i);

            String sql = @"select   p.hierarchylevel1 , m.product_id, ma.xf_longdesc, g.xf_desci, ma.xf_group3, substr(s.store_no,3,4), count(c.product_id)
                            from   sc_plano_key p, sc_product_list m, sc_product t, sc_plano_stores s, sc_product c, sc_itemmas ma, sc_groupval g
                            where	m.product_id = ma.xf_plu and ma.xf_group2 = g.xf_code and
	                                p.key_id = m.key_id and m.product_id = t.product_id and 
	                                m.product_id = c.product_id and p.key_id = s.key_id and 
	                                g.xf_groupid = 'GROUP2' and p.hierarchylevel1 = '@ptype'
                            group by p.hierarchylevel1 , m.product_id, ma.xf_longdesc, g.xf_desci, ma.xf_group3, s.store_no";

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("spaceman", sql, user.ReportParameters, "DataSet1"));
            rpt1.LocalReport.Refresh();
        }
    }
}