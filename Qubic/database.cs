using System;
using System.Collections.Generic;
using System.Data;
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
                                      AttachDbFilename=|DataDirectory|Qubic_db.mdf;
                                      Integrated Security=True";
        }
        public void insert(string pX, string pO, string type, int res, int nbMoves)
        {
            SqlCommand com = new SqlCommand(null, conn);

            com.CommandText = @"INSERT INTO Results"
                        + "(Player_X, Player_O, Result, Moves, Type, Date) "
                        + "VALUES "
                        + "(@pX, @pO, @res, @moves, @type, "
                        + "CONVERT(DATETIME,'" + DateTime.Now.ToString() + "'));";

            SqlParameter resParam = new SqlParameter("@res", SqlDbType.Int, 0);
            SqlParameter movesParam = new SqlParameter("@moves", SqlDbType.Int, 0);
            resParam.Value = res;
            movesParam.Value = nbMoves;
            SqlParameter xParam = new SqlParameter("@pX", SqlDbType.NVarChar, -1);
            xParam.Value = pX;
            SqlParameter oParam = new SqlParameter("@pO", SqlDbType.NVarChar, -1);
            oParam.Value = pO;
            SqlParameter tParam = new SqlParameter("@type", SqlDbType.NVarChar, -1);
            tParam.Value = type;

            com.Parameters.Add(resParam);
            com.Parameters.Add(movesParam);
            com.Parameters.Add(xParam);
            com.Parameters.Add(oParam);
            com.Parameters.Add(tParam);


            try
            {
                conn.Open();
                com.Prepare();
                com.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        public String playerResultCount(string p, string label, int res, string type)
        {
            SqlCommand com = new SqlCommand(null, conn);
            
            string nb = "";

            com.CommandText = @"SELECT COUNT(*) AS nb "
                    + "FROM Results "
                    + "WHERE Result = @res" 
                    + " AND Type = @type" 
                    + " AND Player_" + label + " = @name; ";
            //Console.WriteLine(nbWins);
            
            SqlParameter resParam = new SqlParameter("@res", SqlDbType.Int, 0);
            resParam.Value = res;
            
            SqlParameter nParam = new SqlParameter("@name", SqlDbType.NVarChar, -1);
            nParam.Value = p;
            SqlParameter tParam = new SqlParameter("@type", SqlDbType.NVarChar, -1);
            tParam.Value = type;

            com.Parameters.Add(resParam);
            com.Parameters.Add(nParam);
            com.Parameters.Add(tParam);
            try
            {
                conn.Open();
                com.Prepare();

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
            SqlCommand com = new SqlCommand(null, conn);
            
            string nb = "";
            com.CommandText = @"SELECT COUNT(*) AS nb "
                            + "FROM Results "
                            + " WHERE Type = @type" 
                            + " AND (Player_X = @name"
                            + " OR Player_O = @name); ";

            
            
            SqlParameter nParam = new SqlParameter("@name", SqlDbType.NVarChar, -1);
            nParam.Value = p;
            SqlParameter tParam = new SqlParameter("@type", SqlDbType.NVarChar, -1);
            tParam.Value = type;
            
            com.Parameters.Add(nParam);
            com.Parameters.Add(tParam);


            try
            {
                conn.Open();
                com.Prepare();
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
            SqlCommand com = new SqlCommand(null, conn);
            
            string nb = "";
            com.CommandText = @"SELECT AVG(Moves) AS nb "
                    + "FROM Results "
                    + " WHERE Type = @type" 
                    + " AND (Player_X = @name"
                    + " OR Player_O = @name); ";

            
            SqlParameter nParam = new SqlParameter("@name", SqlDbType.NVarChar, -1);
            nParam.Value = p;
            SqlParameter tParam = new SqlParameter("@type", SqlDbType.NVarChar, -1);
            tParam.Value = type;

            
            com.Parameters.Add(nParam);
            com.Parameters.Add(tParam);
            try
            {
                conn.Open();
                com.Prepare();
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
            SqlCommand com = new SqlCommand(null, conn);
            
            string nb = "";
            com.CommandText = @"SELECT Date AS d "
                    + "FROM Results "
                    + " WHERE Type = @type" 
                    + " AND (Player_X = @name"
                    + " OR Player_O = @name)"
                    + " ORDER BY Date DESC; ";

            
            SqlParameter nParam = new SqlParameter("@name", SqlDbType.NVarChar, -1);
            nParam.Value = p;
            SqlParameter tParam = new SqlParameter("@type", SqlDbType.NVarChar, -1);
            tParam.Value = type;

            com.Parameters.Add(nParam);
            com.Parameters.Add(tParam);
            try
            {
                conn.Open();
                com.Prepare();
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
            SqlCommand com = new SqlCommand(null, conn);
            
            string list = "";
            com.CommandText = @"SELECT TOP 10 Player_" + label + " AS name, "
                + "SUM(CASE WHEN Result = -1 THEN 0.5 ELSE 1 END) AS b "
                + "FROM Results "
                + "WHERE Type = @type "
                + "AND (Result = 1 OR Result = -1) "
                + "GROUP BY Player_" + label + " ORDER BY b DESC;"; 

            
            SqlParameter tParam = new SqlParameter("@type", SqlDbType.NVarChar, -1);
            tParam.Value = type;

            
            com.Parameters.Add(tParam);
            try
            {
                conn.Open();
                com.Prepare();
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
