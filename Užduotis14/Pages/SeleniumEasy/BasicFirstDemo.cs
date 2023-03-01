using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Užduotis14.Pages.SeleniumEasy
{
    public class BasicFirstDemo
    {
        public static void EnterEmail(string valueEmail)
        {

            string locator = "//*[@id='userEmail']";
            Common.EnterEmail(locator, valueEmail);

        }

        public static void EnterFullName(string valueFullName)
        {
            
            string locator = "//*[@id='userName']";

            Common.Sendkeys(locator, valueFullName);
        }
    }
}
