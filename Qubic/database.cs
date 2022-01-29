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
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                      AttachDbFilename=|DataDirectory|Qubic.mdf;
                                      Integrated Security=True";
        }

        public List<String> xStatistic()
        {
            
            var stat = new List<String>();
            /*
            string nbXWins = "select Player_X, count(*) from Results;";
            SqlCommand com = new SqlCommand(selectSql, conn);

            try
            {
                conn.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        imena.Add(read["Player_X"].ToString());
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            */
            return stat;
            
        }
    }
}
