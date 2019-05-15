using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace SeleniumAssignment
{
    class ButtonOperations
    {
        IWebDriver driver;

        public void InitializeBrowser()
       { 
           FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\CSharpGit\DotnetAssignments\SeleniumAssignment\drivers");
           // service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);
           
            

       }

       public void CheckboxOperations()
       {
           driver.Navigate().GoToUrl("https://www.toolsqa.com/automation-practice-form/");
           IWebElement element1=driver.FindElement(By.Id("profession-0"));
           String CheckboxName1=element1.GetAttribute("name");
           Console.WriteLine("Checkbox Value=\t"+CheckboxName1);
           String CheckboxValue1=element1.GetAttribute("value");
           Console.WriteLine("Checkbox Value=\t"+CheckboxValue1);

           IWebElement element2=driver.FindElement(By.Id("profession-1"));
           element2.Click();
           String CheckboxName2=element2.GetAttribute("name");
           Console.WriteLine("Checkbox Value=\t"+CheckboxName2);
           String CheckboxValue2=element2.GetAttribute("value");
           Console.WriteLine("Checkbox Value=\t"+CheckboxValue2);

       }

       public void RadioOperations()
       {
           driver.Navigate().GoToUrl("https://www.toolsqa.com/automation-practice-form/");
           IWebElement element1=driver.FindElement(By.Id("sex-0"));
           String CheckboxName1=element1.GetAttribute("name");
           Console.WriteLine("Checkbox Value=\t"+CheckboxName1);
           String CheckboxValue1=element1.GetAttribute("value");
           Console.WriteLine("Checkbox Value=\t"+CheckboxValue1);

           IWebElement element2=driver.FindElement(By.Id("sex-1"));
           element2.Click();
           String CheckboxName2=element2.GetAttribute("name");
           Console.WriteLine("Checkbox Value=\t"+CheckboxName2);
           String CheckboxValue2=element2.GetAttribute("value");
           Console.WriteLine("Checkbox Value=\t"+CheckboxValue2);

       }
        public void CloseBrowser()
       {
           driver.Close();
       }
    }
}