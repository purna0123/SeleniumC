using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

         By inputUserName = By.XPath("//input[@name='username']");
         By inputPassword = By.XPath("//input[@name='password']");
         By buttonLogin = By.XPath("//button[@type='submit']");

        public HomePage login(string username, String password)
        {
            driver.FindElement(inputUserName).SendKeys(username);
            driver.FindElement(inputPassword).SendKeys(password);
            driver.FindElement(buttonLogin).Click();
            return new HomePage(driver);
        }


    }
}
