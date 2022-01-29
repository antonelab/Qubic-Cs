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

        public String playerResultCount(string p, string label, int res, string type)
        {
            string nbWins;
            string nb = "";

            nbWins = @"SELECT COUNT(*) AS nb "
                    + "FROM Results "
                    + "WHERE Result = " + res.ToString()
                    + " AND Type = \'" + type 
                    + "\' AND Player_" + label + " =\'" + p + "\'; ";
            //Console.WriteLine(nbWins);
            
            SqlCommand com = new SqlCommand(nbWins, conn);

            try
            {
                conn.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        nb = read["nb"].ToString();
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
            if (nb.Equals("")) nb = "0";
            return nb;
            
        }

        public String totalGames(string p, string type)
        {
            string total;
            string nb = "";
            total = @"SELECT COUNT(*) AS nb "
                    + "FROM Results "
                    + " WHERE Type = \'" + type
                    + "\' AND (Player_X =\'" + p + "\'"
                    + " OR Player_O =\'" + p + "\'); ";
      
            SqlCommand com = new SqlCommand(total, conn);

            try
            {
                conn.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        nb = read["nb"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            if (nb.Equals("")) nb = "0";
            return nb;

        }
        public String movesAvg(string p, string type)
        {
            string total;
            string nb = "";
            total = @"SELECT AVG(Moves) AS nb "
                    + "FROM Results "
                    + " WHERE Type = \'" + type
                    + "\' AND (Player_X =\'" + p + "\'"
                    + " OR Player_O =\'" + p + "\'); ";

            SqlCommand com = new SqlCommand(total, conn);

            try
            {
                conn.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        nb = read["nb"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            if (nb.Equals("")) nb = "0";
            return nb;

        }

        public String lastPlayed(string p, string type)
        {
            string l;
            string nb = "";
            l = @"SELECT Date AS d "
                    + "FROM Results "
                    + " WHERE Type = \'" + type
                    + "\' AND (Player_X =\'" + p + "\'"
                    + " OR Player_O =\'" + p + "\')"
                    + " ORDER BY Date DESC; ";

            SqlCommand com = new SqlCommand(l, conn);

            try
            {
                conn.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    while (read.Read())
                    {
                        nb = read["d"].ToString();
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            if (nb.Equals("")) nb = "-";
            return nb;

        }
        public String topPlayers(string label, string type)
        {
            string l="";
            string list = "";
            l = @"SELECT TOP 10 Player_" + label + " AS name, "
                + "SUM(CASE WHEN Result = -1 THEN 0.5 ELSE 1 END) AS b "
                + "FROM Results "
                + "WHERE Type = \'" + type + "\' "
                + "AND (Result = 1 OR Result = -1) "
                + "GROUP BY Player_" + label + " ORDER BY b DESC;"; 

            //Console.WriteLine(l);
            SqlCommand com = new SqlCommand(l, conn);

            try
            {
                conn.Open();

                using (SqlDataReader read = com.ExecuteReader())
                {
                    int counter = 1;
                    while (read.Read())
                    {
                        list += counter.ToString() + ".  ";
                        list += read["name"].ToString();
                        list += "   ";
                        list += read["b"].ToString();
                        list += "\n";
                        counter++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            if (list.Equals("")) list = "-";
            return list;

        }
    }
}
