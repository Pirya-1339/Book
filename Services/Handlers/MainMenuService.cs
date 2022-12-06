using System.Text;
using Gamer228.TGBOT.BotInitializer;
using Gamer228.TGBOT.Db;
using Gamer228.TGBOT.Db.Entities;
using Gamer228.TGBOT.Db.Tables;
using Gamer228.TGBOT.Router;
using Gamer228.TGBOT.Util;
using Microsoft.VisualBasic;
using NLog;

namespace Gamer228.TGBOT.Services.Handlers;

public class MainMenuService
{
    private static ILogger Logger = LogManager.GetCurrentClassLogger();
    public BotTextMessage ProcessCommandStart(string command, TransmittedData transmittedData)
    {
        if (command == SystemStringsStorage.CommandStart)
        {
            transmittedData.State = State.ClickInMainMenu;
            
            return new BotTextMessage(
                DialogsStringsStorage.MenuMain,
                InlineKeyboardsMarkupStorage.InlineKeyboardMarkupMenuMain
            );
        }

        return new BotTextMessage("Введена неверная команда, для запуска бота нажмите /start");
    }

    public BotTextMessage ProcessClickInMainMenu(string callBackData, TransmittedData transmittedData)
    {
        if (callBackData == BotButtonStorage.ButtonShowInMenuMain.CallBackData)
        {
            transmittedData.State = State.ClickInMenuChooseCategoryForShow;

            return new BotTextMessage(
                DialogsStringsStorage.MenuCategoryForShow,
                InlineKeyboardsMarkupStorage.MenuChooseCategoryForShow
            );
        }
        
        throw new Exception("Bad user request");
    }

    public BotTextMessage ProcessClickInMenuChooseCategoryForShow(string callBackData, TransmittedData transmittedData)
    {
        if (callBackData == BotButtonStorage.ButtonActionInMenuAdd.CallBackData)
        {
            //List<Game> games = DbManager.GetInstance().TableGames.GetAllByCategoryId(1);
            //TODO преобразовать List<Game> games в строку для вывода
            return new BotTextMessage("press ButtonActionInMenuAdd");
        }
        else if (callBackData == BotButtonStorage.ButtonMMORPGInMenuAdd.CallBackData)
        {
            return new BotTextMessage("press ButtonMMORPGInMenuAdd");
        }
        
        throw new Exception("Bad user request");
    }
}