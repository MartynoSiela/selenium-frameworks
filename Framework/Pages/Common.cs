using OpenQA.Selenium;

namespace Framework.Pages
{
    internal class Common : PageBase
    {
        internal Common(IWebDriver driver) : base(driver) { }

        internal void OpenPage(string url)
        {
            driver.Url = url;
        }

        internal string GetPageTitle()
        {
            return driver.Title;
        }

        private IWebElement GetElementByXPath(string locatorXpath)
        {
            return driver.FindElement(By.XPath(locatorXpath));
        }

        internal void SendKeysToElement(string locatorXpath, string keys)
        {
            GetElementByXPath(locatorXpath).SendKeys(keys);
        }

        internal void ClickElement(string locatorXpath)
        {
            GetElementByXPath(locatorXpath).Click();
        }
    }
}
