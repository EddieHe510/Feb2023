using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open the broswer
IWebDriver driver = new ChromeDriver();

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

// Check if user has successfully logged in
IWebElement loginMessage = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if(loginMessage.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully");
}
else
{
    Console.WriteLine("Login failed");
}

// Close the browser
driver.Quit();
