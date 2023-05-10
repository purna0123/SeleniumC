using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Pages
{
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
         By labelHeader = By.XPath("//a[contains(text(),'OrangeHRM')]");
         By linkAdmin = By.XPath("//span[text()='Admin']");
         By linkDashBoard = By.XPath("//span[text()='Dashboard']");
         By linkTime = By.XPath("//span[text()='Time']");
         By linkPIM = By.XPath("//span[text()='PIM']");
         By linkLogoutDropdown = By.XPath("//li[@class='oxd-userdropdown']");
         By linkLogoutButton = By.XPath("//a[text()='Logout']");
         
        public HomePage VerifyLeftNavigationTabs()
        {
            Thread.Sleep(3000);
            bool statuslinkAdmin = driver.FindElement(linkAdmin).Displayed;
            bool statuslinkDashBoard = driver.FindElement(linkDashBoard).Displayed;
            bool statuslinkTime = driver.FindElement(linkTime).Displayed;
            bool statuslinkPIM = driver.FindElement(linkPIM).Displayed;
            Console.WriteLine("linkAdmin status : "+statuslinkAdmin +", "+ "linkDashBoard status : " + statuslinkDashBoard + ", " + "linkTime status : " + statuslinkTime + ", " + "linkPIM status : " + statuslinkPIM + ", " + "links displayed");
            return new HomePage(driver);
        }

        public HomePage VerifyTitleOfThePage()
        {
            bool statuslabelHeader = driver.FindElement(linkAdmin).Displayed;
            Console.WriteLine("OrangeHRM header successfully verified :"+ statuslabelHeader);
            return new HomePage(driver);
        }

        public LoginPage logoutFromOrange()
        {
            driver.FindElement(linkLogoutDropdown).Click();
            driver.FindElement(linkLogoutButton).Click();
            Thread.Sleep(3000);
            return new LoginPage(driver);
        }

    }
}
