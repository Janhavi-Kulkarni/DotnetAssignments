using techtalk.specflow;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DemoDef
{
    [Binding]

    public class DemoDefinition
    {
        IWebDriver driver;
        [Given(@"User is on home page")]
        public void NavigateHomePage()
        {
            driver=new ChromeDriver(@"C:\CSharpGit\DotnetAssignments\SpecFlowDemo\NUnitTest\drivers");
            driver.Navigate().GoToUrl("https://shop.demoqa.com/");
        }

        [When(@"Clicked on search button and serch for a product")]
        public void Search()
        {
            driver.FindElement(By.ClassName("noo-search")).Click();
            driver.FindElement(By.ClassName("form-control")).SendKeys("Test Search");
          driver.FindElement(By.TagName("input")).SendKeys("Test");
        }

        [Then(@"User should presented with relevent search results")]
         public void SearchResult()
        {
           Assert.AssertEquals("ToolsQA Demo Site",driver.GetTitle());
        }

        [Given(@"User is on home page")]
        public void HomePage()
        {
            driver=new ChromeDriver(@"C:\CSharpGit\DotnetAssignments\SpecFlowDemo\NUnitTest\drivers");
            driver.Navigate().GoToUrl("https://shop.demoqa.com/");
        }
        [When(@"Clicked on 'My Wishlist'")]
        public void ClickWishList()
        {
            driver.FindElement(By.LinkText("My Wishlist")).Click();

        }
        [Then(@"User should navigated on 'My Wishlist'")]
        public void Result()
        {
            Assert.AssertEquals("https://shop.demoqa.com/",driver.GetUrl());

        }
    }
}