using NUnit.Framework;
using Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
         Operations op=new Operations();
          
        [SetUp]
        public void Setup()
        {
           
           
        }
         [Test]
        public void InitializationTest()
        {
           
        op.InitializeBrowser();
            
        }

        [Test]
        public void LoginTest()
        {
           
        op.Login();
            
        }

        [Test]
        public void OpenBP()
        {
           
          op.SearchBP();
          bool checkClose = op.CancelBP();
            Assert.AreEqual(checkClose, true);
            
        }
        [Test]
        public void Reset()
        {
           
          op.SearchBP();
          bool checkReset = op.ResetBP();
            Assert.AreEqual(checkReset, true);
            
        }
       

        
    }
}