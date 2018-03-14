using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class CommonDB
    {
        // FIELDS
        protected string conString;

        // CONSTRUCTORS
        public CommonDB(string conString)
        {
            this.conString = conString;
        }

        // METHODS
        protected void ExecuteNonQuery(string queryString)
        {
            using(SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(queryString))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        protected DataSet ExecuteQuery(string queryString)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(queryString, con))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        con.Open();
                        cmd.ExecuteNonQuery();
                        dataAdapter.Fill(ds);
                        return ds;
                    }
                }
            }
        }
    }
}
