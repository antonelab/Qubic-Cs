using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qubic
{
    class database
    {
        private SqlConnection conn;

        public database()
        {
            conn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=Results");
        }
    }
}
