using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace WebPPC.UITests.Selenium.Support
{
    public static class Browsers
    {
        public static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(10);

        private static IWebDriver _chrome;
        public static IWebDriver Chrome
        {
            get
            {
                if (_chrome == null) _chrome = new ChromeDriver();
                return _chrome;
            }
        }

        private static IWebDriver _firefox;
        public static IWebDriver Firefox
        {
            get
            {
                if (_firefox == null)
                {
                    _firefox = new FirefoxDriver();
                    _firefox.Manage().Timeouts().ImplicitWait = DefaultTimeout;
                }

                return _firefox;
            }
        }
    }
}
