using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Newtest
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class Class1
    {
        [Test]
        public static void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://github.com";
            Assert.IsTrue(driver.Title.Contains("GitHub"), "Invalid page title.");
            driver.Quit();
        }

        [Test]
        public static void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://meta.ua";
            Assert.Multiple(() => { Assert.IsTrue(driver.Title.Contains("GitHub"), "Invalid page title."); });

        driver.Quit();
        }

        [Test]
        public static void Test3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://youtube.com";
            Assert.Multiple(() => { Assert.IsTrue(driver.Title.Contains("Youtube"), "Invalid page title."); });
            driver.Quit();
        }
    }
}
