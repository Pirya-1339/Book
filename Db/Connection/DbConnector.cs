using Npgsql;

namespace Gamer228.TGBOT.Db.Connection;

public class DbConnector
{
    private const string _connectionString =
        "Host=194.67.105.79;Username=fieldbotuser;Password=679;Database=fieldbotdb";

    public NpgsqlConnection Connection { private set; get; }

    private DbConnector()
    {
        Connection = new NpgsqlConnection(_connectionString);
        Connection.Open();
    }

    private static DbConnector _dbConnector = null;

    public static DbConnector GetInstance()
    {
        if (_dbConnector == null)
        {
            _dbConnector = new DbConnector();
        }

        return _dbConnector;
    }
}