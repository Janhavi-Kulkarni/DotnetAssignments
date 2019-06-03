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
// Initialize Browser and navigate to URL
        public void InitializeBrowser()
       { 
           driver=new ChromeDriver(@"C:\CSharpGit\DotnetAssignments\IdempierProject\driver");
           driver.Manage().Window.Maximize();
             driver.Navigate().GoToUrl("https://www.idempiere.org/test-sites");   
       }

//Click on idempiere.org and log in to the application
       public String Login()
       {
         
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

         String URL=driver.Url;
         String Title=driver.Title;
         Console.WriteLine(Title);
         return URL;

        
          
           
         
       }


      //Navigate to BP and Click on Cancel Button

      public bool CancelBP()
      {
        
       
          fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
         IWebElement searchResult = fluentWait.Until(x=>x.FindElement(By.XPath("//a[@title='Maintain Business Partners']"))); 
       searchResult.Click();
      
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


//Navigate to BP from favorites,add details and reset
        public bool ResetBP()
        {
         
           IWebElement searchResult = fluentWait.Until(x=>x.FindElement(By.XPath("//a[@title='Maintain Business Partners']"))); 
       searchResult.Click();
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

//On BP,add details>Click OK and navigate to Business Partner Page
        public bool NavigateBP()
        {
          bool locateOKBtn = false;
            IWebElement OKBtn = fluentWait.Until(k=>k.FindElement(By.XPath("//button[@title='OK']")));

           

         IWebElement key=driver.FindElement(By.XPath("//input[@instancename='Value']"));
         IWebElement name1=driver.FindElement(By.XPath("//input[@instancename='Name']"));
          IWebElement name2 =driver.FindElement(By.XPath("//input[@instancename='Name2']"));
          IWebElement description=driver.FindElement(By.XPath("//input[@instancename='Description']"));

          
          key.SendKeys("123");
          name1.SendKeys("Janhavi");
          name2.SendKeys("Kulkarni");
          description.SendKeys("this is test description");
         
            
            OKBtn.Click();

          IWebElement  ele=driver.FindElement(By.XPath("//span[contains(text(),'Business Partner')]"));
          
          if(ele.Displayed)
          {
            locateOKBtn=true;
          }

         return locateOKBtn;

        }

        //Crate New BP and Save

        public String CreateNewBP()
        {

          fluentWait.Until(k=>k.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[3]/span[1]/img[1]"))).Click();
          driver.FindElement(By.XPath("//input[@instancename='C_BPartner0Name']")).SendKeys("TestName1");
          driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[6]/span[1]/img[1]")).Click();

          String msg=driver.FindElement(By.XPath("//span[contains(text(),'Record saved')]")).Text;
          return msg;

          
        }

    
      }
       
    }


