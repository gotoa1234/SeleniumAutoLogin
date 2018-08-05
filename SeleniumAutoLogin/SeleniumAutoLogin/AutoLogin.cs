using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAutoLogin
{
    public class AutoLogin
    {
        /// <summary>
        /// 測試登入網頁
        /// </summary>
        private string _url = "https://louislinebot.azurewebsites.net/login";
        /// <summary>
        /// Selenium C# Libary
        /// </summary>
        private IWebDriver driver;
        public AutoLogin()
        {
           
        }

        /// <summary>
        /// 進行登入
        /// </summary>
        public void Login()
        {
            IWebDriver driver = new ChromeDriver();
            //開啟網頁
            driver.Navigate().GoToUrl(_url);
            //隱式等待 - 直到畫面跑出資料才往下執行
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10000);

            //輸入帳號
            IWebElement inputAccount = driver.FindElement(By.Name("Account"));
            Thread.Sleep(2000);
            //清除按鈕
            inputAccount.Clear();
            Thread.Sleep(2000);
            inputAccount.SendKeys("20180513");
            Thread.Sleep(2000);

            //輸入密碼
            IWebElement inputPassword = driver.FindElement(By.Name("Passwrod"));

            inputPassword.Clear();
            Thread.Sleep(2000);
            inputPassword.SendKeys("123456");
            Thread.Sleep(2000);

            //點擊執行
            IWebElement submitButton= driver.FindElement(By.XPath("/html/body/div[2]/form/table/tbody/tr[4]/td[2]/input"));
            Thread.Sleep(2000);
            submitButton.Click();
            Thread.Sleep(2000);

            driver.Quit();
        }

    }
}
