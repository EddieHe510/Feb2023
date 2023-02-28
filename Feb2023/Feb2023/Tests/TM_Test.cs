using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Feb2023.Pages;

// Open the broswer
IWebDriver driver = new ChromeDriver();

// Login Page object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginAction(driver);

// Home Page object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

// TM Page object initialization and definition
TMPage tMPageObj = new TMPage();
tMPageObj.CreateTM(driver);

// Edit TM
tMPageObj.EditTM(driver);

// Delete TM
tMPageObj.DeleteTM(driver);