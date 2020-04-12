using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Newtest
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("UrlTestSuite")]
    public class Class1
    {
        public IWebDriver driver;

        [Test]
        public void Test1()
        {
            driver.Url = "https://github.com";
            Assert.IsTrue(driver.Title.Contains("GitHub"), "Invalid page title.");
        }

        [Test]
        public void Test2()
        {
            driver.Url = "https://meta.ua";
            Assert.Multiple(() => { Assert.IsTrue(driver.Title.Contains("."), "Invalid page title."); });
        }

        [Test]
        public void Test3()
        {
            driver.Url = "https://youtube.com";
            Assert.Multiple(() => { Assert.IsTrue(driver.Title.Contains("YouTube"), "Invalid page title."); });
        }

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
