using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowBDDAutomationFramework.Pages;

namespace SpecFlowBDDAutomationFramework.StepDefinitions
{
    [Binding]
    public sealed class OrangeHomePageStepDefinitions
    {
        private IWebDriver driver;
        LoginPage orangePage;
        HomePage homePage;

       public OrangeHomePageStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }


        [Then(@"Verify Links in Orange home page")]
        public void ThenVerifyLinksInOrangeHomePage()
        {
            homePage = new HomePage(driver);
            homePage.VerifyLeftNavigationTabs();
        }

        [Then(@"logout from the application")]
        public void ThenLogoutFromTheApplication()
        {
            homePage = new HomePage(driver);
            homePage.logoutFromOrange();
        }

    }
}