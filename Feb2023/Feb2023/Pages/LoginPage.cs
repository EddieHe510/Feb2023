using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Feb2023.Pages
{
    public class LoginPage
    {
        public void LoginAction(IWebDriver driver)
        {
            // Maximaize broswer window
            driver.Manage().Window.Maximize();

            // Lauch turnup protal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fJob");

            // Identify the username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // Identify the password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // Identify the login button and click
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
        }
    }
}
