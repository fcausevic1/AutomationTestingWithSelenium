using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAT3_popravljeno_.Pages
{
 
    public class RegisterPage : BasePage
    {
        

       public RegisterPage(IWebDriver driver) : base(driver)
        {

        }
        public void VerifyThatUserCanGoToRegisterPage()
        {
            Assert.True(driver.FindElement(By.XPath("//h1[contains(text(),'Registracija')]")).Displayed);
        }
    }
}
