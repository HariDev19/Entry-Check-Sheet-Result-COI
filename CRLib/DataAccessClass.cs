using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Input;

namespace ChkResultLib
{
    public class DataAccessClass
    {
        SqlDataReader dr;
        bool ret = false;
        string retStr = "";

        public string funGetConString(string server, string db, string userdb, string passdb)
        {
            retStr = "server = " + server + "; database = " + db + "; user = " + userdb + "; password = " + passdb + "";
            return retStr;
        }

        public DataTable funGetDataTable(string server, string db, string userdb, string passdb, string strQuery)
        {
            DataTable dtTbl = new DataTable();
            using (SqlConnection con = new SqlConnection(funGetConString(server, db, userdb, passdb)))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(strQuery, con))
                {
                    cmd.CommandTimeout = 0;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    try
                    {
                        sda.Fill(dtTbl);
                    }
                    catch(Exception ex)
                    {
                        dtTbl = null;
                    }
                }
            }
            return dtTbl;
        }

        public SqlDataReader funGetDataReader(string server, string db, string userdb, string passdb, string strQuery)
        {
            using (SqlConnection con = new SqlConnection(funGetConString(server, db, userdb, passdb)))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(strQuery, con))
                {
                    cmd.CommandTimeout = 0;
                    try
                    {
                        dr = cmd.ExecuteReader();
                        ret = true;
                    }
                    catch(Exception ex)
                    {
                        ret = false;
                    }
                }
            }
            return dr;
        }

        public bool funExecMultiQuery(string server, string db, string userdb, string passdb, List<string> strQueries)
        {
            
            SqlTransaction sqlTrn;
            using (SqlConnection con = new SqlConnection(funGetConString(server, db, userdb, passdb)))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    sqlTrn = con.BeginTransaction();
                    cmd.Connection = con;
                    cmd.Transaction = sqlTrn;
                    try
                    {
                        foreach (string query in strQueries)
                        {
                            if (query != "")
                            {
                                cmd.CommandText = query;
                                cmd.CommandTimeout = 0;
                                cmd.ExecuteNonQuery();
                            }
                        }
                        sqlTrn.Commit();
                        ret = true;
                    }
                    catch (Exception ex)
                    {
                        sqlTrn.Rollback();
                        ret = false;
                    }
                }
                    
                
            }
            
            return ret;
        }

        public bool funExecSingleQuery(string server, string db, string userdb, string passdb, string strQuery)
        {
            using (SqlConnection con = new SqlConnection(funGetConString(server, db, userdb, passdb)))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(strQuery, con))
                {
                    com.CommandTimeout = 0;
                    try
                    {
                        ret = true;
                        com.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        ret = false;
                    }
                }
            }
            return ret;
        }
    }
}
