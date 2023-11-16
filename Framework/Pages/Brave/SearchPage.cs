using OpenQA.Selenium;

namespace Framework.Pages.Brave
{
    public class SearchPage : PageBase
    {
        private Common common;

        public SearchPage(IWebDriver driver) : base(driver)
        {
            common = new Common(driver);
        }

        public void Open()
        {
            common.OpenPage("https://search.brave.com/");
        }

        public void EnterSearchPhrase(string phrase)
        {
            string locator = "//*[@id='searchbox']";
            common.SendKeysToElement(locator, phrase);
        }

        public void ClickButtonSubmit()
        {
            string locator = "//*[@id='submit-button']";
            common.ClickElement(locator);
        }

        public string GetPageTitle()
        {
            return common.GetPageTitle();
        }
    }
}
