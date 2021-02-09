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
        #region Controls
        IWebElement loginButton => driver.FindElement(By.XPath("//*[@id='loginbtn']"));
        IWebElement registerButton => driver.FindElement(By.XPath("//a[contains(text(), 'REGISTRUJTE SE')]"));
        #endregion

        public HomePage(IWebDriver driver) : base(driver) { }


        public RegisterPage GoToRegisterPage()
        {
            loginButton.Click();
            registerButton.Click();

            return new RegisterPage(driver);
            }

       
    }
}
