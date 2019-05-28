using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Service
{
    public class Operations
    {
        IWebDriver driver;

        public void InitializeBrowser()
       { 
           FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\CSharpGit\DotnetAssignments\SeleniumAssignment\drivers");
           // service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
           
            

       }
    }
}
