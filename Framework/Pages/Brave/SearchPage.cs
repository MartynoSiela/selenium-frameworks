using OpenQA.Selenium;

namespace Framework.Pages.Brave
{
    public class SearchPage : PageBase
    {
        public SearchPage(IWebDriver driver) : base(driver) { }

        public void Open()
        {
            driver.Url = "https://search.brave.com/";
        }

        public void EnterSearchPhrase(string phrase)
        {
            driver.FindElement(By.Id("searchbox")).SendKeys(phrase);
        }

        public void ClickButtonSubmit()
        {
            driver.FindElement(By.Id("submit-button")).Click();
        }

        public string GetPageTitle()
        {
            return driver.Title;
        }
    }
}
