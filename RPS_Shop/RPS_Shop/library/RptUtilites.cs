using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web.Configuration;
using Microsoft.Reporting.WebForms;

namespace RPS_Shop.library
{
    public class RptUtilites
    {
        /// <summary>
        /// 1. Get connection string from web config
        /// 2. Create OleDbConnection,  create OleDbDataAdpater and execute sql
        /// 3. Fill data into DataSet
        /// 4. Close connection
        /// </summary>
        /// <param name="WebConfigName"></param>
        /// <param name="Sql"></param>
        /// <param name="DSName"></param>
        /// <returns></returns>
        public static ReportDataSource GetReportDataSource(String WebConfigName, String Sql, String DSName)
        {
            OleDbConnection con = new OleDbConnection(WebConfigurationManager.ConnectionStrings[WebConfigName].ConnectionString);
            con.Open();

            DataSet ds = new DataSet();
            new OleDbDataAdapter(Sql, con).Fill(ds);
            con.Close();

            return new ReportDataSource(DSName, ds.Tables[0]);
        }

        public static ReportDataSource GetReportDataSource(String WebConfigName, String Sql, Dictionary<String, String> RptParameter, String DSName)
        {
            foreach (KeyValuePair<String, String> kvp in RptParameter)
            {
                String key = kvp.Key;
                String val = kvp.Value;

                Sql = Sql.Replace(key, val);
            }
            return GetReportDataSource(WebConfigName, Sql, DSName);
        }
    }
}