using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AddressBook
{
    public class SqlConn
    {

        private SqlConnection _sql = new SqlConnection("server = beast-pc;" +
                                      "Trusted_Connection = yes;" +
                                      "database = TestDB; " +
                                      "connection timeout = 30");
        public void ConnectSql()
        {
            _sql.Open();
        }

        public void CloseSql()
        {
            _sql.Close();
        }     
    }
}
