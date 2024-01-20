using Microsoft.Playwright;

public class WebElement
{
    public ILocator? Locator {get;private set;}
    public string? elementname {get;private set;}
    public WebElement(ILocator locator, string name)
    {
        Locator = locator;
        elementname = name;
    }
    public WebElement(ILocator locator) => Locator = locator;
    public WebElement(string name) => elementname = name;
    public WebElement() {}
}