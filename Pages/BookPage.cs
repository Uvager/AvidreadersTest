using Microsoft.Playwright;
using NUnit.Allure.Attributes;

//Страница выбранной книги
public class BookPage : BasePage
{  
    public BookPage(IPage page): base(page){}
}