using Gamer228.TGBOT.Db.Connection;
using Gamer228.TGBOT.Db.Tables;
using Npgsql;

namespace Gamer228.TGBOT.Db;

public class DbManager
{
    public TableLinks TableLinks { get; private set; }
    public TableLinksCategories TableLinksCategories { get; private set; }

    public DbManager()
    {
        NpgsqlConnection connection = DbConnector.GetInstance().Connection;

        TableLinks = new TableLinks(connection);
        TableLinksCategories = new TableLinksCategories(connection);
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