using Telegram.Bot.Types.ReplyMarkups;

namespace Gamer228.TGBOT.BotInitializer;

public class BotTextMessage
{
    public string Text { get; }
    public InlineKeyboardMarkup InlineKeyboardMarkup { get; }
    
    public BotTextMessage(string text)
    {
        Text = text;
        InlineKeyboardMarkup = InlineKeyboardMarkup.Empty();
    }
    
    public BotTextMessage(string text, InlineKeyboardMarkup inlineKeyboardMarkup)
    {
        Text = text;
        InlineKeyboardMarkup = inlineKeyboardMarkup;
    }
}