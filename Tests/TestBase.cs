using Framework;
using NUnit.Framework;

namespace Tests
{
    public class TestBase
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetUpDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
