using Feb2023.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.Pages
{
    public class TMPage
    {
        public void CreateNew(IWebDriver driver)
        {
            // Identify the Create New Button and click on it
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // Identify the TypeCode drop down list and select the Time option
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCode.Click();

            // selecte the time option
            IWebElement timeOp = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOp.Click();

            // Identify the Code Textbox and input code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("March2023");

            // Identify the Description Textbox and input description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("March2023");

            // Identify the Price per unit TextBox and input the Price
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBox.SendKeys("309");

            // Identify the Save button and click on it
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
        }

        public void EditTM(IWebDriver driver)
        {
            // set a wait until element is clickable
            Wait.WatiToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);

            // Identify the Go To Last Page button and click on it
            IWebElement GoToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GoToLastPage.Click();

            // set a wait until element is clickable
            Wait.WatiToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]", 5);

            // Identify the last record and click the Edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            // Identify the Code TextBox and clear it, then input new code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.Clear();
            codeTextBox.SendKeys("MARCH2023");

            // Identify the Description TextBox and clear it, then input new description
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys("EddieMarch2023");

            Thread.Sleep(5000);

            // Identify the Save button and click on it
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            // set a wait until element is clickable
            Wait.WatiToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);
            // Check if new Time record has been created
            IWebElement GoToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GoToLastPage1.Click();
            Thread.Sleep(5000);
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "MARCH2023", "Actual code and expected code do not match.");
        }

        public void DeleteTM(IWebDriver driver)
        {
            // set a wait until element is clickable
            Wait.WatiToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);

            // Identify the Go To Last Page button and click on it
            IWebElement GoToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            GoToLastPage.Click();

            // set a wait until element is clickable
            Wait.WatiToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]", 5);

            // Identify the last record and click the Delete Button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            // Acquire Alert and Click the Accept
            IAlert deleteAlert = driver.SwitchTo().Alert();
            deleteAlert.Accept();

            Assert.That(deleteButton.Text != "March2023", "Record hasn't been deleted!");
        }

    }
}
