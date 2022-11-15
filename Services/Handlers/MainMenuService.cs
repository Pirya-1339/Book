using System.Text;
using Gamer228.TGBOT.BotInitializer;
using Gamer228.TGBOT.Router;
using Gamer228.TGBOT.Util;
using Microsoft.VisualBasic;
using NLog;

namespace Gamer228.TGBOT.Services.Handlers;

public class MainMenuService
{
    public BotTextMessage ProcessCommandStart(string command, TransmittedData transmittedData)
    {
        if (command == SystemStringsStorage.CommandStart)
        {
            transmittedData.State = State.ClickInMainMenu;
            return new BotTextMessage("Добро пожаловать");
        }
        else
        {
            return new BotTextMessage("Введена неверная команда, для запуска бота нажмите /start");
        }
    }

    public BotTextMessage ProcessClickInMainMenu(string textData, TransmittedData transmittedData)
    {
        if (textData == "ok")
        {
            return new BotTextMessage("OK OK OK OK OK OK");
        }
        return new BotTextMessage("неизвестное действие в главном меню");
        //throw new Exception("Нет обработки");
    }
    
}