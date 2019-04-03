using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DevFINITY.DigitalIdentity.Classes
{
    [Serializable]
    public class ConnectionManager
    {
        private static MySqlConnection _MySqlConnection;
        private static MySqlCommandBuilder _MySqlCommandBuilder;
        private static MySqlDataAdapter _MySqlDataAdapter;

        private ConnectionManager()
        {
            if (_MySqlConnection == null || _MySqlConnection.State == System.Data.ConnectionState.Closed)
            {
                String connectionString =
                    String.Format(
                        @"Server={0};Database=identity;Uid={1};Pwd={2};SslMode=none;",
                        "localhost", "root", ""
                    );
                _MySqlConnection = new MySqlConnection(connectionString);
                _MySqlConnection.Open();
            }
        }

        public static MySqlConnection GetConnection()
        {
            new ConnectionManager();
            return _MySqlConnection;
        }

        public static MySqlDataReader ExecuteQuery(String Query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand()
                {
                    Connection = GetConnection(),
                    CommandType = System.Data.CommandType.Text,
                    CommandText = Query
                };
#if DEBUG
                Console.WriteLine("QueryNoParam: {0}", Query);
#endif
                return command.ExecuteReader();
            }
            catch (Exception e)
            {
                Session.ErrorBag.Add(e.Message);
                Console.Error.WriteLine(e.StackTrace);
                Console.Error.WriteLine(e.Data);
                Console.Error.WriteLine(e.Message);
                return null;
            }
        }

        public static MySqlDataReader ExecuteQuery(String Query, params object[] args)
        {
            try
            {
                MySqlCommand command = new MySqlCommand()
                {
                    Connection = GetConnection(),
                    CommandType = System.Data.CommandType.Text,
                    CommandText = String.Format(Query, args)
                };
#if DEBUG
                Console.WriteLine("QueryParam: {0}", command.CommandText);
#endif
                return command.ExecuteReader();
            }
            catch (Exception e)
            {
                Session.ErrorBag.Add(e.Message);
                Console.Error.WriteLine(e.StackTrace);
                Console.Error.WriteLine(e.Data);
                Console.Error.WriteLine(e.Message);
                return null;
            }
        }

        public static bool ExecuteCommand(String Command)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand()
                {
                    Connection = GetConnection(),
                    CommandType = System.Data.CommandType.Text,
                    CommandText = Command
                })
                {

#if DEBUG
                    Console.WriteLine("CommandNoParam: {0}", command.CommandText);
#endif
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                Session.ErrorBag.Add(e.Message);
                return false;
            }

        }

        public static bool ExecuteCommand(String Command, params object[] args)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand()
                {
                    Connection = GetConnection(),
                    CommandType = System.Data.CommandType.Text,
                    CommandText = String.Format(Command, args)
                })
                {
#if DEBUG
                    Console.WriteLine("QueryWtParam: {0}", command.CommandText);
#endif
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception e)
            {
                Session.ErrorBag.Add(e.Message);
                return false;
            }
        }

        public static DataTable FetchTable(String Command)
        {
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand command = new MySqlCommand()
                {
                    Connection = GetConnection(),
                    CommandType = System.Data.CommandType.Text,
                    CommandText = String.Format(Command)
                };
#if DEBUG
                Console.WriteLine("FetchTableNoParam: {0}", command.CommandText);
#endif
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                _MySqlDataAdapter = adapter;
                _MySqlDataAdapter.SelectCommand = command;
                _MySqlCommandBuilder = new MySqlCommandBuilder(adapter);
                adapter.Fill(ds);
                return ds.Tables[0];

            }
            catch (Exception e)
            {
                Session.ErrorBag.Add(e.Message);
                return null;
            }
        }

        public static DataTable FetchTable(String Command, params object[] args)
        {
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand command = new MySqlCommand()
                {
                    Connection = GetConnection(),
                    CommandType = System.Data.CommandType.Text,
                    CommandText = String.Format(Command, args)
                };
#if DEBUG
                Console.WriteLine("FetchTableWtParam: {0}", command.CommandText);
#endif
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                _MySqlDataAdapter = adapter;
                _MySqlDataAdapter.SelectCommand = command;
                _MySqlCommandBuilder = new MySqlCommandBuilder(adapter);
                adapter.Fill(ds);
                return ds.Tables[0];

            }
            catch (Exception e)
            {
                Session.ErrorBag.Add(e.Message);
                return null;
            }
        }

        public static bool Sync(DataTable table)
        {
            try
            {
                using (_MySqlDataAdapter)
                {
                    _MySqlDataAdapter.UpdateCommand = _MySqlCommandBuilder.GetUpdateCommand();
                    _MySqlDataAdapter.Update(table);
                }
                return true;
            }
            catch (Exception e)
            {
                Session.ErrorBag.Add(e.Message);
                return false;
            }
        }

    }
}
