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
        NUnit.Framework.TestContext.Progress.WriteLine("Начало Case_0");
        
    }

}