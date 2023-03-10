namespace Gamer228.TGBOT.Util;

public class DialogsStringsStorage
{
    public const string CommandStartInputErrorInput =
        "Команда не распознана. Для начала работы с ботом введите /start";

    public const string MenuMain = "Доброго времени друг\nТы в главном меню.";
    public const string MenuCategoryForShow = "Выберите категорию";
    public const string LinkInputUrl = "Введите URL";

    public const string LinkInputUrlError =
        "URL не распознан. Пожалуйста введите корректный URL от 10 до 2048 символов";
    public const string LinkInputUrlSuccess =
        "URL успешно сохранён.\nВведите описание ссылки:";
    
    public const string LinkInputDescriptionError =
        "Ошибка ввода описания. Пожалуйста введите корректное описание от 3 до 256 символов";
    public const string LinkInputDescriptionSuccess =
        "Описание успешно сохранено.\nВыберите категорию ссылки:";

    public static string CreateLinkInputCategory(string url, string description, string categoryName)
    {
        return $"Ссылка: {url}\n\n" +
               $"Описание: {description}\n\n" +
               $"Категория: {categoryName}\n\n" +
               $"Сохранить ссылку?";
    }
    
    public const string LinkApproveAddYes = "Ваша ссылка успешно сохранена\nВыберите дальнейшее действие";
    public const string LinkApproveAddNo = "Сохранение вашей ссылки успешно отменено\nВыберите дальнейшее действие";
    
    public const string MenuShow = "Выберите, категорию, ссылки в которой вы хотите просмотреть";
    public const string MenuShowNoCategories = "У вас нет ещё ни одной добавленной ссылки, пожалуйста вначале добавьте ссылку";
    
    public const string CategoryNameInputError =
        "Ошибка ввода категории. Пожалуйста введите корректное название от 1 до 64 символов";
    public const string CategoryNameInputSuccess =
        "Категория успешно сохранена\nВыберите дальнейшее действие";

    public const string MenuCategoryStart = "Ваши текущие категории:\n";
    
    public static string CreateMenuCategoryHowManyUseCategories(int countUse, int maxCount)
    {
        return $"Вы использовали категорий {countUse} из {maxCount}\n";
    }
    
    public const string MenuCategoryInputNew = "Пожалуйста введите название новой категории:";
    public const string MenuCategoryInputRestrict = "К сожалению вы не можете добавить новую категорию пожалуйста удалите старую.\nДля этого вернитесь в главное меню.";
    
    public const string MenuDelete = "Выберите, что вы хотите удалить?";
    
    public const string MenuDeleteCategory = "Выберите, категорию, которую вы хотите удалить или вернитесь назад";
}