using Gamer228.TGBOT.Db.Connection;
using Gamer228.TGBOT.Db.Tables;
using Npgsql;

namespace Gamer228.TGBOT.Db;

public class DbManager
{
    public TableGames TableGames { get; private set; }
    public TableGamesCategories TableGamesCategories { get; private set; }

    public DbManager()
    {
        NpgsqlConnection connection = DbConnector.GetInstance().Connection;

        TableGames = new TableGames(connection);
        TableGamesCategories = new TableGamesCategories(connection);
    }

    private static DbManager _dbManager = null;

    public static DbManager GetInstance()
    {
        if (_dbManager == null)
        {
            _dbManager = new DbManager();
        }

        return _dbManager;
    }
}