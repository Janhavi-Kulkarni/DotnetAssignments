using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using System;

namespace Tests
{
    public class Tests
    {
         private IWebDriver _driver;
         private void initiateBrowser()
        {
            
                ChromeOptions chromeoptions = new ChromeOptions()
                {

                };
            
                _driver = new ChromeDriver(@"C:\CSharpGit\DotnetAssignments\XPath Assignment\UnitTest\drivers");
                return;

                 

        }
        [SetUp]
        public void Setup()
        {
            initiateBrowser();
        }

        [Test]
        public void Demo()
        {
             _driver.Navigate().GoToUrl("http://shop.demoqa.com/");

            _driver.Manage().Cookies.DeleteAllCookies();
            //maximize the browser window
            _driver.Manage().Window.Maximize();

           // Basic Xpath
           _driver.FindElement(By.XPath(@"//a[@class='noo-search']"));

           //Xpath using contains()
                        _driver.FindElement(By.XPath("//*[contains(text(),'Wishlist')]")); 

            //Xpath using OR
             _driver.FindElement(By.XPath(@"//*[@id='slide-6-layer-4' or @class='tp-caption   tp-resizeme']"));

             //Xpath using AND
             _driver.FindElement(By.XPath(@"//*[@id='rev_slider_4_1_wrapper' and @class='rev_slider_wrapper fullscreen-container']"));

             //Xpath using Text()
             _driver.FindElement(By.XPath(@"//a[text()='My Account']"));

             //Xpath using Starts-with
            _driver.FindElement(By.XPath(@"//div[starts-with(@id,'cbox')]"));

            //Xpath using Ancestor
            _driver.FindElement(By.XPath("//*[text()='My Wishlist']//ancestor::div[1]"));

            //Xpath using Child
            _driver.FindElement(By.XPath("//*[@class='pull-right noo-topbar-right']/child::li[2]"));
             //Xpath Parent
             _driver.FindElement(By.XPath("//*[@class='tp-caption   tp-resizeme']//parent::div[1]"));
             
              //Xpath Self
              _driver.FindElement(By.XPath("//*[@class='tp-caption   tp-resizeme']//self::div"));
            
             //Xpath Decendant
            _driver.FindElement(By.XPath("//*[@class='noo-services style_left image']//descendant::div[1]")); 
            
        }
    }
}