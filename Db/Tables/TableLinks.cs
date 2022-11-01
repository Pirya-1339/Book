using Gamer228.TGBOT.Db.Entities;
using Npgsql;

namespace Gamer228.TGBOT.Db.Tables;

public class TableLinks
{
    private NpgsqlConnection _connection;

    public TableLinks(NpgsqlConnection connection)
    {
        _connection = connection;
    }

    public void AddNew(Game game)
    {
        string sqlRequest =
            $"INSERT INTO games (name, link, category_id, chat_id, description) VALUES ('{game.Name}','{game.Url}','{game.Description}', {game.CategoryId}, {game.ChatId})";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        command.ExecuteNonQuery();
    }

    public IEnumerable<Game> GetAllByCategoryId(int findCategoryId)
    {
        string sqlRequest = $"SELECT * FROM games WHERE category_id=0 ORDER BY id ASC";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();

        List<Game> games = new List<Game>();

        while (dataReader.Read())
        {
            int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
            string name = dataReader.GetString(dataReader.GetOrdinal("name"));
            string url = dataReader.GetString(dataReader.GetOrdinal("url"));
            string description = dataReader.GetString(dataReader.GetOrdinal("description"));
            int categoryId = dataReader.GetInt32(dataReader.GetOrdinal("category_id"));
            long chatId = dataReader.GetInt64(dataReader.GetOrdinal("chat_id"));

            games.Add(new Game()
            {
                Id = id,
                Name = name,
                Url = url,
                Description = description,
                CategoryId = categoryId,
                ChatId = chatId
            });
        }

        dataReader.Close();

        return games;
    }

    public IEnumerable<Game> GetAllByCategoryIdWithStartLinkId(int findCategoryId, int startLinkId)
    {
        string sqlRequest =
            $"SELECT * FROM games WHERE category_id={findCategoryId} AND id>={startLinkId} ORDER BY id ASC";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();

        List<Game> links = new List<Game>();

        while (dataReader.Read())
        {
            int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
            string name = dataReader.GetString(dataReader.GetOrdinal("name"));
            string url = dataReader.GetString(dataReader.GetOrdinal("url"));
            string description = dataReader.GetString(dataReader.GetOrdinal("description"));
            int categoryId = dataReader.GetInt32(dataReader.GetOrdinal("category_id"));
            long chatId = dataReader.GetInt64(dataReader.GetOrdinal("chat_id"));

            links.Add(new Game()
            {
                Id = id,
                Name = name,
                Url = url,
                Description = description,
                CategoryId = categoryId,
                ChatId = chatId
            });
        }

        dataReader.Close();

        return links;
    }
}