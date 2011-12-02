using System;
using System.Data.OleDb;
using System.Web.Configuration;


namespace RPS.library
{
    public class DbUtilites
    {
        public static OleDbConnection GetOleDbConnection(String WebConfigName)
        {
            OleDbConnection con = new OleDbConnection(WebConfigurationManager.ConnectionStrings[WebConfigName].ConnectionString);
            con.Open();

            return con;
        }

        public static OleDbDataReader GetOleDbDataReader(String Sql, String WebConfigName)
        {
            OleDbConnection con = GetOleDbConnection(WebConfigName);
            con.Open();

            OleDbCommand cmd = new OleDbCommand(Sql, con);
            OleDbDataReader reader = cmd.ExecuteReader();

            return reader;
        }
    }
}