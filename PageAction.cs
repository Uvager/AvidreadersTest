using Microsoft.Playwright;

public class PageActions : IPageActions
{
    public async ValueTask ClickOnElement(WebElement element)
    {
        if (element.Locator != null)
        {
            await Assertions.Expect(element.Locator).ToBeEnabledAsync(new LocatorAssertionsToBeEnabledOptions());
            await Assertions.Expect(element.Locator).ToBeVisibleAsync(new LocatorAssertionsToBeVisibleOptions());
            await element.Locator.WaitForAsync();
            await element.Locator.FocusAsync();
            await element.Locator.ClickAsync();
        }
        else {throw new Exception("Локатор null");}
    }
    public async ValueTask EnterText(WebElement element, string text)
    {
        if (element.Locator != null)
        {
            await Assertions.Expect(element.Locator).ToBeEnabledAsync(new LocatorAssertionsToBeEnabledOptions());
            await Assertions.Expect(element.Locator).ToBeVisibleAsync(new LocatorAssertionsToBeVisibleOptions());
            await element.Locator.WaitForAsync();
            await element.Locator.FocusAsync();
            await element.Locator.FillAsync(text);
        }
        else if (text == null)  {throw new Exception("Текст null");}
        else {throw new Exception("Локатор null");}
    }
}