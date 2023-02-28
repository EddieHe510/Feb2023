using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feb2023.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            // Select Time option from TypeCode dropdown list
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCode.Click();

            // Wait for 2s
            Thread.Sleep(2000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            // Input code into code textbox
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Feb2023");

            // Input Description into description textbox
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Feb2023");

            // Input Prive per unit into price per unit textbox
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("309");

            // Click on the save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
        }

        public void EditTM(IWebDriver driver)
        {
            // Navigate to the last one record and Click on the Edit button
            IWebElement newTimeRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            newTimeRecord.Click();

            // Navigate to the Code textbox and Change Code name to FEBRUARY2023
            IWebElement newCodeName = driver.FindElement(By.Id("Code"));
            // Clear up the textbox
            newCodeName.Clear();
            // Input new Code name
            newCodeName.SendKeys("FEBRUARY2023");

            // Navigate to the Description textbox and change Decription to FEB2023
            IWebElement newDescription = driver.FindElement(By.Id("Description"));
            // Clear up the textbox
            newDescription.Clear();
            // Input new description
            newDescription.SendKeys("FEB2023");

            // Click on the save button
            IWebElement newSaveButton = driver.FindElement(By.Id("SaveButton"));
            newSaveButton.Click();

        }

        public void DeleteTM(IWebDriver driver)
        {
            // Navigate to the last one reconrd and Click on the Delete button
            IWebElement lastTimeRecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            lastTimeRecord.Click();

            // Acquire Alert and Click the Accept
            IAlert deleteAlert = driver.SwitchTo().Alert();
            deleteAlert.Accept();
        }
    }
}
