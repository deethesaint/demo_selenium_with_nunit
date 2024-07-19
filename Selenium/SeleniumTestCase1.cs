using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace Selenium
{
    class SeleniumTestCase1
    {
        IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void RunTest()
        {
            driver.Navigate().GoToUrl("https://id.zing.vn/");

            Thread.Sleep(3000);

            driver.FindElement(By.Id("login_account")).Clear();
            driver.FindElement(By.Id("login_account")).SendKeys("badboy_2203");

            driver.FindElement(By.Id("login_pwd")).Clear();
            driver.FindElement(By.Id("login_pwd")).SendKeys("dieucobap");

            driver.FindElement(By.ClassName("zidsignin_btn")).Click();

            //driver.FindElement(By.Name("password")).Clear();
            //driver.FindElement(By.Name("password")).SendKeys("123456");

            //driver.FindElement(By.Id("login")).Click();

            //Thread.Sleep(2000);
            //driver.FindElement(By.LinkText("My Profile")).Click();

            Thread.Sleep(2000);
        }

        [TearDown]
        public void CloseTest()
        {
            driver.Quit();
        }
    }
}
