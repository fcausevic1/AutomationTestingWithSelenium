using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QaAT3_popravljeno_.DriverManager;
using QaAT3_popravljeno_.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAT3_popravljeno_.Tests
{
    public class TestBase
    {
        IWebDriver driver;
        protected HomePage homePage;


        [SetUp]
        public void SetUp()
        {
            driver = new ChooseDriver().CreateDriver("chrome");
            driver.Navigate().GoToUrl("https://olx.ba");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//button[contains(text(),'Prihvati i zatvori')]")).Click();

            homePage = new HomePage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }


    }
}
