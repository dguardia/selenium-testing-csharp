using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.Text;
using OpenQA.Selenium.Support.Extensions;

namespace CommvaultWebsiteSeleniumTest
{
    [TestClass]
    public class CommvaultHomePage
    {
        static IWebDriver driver = new ChromeDriver();

        [ClassInitialize]
        public static void BeforeAll(TestContext context)
        {
            
        }

        [TestInitialize]
        public void Before()
        {
            driver.Navigate().GoToUrl(TestHelper.SiteUrl());
            driver.Manage().Window.Maximize();
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

        [TestMethod]
        public void TestClickByImageUsingJavaScriptLogo()
        {
            IWebElement commvaultLogo = driver.FindElement(By.ClassName("cv-header-logo"));
            ((IJavaScriptExecutor) driver).ExecuteScript("arguments[0].click();", commvaultLogo);
        }

        
        public void Visit(string path)
        {
            driver.Navigate().GoToUrl(TestHelper.SiteUrl() + path);
        }

       

        [TestMethod]
        public void TestGoToPageWithinSiteUsingFunction()
        {
            PageList pageList = new PageList();

            IJavaScriptExecutor jse = (IJavaScriptExecutor) driver;

            //looping over the paths
            foreach (string pageElement in pageList.Elements)
            {
                Visit(pageElement);
                System.Threading.Thread.Sleep(700);
                // Check the title of the page
                Console.WriteLine("Page title is: " + driver.Title + Environment.NewLine);
                //Console.WriteLine(driver.TakeScreenshot().AsBase64EncodedString);

                var myNewFileName = pageElement.ToString().Replace("/", "-");
                Console.WriteLine(myNewFileName);


                var filename = new StringBuilder(@"\1");
                filename.Append(myNewFileName);
                filename.Append("-");
                filename.Append(DateTime.Now.ToString("dd-mm-yyyy_HH_mm_ss"));
                filename.Append(".bmp");
                Console.WriteLine(filename);
                ((IJavaScriptExecutor)driver).ExecuteScript("document.body.style.zoom=(top.window.screen.height-70)/Math.max(document.body.scrollHeight, document.body.offsetHeight, document.documentElement.clientHeight, document.documentElement.scrollHeight, document.documentElement.offsetHeight);");
                Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
                ss.SaveAsFile(TestHelper.TempDir() + filename, ImageFormat.Bmp);
                //jse.ExecuteScript("scroll(0, 650);");
                

                Assert.AreEqual(driver.Url, TestHelper.SiteUrl() + pageElement);
                driver.Navigate().Back();
                
            }
        }

        [TestMethod]
        public void TestClickButtonById()
        {
            

        }



        //IWebElement abc = driver.FindElement(By.XPath("//div[contains(@style, 'background-image: url(http://test.com/images/abc.png);')]"));
        //*[@id="header-top"]/div/div/div[1]/a/div


    }
}
