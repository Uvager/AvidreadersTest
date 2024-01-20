using System.IO;
using NUnit.Allure.Attributes;
public static class LogerController
{
    public static string path = @"C:\С#\PW\LibraTest_0\LibraTestLog.txt";
    
    [AllureStep("Добавление лога")]
    public static async void AddNewLog(string meassage)
    {
        NUnit.Framework.TestContext.Progress.WriteLine(meassage);
        using (StreamWriter sw = new StreamWriter(path, true))
        {
            await sw.WriteLineAsync(meassage);
        }
    }
}
