using Microsoft.Playwright;
using NUnit.Allure.Attributes;


//Страница поиска книг
public class SearchPage : BasePage
{  
    public SearchPage(IPage page): base(page){}
    [AllureStep("Получение первой книги из списка поиска")]
    public async ValueTask ChoiseFirstBookFromSearch()
    {
        await WaitingLoad();
        await Page.Locator(Locators.SearchPageLocators.searchresults).Nth(0).ClickAsync();
        LogerController.AddNewLog("Переход на страницу книги совершен совершен");
    }
}