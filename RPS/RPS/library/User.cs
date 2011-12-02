using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;
using System.Collections.Generic;

namespace RPS.library
{
    public class User
    {
        public String ID, PW, IPAddress, Token, ss;
        private String sql;
        private Database db;
        private DataTable table;
        public Dictionary<String, String> ReportParameters;

        public User(String ID, String PW, String IPAddress, String Token)
        {
            this.ID = ID;
            this.PW = PW;
            this.IPAddress = IPAddress;
            this.Token = Token;
            this.ss = HttpContext.Current.Session.SessionID;

            this.sql = "insert into rps_session values('" + this.ID + "','" + this.Token +
                "','" + this.ss + "', GETDATE(), '" + this.IPAddress + "')";
            this.db = new Database("rpsdb", this.sql, Database.WebConfig);
            this.db.ExecuteSql(this.sql);
            this.db.Close();

            ResetReportParameter();
        }

        public String GetUserID()
        {
            return this.ID;
        }

        public bool ValidatePassword(String str)
        {
            return this.PW == Cryptography.MD5(str);
        }

        public void UpdatePassword(String str)
        {
            String sql = "Update rps_userinfo set user_pw = '" + str + "' where user_id = '" + this.ID + "'";
            this.db.ExecuteSql(sql);
            this.db.Close();
        }

        public bool CheckSession()
        {
            bool flag = false;
            this.db.Sql = "select user_token from rps_currentsession where "
                + "user_id = '" + this.ID + "' and user_session = '" + this.ss + "'";
            flag = db.GetReader().HasRows;
            this.db.Close();

            return flag;
        }

        public Menu UserMenu(Menu menu)
        {
            this.db.Sql = "select t.mnu_id, t.mnu_name, t.mnu_parent, t.mnu_module from rps_menutree t, rps_usermenu u " +
                "where t.mnu_id = u.mnu_id and u.user_id = '"+this.ID+"' order by t.mnu_id";
            this.table = this.db.GetTable();
            DataView view = new DataView(table);
            view.RowFilter = "mnu_parent IS NULL";
            foreach (DataRowView row in view)
            {
                MenuItem item = new MenuItem(row["mnu_name"].ToString(), row["mnu_id"].ToString());
                item.Selectable = false;
                menu.Items.Add(item);
                AddChildMenuItem(item);
            }
            this.db.Close();
            return menu;
        }

        private void AddChildMenuItem(MenuItem parent)
        {
            DataView view = new DataView(this.table);
            view.RowFilter = "mnu_parent='" + parent.Value+"'";
            foreach (DataRowView row in view)
            {
                MenuItem item = new MenuItem(row["mnu_name"].ToString(), row["mnu_id"].ToString());
                if (row["mnu_module"].ToString().Equals(""))
                {
                    item.Selectable = false;
                }
                else
                {
                    item.NavigateUrl = "modules/" + row["mnu_parent"].ToString() + "/" + row["mnu_module"].ToString() + ".aspx";
                    item.Value = row["mnu_id"].ToString();
                }                
                parent.ChildItems.Add(item);
                AddChildMenuItem(item);
            }
        }

        public bool CheckMenuPermission(String module)
        {
            bool flag = false;
            if (!module.ToUpper().Equals("MAIN"))
            {
                /*db.Sql = "select * from rps_usermenu where user_id = '" + this.ID + "' and mnu_id = " +
                "(select mnu_id from rps_menutree where mnu_module = '" + module + "')";*/

                db.Sql = "select * from rps_usermenu where user_id = '" + this.ID + "' and mnu_id = '" + module + "'";

                SqlDataReader reader = db.GetReader();
                flag = reader.HasRows;
                reader.Close();
            }
            else flag = true;
            return flag;
        }

        public void UserLog(String PageName)
        {
            String Sql = "insert into rps_log values ('" + this.ID + "','" + PageName + "',GETDATE())";
            db.ExecuteSql(Sql);
        }

        public void ResetReportParameter()
        {
            this.ReportParameters = new Dictionary<string, string>();
        }
        
        public void AddReportParameter(String Key, String Value)
        {
            this.ReportParameters.Add(Key, Value);
        }
    }
}