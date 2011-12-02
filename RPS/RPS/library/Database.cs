using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace RPS.library
{
    public class Database
    {
        public static bool WebConfig = true;
        public static bool ConString = false;

        private String ConnectionString;
        private SqlConnection con;
        private SqlDataAdapter adapter;
        private DataTable table;
        private DataSet set;
        public String Sql;

        public Database(String conString, String Sql, bool WebConfigFlag)
        {
            this.con = new SqlConnection();
            if (WebConfigFlag)
                this.ConnectionString = WebConfigurationManager.ConnectionStrings[conString].ConnectionString;
            else
                this.ConnectionString = conString;
            this.con.ConnectionString = this.ConnectionString;
            this.Sql = Sql;
        }

        private SqlConnection OpenConnection()
        {
            if (ConnectionState.Open != this.con.State)
                this.con.Open();
            return this.con;
        }
        
        public void Close()
        {
            if (ConnectionState.Open == this.con.State)
                GetConnection().Close();
        }

        public SqlConnection GetConnection()
        {
            return OpenConnection();
        }

        public SqlDataReader GetReader()
        {
            SqlCommand cmd = new SqlCommand(this.Sql, this.GetConnection());
            return cmd.ExecuteReader();
        }

        public Int64 ExecuteSql(String Sql)
        {
            this.Sql = Sql;
            SqlCommand cmd = new SqlCommand(this.Sql, this.GetConnection());
            return cmd.ExecuteNonQuery();
        }

        public SqlDataAdapter GetAdapter()
        {
            this.adapter = new SqlDataAdapter(this.Sql, this.ConnectionString);
            return this.adapter;
        }

        public DataTable GetTable()
        {
            this.adapter = GetAdapter();
            this.table = new DataTable();
            this.adapter.Fill(this.table);
            return this.table;
        }

        public DataSet GetSet()
        {
            this.adapter = GetAdapter();
            this.set = new DataSet();
            this.adapter.Fill(this.set);
            return this.set;
        }
    }
}