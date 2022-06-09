using MySql.Data.MySqlClient;

namespace ExampleSQLApp.Helpers
{
    public class DbHelper
    {
        private readonly MySqlConnection _connection = new("server=localhost;port=3306;username=root;password=root;database=myeducationwinforms");

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
