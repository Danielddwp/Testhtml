using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private static string DriverFolder = "C:\\Users\\Daniel\\Desktop\\Drivers1";
        public static IWebDriver _driver;

        [ClassInitialize]
        public static void SetUp(TestContext context)
        {
            _driver = new ChromeDriver(DriverFolder);
        }

        [ClassCleanup]
        public static void TearDown()
        {
            _driver.Dispose();
        }

        [TestMethod]
        public void TestMethod()
        {
            _driver.Navigate().GoToUrl("http://localhost:3000/");
            string title = _driver.Title;
            Assert.AreEqual("Say hello", title);

            IWebElement inputElement = _driver.FindElement(By.Id("inputField"));

            IWebElement button = _driver.FindElement(By.Id("button"));

            IWebElement outputElement = _driver.FindElement(By.Id("outputField"));
            string text = outputElement.Text;
            Assert.AreEqual("Hello Daniel",text);
        }
    }
}