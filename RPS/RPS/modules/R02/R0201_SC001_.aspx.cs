using System;
using System.Web.UI;
using RPS.library;

namespace RPS.modules.R02
{
    public partial class R0201_SC001 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) 
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String ptype = DropDownList1.Text;
            String sql = "select m.product_id, substr(s.store_no,3,4), count(c.product_id) " +
                    "from sc_plano_key p, sc_product_list m, sc_product t, sc_plano_stores s, sc_product c " +
                    "where 	p.key_id = m.key_id and m.product_id = t.product_id and m.product_id = c.product_id and " +
                    "p.key_id = s.key_id and p.hierarchylevel1 = '" + ptype + "' group by m.product_id, s.store_no ";

            rpt1.LocalReport.DataSources.Clear();
            rpt1.LocalReport.DataSources.Add(RptUtilites.GetReportDataSource("spaceman", sql, "DataSet1"));
            rpt1.LocalReport.Refresh();
        }
    }
}