using OpenQA.Selenium;

namespace Framework.Pages
{
    internal class Common
    {
        internal static void OpenPage(string url)
        {
            Driver.GetDriver().Url = url;
        }

        internal static string GetPageTitle()
        {
            return Driver.GetDriver().Title;
        }

        private static IWebElement GetElementByXpath(string xpath)
        {
            return Driver.GetDriver().FindElement(By.XPath(xpath));
        }

        internal static void SendKeysToElement(string locatorXpath, string keys)
        {
            GetElementByXpath(locatorXpath).SendKeys(keys);
        }

        internal static void ClickElement(string locatorXpath)
        {
            GetElementByXpath(locatorXpath).Click();
        }
    }
}
