using System;


namespace SeleniumTestai
{
    internal class Uzduotis14
    {
        public object By { get; private set; }

        public void TextBoxAllInputFields()
        {
            string expectedResult = "Arune";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement InPutFullName = driver.FindElement(By.XPath(""));
            {

            }




        }


        

        

    }
}
