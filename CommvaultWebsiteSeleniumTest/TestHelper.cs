using System;
using System.Drawing.Imaging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace CommvaultWebsiteSeleniumTest
{
    public static class TestHelper
    {

        public static string SiteUrl()
        {
            // change to your installed location
            return "http://www.commvault.com";
        }

        // change to yours
        public static string ScriptDir()
        {
            return @"C:\CommvaultSeleniumTest\CommvaultWebsiteSeleniumTest\CommvaultWebsiteSeleniumTest";
        }

        public static string TempDir()
        {
            return "C:\\temp";
        }

    }
}
