using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumAssignment
{
    class MainClass
    {
        static void Main(string[] args)
        {
           SeleniumCommands sel =new SeleniumCommands();
           sel.InitializeBrowser();
           sel.BrowserCommands();
         sel.NavigationCommands();
          sel.CloseBrowser();

          ButtonOperations ButOp=new ButtonOperations();
          ButOp.InitializeBrowser();
          ButOp.CheckboxOperations();
          ButOp.RadioOperations();
        }

        

    }
}