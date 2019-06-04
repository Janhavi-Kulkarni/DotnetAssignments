using NUnit.Framework;
using StepDefinition;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    public class Tests
    {
        IdempierDef ID=new IdempierDef();
        [SetUp]
        public void Setup()
        {
            ID.Login();
            String ValidURL=op.Login();
            Assert.AreEqual(ValidURL,"https://test.idempiere.org/webui/");
        }

        [Test]
        public void Test1()
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