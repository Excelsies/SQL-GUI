using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SQLGUIProject
{
    class runSQLQuery
    {
        public DataTable runQuery(string query, SQLGUI.Common.SQLServer server, string database, List<string> parameters)
        {
            SqlConnection myConnection;
            SqlCommand myCommand;
            DataTable dt = new DataTable();

            //sets up the connection to the database
            if (!server.WindowsAuthentication)
            {
                if (database == null)
                {
                    myConnection = new SqlConnection("user id=" + server.ServerCredentials[0] +
                                               ";password=" + server.ServerCredentials[1] + ";server=" + server +
                                               "connection timeout=5");
                }
                else
                {
                    myConnection = new SqlConnection("user id=" + server.ServerCredentials[0] +
                                               ";password=" + server.ServerCredentials[1] + ";server=" + server +
                                               ";database=" + database + "_MPICore_Data; " +
                                               "connection timeout=5");
                }
            }
            else
            {
                if (database != null)
                {
                    myConnection = new SqlConnection("server=" + server + ";database=" + database + "Integrated Security=SSPI; connection timeout=8");
                }
                else
                {
                    myConnection = new SqlConnection("server=" + server + "; Integrated Security=SSPI; connection timeout=8");
                }

            }

            //tries to open the connection
            try
            {
                myConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //tries to run the query
            try
            {
                SqlDataReader myReader = null;

                string command = null;

                string[] querySplit = query.Split(new[] { "[P]" }, StringSplitOptions.None);

                for (int i = 0; i < querySplit.Length; i++)
                {
                    if (parameters.Count > i)
                        command += querySplit[i] + "'" + parameters[i] + "'";
                    else
                        command += querySplit[i];
                }


                myCommand = new SqlCommand(command, myConnection);

                myReader = myCommand.ExecuteReader();

                try
                {
                    //outputs the results
                    if (myReader.HasRows)
                    {

                        dt.Load(myReader);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            try
            {
                myConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return dt;
        }
    }
}
