

using OpenQA.Selenium;
using System;
using System.Security.Cryptography.X509Certificates;
using Užduotis14.Pages.SeleniumEasy;

namespace Užduotis14.Pages
{
    public class Common
    {
        internal static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }
        internal static void EnterEmail(string locator, string valueEmail)
        {
            Driver.GetDriver().FindElement(By.XPath(locator)).SendKeys(valueEmail);
           

     

        internal static void Sendkeys(string locator, string valueFullName)
        {
            Driver.GetDriver().FindElement(By.XPath(locator)).SendKeys(valueFullName);
        }
    }
}
