using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CommvaultWebsiteSeleniumTest
{
    [TestClass]
    public class TestHowToBuyMktoForm
    {
        static IWebDriver driver = new ChromeDriver();
        private readonly string element = "/how-to-buy";
        private readonly string thankYou = "/how-to-buy/contact-confirmation";

        //here the list of how-to-buy pages
        private readonly string[] _elementsHowToBuy =
        {
            "/popular-bundles/vm-backup-and-recovery",
            "/popular-bundles/cloud-backup-and-recovery",
            "/popular-bundles/email-archive",
            "/popular-bundles/endpoint-data-protection",
            "/popular-bundles/snapshot-management-and-recovery",
            "/popular-bundles/appliances"
        };

        [ClassInitialize]
        public static void BeforeAll(TestContext context)
        {

        }

        [TestInitialize]
        public void Before()
        {
            driver.Navigate().GoToUrl(TestHelper.SiteUrl() + element);
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.ClassName("fancybox")).Click();
        }

        [TestCleanup]
        public void AfterEach()
        {
            //System.Threading.Thread.Sleep(500);
        }

        [ClassCleanup]
        public static void AfterAll()
        {
            driver.Quit();
        }

        private void Visit(string path)
        {
            driver.Navigate().GoToUrl(TestHelper.SiteUrl() + path);
        }

        private void FillOutTheForm()
        {   
            IWebElement popUpForm = driver.FindElement(By.Id("mktoForm_1025"));
            popUpForm.FindElement(By.Name("FirstName")).SendKeys("David");
            popUpForm.FindElement(By.Name("LastName")).SendKeys("Guardia");
            popUpForm.FindElement(By.Name("Email")).SendKeys("automaticTest@commvault.com");
            popUpForm.FindElement(By.Name("Phone")).SendKeys("7326525621");
            popUpForm.FindElement(By.Name("Company")).SendKeys("Commvault");
            popUpForm.FindElement(By.Name("Company")).Submit();
            System.Threading.Thread.Sleep(500);
        }

        [TestMethod]
        public void FillOutParentHowToBuy()
        {
            FillOutTheForm();
            Assert.AreEqual(driver.Url, TestHelper.SiteUrl() + thankYou);
            driver.Navigate().GoToUrl(TestHelper.SiteUrl());
        }

        [TestMethod]
        public void OpenTheHowToBuyForm()
        {
            foreach (string elementHowToBuyChild in _elementsHowToBuy)
            {
                Visit(element + elementHowToBuyChild);
                System.Threading.Thread.Sleep(500);
                driver.FindElement(By.ClassName("fancybox")).Click();
                FillOutTheForm();
                driver.Navigate().GoToUrl(TestHelper.SiteUrl());
            }
        }
    }
}
