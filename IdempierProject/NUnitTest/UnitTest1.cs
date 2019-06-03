using NUnit.Framework;
using Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Tests
{
    public class Tests
    {
        Operations op = new Operations();

        [SetUp]
        public void Setup()
        {
            op.InitializeBrowser();
            op.Login();
        }
        public void InitializationTest()
        {



        }
        public void LoginTest()
        {

            //String ValidURL=op.Login();
            // Assert.AreEqual(ValidURL,"https://test.idempiere.org/webui/");


        }



        [Test]
        public void BPOperations2()
        {

            bool checkClose = op.CancelBP();
            Assert.AreEqual(checkClose, true);
            bool checkReset = op.ResetBP();
            Assert.AreEqual(checkReset, true);
            bool checkNavigation = op.NavigateBP();
            Assert.AreEqual(checkNavigation, true);

            String message = op.CreateNewBP();

            Assert.AreEqual(message, "Record saved");

            

        }





    }
}