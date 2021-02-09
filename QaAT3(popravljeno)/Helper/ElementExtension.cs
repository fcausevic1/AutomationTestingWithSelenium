using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaAT3_popravljeno_.Helper
{
    public static class ElementExtension
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSec)
        {
            if (timeoutInSec > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSec));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }

        public static bool WaitUntilClickable(this IWebElement element, IWebDriver driver, int seconds)
        {
            {
                try
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

                    return wait.Until(drv =>
                    {
                        if (SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element) != null)
                            return true;
                        return false;
                    });
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
