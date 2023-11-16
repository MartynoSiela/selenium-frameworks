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

            SearchPage.Open();
            SearchPage.EnterSearchPhrase(phrase);
            SearchPage.ClickButtonSubmit();
            string actualTitle = SearchPage.GetPageTitle();

            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
        }
    }
}
