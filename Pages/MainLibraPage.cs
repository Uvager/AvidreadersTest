using Microsoft.Playwright;
using NUnit.Allure.Attributes;

//Класс главной страницы
public class MainLibraPage : BasePage
{   
    public MainLibraPage(IPage page): base(page){}
    [AllureStep("Поиск по запросу")]
    public async ValueTask MakeASearch(string search)
    {
        await WaitingLoad();
        await Page.Locator(Locators.MainLibraPageLocators.searchbar).FillAsync($"{search}");
        await Page.Locator(Locators.MainLibraPageLocators.searchbarbutton).ClickAsync();
        
        LogerController.AddNewLog($"Поиск по запросу {search} совершен");
    }
    [AllureStep("Переход на страницу 'Популярные книги'")]
    public async ValueTask GoToPopBooks()
    {
        await WaitingLoad();
        await Page.Locator(Locators.MainLibraPageLocators.popbookspage).ClickAsync();
        LogerController.AddNewLog("Переход на страницу 'Популярные книги' совершен");
    }
    [AllureStep("Авторизация совершена")]
    public async ValueTask Auth(string email, string password)
    {
        await WaitingLoad();
        await Page.Locator(Locators.AuthLocators.authbutton).ClickAsync();
        await Page.Locator(Locators.AuthLocators.authemail).FillAsync(email);
        await Page.Locator(Locators.AuthLocators.authpassw).FillAsync(password);
        await Page.Locator(Locators.AuthLocators.authlogin).ClickAsync();
        LogerController.AddNewLog("Авторизация совершена");
    }
}