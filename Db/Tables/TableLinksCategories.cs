using Gamer228.TGBOT.Db.Entities;
using Npgsql;

namespace Gamer228.TGBOT.Db.Tables;

public class TableLinksCategories
{
     private NpgsqlConnection _connection;

    public TableLinksCategories(NpgsqlConnection connection)
    {
        _connection = connection;
    }

    public GameCategory GetById(int findId)
    {
        string sqlRequest = $"SELECT * FROM categories WHERE id={findId}";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();

        dataReader.Read();

        int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
        string name = dataReader.GetString(dataReader.GetOrdinal("name"));

        dataReader.Close(); 

        return new GameCategory()
        {
            Id = id,
            Name = name
        };
    }

    public bool ContaintByChatId(long chatId)
    {
        string sqlRequest = $"SELECT * FROM categories WHERE chat_id={chatId}";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();

        bool exist = dataReader.HasRows;

        dataReader.Close();

        return exist;
    }

    public void AddNew(GameCategory gameCategory)
    {
        string sqlRequest = 
            $"INSERT INTO categories (name, chat_id) VALUES ('{gameCategory.Name}', '{gameCategory.ChatId}')";

        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        command.ExecuteNonQuery();
    }

    public IEnumerable<GameCategory> GetAllByChatId(long chatId)
    {
        string sqlRequest = $"SELECT * FROM categories WHERE chat_id={chatId} ORDER BY id ASC";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();

        List<GameCategory> gameCategories = new List<GameCategory>();

        while (dataReader.Read())
        {
            int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
            string name = dataReader.GetString(dataReader.GetOrdinal("name"));

            gameCategories.Add(new GameCategory()
            {
                Id = id,
                Name = name
            });
        }

        dataReader.Close();

        return gameCategories;
    }

    public void DeleteById(int id)
    {
        string sqlRequest = $"DELETE FROM categories WHERE id={id}";

        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        command.ExecuteNonQuery();
    }
}