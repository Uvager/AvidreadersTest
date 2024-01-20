using Microsoft.Playwright;
using NUnit.Allure.Attributes;
using NUnit.Framework.Internal;

//Страница выбранной книги
public class BookPage : BasePage
{  
    public BookPage(IPage page): base(page){}
    [AllureStep("Получение названия книги")]
    public async ValueTask<string> GetBookName()
    {
       await WaitingLoad();
       string bookname = await Page.Locator(Locators.BookPageLocators.bookname).InnerTextAsync();
       LogerController.AddNewLog($"Название книги - {bookname}");
       return bookname;
    }
    [AllureStep("Получение автора книги")]
    public async ValueTask<string> GetBookAutor()
    {
       await WaitingLoad();
       string bookautor = await Page.Locator(Locators.BookPageLocators.bookautor).InnerTextAsync();
       LogerController.AddNewLog($"Автор книги - {bookautor}");
       return bookautor;
    }
    public async ValueTask MakeReview(string review)
    {
      await WaitingLoad();
      await Page.Locator(Locators.BookPageLocators.bookreview).FillAsync(review);
      await Page.Locator(Locators.BookPageLocators.bookstars5).ClickAsync();
      await Page.Locator(Locators.BookPageLocators.addreview).ClickAsync();
      LogerController.AddNewLog($"Отзыв '{review}' оставлен");
    }
    public async ValueTask<string> GetReviewText(int index)
    {
      await WaitingLoad();
      string review = await Page.Locator(Locators.BookPageLocators.bookreview).Nth(index).InnerTextAsync();
      LogerController.AddNewLog($"Отзыв '{review}' получен");
      return review;
    }
    public async ValueTask<int> CountReview()
    {
      await WaitingLoad();
      int count = await Page.Locator(Locators.BookPageLocators.allreview).CountAsync();
      LogerController.AddNewLog($"Колличество отзывов = {count}");
      return count;
    }
}