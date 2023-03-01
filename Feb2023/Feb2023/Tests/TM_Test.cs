using Feb2023.Pages;
using Feb2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.Tests
{
    [TestFixture]
    public class TM_Test: CommonDriver
    {
        [SetUp]
        public void LoginStep()
        {
            driver = new ChromeDriver();

            // Login page object initialzation and definition
            LoginPage loginObj = new LoginPage();
            loginObj.LoginAction(driver);

            // Home page object initialzation and definition
            HomePage homeObj = new HomePage();
            homeObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateNew()
        {
            // TM page object initialzation and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateNew(driver);
        }

        [Test]
        public void Edit()
        {
            // TM page object initialzation and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTM(driver); 
        }

        [Test]
        public void Delete()
        {
            // TM page object initialzation and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTM(driver); 
        }

        [TearDown]
        public void CloseBrowser()
        { 
            driver.Quit();
        }
    }
}
