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
        [AllureSuite("MathTestSuite")]
        [Parallelizable(ParallelScope.All)]
        public class Class2
        {
            [Test]
            public static void Test4()
            {
                Assert.AreEqual(Math.Max(3, 5), 5, "Incorrect max function.");
            }

            [Test]
            public static void Test5()
            {
                Assert.AreEqual(Math.Min(3, 5), 4, "Incorrect min function.");
            }

            [Test]
            public static void Test6()
            {
                Assert.AreEqual(Math.Abs(-3), 3, "Incorrect abs function.");
            }
        }
    }

