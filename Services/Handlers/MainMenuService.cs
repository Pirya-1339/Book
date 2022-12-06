using System.Text;
using Gamer228.TGBOT.BotInitializer;
using Gamer228.TGBOT.Db;
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
        else
        {
            return new BotTextMessage("Введена неверная команда, для запуска бота нажмите /start");
        }
    }

    public BotTextMessage ProcessClickInMainMenu(string callBackData, TransmittedData transmittedData)
    {
        if (callBackData == BotButtonStorage.ButtonBrowseInMenuMain.CallBackData)
        {
            transmittedData.State = State.WaitingButtonBrowseInMenuMain ;

            return new BotTextMessage(
                DialogsStringsStorage.MenuCategory,
                InlineKeyboardsMarkupStorage.InlineKeyboardMarkupMenuAdd
            );
        }
        
        throw new Exception("Bad user request");
    }

    /*public BotTextMessage ProcessClickCategori(string callBackData, TransmittedData transmittedData)
    {
        if (callBackData == BotButtonStorage.ButtonActionInMenuAdd.CallBackData)
        {
            
        }
    }*/

    
    
}