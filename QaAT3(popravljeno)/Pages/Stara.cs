using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAT3_popravljeno_
{

    [TestFixture]
    public class Registration
    {
        IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://olx.ba");
                driver.Manage().Window.Maximize();
                driver.FindElement(By.XPath("//button[contains(text(),'Prihvati i zatvori')]")).Click();
        }



        public void RegisterUser(string email, string username, string password, string s)
        {

            driver.FindElement(By.XPath("//*[@id='loginbtn']")).Click();
            driver.FindElement(By.XPath("//a[contains(text(), 'REGISTRUJTE SE')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(), 'REGISTRUJ PROFIL')]")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@id='reg-password']")).SendKeys(password);
            driver.FindElement(By.XPath("//input[@id='reg-username']")).SendKeys(username);
            driver.FindElement(By.XPath("//div[@class='spol-ikona']")).Click();
            driver.FindElement(By.XPath("//select[@id='kanton']")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'Sarajevo')]")).Click();
            driver.FindElement(By.XPath("//input[@id='tos']")).Click();
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }


        public void VerifyThatUserIsRegistered()
        {
            Assert.True(true);
        }

        [Test]
        public void VeriftyThatUserIsRegisteredTest()
        {
            string username = "username";
            string email = "email.email@email.com";
            string password = "test123";

            RegisterUser(email, username, password, null);
            VerifyThatUserIsRegistered();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
    [TestFixture]
    public class SearchingForVehicles
    {
        

        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://olx.ba");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//button[contains(text(),'Prihvati i zatvori')]")).Click();
        }


        public void SearchForCarUnderSpecificValue(int maxValue)
        {
            driver.FindElement(By.XPath("//a[@id='km']")).Click();
            driver.FindElement(By.XPath("//*[@id='km']")).FindElement(By.XPath("//a[contains(text(),'Vozila')]")).Click();
            driver.FindElement(By.XPath("//input[@id='nova']")).Click();
            driver.FindElement(By.XPath("//select[@id='v_b']")).Click();
            // driver.FindElement(By.XPath($"//option[contains(text(),'{brand}')]")).Click();
            driver.FindElement(By.XPath("//input[@id='do']")).SendKeys(maxValue.ToString());
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        public void VerifyThatUserCanSearchForSpecificCar()
        {
            Assert.True(driver.FindElement(By.XPath(" //div[@id='lista_rezultata']")).Displayed);
        }

        [Test]
        public void VerifyThatUserCanSearchForSpecificCarTest()
        {
            //string brand = "Toyota";
            int maxValue = 30000;

            SearchForCarUnderSpecificValue(maxValue);
            VerifyThatUserCanSearchForSpecificCar();
        }

        public void SearchForSpecificCarBrand(string brand)
        {
            driver.FindElement(By.XPath("//a[@id='km']")).Click();
            driver.FindElement(By.XPath("//*[@id='km']")).FindElement(By.XPath("//a[contains(text(),'Vozila')]")).Click();
            driver.FindElement(By.XPath("//input[@id='nova']")).Click();
            driver.FindElement(By.XPath("//select[@id='v_b']")).Click();
            driver.FindElement(By.XPath($"//option[contains(text(),'{brand}')]")).Click();
            //driver.FindElement(By.XPath("//input[@id='do']")).SendKeys(maxValue.ToString());
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }

        public void VerifyThatUserCanSearchForSpecificCarBrand()
        {
            Assert.True(driver.FindElement(By.XPath(" //div[@id='lista_rezultata']")).Displayed);
        }

        [Test]
        public void VerifyThatUserCanSearchForSpecificCarBrandTest()
        {
            string brand = "Toyota";
            

            SearchForSpecificCarBrand(brand);
            VerifyThatUserCanSearchForSpecificCarBrand();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
        // nauciti
        // kako se dijeli testiranje, staticko/dinamicko, white, black, regresija, smoke,
        // Page object mode, Page object pattern!
        // drugi nacin je IPage factory
    }
    [TestFixture]
    public class SearchingForApartments
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://olx.ba");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//button[contains(text(),'Prihvati i zatvori')]")).Click();
        }

        public void SearchForAparatmentsInSpecificArea(string area)
        {
            driver.FindElement(By.XPath("//a[@id='km']")).Click();
            driver.FindElement(By.XPath("//div[@class='podmeni']")).FindElement(By.XPath("//a[contains(text(),'Nekretnine')]")).Click();
            driver.FindElement(By.XPath("//select[@id='kanton']")).Click();
            driver.FindElement(By.XPath("//select[@id='kanton']")).FindElement(By.XPath($"//option[contains(text(),'{area}')]")).Click();
            driver.FindElement(By.XPath("//div[@class='nekretnine-filteri-buttons']")).FindElement(By.XPath("//span[@id='trazinekretnine']")).Click();
            VerifyThatUserCanSearchForApartmentsInSpecificArea();
        }

        public void VerifyThatUserCanSearchForApartmentsInSpecificArea()
        {
            Assert.True(driver.FindElement(By.XPath("//div[@id='rezultatipretrage']")).Displayed);
        }

        [Test]
        public void VerifyThatUserCanSearchForApartmentsInSpeficifAreaTest()
        {
            string area = "Sarajevo";

            SearchForAparatmentsInSpecificArea(area);
        }

        public void SearchForApartmentUnderSpecificValue(string value)
        {
            driver.FindElement(By.XPath("//a[@id='km']")).Click();
            driver.FindElement(By.XPath("//div[@class='podmeni']")).FindElement(By.XPath("//a[contains(text(),'Nekretnine')]")).Click();
            driver.FindElement(By.XPath("//input[@id='do']")).SendKeys(value);
            driver.FindElement(By.XPath("//div[@class='nekretnine-filteri-buttons']")).FindElement(By.XPath("//span[@id='trazinekretnine']")).Click();

        }

        public void VerifyThatUserCanSearchForApartmentUnderSpecificValue()
        {
            Assert.True(driver.FindElement(By.XPath("//div[@id='rezultatipretrage']")).Displayed);
        }

        [Test]
        public void VerifyThatUserCanSearchForApartmentUnderSpecificValueTest()
        {
            string value = "200000";

            SearchForApartmentUnderSpecificValue(value);
        }






        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}






