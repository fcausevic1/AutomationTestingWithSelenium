using NUnit.Framework;
using OpenQA.Selenium;
using QaAT3_popravljeno_.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAT3_popravljeno_.Tests
{
    [TestFixture]
    class RegisterTest : TestBase
    {
         [Test]
        public void VerifyThatUserCanGoToRegisterPageTest()
        {
            RegisterPage registerPage = homePage.GoToRegisterPage();
            registerPage.VerifyThatUserCanGoToRegisterPage();

        }

    }
}
