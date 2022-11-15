using Telegram.Bot.Types.ReplyMarkups;

namespace Gamer228.TGBOT.Util;

public class InlineKeyboardsMarkupStorage
{
     public static InlineKeyboardMarkup InlineKeyboardMarkupMenuMain = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonAddCategoryInMenuMain.Name,
                BotButtonStorage.ButtonAddCategoryInMenuMain.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBrowseInMenuMain.Name,
                BotButtonStorage.ButtonBrowseInMenuMain.CallBackData),
        },

    });

    public static InlineKeyboardMarkup InlineKeyboardMarkupMenuAdd = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonActionInMenuAdd.Name,
                BotButtonStorage.ButtonActionInMenuAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonMMORPGInMenuAdd.Name,
                BotButtonStorage.ButtonMMORPGInMenuAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonGolovaInMenuAdd.Name,
                BotButtonStorage.ButtonGolovaInMenuAdd.CallBackData),
        },
        new[]
        {
        InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonArkInMenuAdd.Name,
        BotButtonStorage.ButtonArkInMenuAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonGonkiInMenuAdd.Name,
                BotButtonStorage.ButtonGonkiInMenuAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonAdventuresInMenuAdd.Name,
                BotButtonStorage.ButtonAdventuresInMenuAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonSimulatorsInMenuAdd.Name,
                BotButtonStorage.ButtonSimulatorsInMenuAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonStrategiesInMenuAdd.Name,
                BotButtonStorage.ButtonStrategiesInMenuAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonFighting_gamesInMenuAdd.Name,
                BotButtonStorage.ButtonFighting_gamesInMenuAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBackInMenuAdd.Name,
                BotButtonStorage.ButtonBackInMenuAdd.CallBackData),
        }
    });

    public static InlineKeyboardMarkup CreateInlineKeyboardMarkupMenuLinkCategoryForAdd(
        IEnumerable<LinkCategory> linkCategories)
    {
        List<List<InlineKeyboardButton>> keyboardMarkup = new List<List<InlineKeyboardButton>>();

        foreach (LinkCategory linkCategory in linkCategories)
        {
            keyboardMarkup.Add(
                new()
                {
                    InlineKeyboardButton.WithCallbackData(linkCategory.Name, linkCategory.Id.ToString())
                }
            );
        }

        return new InlineKeyboardMarkup(keyboardMarkup);
    }

    public static InlineKeyboardMarkup InlineKeyboardMarkupMenuApproveAdd = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonYesInMenuApproveAdd.Name,
                BotButtonStorage.ButtonYesInMenuApproveAdd.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonNoInMenuApproveAdd.Name,
                BotButtonStorage.ButtonNoInMenuApproveAdd.CallBackData),
        }
    });

    public static InlineKeyboardMarkup InlineKeyboardMarkupMenuAddAnotherLink = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonGotoMainMenuInMenuAddAnotherLink.Name,
                BotButtonStorage.ButtonGotoMainMenuInMenuAddAnotherLink.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonAddOneInMenuAddAnotherLink.Name,
                BotButtonStorage.ButtonAddOneInMenuAddAnotherLink.CallBackData),
        }
    });

    public static InlineKeyboardMarkup CreateInlineKeyboardMarkupMenuLinkCategoryForShow(
        IEnumerable<LinkCategory> linkCategories)
    {
        List<List<InlineKeyboardButton>> keyboardMarkup = new List<List<InlineKeyboardButton>>();

        foreach (LinkCategory linkCategory in linkCategories)
        {
            keyboardMarkup.Add(
                new()
                {
                    InlineKeyboardButton.WithCallbackData(linkCategory.Name, linkCategory.Id.ToString())
                }
            );
        }

        keyboardMarkup.Add(new()
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBackwardInMenuShow.Name,
                BotButtonStorage.ButtonBackwardInMenuShow.CallBackData)
        });

        return new InlineKeyboardMarkup(keyboardMarkup);
    }
    
    public static InlineKeyboardMarkup InlineKeyboardMarkupShowLinksAll = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBackwardInShowLinks.Name,
                BotButtonStorage.ButtonBackwardInShowLinks.CallBackData),
        }
    });
    
    public static InlineKeyboardMarkup InlineKeyboardMarkupShowLinksMore = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonMoreInShowLinks.Name,
                BotButtonStorage.ButtonMoreInShowLinks.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBackwardInShowLinks.Name,
                BotButtonStorage.ButtonBackwardInShowLinks.CallBackData),
        }
    });
    
    public static InlineKeyboardMarkup InlineKeyboardMarkupMenuAddAnotherCategory = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonGotoMainMenuInMenuAddAnotherCategory.Name,
                BotButtonStorage.ButtonGotoMainMenuInMenuAddAnotherCategory.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonAddOneInMenuAddAnotherCategory.Name,
                BotButtonStorage.ButtonAddOneInMenuAddAnotherCategory.CallBackData),
        }
    });
    
    public static InlineKeyboardMarkup InlineKeyboardMarkupMenuAddCategory = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonGotoMainMenuInMenuAddCategory.Name,
                BotButtonStorage.ButtonGotoMainMenuInMenuAddCategory.CallBackData),
        }
    });
    
    
    public static InlineKeyboardMarkup InlineKeyboardMarkupMenuDelete = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonLinkInMenuDelete.Name,
                BotButtonStorage.ButtonLinkInMenuDelete.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonCategoryInMenuDelete.Name,
                BotButtonStorage.ButtonCategoryInMenuDelete.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBackwardInMenuDelete.Name,
                BotButtonStorage.ButtonBackwardInMenuDelete.CallBackData),
        }
    });
    
    
    public static InlineKeyboardMarkup CreateInlineKeyboardMarkupMenuDeleteCategory(
        IEnumerable<LinkCategory> linkCategories)
    {
        List<List<InlineKeyboardButton>> keyboardMarkup = new List<List<InlineKeyboardButton>>();

        foreach (LinkCategory linkCategory in linkCategories)
        {
            keyboardMarkup.Add(
                new()
                {
                    InlineKeyboardButton.WithCallbackData(linkCategory.Name, linkCategory.Id.ToString())
                }
            );
        }

        keyboardMarkup.Add(new()
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBackwardInMenuDelete.Name,
                BotButtonStorage.ButtonBackwardInMenuDelete.CallBackData)
        });

        return new InlineKeyboardMarkup(keyboardMarkup);
    }
    
}



