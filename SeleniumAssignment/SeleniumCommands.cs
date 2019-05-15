using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace SeleniumAssignment
{
    class SeleniumCommands
    {
        IWebDriver driver;
       public void InitializeBrowser()
       { 
           FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\CSharpGit\DotnetAssignments\SeleniumAssignment\drivers");
           // service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
           
            

       }

       public void BrowserCommands()
       {
            driver.Navigate().GoToUrl("http://store.demoqa.com/");

            //get page titlename and print
           String title= driver.Title;
           Console.WriteLine("Page Title is \t"+ title);

           //get page title length and print
            int TitleLength=title.Length;
            Console.WriteLine("Page Title length is \t"+TitleLength);

            //get page url and url length and print 
            String PageUrl=driver.Url;
            int UrlLength=PageUrl.Length;
            Console.WriteLine("Page URL is \t"+PageUrl);
            Console.WriteLine("and URL length is \t"+UrlLength);

            //get page source and page source length and print 
            String PageSource=driver.PageSource;
            int SourceLength=PageSource.Length;
            Console.WriteLine("Page Source length is=\t"+SourceLength);

       }

       public void NavigationCommands()
       {
            driver.Navigate().GoToUrl("http://newtours.demoaut.com/");
           // driver.FindElement(By.Xpath("//a[contains(text(),'REGISTER')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'REGISTER')]")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();



       }

       public void CloseBrowser()
       {
           driver.Close();
       }
      
    }
}
