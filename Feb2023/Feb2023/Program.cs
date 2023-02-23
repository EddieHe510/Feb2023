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

// Create a new time record
// Navigate to Time and Material page
IWebElement administrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropDown.Click();

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

// Click create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

// Select Time option from TypeCode dropdown list
IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
typeCode.Click();

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
timeOption.Click();

// Input code into code textbox
IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("Feb2023");

// Input Description into description textbox
IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
descriptionTextBox.SendKeys("Feb2023");

// Input Prive per unit into price per unit textbox
IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceTextbox.SendKeys("510");

// Click on the save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

// Wait for 5s
Thread.Sleep(5000);

// Check if time record has been created
IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPage.Click();

// Wait for 5s
Thread.Sleep(5000);

// Navigate to the last one record
IWebElement newTimeRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (newTimeRecord.Text == "Feb2023")
{
    Console.WriteLine("New Time Record Created Sucessfully!!!");
}
else
{
    Console.WriteLine("New Time Record Hasn't Been Created!!!");
}
// Wait for 5s
Thread.Sleep(5000);

// Close the browser
driver.Quit();