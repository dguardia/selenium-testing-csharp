using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CommvaultWebsiteSeleniumTest
{
    [TestClass]
    public class TestNoVendorLockInMktoForm
    {
        static IWebDriver driver = new ChromeDriver();
        private readonly string element = "/no-vendor-lock-in";
        private readonly string thankYou = "/how-to-buy/contact-confirmation";

        
    }
}
