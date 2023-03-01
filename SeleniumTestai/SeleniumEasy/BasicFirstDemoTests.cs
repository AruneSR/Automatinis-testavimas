using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Užduotis14.Pages;
using Užduotis14.Pages.SeleniumEasy;

namespace SeleniumTestai.SeleniumEasy
{
    internal class BasicFirstDemoTests
    {
        [Test]
        public void FormWithValidData()
        {
            

            string valueFullName = "Tester";
            string valueEmail = "test@tester.com";
            string valueCurrentAddress = "Test Address";
            string valuePermanentAddress = "Test Address 2";


            Driver.SetupDriver();
            Driver.OpenUrl("https://demoqa.com/text-box");
            BasicFirstDemo.EnterFullName(valueFullName);
            BasicFirstDemo.EnterEmail(valueEmail);

            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

           
            inputEmail.SendKeys(valueEmail);
            inputCurrentAddress.SendKeys(valueCurrentAddress);
            inputPermanentAddress.SendKeys(valuePermanentAddress);

            
            Commmon.EnterEmail



          


            driver.ExecuteJavaScript("window.scrollBy(0, 200)");
            buttonSubmit.Click();

            IWebElement outputFullName = driver.FindElement(By.XPath("//*[@id='output']//*[@id='name']"));
            IWebElement outputEmail = driver.FindElement(By.XPath("//*[@id='output']//*[@id='email']"));
            IWebElement outputCurrentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
            IWebElement outputPermanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='permanentAddress']"));

            Driver.QuitDriver();

            Assert.AreEqual($"Name:{valueFullName}", outputFullName.Text);
            Assert.AreEqual($"Email:{valueEmail}", outputEmail.Text);
            Assert.AreEqual($"Current Address :{valueCurrentAddress}", outputCurrentAddress.Text);
            Assert.AreEqual($"Permananet Address :{valuePermanentAddress}", outputPermanentAddress.Text);

           
        }

    }
}
