namespace Framework.Pages.Brave
{
    public class SearchPage
    {
        public static void Open()
        {
            Common.OpenPage("https://search.brave.com/");
        }

        public static void EnterSearchPhrase(string phrase)
        {
            string locator = "//*[@id='searchbox']";
            Common.SendKeysToElement(locator, phrase);
        }

        public static void ClickButtonSubmit()
        {
            string locator = "//*[@id='submit-button']";
            Common.ClickElement(locator);
        }

        public static string GetPageTitle()
        {
            return Common.GetPageTitle();
        }
    }
}
