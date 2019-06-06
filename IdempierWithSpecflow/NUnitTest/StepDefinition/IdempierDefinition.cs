using System;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Idempiere.IdempiereTest.IdempiereTest
{
    [Binding]
    public class IdempierFeatureSteps
    {
        IWebDriver driver;
        private static DefaultWait<IWebDriver> fluentWait;

        [Given(@"I navigated on login page from link")]
        public void GivenINavigatedOnLoginPageFromLink()
        {
            driver = new ChromeDriver(@"C:\CSharpGit\DotnetAssignments\Idempiere\driver\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.idempiere.org/test-sites");
            driver.FindElement(By.PartialLinkText("idempiere.org")).Click();
            // driver.FindElement(By.XPath("//a[contains(text(),'https://test.idempiere.org/webui/')]")).Click();
            IList<String> li = driver.WindowHandles;
            foreach (var item in li)
            {
                if (item != driver.CurrentWindowHandle)
                {
                    driver.SwitchTo().Window(item);
                }

            }
        }
        
        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            driver.FindElement(By.XPath("//input[@autocomplete='username']")).SendKeys("admin @ gardenworld.com");
            driver.FindElement(By.XPath("//input[@autocomplete='current-password']")).SendKeys("GardenAdmin");
        }
        
        [Given(@"I navigated on Favorties")]
        public void GivenINavigatedOnFavorties()
        {
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
            searchResult.Click();
        }
        
        [Given(@"I selecte Business Partner")]
        public void GivenISelecteBusinessPartner()
        {
            fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement searchResult = fluentWait.Until(x => x.FindElement(By.XPath("//a[@title='Maintain Business Partners']")));
            searchResult.Click();
        }
        
        [Given(@"I entered values in all fields")]
        public void GivenIEnteredValuesInAllFields(Table table)
        {
            IWebElement key = driver.FindElement(By.XPath("//input[@instancename='Value']"));
            IWebElement name1 = driver.FindElement(By.XPath("//input[@instancename='Name']"));
            IWebElement name2 = driver.FindElement(By.XPath("//input[@instancename='Name2']"));
            IWebElement description = driver.FindElement(By.XPath("//input[@instancename='Description']"));


            key.SendKeys("123");
            name1.SendKeys("Janhavi");
            name2.SendKeys("Kulkarni");
            description.SendKeys("this is test description");
        }
        
        [When(@"Click on Login button")]
        public void WhenClickOnLoginButton()
        {
            
            driver.FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();
        }
        
        [When(@"I Clicked on Cancel button")]
        public bool WhenIClickedOnCancelButton()
        {
            bool locateCancelBtn = false;
            IWebElement cancelBtn = fluentWait.Until(y => y.FindElement(By.XPath("//button[@title='Cancel']")));

            if (cancelBtn.Displayed)
            {
                locateCancelBtn = true;
            }

            //Close the form
            if (locateCancelBtn)
            {
                cancelBtn.Click();
            }

            return locateCancelBtn;
        }
        
        [When(@"I clicked on Reset button")]
        public bool WhenIClickedOnResetButton()
        {
            bool locateResetBtn = false;
            IWebElement resetBtn = fluentWait.Until(y => y.FindElement(By.XPath("//button[@title='Reset']")));
            IWebElement key = driver.FindElement(By.XPath("//input[@instancename='Value']"));
            IWebElement name1 = driver.FindElement(By.XPath("//input[@instancename='Name']"));
            IWebElement name2 = driver.FindElement(By.XPath("//input[@instancename='Name2']"));
            IWebElement description = driver.FindElement(By.XPath("//input[@instancename='Description']"));
            if (resetBtn.Displayed)
            {
                locateResetBtn = true;
            }
            resetBtn.Click();
           
            if (key.Text.Equals(" ") && name1.Text.Equals(" ") && name2.Text.Equals(" ") && description.Text.Equals(" "))
            {
                locateResetBtn = true;
            }

            return locateResetBtn;
        }
        
        [When(@"I Cliked on OK button")]
        public void WhenIClikedOnOKButton()
        {
            bool locateOKBtn = false;
            IWebElement OKBtn = fluentWait.Until(k => k.FindElement(By.XPath("//button[@title='OK']")));
            OKBtn.Click();
        }
        
        [When(@"I Cliked on New Record Icon button")]
        public void WhenIClikedOnNewRecordIconButton()
        {
            fluentWait.Until(k => k.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[3]/span[1]/img[1]"))).Click();
        }
        
        [When(@"Entered value")]
        public void WhenEnteredValue(Table table)
        {
            driver.FindElement(By.XPath("//input[@instancename='C_BPartner0Name']")).SendKeys("TestName1");
            
        }
        
        [When(@"Cliked on Save Icon button")]
        public void WhenClikedOnSaveIconButton()
        {
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[6]/span[1]/img[1]")).Click();
        }
        
        [Then(@"I should get navigated on dashboard")]
        public void ThenIShouldGetNavigatedOnDashboard()
        {
            String URL = driver.Url;
            String Title = driver.Title;
            Console.WriteLine(Title);
            Assert.AreEqual(URL, "https://test.idempiere.org/webui/");
        }
        
        [Then(@"Business Partner Search Window should get closed")]
        public void ThenBusinessPartnerSearchWindowShouldGetClosed()
        {
            String URL = driver.Url;
            Assert.AreEqual(URL, "https://test.idempiere.org/webui/");
        }
        
        [Then(@"All values should get reset to blank")]
        public void ThenAllValuesShouldGetResetToBlank()
        {
            bool locateResetBtn = false;
            IWebElement resetBtn = fluentWait.Until(y => y.FindElement(By.XPath("//button[@title='Reset']")));
            IWebElement key = driver.FindElement(By.XPath("//input[@instancename='Value']"));
            IWebElement name1 = driver.FindElement(By.XPath("//input[@instancename='Name']"));
            IWebElement name2 = driver.FindElement(By.XPath("//input[@instancename='Name2']"));
            IWebElement description = driver.FindElement(By.XPath("//input[@instancename='Description']"));
            if (key.Text.Equals(" ") && name1.Text.Equals(" ") && name2.Text.Equals(" ") && description.Text.Equals(" "))
            {
                locateResetBtn = true;
            }
            Assert.AreEqual(locateResetBtn, "true");
        }
        
        [Then(@"I should get navigated on Business Partner window")]
        public void ThenIShouldGetNavigatedOnBusinessPartnerWindow()
        {
            IWebElement ele = driver.FindElement(By.XPath("//span[contains(text(),'Business Partner')]"));

            if (ele.Displayed)
            {
                bool locateOKBtn = false;
                IWebElement OKBtn = fluentWait.Until(k => k.FindElement(By.XPath("//button[@title='OK']")));
                locateOKBtn = true;
                Assert.AreEqual(locateOKBtn, "true");
            }
        }
        
        [Then(@"New Business Partner should get created and saved")]
        public void ThenNewBusinessPartnerShouldGetCreatedAndSaved()
        {
            String msg = driver.FindElement(By.XPath("//span[contains(text(),'Record saved')]")).Text;
            Assert.AreEqual(msg, "Record saved");

        }
    }
}
