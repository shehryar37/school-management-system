using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iProject {
    class ConnectionSettings {
        static string connection = @"server=SHEHRYAR-PC; database=SchoolManagementSystem; user id=sa; password=05012002";
        SqlConnection sqlConnection = new SqlConnection(connection);

        public SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }
    }
}
