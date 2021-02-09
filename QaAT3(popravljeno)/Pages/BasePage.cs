using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QaAT3_popravljeno_.DriverManager;

namespace QaAT3_popravljeno_.Pages
{
    public class BasePage
    {
        public IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

        }
        
       
    }
}
