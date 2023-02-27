namespace SeleniumTestai
{
    internal interface IWebDriver
    {
        object Url { get; set; }

        void FindElement(object xPath);
        IWEbElement FindElement(object value);
    }
}