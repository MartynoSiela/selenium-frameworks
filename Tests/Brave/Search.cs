using Framework.Pages.Brave;
using NUnit.Framework;

namespace Tests.Brave
{
    [Parallelizable(ParallelScope.Children)]
    internal class Search : TestBase
    {
        [TestCase("Selenium Tutorial")]
        [TestCase("Obuolių pyragas")]
        [TestCase("Hello World")]
        [TestCase("Kaip išnaikinti širšes palėpėje")]
        public void SearchForPhrase(string phrase)
        {
            string expectedTitle = $"{phrase} - Brave Search";

            SearchPage searchPage = new SearchPage(driver);
            searchPage.Open();
            searchPage.EnterSearchPhrase(phrase);
            searchPage.ClickButtonSubmit();
            string actualTitle = searchPage.GetPageTitle();

            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
    }
}
