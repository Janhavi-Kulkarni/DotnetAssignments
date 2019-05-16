using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System;




namespace Tests
{
    [TestFixture]
    public class BrowserTest
    {
        private IWebDriver _driver;
       
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void LaunchChromeBrowser()
        {
            _driver=new ChromeDriver(@"C:\CSharpGit\DotnetAssignments\XPath Assignment\UnitTest\drivers");
            _driver.Navigate().GoToUrl("https://www.google.com/");
                     _driver.Close();
            
        }

        [Test]
        public void LaunchIEBrowser()
        {
            _driver=new  InternetExplorerDriver(@"C:\CSharpGit\DotnetAssignments\XPath Assignment\UnitTest\drivers");
            _driver.Navigate().GoToUrl("https://www.google.com/");
           
            _driver.Close();
        }

         [Test]
        public void LaunchFireFoxBrowser()
        {
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\CSharpGit\DotnetAssignments\XPath Assignment\UnitTest\drivers");
           // service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            _driver = new FirefoxDriver(service);
            _driver.Navigate().GoToUrl("https://www.google.com/");
            

            _driver.Close();
        }

}
}