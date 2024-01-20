using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

[AllureNUnit]
[AllureSuite("Libra tests")]
public class Tests : BaseTest
{
    [Test]
    [AllureSuite("Case_0")]
    public async Task Case_0()
    {
        LogerController.AddNewLog("Начало Case_0");
        SearchPage searchpage = new SearchPage(Page);
        MainLibraPage mainlibrapage = new MainLibraPage(Page);
        BookPage bookpage = new BookPage(Page);
        await mainlibrapage.MakeASearch("Мастер и Маргарита");
        await searchpage.ChoiseFirstBookFromSearch();
        Assert.That(await bookpage.GetBookName() == "Мастер и Маргарита","Case_0 Ошибка название не совпадает");
        LogerController.AddNewLog("Название совпадает");
        Assert.That(await bookpage.GetBookAutor() == "Булгаков Михаил Афанасьевич","Case_0 Ошибка автор не совпадает");
        LogerController.AddNewLog("Автор совпадает");
        await Expect(Page.Locator(Locators.BookPageLocators.bookdownloadbutton).Nth(0)).ToBeVisibleAsync();
        LogerController.AddNewLog("Кнопка загрузки присутствует");
        LogerController.AddNewLog("Окончание Case_0");
    }
    [Test]
    [AllureSuite("Case_1")]
    public async Task Case_1()
    {
        LogerController.AddNewLog("Начало Case_1");
        MainLibraPage mainlibrapage = new MainLibraPage(Page);
        PopBooksPage popbookspage = new PopBooksPage(Page);
        await mainlibrapage.GoToPopBooks();
        Assert.That(await popbookspage.CountPopBooks() == 40, "Case_0_Ошибка, неверное колличество книг");
        LogerController.AddNewLog("Колличество книг совпадает");
        LogerController.AddNewLog("Окончание Case_1");
    }
    // [Test]
    // [AllureSuite("Case_2")]
    // public async Task Case_2()
    // {
    //     LogerController.AddNewLog("Начало Case_2");
    //     MainLibraPage mainlibrapage = new MainLibraPage(Page);
    //     PopBooksPage popbookspage = new PopBooksPage(Page);
    //     SearchPage searchpage = new SearchPage(Page);
    //     BookPage bookpage = new BookPage(Page);
    //     await mainlibrapage.Auth("eg.dmitrieff2011@yandex.ru","Qwerty123");
    //     await mainlibrapage.MakeASearch("Бесы");
    //     await searchpage.ChoiseFirstBookFromSearch();
    //     string review = "Зашибись";
    //     await bookpage.MakeReview(review);
    //     int count = await bookpage.CountReview();
    //     for (int i = 0; i <=count; i++)
    //     {
    //         if (await bookpage.GetReviewText(i) == review )
    //         {
    //             review = await bookpage.GetReviewText(i);
    //             Assert.That(review.Contains(await bookpage.GetReviewText(i)));
    //             LogerController.AddNewLog("Совпадение найдено");
    //             break;
    //         }
    //     }
    //     LogerController.AddNewLog("Окончание Case_2");
    //}

}