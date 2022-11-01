using Gamer228.TGBOT.BotInitializer;
using Gamer228.TGBOT.Router;
using Gamer228.TGBOT.Services.Handlers;
using NLog;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Gamer228.TGBOT.Services;

public class ServicesManager
{
    private static ILogger Logger = LogManager.GetCurrentClassLogger();

    private Dictionary<State, Func<string, TransmittedData, BotTextMessage>>
        _stateServiceMethodPairs;

    private MainMenuService _mainMenuService;
    private LinksService _linksService;
    private CategoriesService _categoriesService;

    public ServicesManager()
    {
        _mainMenuService = new MainMenuService();
        _linksService = new LinksService();
        _categoriesService = new CategoriesService();

        _stateServiceMethodPairs =
            new Dictionary<State, Func<string, TransmittedData, BotTextMessage>>();

        _stateServiceMethodPairs[State.WaitingCommandStart] = _mainMenuService.ProcessCommandStart;
    }

    public BotTextMessage ProcessBotUpdate(string textData, TransmittedData transmittedData)
    {
        var serviceMethod = _stateServiceMethodPairs[transmittedData.State];

        return serviceMethod.Invoke(textData, transmittedData);
    }
}