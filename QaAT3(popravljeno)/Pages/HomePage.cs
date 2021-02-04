using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAT3_popravljeno_.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }


        public RegisterPage GoToRegisterPage()
        {
            driver.FindElement(By.XPath("//*[@id='loginbtn']")).Click();
            driver.FindElement(By.XPath("//a[contains(text(), 'REGISTRUJTE SE')]")).Click();

            return new RegisterPage(driver);
            }

       
    }
}
