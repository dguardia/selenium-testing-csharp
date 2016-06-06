using System;
using System.Drawing.Imaging;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace CommvaultWebsiteSeleniumTest
{
    
    [TestClass]
    public class TestSuscribeMktoForms
    {
        private IWebDriver driver;
        private readonly string _element = "/stay-connected/thank-you";


        [TestMethod]
        public void TestSuscribingFooterInInternetExplorer()
        {
            driver = new InternetExplorerDriver();
            driver.Navigate().GoToUrl(TestHelper.SiteUrl());
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);

            IWebElement suscribeFormFooter = driver.FindElement(By.Id("mktoForm_1016"));

            suscribeFormFooter.FindElement(By.Name("Email")).SendKeys("automaticTest@commvault.com");
            suscribeFormFooter.FindElement(By.Name("Email")).Submit();

            var filename = new StringBuilder(@"\1-ie-suscribe-thank-you-screenshot");
            filename.Append("-");
            filename.Append(DateTime.Now.ToString("dd-mm-yyyy HH_mm_ss"));
            filename.Append(".png");

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(TestHelper.TempDir() + filename, ImageFormat.Png);

            Assert.AreEqual(driver.Url, TestHelper.SiteUrl() + _element);

            driver.Navigate().GoToUrl(TestHelper.SiteUrl());
            driver.Quit();
        }

        [TestMethod]
        public void TestSuscribingFooterInChrome()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(TestHelper.SiteUrl());
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(500);

            IWebElement suscribeFormFooter = driver.FindElement(By.Id("mktoForm_1016"));

            suscribeFormFooter.FindElement(By.Name("Email")).SendKeys("automaticTest@commvault.com");
            suscribeFormFooter.FindElement(By.Name("Email")).Submit();
            System.Threading.Thread.Sleep(500);

            var filename = new StringBuilder(@"\1-chrome-suscribe-thank-you-screenshot");
            filename.Append("-");
            filename.Append(DateTime.Now.ToString("dd-mm-yyyy HH_mm_ss"));
            filename.Append(".png");

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(TestHelper.TempDir() + filename, ImageFormat.Bmp);

            


            Assert.AreEqual(driver.Url, TestHelper.SiteUrl() + _element);

            driver.Navigate().GoToUrl(TestHelper.SiteUrl());
            driver.Quit();
        }


        [TestMethod]
        public void TestSuscribingFooterInFirefox()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(TestHelper.SiteUrl());
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(500);

            IWebElement suscribeFormFooter = driver.FindElement(By.Id("mktoForm_1016"));

            suscribeFormFooter.FindElement(By.Name("Email")).SendKeys("automaticTest@commvault.com");
            suscribeFormFooter.FindElement(By.Name("Email")).Submit();
            System.Threading.Thread.Sleep(500);


            var filename = new StringBuilder(@"\1-firefox-suscribe-thank-you-screenshot");
            filename.Append("-");
            filename.Append(DateTime.Now.ToString("dd-mm-yyyy HH_mm_ss"));
            filename.Append(".png");

            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(TestHelper.TempDir() + filename, ImageFormat.Png);

            Assert.AreEqual(driver.Url, TestHelper.SiteUrl() + _element);

            driver.Navigate().GoToUrl(TestHelper.SiteUrl());
            driver.Quit();
        }
    }

}
