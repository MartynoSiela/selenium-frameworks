using OpenQA.Selenium;

namespace Framework.Pages.Brave
{
    public class SearchPage
    {
        public static void Open()
        {
            Driver.GetDriver().Url = "https://search.brave.com/";
        }

        public static void EnterSearchPhrase(string phrase)
        {
            Driver.GetDriver().FindElement(By.Id("searchbox")).SendKeys(phrase);
        }

        public static void ClickButtonSubmit()
        {
            Driver.GetDriver().FindElement(By.Id("submit-button")).Click();
        }

        public static string GetPageTitle()
        {
            return Driver.GetDriver().Title;
        }
    }
}
