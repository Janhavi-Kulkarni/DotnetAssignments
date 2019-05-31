using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Service
{
    public class Operations
    {
        IWebDriver driver;
        private static DefaultWait<IWebDriver> fluentWait;

        public void InitializeBrowser()
       { 
           driver=new ChromeDriver(@"C:\CSharpGit\DotnetAssignments\IdempierProject\driver");
           driver.Manage().Window.Maximize();
             driver.Navigate().GoToUrl("https://www.idempiere.org/test-sites");   
       }

       public void Login()
       {
        // bool ele=false;
        driver.FindElement(By.PartialLinkText("idempiere.org")).Click();
        // driver.FindElement(By.XPath("//a[contains(text(),'https://test.idempiere.org/webui/')]")).Click();
         IList<String> li=driver.WindowHandles;
          foreach (var item in li)
          {
            if(item!=driver.CurrentWindowHandle)
            {
              driver.SwitchTo().Window(item);
            }
              
          }
          driver.FindElement(By.XPath("//input[@autocomplete='username']")).SendKeys("admin @ gardenworld.com");
          driver.FindElement(By.XPath("//input[@autocomplete='current-password']")).SendKeys("GardenAdmin");
          driver.FindElement(By.XPath("//button[contains(text(),'OK')]")).Click();

          /*if(driver.FindElement(By.XPath("//input[@class='z-bandbox-input']")).Displayed)
          {
              return true;
          }

        
          
           
           //driver.FindElement(By.XPath(@"//a[contains(text(),'https://test.idempiere.org/webui/')]")).Click();
          // driver.FindElement(By.XPath(@"//input[contains(text(),'Q10')]")).SendKeys("admin @ gardenworld.com");
          // driver.FindElement(By.XPath(@"//input[contains(text(),'Q50')]")).SendKeys("GardenAdmin");
          //driver.FindElement(By.XPath(@"//input[@class='z-textbox[1]']")).SendKeys("admin@gardenworld.com");
          //driver.FindElement(By.XPath(@"//input[@class='z-textbox[2]']")).SendKeys("GardenAdmin");

          // driver.FindElement(By.ClassName("login-btn z-button")).Click();*/
       }

      public void SearchBP()
      {
       fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
         IWebElement searchResult = fluentWait.Until(x=>x.FindElement(By.XPath("//a[@title='Maintain Business Partners']"))); 
       searchResult.Click();
      }

      public bool CancelBP()
      {
         /*fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));*/
        // IWebElement searchResult = fluentWait.Until(x=>x.FindElement(By.XPath("//button[@title='Cancel']"))); 
       //searchResult.Click();
      // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
       //driver.FindElement(By.XPath("//button[@title='Cancel']//img[@class='z-button-image']")).Click();
       
            bool locateCancelBtn = false;
            IWebElement cancelBtn = fluentWait.Until(y=>y.FindElement(By.XPath("//button[@title='Cancel']")));
            
            if(cancelBtn.Displayed)
            {
                locateCancelBtn = true;
            }

            //Close the form
            if(locateCancelBtn)
            {
                cancelBtn.Click();
            }
            
            return locateCancelBtn;
        }

        public bool ResetBP()
        {
          
          
            bool locateResetBtn = false;
            IWebElement resetBtn = fluentWait.Until(y=>y.FindElement(By.XPath("//button[@title='Reset']")));

            if(resetBtn.Displayed)
            {
                locateResetBtn = true;
            }

         IWebElement key=driver.FindElement(By.XPath("//input[@instancename='Value']"));
         IWebElement name1=driver.FindElement(By.XPath("//input[@instancename='Name']"));
          IWebElement name2 =driver.FindElement(By.XPath("//input[@instancename='Name2']"));
          IWebElement description=driver.FindElement(By.XPath("//input[@instancename='Description']"));

          
          key.SendKeys("123");
          name1.SendKeys("Janhavi");
          name2.SendKeys("Kulkarni");
          description.SendKeys("this is test description");

          resetBtn.Click();
          if(key.Text.Equals(" ")&&name1.Text.Equals(" ")&&name2.Text.Equals(" ")&&description.Text.Equals(" "))
          {
            locateResetBtn=true;
          }

         return locateResetBtn;

        }

    
      }
       
    }

