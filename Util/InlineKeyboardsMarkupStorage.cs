using Telegram.Bot.Types.ReplyMarkups;

namespace Gamer228.TGBOT.Util;

public class InlineKeyboardsMarkupStorage
{
     public static InlineKeyboardMarkup InlineKeyboardMarkupMenuMain = new(new[]
    { 
        new[]
             {
                 InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonShowInMenuMain.Name,
                     BotButtonStorage.ButtonShowInMenuMain.CallBackData),
             },
    });

    public static InlineKeyboardMarkup MenuChooseCategoryForShow = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonMaths.Name,
                BotButtonStorage.ButtonMaths.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonEnglish.Name,
                BotButtonStorage.ButtonEnglish.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonRussian.Name,
                BotButtonStorage.ButtonRussian.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonLiterature.Name,
                BotButtonStorage.ButtonLiterature.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonGeography.Name,
                BotButtonStorage.ButtonGeography.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonHistory.Name,
                BotButtonStorage.ButtonHistory.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonScience.Name,
                BotButtonStorage.ButtonScience.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonArt.Name,
                BotButtonStorage.ButtonArt.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonMusic.Name,
                BotButtonStorage.ButtonMusic.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonPhysics.Name,
                BotButtonStorage.ButtonPhysics.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonChemistry.Name,
                BotButtonStorage.ButtonChemistry.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBiology.Name,
                BotButtonStorage.ButtonBiology.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonTechnology.Name,
                BotButtonStorage.ButtonTechnology.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonPe.Name,
                BotButtonStorage.ButtonPe.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonComputing.Name,
                BotButtonStorage.ButtonComputing.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonOBZH.Name,
                BotButtonStorage.ButtonOBZH.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonSocial_Studies.Name,
                BotButtonStorage.ButtonSocial_Studies.CallBackData),
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonBackInMenuAdd.Name,
                BotButtonStorage.ButtonBackInMenuAdd.CallBackData),
        },
    });

    public static InlineKeyboardMarkup InlineKeyboardMarkupAction = new(new[]
    { 
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
                BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
                BotButtonStorage.ButtonInMenuMainNext.CallBackData),
        }
       

    });

    public static InlineKeyboardMarkup InlineKeyboardMarkupMMORPG = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
                BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
                BotButtonStorage.ButtonInMenuMainNext.CallBackData),
        }


    });
    
    public static InlineKeyboardMarkup InlineKeyboardMarkupGolova = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
                BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
                BotButtonStorage.ButtonInMenuMainNext.CallBackData),
        }


    });
    
    public static InlineKeyboardMarkup InlineKeyboardMarkupArk = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
                BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
                BotButtonStorage.ButtonInMenuMainNext.CallBackData),
        }


    });
    public static InlineKeyboardMarkup InlineKeyboardMarkupGonki = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
                BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
                BotButtonStorage.ButtonInMenuMainNext.CallBackData),
        }


    });
    public static InlineKeyboardMarkup InlineKeyboardMarkupAdventures = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
                BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
                BotButtonStorage.ButtonInMenuMainNext.CallBackData),
        }


    });
   public static InlineKeyboardMarkup InlineKeyboardMarkupSimulators = new(new[]
    {
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
                 BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
        },
        new[]
        {
            InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
                BotButtonStorage.ButtonInMenuMainNext.CallBackData),
        }


    });
   public static InlineKeyboardMarkup InlineKeyboardMarkupStrategie = new(new[]
   {
       new[]
       {
           InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
               BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
       },
       new[]
       {
           InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
               BotButtonStorage.ButtonInMenuMainNext.CallBackData),
       }


   });
   public static InlineKeyboardMarkup InlineKeyboardMarkupFighting_games = new(new[]
   {
       new[]
       {
           InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainPrevious.Name,
               BotButtonStorage.ButtonInMenuMainPrevious.CallBackData)
       },
       new[]
       {
           InlineKeyboardButton.WithCallbackData(BotButtonStorage.ButtonInMenuMainNext.Name,
               BotButtonStorage.ButtonInMenuMainNext.CallBackData),
       }


   });
    /*public static InlineKeyboardMarkup CreateInlineKeyboardMarkupMenuLinkCategoryForAdd(
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
    }*/


}



