namespace Gamer228.TGBOT.Db.Entities;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public int CategoryId { get; set; }
    public long ChatId { get; set; }
    public string Description { get; set; }
}