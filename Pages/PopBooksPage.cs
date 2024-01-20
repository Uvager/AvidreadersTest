using Microsoft.Playwright;
using NUnit.Allure.Attributes;

public class PopBooksPage : BasePage
{  
    public PopBooksPage(IPage page): base(page){}
    [AllureStep("Подсчет колличества книг на странице 'Популярные книги'")]
    public async ValueTask<int> CountPopBooks()
    {
        await WaitingLoad();
        int count = await Page.Locator(Locators.PopBooksPageLocators.popbooksall).CountAsync();
        LogerController.AddNewLog($"Колличество книг на странице 'Популярные книги'={count}");
        return count;
    }
}