using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace FishStore.AutomatedUITests
{
    public class AutomatedUITests: IDisposable
    {
        private readonly IWebDriver _driver;

        public AutomatedUITests()
        {
            _driver = new ChromeDriver();            
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }

        [Fact]
        public void TestEmail()
        {
            _driver.Navigate()
                .GoToUrl("https://localhost:44322/Identity/Account/Login");

            Assert.Equal("FakeFishStore", _driver.Title);
            
            var emailInput = _driver.FindElement(By.Id("Input_Email"));
            emailInput.SendKeys("afsdfasdfaffaefadsf");

            _driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            var emailSpan = _driver.FindElement(By.Id("Input_Email-error"));
            Assert.NotNull(emailSpan);

            //Si emailSpan existe es porque el email es invalido, por lo tanto, si emailSpan NO es null cuando el email es invalido, el caso de prueba es correcto



            //string emailValidAttr = emailInput.GetAttribute("aria-invalid");
            //Assert.Equal("true",emailValidAttr);
            //var passwordInput = _driver.FindElement(By.Id("Input_Password"));
            //passwordInput.SendKeys("q@test.cossssm");
            //Assert.Contains("Prueba 2", _driver.PageSource);
        }
    }
}
