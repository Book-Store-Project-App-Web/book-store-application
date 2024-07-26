using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace BLL
{
    public class Loginclass
    {
        
        public Loginclass()
        {
            
        }
        
        public int Check_config(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                return 1;
            SqlConnection _Sqlconn = new SqlConnection(connectionString);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;
            }
            catch
            {
                return 2;
            }
        }

        public Utilities.LoginResult Check_User(string pUsername, string pPassword)
        {
            //using (SqlConnection con = new SqlConnection(connectString))
            //{
            //    string query = "SELECT * FROM QL_NguoiDung WHERE TenDangNhap = @username AND MatKhau = @password";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.Parameters.AddWithValue("@username", pUsername);
            //    cmd.Parameters.AddWithValue("@password", pPassword);

            //    SqlDataAdapter dataUser = new SqlDataAdapter(cmd);
            //    DataTable data = new DataTable();
            //    dataUser.Fill(data);

            //    if (data.Rows.Count == 0) return Utilities.LoginResult.Invalid;
            //    else if (data.Rows[0][2] == null || data.Rows[0][2].ToString() == "False")
            //    {
            //        return Utilities.LoginResult.Disabled;
            //    }
                return Utilities.LoginResult.Success;
            //}
        }

        public DataTable getServerName()
        {
            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }

        public DataTable GetDBName(string pServer, string pUser, string pPassword)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source = " + pServer + "; Initial Catalog = master; User ID = " + pUser + ";pwd = " + pPassword + "");
            da.Fill(dt);
            return dt;
        }

    }
}
