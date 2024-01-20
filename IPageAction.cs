using Microsoft.Playwright;
using NUnit.Allure.Attributes;
public interface IPageActions
{
    public ValueTask ClickOnElement(WebElement element);
    public ValueTask EnterText(WebElement element, string text);
}