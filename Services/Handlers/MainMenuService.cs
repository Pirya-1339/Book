using System.Text;
using Gamer228.TGBOT.BotInitializer;
using Gamer228.TGBOT.Router;
using Microsoft.VisualBasic;
using NLog;

namespace Gamer228.TGBOT.Services.Handlers;

public class MainMenuService
{
    private static ILogger Logger = LogManager.GetCurrentClassLogger();

    public BotTextMessage ProcessCommandStart(string command, TransmittedData transmittedData)
    {
        return null;
    }
    
     public BotTextMessage ProcessClickOnInlineButtonInMenuMain(string callBackData, TransmittedData transmittedData)
     {
         return null;
     }
     
     public BotTextMessage ProcessClickOnInlineButtonInMenuAdd(string callBackData,
        TransmittedData transmittedData)
     {
         return null;
     }
     
     public BotTextMessage ProcessClickOnInlineButtonInMenuDelete(string callBackData,
         TransmittedData transmittedData)
     {
         return null;
     }
}