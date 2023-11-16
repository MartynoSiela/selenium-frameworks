using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void SetUpDriver()
        {
            driver.Value = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void QuitDriver()
        {
            driver.Value.Quit();
        }
    }
}
