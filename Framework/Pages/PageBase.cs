using OpenQA.Selenium;

namespace Framework.Pages
{
    public class PageBase
    {
        protected IWebDriver driver;

        public PageBase(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
