using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAT3_popravljeno_.DriverManager
{
    public class ChooseDriver
    {
        public IWebDriver driver;

        public IWebDriver CreateDriver(string browser)
        {
            switch(browser)
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(AppDomain.CurrentDomain.BaseDirectory);
                     driver = new FirefoxDriver(service);
                    break;
                case "iexplorer":
                    driver = new InternetExplorerDriver();
                    break;
            }
            return driver;
        }
    }
}
