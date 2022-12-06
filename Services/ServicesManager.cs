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
        _methods;

    private MainMenuService _mainMenuService;

    public ServicesManager()
    {
        _mainMenuService = new MainMenuService();

        _methods =
            new Dictionary<State, Func<string, TransmittedData, BotTextMessage>>();

        _methods[State.CommandStart] = _mainMenuService.ProcessCommandStart;
        _methods[State.ClickInMainMenu] = _mainMenuService.ProcessClickInMainMenu;
        _methods[State.ClickInMenuChooseCategoryForShow] = _mainMenuService.ProcessClickInMenuChooseCategoryForShow;
    }

    public BotTextMessage ProcessBotUpdate(string textData, TransmittedData transmittedData)
    {
        var serviceMethod = _methods[transmittedData.State];

        return serviceMethod.Invoke(textData, transmittedData);
    }
}