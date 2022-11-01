using Gamer228.TGBOT.BotInitializer;
using Gamer228.TGBOT.Services;
using Gamer228.TGBOT.Services.Handlers;
using NLog;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Gamer228.TGBOT.Router;

public class ChatsRouter
{
    private static ILogger Logger = LogManager.GetCurrentClassLogger();

    private Dictionary<long, TransmittedData> _chatTransmittedDataPairs;
    private ServicesManager _servicesManager;

    public ChatsRouter()
    {
        _chatTransmittedDataPairs = new Dictionary<long, TransmittedData>();
        _servicesManager = new ServicesManager();
    }

    public BotTextMessage Route(long chatId, string textData)
    {
        if (!_chatTransmittedDataPairs.ContainsKey(chatId))
        {
            _chatTransmittedDataPairs[chatId] = new TransmittedData(chatId);
        }

        TransmittedData transmittedData = _chatTransmittedDataPairs[chatId];

        /*if (textData == SystemStringsStorage.CommandReset && transmittedData.State != State.WaitingCommandStart)
        {
            return GlobalService.ProcessCommandReset(transmittedData);
        }*/
        
        return _servicesManager.ProcessBotUpdate(textData, transmittedData);
    }
}