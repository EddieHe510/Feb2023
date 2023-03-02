using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver)
        {
            // Maximize broswer window
            driver.Manage().Window.Maximize();

            // lauch the turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            try
            {
                // Identify the Username TextBox and enter valid username
                IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
                usernameTextBox.SendKeys("hari");
            }
            catch (Exception ex)
            {
                Assert.Fail("Trunup Portal home page did not match!", ex.Message);
            }
            
            // Identify the Password TextBox and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            // Identify the Log in button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();

        }
        

    }
}
